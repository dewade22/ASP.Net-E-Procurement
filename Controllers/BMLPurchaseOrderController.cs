using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balimoon_E_Procurement.Models;
using Balimoon_E_Procurement.Models.BalimoonBML;
using Balimoon_E_Procurement.Models.BalimoonBML.ViewModel;
using Balimoon_E_Procurement.Models.DatatableModels;
using Balimoon_E_Procurement.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Balimoon_E_Procurement.Controllers
{
    public class BMLPurchaseOrderController : Controller
    {
        private readonly BalimoonBMLContext _balimoonBMLContext;
        private readonly MainSystemContext _mainSystemContext;
        private readonly UserManager<IdentityUser> _userManager;
        public BMLPurchaseOrderController(BalimoonBMLContext balimoonBMLContext,
            MainSystemContext mainSystemContext,
            UserManager<IdentityUser> userManager)
        {
            _balimoonBMLContext = balimoonBMLContext;
            _mainSystemContext = mainSystemContext;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View("~/Views/BMLPurchaseOrder/List.cshtml");
        }

        public IActionResult List()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetBMLPOList([FromBody]DTParameters dtParameters)
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
            var result = _balimoonBMLContext.PurchasesHeader.Select(a => new PurchasesHeader
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
            var totalResultsCount = await _balimoonBMLContext.PurchasesHeader.CountAsync();

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
            var PurchaseHeader = _balimoonBMLContext.PurchasesHeader.Where(a => a.PurchaseHeaderId == PurchaseHeaderId).SingleOrDefault();

            //Join The Header and Line To Get Details
            var join = (from header in _balimoonBMLContext.PurchasesHeader
                        join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                        into details
                        from line in details.DefaultIfEmpty()
                        join Locations in _balimoonBMLContext.Locations on line.LocationCode equals Locations.LocationCode
                        into LocationDetails
                        from Locations in LocationDetails.DefaultIfEmpty()
                        join DimensionValue in _balimoonBMLContext.DimensionValue on line.ShortcutDimension1Code equals DimensionValue.DimensionValueCode
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
            var join = (from line in _balimoonBMLContext.PurchasesLine
                        join vendor in _balimoonBMLContext.Vendors on line.BuyfromVendorNo equals vendor.VendorNo
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
                            Currency = line.CurrencyCode,
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
            var totalResultsCount = await _balimoonBMLContext.PurchasesLine.Where(a => a.PurchaseHeaderId == PurchaseHeaderId).CountAsync();
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

        public IActionResult Open()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetBMLPOListOpen([FromBody]DTParameters dtParameters)
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
            var result = (from header in _balimoonBMLContext.PurchasesHeader
                          join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                          where header.Status == 0
                          select new
                          {
                              PurchaseHeaderId = header.PurchaseHeaderId,
                              No = header.No,
                              BuyfromVendorName = header.BuyfromVendorName,
                              RefPrno = header.RefPrno,
                              OrderDate = header.OrderDate,
                              ExpectedReceiptDate = header.ExpectedReceiptDate,
                              Description = line.Description,
                              Amount = header.AmountIncludingVat
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.No != null && a.No.ToUpper().Contains(searchBy.ToUpper()) ||
                a.BuyfromVendorName != null && a.BuyfromVendorName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Description != null && a.Description.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RefPrno != null && a.RefPrno.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var total = (from header in _balimoonBMLContext.PurchasesHeader
                         join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                         where header.Status == 0
                         select new
                         {
                             HeaderId = header.PurchaseHeaderId
                         }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = total.Count();

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

        public IActionResult Release()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetBMLPOListRelease([FromBody]DTParameters dtParameters)
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
            var result = (from header in _balimoonBMLContext.PurchasesHeader
                          join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                          where header.Status == 1
                          select new
                          {
                              PurchaseHeaderId = header.PurchaseHeaderId,
                              No = header.No,
                              BuyfromVendorName = header.BuyfromVendorName,
                              RefPrno = header.RefPrno,
                              OrderDate = header.OrderDate,
                              ExpectedReceiptDate = header.ExpectedReceiptDate,
                              Description = line.Description,
                              Amount = header.AmountIncludingVat
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.No != null && a.No.ToUpper().Contains(searchBy.ToUpper()) ||
                a.BuyfromVendorName != null && a.BuyfromVendorName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Description != null && a.Description.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RefPrno != null && a.RefPrno.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var total = (from header in _balimoonBMLContext.PurchasesHeader
                         join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                         where header.Status == 1
                         select new
                         {
                             HeaderId = header.PurchaseHeaderId
                         }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = total.Count();

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

        public IActionResult PendingApproval()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetBMLPOListPA([FromBody]DTParameters dtParameters)
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
            var result = (from header in _balimoonBMLContext.PurchasesHeader
                          join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                          where header.Status == 2
                          select new
                          {
                              PurchaseHeaderId = header.PurchaseHeaderId,
                              No = header.No,
                              BuyfromVendorName = header.BuyfromVendorName,
                              RefPrno = header.RefPrno,
                              OrderDate = header.OrderDate,
                              ExpectedReceiptDate = header.ExpectedReceiptDate,
                              Description = line.Description,
                              Amount = header.AmountIncludingVat
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.No != null && a.No.ToUpper().Contains(searchBy.ToUpper()) ||
                a.BuyfromVendorName != null && a.BuyfromVendorName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Description != null && a.Description.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RefPrno != null && a.RefPrno.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var total = (from header in _balimoonBMLContext.PurchasesHeader
                         join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                         where header.Status == 2
                         select new
                         {
                             HeaderId = header.PurchaseHeaderId
                         }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = total.Count();

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

        public IActionResult PendingPrePayment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetBMLPOListPP([FromBody]DTParameters dtParameters)
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
            var result = (from header in _balimoonBMLContext.PurchasesHeader
                          join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                          where header.Status == 3
                          select new
                          {
                              PurchaseHeaderId = header.PurchaseHeaderId,
                              No = header.No,
                              BuyfromVendorName = header.BuyfromVendorName,
                              RefPrno = header.RefPrno,
                              OrderDate = header.OrderDate,
                              ExpectedReceiptDate = header.ExpectedReceiptDate,
                              Description = line.Description,
                              Amount = header.AmountIncludingVat
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.No != null && a.No.ToUpper().Contains(searchBy.ToUpper()) ||
                a.BuyfromVendorName != null && a.BuyfromVendorName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Description != null && a.Description.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RefPrno != null && a.RefPrno.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var total = (from header in _balimoonBMLContext.PurchasesHeader
                         join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                         where header.Status == 3
                         select new
                         {
                             HeaderId = header.PurchaseHeaderId
                         }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = total.Count();

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

        public IActionResult Archived()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetBMLPOListA([FromBody]DTParameters dtParameters)
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
            var result = (from header in _balimoonBMLContext.PurchasesHeader
                          join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                          where header.Status == 4
                          select new
                          {
                              PurchaseHeaderId = header.PurchaseHeaderId,
                              No = header.No,
                              BuyfromVendorName = header.BuyfromVendorName,
                              RefPrno = header.RefPrno,
                              OrderDate = header.OrderDate,
                              ExpectedReceiptDate = header.ExpectedReceiptDate,
                              Description = line.Description,
                              Amount = header.AmountIncludingVat
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.No != null && a.No.ToUpper().Contains(searchBy.ToUpper()) ||
                a.BuyfromVendorName != null && a.BuyfromVendorName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Description != null && a.Description.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RefPrno != null && a.RefPrno.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var total = (from header in _balimoonBMLContext.PurchasesHeader
                         join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                         where header.Status == 4
                         select new
                         {
                             HeaderId = header.PurchaseHeaderId
                         }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = total.Count();

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

        public IActionResult Closed()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetBMLPOListCL([FromBody]DTParameters dtParameters)
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
            var result = (from header in _balimoonBMLContext.PurchasesHeader
                          join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                          where header.Status == 5
                          select new
                          {
                              PurchaseHeaderId = header.PurchaseHeaderId,
                              No = header.No,
                              BuyfromVendorName = header.BuyfromVendorName,
                              RefPrno = header.RefPrno,
                              OrderDate = header.OrderDate,
                              ExpectedReceiptDate = header.ExpectedReceiptDate,
                              Description = line.Description,
                              Amount = header.AmountIncludingVat
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.No != null && a.No.ToUpper().Contains(searchBy.ToUpper()) ||
                a.BuyfromVendorName != null && a.BuyfromVendorName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Description != null && a.Description.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RefPrno != null && a.RefPrno.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var total = (from header in _balimoonBMLContext.PurchasesHeader
                         join line in _balimoonBMLContext.PurchasesLine on header.PurchaseHeaderId equals line.PurchaseHeaderId
                         where header.Status == 5
                         select new
                         {
                             HeaderId = header.PurchaseHeaderId
                         }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = total.Count();

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

        [Authorize(Roles ="Purchasing")]
        public IActionResult PurchasingIndex()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles ="Purchasing")]
        public IActionResult GetPRReadyPO([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "PurchaseHeaderId";
                orderDescendingDirection = true;
            }
           
            var result = (from header in _balimoonBMLContext.PurchaseRequisitionHeader
                          where (header.Status == 1 && header.DueDate >= DateTime.Now)
                          select new
                          {
                              PRID = header.RequisitionHeaderId,
                              PRNo = header.RequisitionNo,
                              Requester = header.RequesterId,
                              Departement = header.ShortcutDimension1Code,
                              OrderDate = header.OrderDate,
                              Notes = header.RequestNotes
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.PRNo != null && r.PRNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Requester != null && r.Requester.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Departement != null && r.Departement.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Notes != null && r.Notes.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var total = (from header in _balimoonBMLContext.PurchaseRequisitionHeader
                         where (header.Status == 1 && header.DueDate >= DateTime.Now)
                         select new
                         {
                            PRID = header.RequisitionHeaderId
                         }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = total.Count();

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

        [Authorize(Roles ="Purchasing")]
        public IActionResult ExpirePRR()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Purchasing")]
        public IActionResult ExpireRR([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "PurchaseHeaderId";
                orderDescendingDirection = true;
            }

            var result = (from header in _balimoonBMLContext.PurchaseRequisitionHeader
                          where (header.Status == 1 && header.DueDate <= DateTime.Now)
                          select new
                          {
                              PRID = header.RequisitionHeaderId,
                              PRNo = header.RequisitionNo,
                              Requester = header.RequesterId,
                              Departement = header.ShortcutDimension1Code,
                              OrderDate = header.OrderDate,
                              Notes = header.RequestNotes
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.PRNo != null && r.PRNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Requester != null && r.Requester.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Departement != null && r.Departement.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Notes != null && r.Notes.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var total = (from header in _balimoonBMLContext.PurchaseRequisitionHeader
                         where (header.Status == 1 && header.DueDate <= DateTime.Now)
                         select new
                         {
                             PRID = header.RequisitionHeaderId
                         }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = total.Count();

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

        [HttpGet]
        [Authorize(Roles = "Purchasing")]
        public JsonResult EditExpirePR(int PRID)
        {
            var result = string.Empty;

            var ID = PRID;
            if(PRID != 0)
            {
                var header = _balimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == ID);

                result = JsonConvert.SerializeObject(header, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            }
            return Json(result);
        }

        [HttpPost]
        [Authorize(Roles = "Purchasing")]
        public JsonResult EditExpirePR1(BMLPurchaseOrderVM model)
        {
            var result = false;
            var GetTgl = model.purchaseRequisitionHeader.DueDate;
            if(GetTgl != null)
            {
                PurchaseRequisitionHeader purchaseRequisitionHeader = _balimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.purchaseRequisitionHeader.RequisitionHeaderId);
                if(purchaseRequisitionHeader != null) { 
                    purchaseRequisitionHeader.DueDate = model.purchaseRequisitionHeader.DueDate;
                    purchaseRequisitionHeader.ExpirationDate = model.purchaseRequisitionHeader.DueDate;
                    _balimoonBMLContext.PurchaseRequisitionHeader.Update(purchaseRequisitionHeader);
                    _balimoonBMLContext.SaveChanges();
                    //Cek Line apakah ada
                    var Line = _balimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(i => i.RequisitionheaderId == model.purchaseRequisitionHeader.RequisitionHeaderId);
                    if(Line != null)
                    {
                        Line.DueDate = model.purchaseRequisitionHeader.DueDate;
                        Line.ExpirationDate = model.purchaseRequisitionHeader.DueDate;
                        _balimoonBMLContext.PurchaseRequisitionLine.Update(Line);
                        _balimoonBMLContext.SaveChanges();
                        result = true;
                    }
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return Json(result);
        }


        [HttpGet]
        [Authorize(Roles = "Purchasing")]
        public IActionResult DetilPROK(int PRID)
        {
            var getPRID = PRID;
            var PRNO = _balimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == getPRID);
            var header = (from PRHeader in _balimoonBMLContext.PurchaseRequisitionHeader
                          where PRHeader.RequisitionHeaderId == getPRID
                          select new BMLPurchaseOrderVM
                          {
                              purchaseRequisitionHeader = PRHeader
                          }).FirstOrDefault();
            if (header == null)
            {
                return NotFound();
            }
            //List Of Priority
            List<Models.LookupField> Priority = _mainSystemContext.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.Priority = new SelectList(Priority, "LookupCode", "LookupDescription");

            //List Of Type
            List<Models.LookupField> RecordType = _mainSystemContext.LookupField.Where(a => a.LookupGroup == "RecordType").ToList();
            ViewBag.ListOfRecordType = new SelectList(RecordType, "LookupCode", "LookupDescription");

            //List Of Record No
            List<Models.BalimoonBML.Items> RecordNo = _balimoonBMLContext.Items.ToList();
            ViewBag.ListOfRecordNo = new SelectList(RecordNo, "ItemNo", "Description");

            //List Of UOM
            List<Models.BalimoonBML.UnitOfMeasures> unitOfMeasures = _balimoonBMLContext.UnitOfMeasures.ToList();
            ViewBag.ListOfUOM = new SelectList(unitOfMeasures, "Uomdescription", "Uomdescription");

            //List Of  Vendor
            List<Models.BalimoonBML.Vendors> VendorsName = _balimoonBMLContext.Vendors.ToList();
            ViewBag.ListOfVendors = new SelectList(VendorsName, "VendorNo", "VendorName");


            ViewBag.PRNO = PRNO.RequisitionNo;
            return View(header);
        }

        [HttpPost]
        [Authorize(Roles = "Purchasing")]
        public IActionResult TabelPRJadi([FromBody]DTParameters dtParameters, int RequisitionHeaderId)
        {
            var getPRID = RequisitionHeaderId;
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionLineId";
                orderDescendingDirection = true;
            }

            var result = (from line in _balimoonBMLContext.PurchaseRequisitionLine
                          join Items in _balimoonBMLContext.Items on line.RecordNo equals Items.ItemNo
                          where line.RequisitionheaderId == getPRID
                          select new
                          {
                              RequisitionLineId = line.RequisitionLineId,
                              SeqLineNo = line.SeqLineNo,
                              ItemName = Items.Description,
                              Description = line.Description,
                              Quantity = line.Quantity,
                              UnitofMeasure = line.UnitofMeasure,
                              UnitCost = line.DirectUnitCost,
                              Amount = line.CostAmount,

                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.Description != null && r.Description.ToUpper().Contains(searchBy.ToUpper()) ||
                    r.UnitofMeasure != null && r.UnitofMeasure.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var total = (from line in _balimoonBMLContext.PurchaseRequisitionLine
                          join Items in _balimoonBMLContext.Items on line.RecordNo equals Items.ItemNo
                          where line.RequisitionheaderId == getPRID
                          select new
                          {
                              RequisitionLineId = line.RequisitionLineId,
                          }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = total.Count();

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

        
        [Authorize(Roles = "Purchasing")]
        public JsonResult EditPRLine(int RequisitionLineId)
        {
            var result = string.Empty;
            var getLineID = RequisitionLineId;
            var lineitems = (from line in _balimoonBMLContext.PurchaseRequisitionLine
                             join item in _balimoonBMLContext.Items on line.RecordNo equals item.ItemNo
                             where line.RequisitionLineId == getLineID
                             select new
                             {
                                 LineId = line.RequisitionLineId,
                                 PRNO = line.DocumentNo,
                                 Desc = line.Description,
                                 Desc2= item.Description,
                                 SeqNo = line.SeqLineNo,
                             }).FirstOrDefault();
            result = JsonConvert.SerializeObject(lineitems, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(result);
        }
    }
}