using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balimoon_E_Procurement.Models;
using Balimoon_E_Procurement.Models.BalimoonBMI;
using Balimoon_E_Procurement.Models.DatatableModels;
using Balimoon_E_Procurement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Balimoon_E_Procurement.Controllers
{
    public class BMIPurchaseRequestController : Controller
    {
        private readonly MainSystemContext _context;
        private readonly BalimoonBMIContext _BalimoonBMIContext;

        public BMIPurchaseRequestController(
            BalimoonBMIContext BalimoonBMIContext,
            MainSystemContext context)
        {
            _BalimoonBMIContext = BalimoonBMIContext;
            _context = context;
        }

        public IActionResult List()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetPRList([FromBody]DTParameters dtParameters)
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
                orderCriteria = "RequisitionHeaderId";
                orderAscendingDirection = true;
            }

            var result = _BalimoonBMIContext.PurchaseRequisitionHeader.Select(a => new PurchaseRequisitionHeader
            {
                RequisitionHeaderId = a.RequisitionHeaderId,
                RequisitionNo = a.RequisitionNo,
                DueDate = a.DueDate,
                RequesterId = a.RequesterId,
                ShortcutDimension1Code = a.ShortcutDimension1Code,
                ShortcutDimension2Code = a.ShortcutDimension2Code,
                ExpirationDate = a.ExpirationDate,
                OrderDate = a.OrderDate,
                Status = a.Status,
                Priority = a.Priority,
                RequestNotes = a.RequestNotes,
                PurchaseNo = a.PurchaseNo,
                RowStatus = a.RowStatus,
                CreatedBy = a.CreatedBy,
                CreatedTime = a.CreatedTime,
                LastModifiedBy = a.LastModifiedBy,
                LastModifiedTime = a.LastModifiedTime,
                LocationCode = a.LocationCode
            }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.ShortcutDimension2Code != null && r.ShortcutDimension2Code.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.PurchaseNo != null && r.PurchaseNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.CreatedBy != null && r.CreatedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LastModifiedBy != null && r.LastModifiedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LocationCode != null && r.LocationCode.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();

            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record

            var filteredResultsCount = result.Count();
            var totalResultsCount = await _BalimoonBMIContext.PurchaseRequisitionHeader.CountAsync();

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

        public JsonResult GetPR(int RequisitionHeaderId)
        {

            var result = string.Empty;

            //Get The Req Header ID
            var purchaseRequisitionHeader = _BalimoonBMIContext.PurchaseRequisitionHeader.Where(a => a.RequisitionHeaderId == RequisitionHeaderId).SingleOrDefault();

            //Join the header and line to get detail
            var join = (from header in _BalimoonBMIContext.PurchaseRequisitionHeader
                        join line in _BalimoonBMIContext.PurchaseRequisitionLine on header.RequisitionHeaderId equals line.RequisitionheaderId
                        into details
                        from line in details.DefaultIfEmpty()
                        where header.RequisitionHeaderId == purchaseRequisitionHeader.RequisitionHeaderId
                        select new
                        {
                            RequisitionHeaderId = header.RequisitionHeaderId,
                            RequisitionNo = header.RequisitionNo,
                            DueDate = header.DueDate,
                            RequesterID = header.RequesterId,
                            ShortcutDimension1Code = header.ShortcutDimension1Code,
                            ShortcutDimension2Code = header.ShortcutDimension2Code,
                            ExpirationDate = header.ExpirationDate,
                            OrderDate = header.OrderDate,
                            Status = header.Status,
                            Priority = header.Priority,
                            RequestNotes = header.RequestNotes,
                            PurchaseNo = header.PurchaseNo,
                            RowStatus = header.RowStatus,
                            CreatedBy = header.CreatedBy,
                            CreatedTime = header.CreatedTime,
                            LastModifiedBy = header.LastModifiedBy,
                            LastModifiedTime = header.LastModifiedTime,
                            LocationCode = header.LocationCode,
                            SeqLineNo = line.SeqLineNo,
                            RecordType = line.RecordType,
                            RecordNo = line.RecordNo,
                            Description = line.Description,
                            Description2 = line.Description2,
                            Quantity = line.Quantity,
                            UnitOfMeasure = line.UnitOfMeasure,
                            VendorNo = line.VendorNo,
                            DirectUnitCost = line.DirectUnitCost,
                            VatbusPostingGroup = line.VatbusPostingGroup,
                            VatprodPostingGroup = line.VatprodPostingGroup,
                            InventoryPostingGroup = line.InventoryPostingGroup,
                            DueDateLine = line.DueDate,
                            RequesterIDLine = line.RequesterId,
                            Confirmed = line.Confirmed,
                            ShortcutDimension1CodeLine = line.ShortcutDimension1Code,
                            ShortcutDimension2CodeLine = line.ShortcutDimension2Code,
                            LocationCodeLine = line.LocationCode,
                            RecurringMethod = line.RecurringMethod,
                            ExpirationDateLine = line.ExpirationDate,
                            RecurringFrequency = line.RecurringFrequency,
                            OrderDateLine = line.OrderDate,
                            VendorItemNo = line.VendorItemNo,
                            SalesOrderNo = line.SalesOrderNo,
                            SalesOrderLineNo = line.SalesOrderLineNo,
                            SelltoCustomerNo = line.SelltoCustomerNo,
                            ShiptoCode = line.ShiptoCode,
                            OrderAddress = line.OrderAddressCode,
                            CurrencyCode = line.CurrencyCode,
                            CurrencyFactor = line.CurrencyFactor,
                            QtyperUnitOfMeasure = line.QtyperUnitofMeasure,
                            UnitofMeasureCode = line.UnitofMeasureCode,
                            QuantityBase = line.QuantityBase,
                            UnitCost = line.UnitCost,
                            CostAmount = line.CostAmount,

                        }).FirstOrDefault();

            result = JsonConvert.SerializeObject(join, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> GetPRDetails([FromBody]DTParameters dtParameters, int RequisitionHeaderId)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderAscendingDirection = true;
            var getId = RequisitionHeaderId;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
            }
            else
            {
                orderCriteria = "RecordNo";
                orderAscendingDirection = true;
            }

            var result = _BalimoonBMIContext.PurchaseRequisitionLine.Where(a => a.RequisitionheaderId == RequisitionHeaderId).Select(a => new PurchaseRequisitionLine
            {
                RequisitionheaderId = a.RequisitionheaderId,
                DocumentNo = a.DocumentNo,
                Description = a.Description,
                Quantity = a.Quantity,
                UnitCost = a.UnitCost,
                CostAmount = a.CostAmount

            }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.DocumentNo != null && r.DocumentNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Description != null && r.Description.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record

            var filteredResultsCount = result.Count();
            var totalResultsCount = await _BalimoonBMIContext.PurchaseRequisitionLine.Where(a => a.RequisitionheaderId == RequisitionHeaderId).CountAsync();

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
    }
}