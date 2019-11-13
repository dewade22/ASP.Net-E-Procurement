using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balimoon_E_Procurement.Models;
using Balimoon_E_Procurement.Models.BalimoonBMI;
using Balimoon_E_Procurement.Models.DatatableModels;
using Balimoon_E_Procurement.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Balimoon_E_Procurement.Controllers
{
    public class BMIPurchaseOrderController : Controller
    {
        private readonly BalimoonBMIContext _balimoonBMIContext;
        private readonly MainSystemContext _mainSystemContext;
        private readonly UserManager<IdentityUser> _userManager;
        public BMIPurchaseOrderController(BalimoonBMIContext balimoonBMIContext,
            MainSystemContext mainSystemContext,
            UserManager<IdentityUser> userManager)
        {
            _balimoonBMIContext = balimoonBMIContext;
            _mainSystemContext = mainSystemContext;
            _userManager = userManager;
        }
        public IActionResult List()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetBMIPOList([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderAscendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
            }
            else
            {
                orderCriteria = "PurchaseHeaderId";
                orderAscendingDirection = true;
            }
            var result = _balimoonBMIContext.PurchasesHeader.Select(a => new PurchasesHeader
            {
                PurchaseHeaderId = a.PurchaseHeaderId,
                DocumentType = a.DocumentType,
                No = a.No,
                BuyfromVendorName = a.BuyfromVendorName,
                BuyfromVendorName2 = a.BuyfromVendorName2,
                BuyfromVendorNo = a.BuyfromVendorNo,
                PaytoVendorNo = a.PaytoVendorNo,
                PaytoName = a.PaytoName,
                PaytoName2 = a.PaytoName2,
                PaytoAddress = a.PaytoAddress,
                PaytoAddress2 = a.PaytoAddress2,
                PaytoCity = a.PaytoCity,
                PaytoContact = a.PaytoContact,
                YourReference = a.YourReference,
                ShiptoCode = a.ShiptoCode,
                ShiptoName = a.ShiptoName,
                ShiptoName2 = a.ShiptoName2,
                ShiptoAddress = a.ShiptoAddress,
                ShiptoAddress2 = a.ShiptoAddress2,
                ShiptoCity = a.ShiptoCity,
                ShiptoContact = a.ShiptoContact,
                OrderDate = a.OrderDate,
                PostingDate = a.PostingDate,
                ExpectedReceiptDate = a.ExpectedReceiptDate,
                PostingDescription = a.PostingDescription,
                PaymentTermsCode = a.PaymentTermsCode,
                DueDate = a.DueDate,
                ShipmentMethodCode = a.ShipmentMethodCode,
                Amount = a.Amount,
                RefPrno = a.RefPrno
            }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.No != null && a.No.ToUpper().Contains(searchBy.ToUpper()) ||
                a.BuyfromVendorName != null && a.BuyfromVendorName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RefPrno != null && a.RefPrno.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record

            var filteredResultsCount = result.Count();
            var totalResultsCount = await _balimoonBMIContext.PurchasesHeader.CountAsync();

            return Json(new
            {
                draw = dtParameters.Draw,
                recordsTotal = totalResultsCount,
                recordsFiltered = filteredResultsCount,
                data = result
            .Skip(dtParameters.Start)
            .Take(dtParameters.Length)
            .ToList()
            });
        }

        public JsonResult GetPO(int PurchaseHeaderId)
        {
            //make the result variabel to return a value
            var result = string.Empty;

            //Get The PO Header
            var PurchaseHeader = _balimoonBMIContext.PurchasesHeader.Where(a => a.PurchaseHeaderId == PurchaseHeaderId).SingleOrDefault();

            //Join The Header and Line To Get Details
            var join = (from header in _balimoonBMIContext.PurchasesHeader
                        join line in _balimoonBMIContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                        into details
                        from line in details.DefaultIfEmpty()
                        join Locations in _balimoonBMIContext.Locations on line.LocationCode equals Locations.LocationCode
                        into LocationDetails
                        from Locations in LocationDetails.DefaultIfEmpty()
                        join DimensionValue in _balimoonBMIContext.DimensionValue on line.ShortcutDimension1Code equals DimensionValue.DimensionValueCode
                        into DimensionDetails
                        from DimensionValue in DimensionDetails.DefaultIfEmpty()
                        where header.PurchaseHeaderId == PurchaseHeaderId
                        select new
                        {
                            PurchaseHeaderId = header.PurchaseHeaderId,
                            DocumentNo = line.DocumentNo,
                            LocationCode = line.LocationCode,
                            LocationName = Locations.LocationName,
                            PostingGroup = line.PostingGroup,
                            RefPRNo = header.RefPrno, //Nomor PR ada di 2 kolom, kolom RefPrno dan QuoteNo
                            DimensionValue = DimensionValue.DimensionValueName,
                            AssignedUserId = header.AssignedUserId,
                            CreatedBy = header.CreatedBy,
                            OrderDate = header.OrderDate,
                            ExpectedReceiptDate = header.ExpectedReceiptDate,
                            VendorName = header.PaytoName,
                            Amount = header.Amount,
                            AmountIncludingVAT = header.AmountIncludingVat
                        }).FirstOrDefault();

            result = JsonConvert.SerializeObject(join, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            //return the result value
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> GetPODetails([FromBody]DTParameters dtParameters, int PurchaseHeaderId)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderAscendingDirection = true;
            var getId = PurchaseHeaderId;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
            }
            else
            {
                orderCriteria = "PurchaseLineId";
                orderAscendingDirection = true;
            }
            var join = (from line in _balimoonBMIContext.PurchasesLine
                        join vendor in _balimoonBMIContext.Vendors on line.BuyfromVendorNo equals vendor.VendorNo
                        into vendordetails
                        from vendor in vendordetails.DefaultIfEmpty()
                        where line.PurchaseHeaderId == getId
                        select new
                        {
                            PurchaseLineId = line.PurchaseLineId,
                            Description = line.Description,
                            VendorName = vendor.VendorName,
                            Quantity = line.Quantity,
                            QuantityReceive = line.QuantityReceived,
                            Amount = line.Amount,
                            AmountVAT = line.AmountIncludingVat
                        }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                join = join.Where(a => a.Description != null && a.Description.ToUpper().Contains(searchBy.ToUpper()) ||
                a.VendorName != null && a.VendorName.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            join = orderAscendingDirection ? join.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : join.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var filteredResultsCount = join.Count();
            var totalResultsCount = await _balimoonBMIContext.PurchasesLine.Where(a => a.PurchaseHeaderId == PurchaseHeaderId).CountAsync();
            return Json(new
            {
                draw = dtParameters.Draw,
                recordsTotal = totalResultsCount,
                recordsFiltered = filteredResultsCount,
                data = join
           .Skip(dtParameters.Start)
           .Take(dtParameters.Length)
           .ToList()
            });
        }
    }
}