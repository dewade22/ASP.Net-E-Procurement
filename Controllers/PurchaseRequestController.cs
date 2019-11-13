using System;
using System.Linq;
using System.Threading.Tasks;
using Balimoon_E_Procurement.Models;
using Balimoon_E_Procurement.Models.BalimoonBML;
using Balimoon_E_Procurement.Models.DatatableModels;
using Balimoon_E_Procurement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Balimoon_E_Procurement.Models.BalimoonBML.ViewModel;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authorization;
using Balimoon_E_Procurement.Models.Tools;

namespace Balimoon_E_Procurement.Controllers
{
    public class PurchaseRequestController : Controller
    {
        private readonly BalimoonBMLContext _BalimoonBMLContext;
        private readonly MainSystemContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSender _emailSender;
        PRImages prImages;
        DeletePRImages deletePRImages;

        public PurchaseRequestController(
            BalimoonBMLContext BalimoonBMLContext,
            UserManager<IdentityUser> userManager,
            MainSystemContext context,
            IEmailSender emailSender)
        {
            deletePRImages = new DeletePRImages();
            prImages = new PRImages();
            _BalimoonBMLContext = BalimoonBMLContext;
            _userManager = userManager;
            _context = context;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View("~/Views/PurchaseRequest/List.cshtml");
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
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionHeaderId";
                orderAscendingDirection = true;
            }

            var result = _BalimoonBMLContext.PurchaseRequisitionHeader.Select(a => new PurchaseRequisitionHeader
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
            var totalResultsCount = await _BalimoonBMLContext.PurchaseRequisitionHeader.CountAsync();

            return Json(new
            { draw = dtParameters.Draw,
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
            var purchaseRequisitionHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.Where(a => a.RequisitionHeaderId == RequisitionHeaderId).SingleOrDefault();

            //Join the header and line to get detail
            var join = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                        join line in _BalimoonBMLContext.PurchaseRequisitionLine on header.RequisitionHeaderId equals line.RequisitionheaderId
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
                            UnitOfMeasure = line.UnitofMeasure,
                            VendorNo = line.VendorNo,
                            CurrencyCode = line.CurrencyCode,
                            CurrencyFactor = line.CurrencyFactor,
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
                            QtyperUnitOfMeasure = line.QtyperUnitofMeasure,
                            UnitofMeasureCode = line.UnitofMeasureCode,
                            QuantityBase = line.QuantityBase,
                            UnitCost = line.UnitCost,
                            CostAmount = line.CostAmount

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

            var result = _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.RequisitionheaderId == RequisitionHeaderId).Select(a => new PurchaseRequisitionLine
            {
                RequisitionheaderId = a.RequisitionheaderId,
                RequisitionLineId = a.RequisitionLineId,
                DocumentNo = a.DocumentNo,
                RecordType = a.RecordType,
                Description = a.Description,
                Quantity = a.Quantity,
                UnitofMeasure = a.UnitofMeasure,
                ItemCategoryCode = a.ItemCategoryCode,
                UnitCost = a.UnitCost,
                CurrencyCode = a.CurrencyCode,
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
            var totalResultsCount = await _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.RequisitionheaderId == RequisitionHeaderId).CountAsync();

            return Json(new {
                draw = dtParameters.Draw,
                recordsTotal = totalResultsCount,
                recordsFiltered = filteredResultsCount,
                data = result
            .Skip(dtParameters.Start)
            .Take(dtParameters.Length)
            .ToList()
            });

        }

        public IActionResult Open()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [HttpPost]
        public IActionResult GetPRListOp([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderAscendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderAscendingDirection = true;
            }

            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where header.Status == 0
                          select new
                          {
                              RequisitionHeaderId = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              RequesterId = header.RequesterId,
                              ShortcutDimension1Code = header.ShortcutDimension1Code,
                              RequestNotes = header.RequestNotes,
                              PurchaseNo = header.PurchaseNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              CreatedBy = header.CreatedBy,
                              LastModifiedBy = header.LastModifiedBy,
                              LocationCode = header.LocationCode,

                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.PurchaseNo != null && r.PurchaseNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.CreatedBy != null && r.CreatedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LastModifiedBy != null && r.LastModifiedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LocationCode != null && r.LocationCode.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();

            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where header.Status == 0
                              select new
                              {
                                  header = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();

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
        public IActionResult Cancelled()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [HttpPost]
        public IActionResult GetPRListCancl([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderAscendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderAscendingDirection = true;
            }

            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where header.Status == 8
                          select new
                          {
                              RequisitionHeaderId = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              RequesterId = header.RequesterId,
                              ShortcutDimension1Code = header.ShortcutDimension1Code,
                              RequestNotes = header.RequestNotes,
                              PurchaseNo = header.PurchaseNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              CreatedBy = header.CreatedBy,
                              LastModifiedBy = header.LastModifiedBy,
                              LocationCode = header.LocationCode,

                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.PurchaseNo != null && r.PurchaseNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.CreatedBy != null && r.CreatedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LastModifiedBy != null && r.LastModifiedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LocationCode != null && r.LocationCode.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();

            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where header.Status == 8
                              select new
                              {
                                  header = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();

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
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [HttpPost]
        public IActionResult GetPRListRe([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderAscendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderAscendingDirection = true;
            }

            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where header.Status == 1
                          select new
                          {
                              RequisitionHeaderId = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              RequesterId = header.RequesterId,
                              ShortcutDimension1Code = header.ShortcutDimension1Code,
                              RequestNotes = header.RequestNotes,
                              PurchaseNo = header.PurchaseNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              CreatedBy = header.CreatedBy,
                              LastModifiedBy = header.LastModifiedBy,
                              LocationCode = header.LocationCode
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.PurchaseNo != null && r.PurchaseNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.CreatedBy != null && r.CreatedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LastModifiedBy != null && r.LastModifiedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LocationCode != null && r.LocationCode.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();

            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where header.Status == 1
                              select new
                              {
                                  header = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();

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
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [HttpPost]
        public IActionResult GetPRListPA([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderAscendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderAscendingDirection = true;
            }

            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where header.Status == 2
                          select new
                          {
                              RequisitionHeaderId = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              RequesterId = header.RequesterId,
                              ShortcutDimension1Code = header.ShortcutDimension1Code,
                              RequestNotes = header.RequestNotes,
                              PurchaseNo = header.PurchaseNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              CreatedBy = header.CreatedBy,
                              LastModifiedBy = header.LastModifiedBy,
                              LocationCode = header.LocationCode
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.PurchaseNo != null && r.PurchaseNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.CreatedBy != null && r.CreatedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LastModifiedBy != null && r.LastModifiedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LocationCode != null && r.LocationCode.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();

            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where header.Status == 2
                              select new
                              {
                                  header = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();

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
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [HttpPost]
        public IActionResult GetPRListPPay([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderAscendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderAscendingDirection = true;
            }

            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where header.Status == 3
                          select new
                          {
                              RequisitionHeaderId = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              RequesterId = header.RequesterId,
                              ShortcutDimension1Code = header.ShortcutDimension1Code,
                              RequestNotes = header.RequestNotes,
                              PurchaseNo = header.PurchaseNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              CreatedBy = header.CreatedBy,
                              LastModifiedBy = header.LastModifiedBy,
                              LocationCode = header.LocationCode
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.PurchaseNo != null && r.PurchaseNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.CreatedBy != null && r.CreatedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LastModifiedBy != null && r.LastModifiedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LocationCode != null && r.LocationCode.ToUpper().Contains(searchBy.ToUpper())
                 ).ToList();

            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join line in _BalimoonBMLContext.PurchaseRequisitionLine on header.RequisitionHeaderId equals line.RequisitionheaderId

                              where header.Status == 3
                              select new
                              {
                                  header = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();

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
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [HttpPost]
        public IActionResult GetPRListAcv([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderAscendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderAscendingDirection = true;
            }

            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where header.Status == 4
                          select new
                          {
                              RequisitionHeaderId = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              RequesterId = header.RequesterId,
                              ShortcutDimension1Code = header.ShortcutDimension1Code,
                              RequestNotes = header.RequestNotes,
                              PurchaseNo = header.PurchaseNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              CreatedBy = header.CreatedBy,
                              LastModifiedBy = header.LastModifiedBy,
                              LocationCode = header.LocationCode
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.PurchaseNo != null && r.PurchaseNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.CreatedBy != null && r.CreatedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LastModifiedBy != null && r.LastModifiedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LocationCode != null && r.LocationCode.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();

            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where header.Status == 4
                              select new
                              {
                                  header = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();

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
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [HttpPost]
        public IActionResult GetPRListCl([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderAscendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderAscendingDirection = true;
            }

            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where header.Status == 5
                          select new
                          {
                              RequisitionHeaderId = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              RequesterId = header.RequesterId,
                              ShortcutDimension1Code = header.ShortcutDimension1Code,
                              RequestNotes = header.RequestNotes,
                              PurchaseNo = header.PurchaseNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              CreatedBy = header.CreatedBy,
                              LastModifiedBy = header.LastModifiedBy,
                              LocationCode = header.LocationCode
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.PurchaseNo != null && r.PurchaseNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.CreatedBy != null && r.CreatedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LastModifiedBy != null && r.LastModifiedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LocationCode != null && r.LocationCode.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();

            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where header.Status == 5
                              select new
                              {
                                  header = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();

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

        public IActionResult Rejected()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [HttpPost]
        public IActionResult GetPRListRejected([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderAscendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderAscendingDirection = true;
            }

            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          join ApprovalEntry in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals ApprovalEntry.DocumentNo
                          where header.Status == 7 && ApprovalEntry.Status == 3
                          select new
                          {
                              RequisitionHeaderId = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              RequesterId = header.RequesterId,
                              ShortcutDimension1Code = header.ShortcutDimension1Code,
                              RequestNotes = header.RequestNotes,
                              PurchaseNo = header.PurchaseNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              CreatedBy = header.CreatedBy,
                              LastModifiedBy = header.LastModifiedBy,
                              LocationCode = header.LocationCode,
                              RejectedNotes = ApprovalEntry.Message
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.PurchaseNo != null && r.PurchaseNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.CreatedBy != null && r.CreatedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LastModifiedBy != null && r.LastModifiedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LocationCode != null && r.LocationCode.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();

            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join ApprovalEntry in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals ApprovalEntry.DocumentNo
                              where header.Status == 7 && ApprovalEntry.Status == 3
                              select new
                              {
                                  header = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();

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
        public IActionResult Posted()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [HttpPost]
        public IActionResult GetPRListPst([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderAscendingDirection = true;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderAscendingDirection = true;
            }

            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where header.Status == 6
                          select new
                          {
                              RequisitionHeaderId = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              RequesterId = header.RequesterId,
                              ShortcutDimension1Code = header.ShortcutDimension1Code,
                              RequestNotes = header.RequestNotes,
                              PurchaseNo = header.PurchaseNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              CreatedBy = header.CreatedBy,
                              LastModifiedBy = header.LastModifiedBy,
                              LocationCode = header.LocationCode
                          }).ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.PurchaseNo != null && r.PurchaseNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.CreatedBy != null && r.CreatedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LastModifiedBy != null && r.LastModifiedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LocationCode != null && r.LocationCode.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();

            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where header.Status == 6
                              select new
                              {
                                  header = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();

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

        // Proses Pada BML
        public IActionResult AddPR()
        {
            //LIST Dept Code
            List<Models.BalimoonBML.DimensionValue> DeptCode = _BalimoonBMLContext.DimensionValue.Where(a => a.DimensionCode == "DEPARTMENT").ToList();
            ViewBag.ListOfDepartment = new SelectList(DeptCode, "DimensionValueCode", "DimensionValueName");

            //List Project Code
            List<Models.BalimoonBML.DimensionValue> ProjectCode = _BalimoonBMLContext.DimensionValue.Where(a => a.DimensionCode == "PROJECT").ToList();
            ViewBag.ListOfProjectCode = new SelectList(ProjectCode, "DimensionValueCode", "DimensionValueName");

            //Location
            List<Models.BalimoonBML.Locations> Locations = _BalimoonBMLContext.Locations.ToList();
            ViewBag.ListOfLocation = new SelectList(Locations, "LocationCode", "LocationName");

            //Priority
            List<Models.LookupField> Priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(Priority, "LookupCode", "LookupDescription");

            //PR Line
            //List Of Type
            List<Models.LookupField> RecordType = _context.LookupField.Where(a => a.LookupGroup == "RecordType").ToList();
            ViewBag.ListOfRecordType = new SelectList(RecordType, "LookupCode", "LookupDescription");

            //List Of Record No
            List<Models.BalimoonBML.Items> RecordNo = _BalimoonBMLContext.Items.ToList();
            ViewBag.ListOfRecordNo = new SelectList(RecordNo, "ItemNo", "Description");

            //List Of UOM
            List<Models.BalimoonBML.UnitOfMeasures> unitOfMeasures = _BalimoonBMLContext.UnitOfMeasures.ToList();
            ViewBag.ListOfUOM = new SelectList(unitOfMeasures, "Uomdescription", "Uomdescription");

            //List Of  Vendor
            List<Models.BalimoonBML.Vendors> VendorsName = _BalimoonBMLContext.Vendors.ToList();
            ViewBag.ListOfVendors = new SelectList(VendorsName, "VendorNo", "VendorName");

            return View();
        }

        [HttpPost]
        public IActionResult GetMyPR([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string UserName = ViewBag.UserName;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderDescendingDirection = true;
            }
            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where (header.RequesterId == UserName || header.CreatedBy == UserName || header.LastModifiedBy == UserName) && (header.Status == 0)
                          select new
                          {
                              RequisitionHeaderId = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              RequesterId = header.RequesterId,
                              ShortcutDimension1Code = header.ShortcutDimension1Code,
                              RequestNotes = header.RequestNotes,
                              PurchaseNo = header.PurchaseNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              CreatedBy = header.CreatedBy,
                              LastModifiedBy = header.LastModifiedBy,
                              LocationCode = header.LocationCode,

                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.PurchaseNo != null && r.PurchaseNo.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.CreatedBy != null && r.CreatedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LastModifiedBy != null && r.LastModifiedBy.ToUpper().Contains(searchBy.ToUpper()) ||
                 r.LocationCode != null && r.LocationCode.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();

            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where (header.RequesterId == UserName || header.CreatedBy == UserName || header.LastModifiedBy == UserName) && (header.Status == 0)
                              select new
                              {
                                  header = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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


        /* MenamBah PR */
        [HttpPost]
        public IActionResult AddHeader(PurchaseRequestVM model)
        {
            var result = "Error";
            var Priority = model.HeaderTbl.Priority;
            var DeptCode = model.HeaderTbl.ShortcutDimension1Code;
            var LocationCode = model.HeaderTbl.LocationCode;
            if (!ModelState.IsValid)
            {
                result = "Model Not Valid";
            }
            else
            {
                DateTime duedate = Convert.ToDateTime(model.HeaderTbl.ExpirationDate);
                DateTime NowDate = DateTime.Now;
                TimeSpan different = duedate - NowDate;
                var getDifferent = different.Days;
                if (getDifferent + 1 < 14)
                {
                    result = "Date Different Less Then 14 Days, its Only " + getDifferent + " Days";
                }
                else if (Priority == null)
                {
                    result = "Please Choose The Priority Options";
                }
                else if (DeptCode == null)
                {
                    result = "Please Choose The Department Code";
                }
                else if (LocationCode == null)
                {
                    result = "Please Choose The Location Opton";
                }
                else
                {

                    var tanggalsekarang = DateTime.Now;
                    var reqstNote = model.HeaderTbl.RequestNotes;
                    var NewPRNo = "";
                    ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
                    string UserName = ViewBag.UserName;
                    var getRequisitionNo = _BalimoonBMLContext.PurchaseRequisitionHeader.Max(a => a.RequisitionNo);

                    //Make New PR Number
                    if (getRequisitionNo == null)
                    {
                        NewPRNo = "PR-000001";
                    }
                    else
                    {
                        char[] trimmed = { 'P', 'R', '-' };
                        var PRTrimmed = getRequisitionNo.Trim(trimmed);
                        int PRRecent = Convert.ToInt32(PRTrimmed);
                        int PRNow = PRRecent + 1;
                        if (PRNow < 10)
                        {
                            NewPRNo = "PR-00000" + PRNow;
                        }
                        else if (PRNow < 100)
                        {
                            NewPRNo = "PR-0000" + PRNow;
                        }
                        else if (PRNow < 1000)
                        {
                            NewPRNo = "PR-000" + PRNow;
                        }
                        else if (PRNow < 10000)
                        {
                            NewPRNo = "PR-00" + PRNow;
                        }
                        else if (PRNow < 100000)
                        {
                            NewPRNo = "PR-0" + PRNow;
                        }
                        else
                        {
                            NewPRNo = "PR-" + PRNow;
                        }
                    }
                    var shortcutDimension2 = model.HeaderTbl.ShortcutDimension2Code;
                    var purchaseno = model.HeaderTbl.PurchaseNo;

                    //Filter Form
                    if (shortcutDimension2 == null)
                    {
                        shortcutDimension2 = "";
                    }
                    if (purchaseno == null)
                    {
                        purchaseno = "";
                    }
                    //Make Array To Insert
                    var insert = new PurchaseRequisitionHeader
                    {
                        RequisitionNo = NewPRNo,
                        DueDate = model.HeaderTbl.ExpirationDate,
                        RequesterId = UserName,
                        ShortcutDimension1Code = DeptCode,
                        ShortcutDimension2Code = shortcutDimension2,
                        ExpirationDate = model.HeaderTbl.ExpirationDate,
                        OrderDate = tanggalsekarang,
                        Status = 0,
                        Priority = Priority,
                        RequestNotes = reqstNote,
                        PurchaseNo = purchaseno,
                        RowStatus = 0,
                        CreatedBy = UserName,
                        LastModifiedBy = "",
                        CreatedTime = DateTime.Now,
                        LocationCode = LocationCode
                    };
                    _BalimoonBMLContext.PurchaseRequisitionHeader.Add(insert);
                    _BalimoonBMLContext.SaveChanges();
                    result = "Sukses";
                }

            }
            return Json(result);
        }

        public JsonResult AddLine(int RequisitionHeaderId)
        {
            var result = string.Empty;
            var purchaaserequisitionheader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == RequisitionHeaderId);
            if (purchaaserequisitionheader != null)
            {
                var join = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                            where header.RequisitionHeaderId == RequisitionHeaderId
                            select new
                            {
                                RequisitionHeaderId = header.RequisitionHeaderId
                            }).FirstOrDefault();
                result = JsonConvert.SerializeObject(join, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            }
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddingLine(IFormFile file, PurchaseRequestVM model)
        {
            var result = "Fail";
            if (!ModelState.IsValid)
            {
                result = "Model Not Valid";
            }
            else
            {
                var vendors = model.LineTbl.VendorNo;
                //Cek Field Penting Sudah Terisi
                if (model.LineTbl.RecordType == null)
                {
                    result = "Record Type Cannot Be Null";
                }
                else if (model.LineTbl.RecordNo == null)
                {
                    result = "Description Cannot Be Null, Please Choose One";
                }
                else if (model.LineTbl.Description == null)
                {
                    result = "Description Field Cannot Be Null, Please Type Any Text";
                }
                else if (model.LineTbl.UnitofMeasure == null)
                {
                    result = "Unit of Measure Cannot Be Null, Please Choose One";
                }
                else if (model.LineTbl.UnitCost == null)
                {
                    result = "Expected Unit Price Cannot Be Null, Please Add Some Price";
                }
                else
                {
                    if (vendors == null)
                    {
                        vendors = "";
                    }
                    if (file != null)
                    {
                        string uploadImage = await prImages.ImagesUpload(file);
                        if (uploadImage == "")
                        {
                            var header = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
                            var line = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.DocumentNo == header.RequisitionNo);
                            var getItem = _BalimoonBMLContext.Items.FirstOrDefault(a => a.ItemNo == model.LineTbl.RecordNo);
                            var seqNo = 0;
                            if (line == null)
                            {
                                seqNo = 1000;
                            }
                            else
                            {
                                var getMaxSeq = _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.DocumentNo == header.RequisitionNo).Max(a => a.SeqLineNo);
                                seqNo = getMaxSeq + 1000;
                            }
                            var insert = new PurchaseRequisitionLine
                            {
                                RequisitionheaderId = header.RequisitionHeaderId,
                                DocumentNo = header.RequisitionNo,
                                DueDate = header.DueDate,
                                OrderDate = header.OrderDate,
                                RecordType = model.LineTbl.RecordType,
                                SeqLineNo = seqNo,
                                RecordNo = model.LineTbl.RecordNo,
                                Description = model.LineTbl.Description,
                                Description2 = "",
                                Quantity = model.LineTbl.Quantity,
                                UnitofMeasure = model.LineTbl.UnitofMeasure,
                                VendorNo = vendors,
                                DirectUnitCost = model.LineTbl.UnitCost,
                                UnitCost = model.LineTbl.UnitCost,
                                VatprodPostingGroup = getItem.VatprodPostingGroup,
                                InventoryPostingGroup = getItem.InventoryPostingGroup,
                                RequesterId = header.RequesterId,
                                Confirmed = 0,
                                ShortcutDimension1Code = header.ShortcutDimension1Code,
                                ShortcutDimension2Code = header.ShortcutDimension2Code,
                                LocationCode = header.ShortcutDimension1Code,
                                RecurringMethod = 0,
                                ExpirationDate = header.ExpirationDate,
                                SalesOrderLineNo = 0,
                                SalesOrderNo = "",
                                QtyperUnitofMeasure = 1,
                                UnitofMeasureCode = model.LineTbl.UnitofMeasure,
                                QuantityBase = model.LineTbl.Quantity,
                                DemandType = 0,
                                DemandSubtype = 0,
                                DemandLineNo = 0,
                                DemandRefNo = 0,
                                Status = 0,
                                SupplyFrom = vendors,
                                ItemCategoryCode = getItem.ItemCategoryCode,
                                Nonstock = 0,
                                ProductGroupCode = getItem.ProductGroupCode,
                                GenProdPostingGroup = getItem.GenProdPostingGroup,
                                OriginalQuantity = model.LineTbl.Quantity,
                                FinishedQuantity = 0,
                                RemainingQuantity = model.LineTbl.Quantity,
                                CostAmount = model.LineTbl.Quantity * model.LineTbl.UnitCost,
                                RowStatus = 0,
                                CreatedBy = header.CreatedBy,
                                CreatedTime = header.CreatedTime,
                                RequestNotes = model.LineTbl.RequestNotes,
                                VatbusPostingGroup = "",
                                RecurringFrequency = "",
                                VendorItemNo = "",
                                SelltoCustomerNo = "",
                                ShiptoCode = "",
                                OrderAddressCode = "",
                                CurrencyCode = "",
                                CurrencyFactor = 1,
                                ProdOrderNo = "",
                                VariantCode = "",
                                BinCode = "",
                                DemandOrderNo = "",
                                UnitOfMeasureCodeDemand = "",
                                OriginalItemNo = "",
                                OriginalVariantCode = "",
                                UserId = "",
                                PurchasingCode = "",
                                TransferfromCode = "",
                                RoutingNo = "",
                                OperationNo = "",
                                WorkCenterNo = "",
                                GenBusinessPostingGroup = "",
                                ProductionBomversionCode = "",
                                RoutingVersionCode = "",
                                ProductionBomno = "",
                                RefOrderNo = "",
                                NoSeries = "",
                                QuantityPo = 0,
                                OrderPromisingId = "",
                                Priority = header.Priority,
                                Picture = "default.jpg"
                            };
                            _BalimoonBMLContext.PurchaseRequisitionLine.Add(insert);
                            _BalimoonBMLContext.SaveChanges();
                            result = "Sukses";
                        }
                        else if (uploadImage != "File must be either .jpg, .jpeg, .png and Maximum Size is 2MB")
                        {
                            var header = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
                            var line = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.DocumentNo == header.RequisitionNo);
                            var getItem = _BalimoonBMLContext.Items.FirstOrDefault(a => a.ItemNo == model.LineTbl.RecordNo);
                            var seqNo = 0;
                            if (line == null)
                            {
                                seqNo = 1000;
                            }
                            else
                            {
                                var getMaxSeq = _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.DocumentNo == header.RequisitionNo).Max(a => a.SeqLineNo);
                                seqNo = getMaxSeq + 1000;
                            }
                            var insert = new PurchaseRequisitionLine
                            {
                                RequisitionheaderId = header.RequisitionHeaderId,
                                DocumentNo = header.RequisitionNo,
                                DueDate = header.DueDate,
                                OrderDate = header.OrderDate,
                                RecordType = model.LineTbl.RecordType,
                                SeqLineNo = seqNo,
                                RecordNo = model.LineTbl.RecordNo,
                                Description = model.LineTbl.Description,
                                Description2 = "",
                                Quantity = model.LineTbl.Quantity,
                                UnitofMeasure = model.LineTbl.UnitofMeasure,
                                VendorNo = vendors,
                                DirectUnitCost = model.LineTbl.UnitCost,
                                UnitCost = model.LineTbl.UnitCost,
                                VatprodPostingGroup = getItem.VatprodPostingGroup,
                                InventoryPostingGroup = getItem.InventoryPostingGroup,
                                RequesterId = header.RequesterId,
                                Confirmed = 0,
                                ShortcutDimension1Code = header.ShortcutDimension1Code,
                                ShortcutDimension2Code = header.ShortcutDimension2Code,
                                LocationCode = header.ShortcutDimension1Code,
                                RecurringMethod = 0,
                                ExpirationDate = header.ExpirationDate,
                                SalesOrderLineNo = 0,
                                SalesOrderNo = "",
                                QtyperUnitofMeasure = 1,
                                UnitofMeasureCode = model.LineTbl.UnitofMeasure,
                                QuantityBase = model.LineTbl.Quantity,
                                DemandType = 0,
                                DemandSubtype = 0,
                                DemandLineNo = 0,
                                DemandRefNo = 0,
                                Status = 0,
                                SupplyFrom = vendors,
                                ItemCategoryCode = getItem.ItemCategoryCode,
                                Nonstock = 0,
                                ProductGroupCode = getItem.ProductGroupCode,
                                GenProdPostingGroup = getItem.GenProdPostingGroup,
                                OriginalQuantity = model.LineTbl.Quantity,
                                FinishedQuantity = 0,
                                RemainingQuantity = model.LineTbl.Quantity,
                                CostAmount = model.LineTbl.Quantity * model.LineTbl.UnitCost,
                                RowStatus = 0,
                                CreatedBy = header.CreatedBy,
                                CreatedTime = header.CreatedTime,
                                RequestNotes = model.LineTbl.RequestNotes,
                                VatbusPostingGroup = "",
                                RecurringFrequency = "",
                                VendorItemNo = "",
                                SelltoCustomerNo = "",
                                ShiptoCode = "",
                                OrderAddressCode = "",
                                CurrencyCode = "",
                                CurrencyFactor = 1,
                                ProdOrderNo = "",
                                VariantCode = "",
                                BinCode = "",
                                DemandOrderNo = "",
                                UnitOfMeasureCodeDemand = "",
                                OriginalItemNo = "",
                                OriginalVariantCode = "",
                                UserId = "",
                                PurchasingCode = "",
                                TransferfromCode = "",
                                RoutingNo = "",
                                OperationNo = "",
                                WorkCenterNo = "",
                                GenBusinessPostingGroup = "",
                                ProductionBomversionCode = "",
                                RoutingVersionCode = "",
                                ProductionBomno = "",
                                RefOrderNo = "",
                                NoSeries = "",
                                QuantityPo = 0,
                                OrderPromisingId = "",
                                Priority = header.Priority,
                                Picture = uploadImage
                            };
                            _BalimoonBMLContext.PurchaseRequisitionLine.Add(insert);
                            _BalimoonBMLContext.SaveChanges();
                            result = "Sukses";
                        }
                        else
                        {
                            result = "File must be either .jpg, .jpeg, .png and Maximum Size is 1.5 MB";
                        }
                    }
                    else
                    {
                        var header = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
                        var line = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.DocumentNo == header.RequisitionNo);
                        var getItem = _BalimoonBMLContext.Items.FirstOrDefault(a => a.ItemNo == model.LineTbl.RecordNo);
                        var seqNo = 0;
                        if (line == null)
                        {
                            seqNo = 1000;
                        }
                        else
                        {
                            var getMaxSeq = _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.DocumentNo == header.RequisitionNo).Max(a => a.SeqLineNo);
                            seqNo = getMaxSeq + 1000;
                        }
                        var insert = new PurchaseRequisitionLine
                        {
                            RequisitionheaderId = header.RequisitionHeaderId,
                            DocumentNo = header.RequisitionNo,
                            DueDate = header.DueDate,
                            OrderDate = header.OrderDate,
                            RecordType = model.LineTbl.RecordType,
                            SeqLineNo = seqNo,
                            RecordNo = model.LineTbl.RecordNo,
                            Description = model.LineTbl.Description,
                            Description2 = "",
                            Quantity = model.LineTbl.Quantity,
                            UnitofMeasure = model.LineTbl.UnitofMeasure,
                            VendorNo = vendors,
                            DirectUnitCost = model.LineTbl.UnitCost,
                            UnitCost = model.LineTbl.UnitCost,
                            VatprodPostingGroup = getItem.VatprodPostingGroup,
                            InventoryPostingGroup = getItem.InventoryPostingGroup,
                            RequesterId = header.RequesterId,
                            Confirmed = 0,
                            ShortcutDimension1Code = header.ShortcutDimension1Code,
                            ShortcutDimension2Code = header.ShortcutDimension2Code,
                            LocationCode = header.ShortcutDimension1Code,
                            RecurringMethod = 0,
                            ExpirationDate = header.ExpirationDate,
                            SalesOrderLineNo = 0,
                            SalesOrderNo = "",
                            QtyperUnitofMeasure = 1,
                            UnitofMeasureCode = model.LineTbl.UnitofMeasure,
                            QuantityBase = model.LineTbl.Quantity,
                            DemandType = 0,
                            DemandSubtype = 0,
                            DemandLineNo = 0,
                            DemandRefNo = 0,
                            Status = 0,
                            SupplyFrom = vendors,
                            ItemCategoryCode = getItem.ItemCategoryCode,
                            Nonstock = 0,
                            ProductGroupCode = getItem.ProductGroupCode,
                            GenProdPostingGroup = getItem.GenProdPostingGroup,
                            OriginalQuantity = model.LineTbl.Quantity,
                            FinishedQuantity = 0,
                            RemainingQuantity = model.LineTbl.Quantity,
                            CostAmount = model.LineTbl.Quantity * model.LineTbl.UnitCost,
                            RowStatus = 0,
                            CreatedBy = header.CreatedBy,
                            CreatedTime = header.CreatedTime,
                            RequestNotes = model.LineTbl.RequestNotes,
                            VatbusPostingGroup = "",
                            RecurringFrequency = "",
                            VendorItemNo = "",
                            SelltoCustomerNo = "",
                            ShiptoCode = "",
                            OrderAddressCode = "",
                            CurrencyCode = "",
                            CurrencyFactor = 1,
                            ProdOrderNo = "",
                            VariantCode = "",
                            BinCode = "",
                            DemandOrderNo = "",
                            UnitOfMeasureCodeDemand = "",
                            OriginalItemNo = "",
                            OriginalVariantCode = "",
                            UserId = "",
                            PurchasingCode = "",
                            TransferfromCode = "",
                            RoutingNo = "",
                            OperationNo = "",
                            WorkCenterNo = "",
                            GenBusinessPostingGroup = "",
                            ProductionBomversionCode = "",
                            RoutingVersionCode = "",
                            ProductionBomno = "",
                            RefOrderNo = "",
                            NoSeries = "",
                            QuantityPo = 0,
                            OrderPromisingId = "",
                            Priority = header.Priority,
                            Picture = "default.jpg"
                        };
                        _BalimoonBMLContext.PurchaseRequisitionLine.Add(insert);
                        _BalimoonBMLContext.SaveChanges();
                        result = "Sukses";
                    }

                }
            }
            return Json(result);
        }

        [HttpPost]
        public IActionResult GetAddedLine([FromBody]DTParameters dtParameters, int RequisitionHeaderId)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string UserName = ViewBag.UserName;

            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderDescendingDirection = true;
            }
            var result = (from line in _BalimoonBMLContext.PurchaseRequisitionLine
                          where line.RequisitionheaderId == RequisitionHeaderId
                          select new
                          {
                              RequisitionHeaderId = line.RequisitionheaderId,
                              RequisitionNo = line.DocumentNo,
                              Description = line.Description,
                              Quantity = line.Quantity,
                              UnitPrice = line.UnitCost,
                              Amount = line.CostAmount
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Description != null && r.Description.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();

            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from line in _BalimoonBMLContext.PurchaseRequisitionLine
                              where line.RequisitionheaderId == RequisitionHeaderId
                              select new
                              {
                                  header = line.RequisitionheaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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

        [HttpPost]
        public JsonResult SavePROpen(PurchaseRequestVM model)
        {
            var result = "";
            var exist = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.RequisitionheaderId == model.HeaderTbl.RequisitionHeaderId);
            if (exist == null)
            {
                result = "Please Add Some Item Into PR Before Send it To Approval";
            }
            else
            {
                var getDetailPR = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
                ViewBag.UserId = _userManager.GetUserId(HttpContext.User);
                string userId = ViewBag.UserId;
                ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
                string userName = ViewBag.UserName;

                var PRLine = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.RequisitionheaderId == model.HeaderTbl.RequisitionHeaderId);
                var usersname = _context.AspNetSystemUsers.FirstOrDefault(a => a.UserId == userId);
                if (usersname.PurchaseAmountApprovalLimit != null)
                {
                    //Untuk Requester Atasan Tanpa LIMIT
                    var getLine = _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.RequisitionheaderId == model.HeaderTbl.RequisitionHeaderId).Sum(a => a.CostAmount);
                    if (usersname.PurchaseAmountApprovalLimit >= getLine || usersname.PurchaseAmountApprovalLimit == 0)
                    {
                        var getPurchasingInRole = _context.AspNetUserRoles.FirstOrDefault(a => a.RoleId == "00060");
                        var getPurchasingInUser = _context.AspNetUsers.FirstOrDefault(a => a.Id == getPurchasingInRole.UserId);
                        var PurchasingEmail = getPurchasingInUser.Email;

                        _emailSender.SendEmailAsync(PurchasingEmail, "PR Siap Dijadikan PO",
                              $"Balimoon E-Procurement<br>" +
                              $"Dear  " + getPurchasingInUser.UserName + ",<br>Permohonan Pembelian Yang Diajukan Oleh " + getDetailPR.RequesterId + " Sudah Siap Untuk Dijadikan PO<br>" +
                              $"<br>" +
                              $"PR Dengan Nomor : " + getDetailPR.RequisitionNo + "<br>Catatan : " + getDetailPR.RequestNotes + " dan diajukan pada : " + (getDetailPR.CreatedTime) + "<br><br>" +
                              $"Segera <a href='https://" + this.Request.Host + "/BMLPurchaseOrder/PurchasingIndex'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau PR yang telah Diajukan<br>" +
                              $"<br>" +
                              $"<br>" +
                              $"Regards,<br>" +
                              $"BalimOOn - IT Team"
                             );

                        //Kirim Email Ke Pembuat PR
                        var PembuatPR = _context.AspNetUsers.FirstOrDefault(a => a.Id == userId);
                        _emailSender.SendEmailAsync(PembuatPR.Email, "PR Anda Siap Dijadikan PO",
                            $"Balimoon E-Procurement<br>" +
                            $"Dear " + PembuatPR.UserName + ",<br>Permohonan Pembelian Yang Anda Ajukan Telah Siap Untuk Dijadikan PO<br>" +
                            $"<br>" +
                            $"PR Dengan Nomor : " + getDetailPR.RequisitionNo + ",<br>Catatan : " + getDetailPR.RequestNotes + "<br>Diajukan Pada: " + getDetailPR.CreatedTime + "<br><br>" +
                            $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/MyReleasePR'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau Status PR Anda<br><br><br>" +
                            $"Regards,<br>BalimOOn - IT Team"
                            );

                        PurchaseRequisitionHeader purchaseRequisitionHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
                        purchaseRequisitionHeader.Status = 1;
                        _BalimoonBMLContext.PurchaseRequisitionHeader.Update(purchaseRequisitionHeader);
                        _BalimoonBMLContext.SaveChanges();

                        var ApprExist = _BalimoonBMLContext.ApprovalEntry.FirstOrDefault(a => a.DocumentNo == getDetailPR.RequisitionNo);
                        var newSeq = 0;
                        if (ApprExist == null)
                        {
                            newSeq = 1;
                        }
                        else
                        {
                            var getSeqMaxAppr = _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == getDetailPR.RequisitionNo).Max(a => a.SequenceNo);
                            newSeq = getSeqMaxAppr + 1;
                        }
                        var StatusPR = Convert.ToInt32(getDetailPR.Status);
                        //Insert Data Into Approval Entry
                        var ApprovalInsert = new ApprovalEntry
                        {
                            TableName = "PR",
                            DocumentType = 0,
                            DocumentNo = getDetailPR.RequisitionNo,
                            SequenceNo = newSeq,
                            ApprovalCode = "",
                            SenderBy = getDetailPR.RequesterId,
                            SalespersPurchCode = "",
                            ApproverBy = "",
                            Status = 0,
                            DueDate = getDetailPR.DueDate.Value,
                            Amount = getLine.Value,
                            AmountLcy = 0,
                            CurrencyCode = PRLine.CurrencyCode,
                            ApprovalType = 0,
                            LimitType = 3,
                            AvailableCreditLimitLcy = 0,
                            DelegationDateFormula = "",
                            DateTimeSentforApproval = PRLine.EndingDateTime.Value,
                            RowStatus = 0,
                            CreatedBy = userName,
                            CreatedTime = DateTime.Now,
                            LastModifiedBy = "",
                            NextApproval = userName,
                            Message = ""
                        };
                        _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert);
                        _BalimoonBMLContext.SaveChanges();

                        var ApprovalInsert2 = new ApprovalEntry
                        {
                            TableName = "PR",
                            DocumentType = 0,
                            DocumentNo = getDetailPR.RequisitionNo,
                            SequenceNo = newSeq + 1,
                            ApprovalCode = userName,
                            SenderBy = getDetailPR.RequesterId,
                            SalespersPurchCode = "",
                            ApproverBy = userName,
                            Status = 4,
                            DueDate = getDetailPR.DueDate.Value,
                            Amount = getLine.Value,
                            AmountLcy = 0,
                            CurrencyCode = PRLine.CurrencyCode,
                            ApprovalType = 2,
                            LimitType = 3,
                            AvailableCreditLimitLcy = 0,
                            DelegationDateFormula = "",
                            DateTimeSentforApproval = PRLine.EndingDateTime.Value,
                            RowStatus = 0,
                            CreatedBy = userName,
                            CreatedTime = DateTime.Now,
                            LastModifiedBy = "",
                            NextApproval = "",
                            Message = ""
                        };
                        _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert2);
                        _BalimoonBMLContext.SaveChanges();

                        result = "Sukses";
                    }
                    else
                    {
                        //Untuk requester Atasan Dengan Limit
                        var Approval = usersname.ApproverId;
                        var getapprover = _context.AspNetUsers.FirstOrDefault(a => a.UserName == Approval);
                        var ApprovalId = getapprover.Id;
                        var ApprovalEmail = getapprover.Email;

                        _emailSender.SendEmailAsync(ApprovalEmail, "Ada PR Baru Menunggu Konfirmasi Anda",
                                $"Balimoon E-Procurement<br>" +
                                $"Dear  " + getapprover.UserName + ",<br> Ada Permohonan Pembelian Yang Diajukan Oleh " + getDetailPR.RequesterId + " yang  Memerlukan Konfirmasi Anda<br>" +
                                $"<br>" +
                                $"PR Dengan Nomor : " + getDetailPR.RequisitionNo + "<br>Catatan : " + getDetailPR.RequestNotes + " dan diajukan pada : " + (getDetailPR.CreatedTime) + "<br><br>" +
                                $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/ApprovePR'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau PR yang telah Diajukan<br>" +
                                $"<br>" +
                                $"<br>" +
                                $"Regards,<br>" +
                                $"BalimOOn - IT Team"
                               );
                        PurchaseRequisitionHeader purchaseRequisitionHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
                        purchaseRequisitionHeader.Status = 2;
                        _BalimoonBMLContext.PurchaseRequisitionHeader.Update(purchaseRequisitionHeader);
                        _BalimoonBMLContext.SaveChanges();

                        //Add Tabel Approval Entry
                        var ApprExist = _BalimoonBMLContext.ApprovalEntry.FirstOrDefault(a => a.DocumentNo == getDetailPR.RequisitionNo);
                        var newSeq = 0;
                        if (ApprExist == null)
                        {
                            newSeq = 1;
                        }
                        else
                        {
                            var getSeqMaxAppr = _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == getDetailPR.RequisitionNo).Max(a => a.SequenceNo);
                            newSeq = getSeqMaxAppr + 1;
                        }
                        var StatusPR = Convert.ToInt32(getDetailPR.Status);

                        //Insert Data Into Approval Entry
                        var ApprovalInsert = new ApprovalEntry
                        {
                            TableName = "PR",
                            DocumentType = 0,
                            DocumentNo = getDetailPR.RequisitionNo,
                            SequenceNo = newSeq,
                            ApprovalCode = userName,
                            SenderBy = getDetailPR.RequesterId,
                            SalespersPurchCode = "",
                            ApproverBy = userName,
                            Status = 0,
                            DueDate = getDetailPR.DueDate.Value,
                            Amount = getLine.Value,
                            AmountLcy = 0,
                            CurrencyCode = PRLine.CurrencyCode,
                            ApprovalType = 0,
                            LimitType = 0,
                            AvailableCreditLimitLcy = 0,
                            DelegationDateFormula = "",
                            DateTimeSentforApproval = PRLine.EndingDateTime.Value,
                            RowStatus = 0,
                            CreatedBy = userName,
                            CreatedTime = DateTime.Now,
                            LastModifiedBy = "",
                            NextApproval = getapprover.UserName,
                            Message = ""
                        };
                        _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert);
                        _BalimoonBMLContext.SaveChanges();

                        var ApprovalInsert2 = new ApprovalEntry
                        {
                            TableName = "PR",
                            DocumentType = 0,
                            DocumentNo = getDetailPR.RequisitionNo,
                            SequenceNo = newSeq + 1,
                            ApprovalCode = userName,
                            SenderBy = getDetailPR.RequesterId,
                            SalespersPurchCode = "",
                            ApproverBy = userName,
                            Status = 5,
                            DueDate = getDetailPR.DueDate.Value,
                            Amount = getLine.Value,
                            AmountLcy = 0,
                            CurrencyCode = PRLine.CurrencyCode,
                            ApprovalType = 2,
                            LimitType = 0,
                            AvailableCreditLimitLcy = 0,
                            DelegationDateFormula = "",
                            DateTimeSentforApproval = PRLine.EndingDateTime.Value,
                            RowStatus = 0,
                            CreatedBy = userName,
                            CreatedTime = DateTime.Now,
                            LastModifiedBy = "",
                            NextApproval = getapprover.UserName,
                            Message = ""
                        };
                        _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert2);
                        _BalimoonBMLContext.SaveChanges();
                        result = "Sukses";
                    }
                }
                //Untuk Requester Tanpa Budget (Bawahan)
                else
                {
                    var getLine = _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.RequisitionheaderId == model.HeaderTbl.RequisitionHeaderId).Sum(a => a.CostAmount);
                    var Approval = usersname.ApproverId;
                    var getapprover = _context.AspNetUsers.FirstOrDefault(a => a.UserName == Approval);
                    var ApprovalId = getapprover.Id;
                    var ApprovalEmail = getapprover.Email;
                    _emailSender.SendEmailAsync(ApprovalEmail, "Ada PR Baru Menunggu Konfirmasi Anda",
                            $"Balimoon E-Procurement<br>" +
                            $"Dear  " + getapprover.UserName + ",<br> Ada Permohonan Pembelian Yang Diajukan Oleh " + getDetailPR.RequesterId + " yang  Memerlukan Konfirmasi Anda<br>" +
                            $"<br>" +
                            $"PR Dengan Nomor : " + getDetailPR.RequisitionNo + "<br>Catatan PR : " + getDetailPR.RequestNotes + "<br>Diajukan pada : " + (getDetailPR.CreatedTime) + "<br><br>" +
                            $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/ApprovePR'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau PR yang telah Diajukan<br>" +
                            $"<br>" +
                            $"<br>" +
                            $"Regards,<br>" +
                            $"BalimOOn - IT Team"
                           );
                    PurchaseRequisitionHeader purchaseRequisitionHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
                    purchaseRequisitionHeader.Status = 6;
                    _BalimoonBMLContext.PurchaseRequisitionHeader.Update(purchaseRequisitionHeader);
                    _BalimoonBMLContext.SaveChanges();

                    //Add Approval Entry
                    var ApprExist = _BalimoonBMLContext.ApprovalEntry.FirstOrDefault(a => a.DocumentNo == getDetailPR.RequisitionNo);
                    var newSeq = 0;
                    if (ApprExist == null)
                    {
                        newSeq = 1;
                    }
                    else
                    {
                        var getSeqMaxAppr = _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == getDetailPR.RequisitionNo).Max(a => a.SequenceNo);
                        newSeq = getSeqMaxAppr + 1;
                    }

                    var StatusPR = Convert.ToInt32(getDetailPR.Status);

                    //Insert Data Into Approval Entry
                    var ApprovalInsert = new ApprovalEntry
                    {
                        TableName = "PR",
                        DocumentType = 0,
                        DocumentNo = getDetailPR.RequisitionNo,
                        SequenceNo = newSeq,
                        ApprovalCode = "",
                        SenderBy = getDetailPR.RequesterId,
                        SalespersPurchCode = "",
                        ApproverBy = "",
                        Status = 0,
                        DueDate = getDetailPR.DueDate.Value,
                        Amount = getLine.Value,
                        AmountLcy = 0,
                        CurrencyCode = PRLine.CurrencyCode,
                        ApprovalType = 0,
                        LimitType = 2,
                        AvailableCreditLimitLcy = 0,
                        DelegationDateFormula = "",
                        DateTimeSentforApproval = PRLine.EndingDateTime.Value,
                        RowStatus = 0,
                        CreatedBy = userName,
                        CreatedTime = DateTime.Now,
                        LastModifiedBy = "",
                        NextApproval = getapprover.UserName,
                        Message = ""
                    };
                    _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert);
                    _BalimoonBMLContext.SaveChanges();
                    result = "Sukses";
                }
            }
            return Json(result);
        }

        [HttpGet]
        public JsonResult EditHeader(int RequisitionHeaderId)
        {
            var result = string.Empty;
            var PurchaseRequisitionHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == RequisitionHeaderId);
            if (PurchaseRequisitionHeader != null)
            {
                var join = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                            where header.RequisitionHeaderId == RequisitionHeaderId
                            select new
                            {
                                RequisitionHeaderId = header.RequisitionHeaderId,
                                OrderDate = header.OrderDate,
                                DueDate = header.DueDate,
                                ExpirationDate = header.ExpirationDate,
                                RequestNotes = header.RequestNotes,
                                ShortcutDimension2Code = header.ShortcutDimension2Code,
                                ShortcutDimension1Code = header.ShortcutDimension1Code,
                                Priority = header.Priority,
                                LocationCode = header.LocationCode,
                                PRNO = header.RequisitionNo
                            }).FirstOrDefault();
                result = JsonConvert.SerializeObject(join, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            }
            return Json(result);
        }

        [HttpPost]
        public IActionResult EditHeaderProcess(PurchaseRequestVM model)
        {
            var result = "";
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string currentLogin = ViewBag.UserName;
            //declare penampung current data sementara
            var cRequestNotes = model.HeaderTbl.RequestNotes;
            var cShortcutDimension2Code = model.HeaderTbl.ShortcutDimension2Code;
            var cShortcutDimension1Code = model.HeaderTbl.ShortcutDimension1Code;
            int cPriority = 0;
            var cLocationCode = model.HeaderTbl.LocationCode;
            if (!ModelState.IsValid)
            {
                result = "Model Not Valid";
            }
            else
            {
                //get current value
                var currentValue = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
                if (currentValue == null)
                {
                    result = "Data With ID " + model.HeaderTbl.RequisitionHeaderId + "Cannot Be Found!!";
                }
                else
                {
                    DateTime duedate = Convert.ToDateTime(model.HeaderTbl.DueDate);
                    DateTime NowDate = Convert.ToDateTime(currentValue.OrderDate);
                    TimeSpan different = duedate - NowDate;
                    var getDifferent = different.Days;
                    if (getDifferent + 1 < 14)
                    {
                        result = "Date Different Less Then 14 Days, its Only " + getDifferent + " Days";
                    }

                    // cek semua value yang akan di update apakah terisi

                    else
                    {
                        if (cRequestNotes == null)
                        {
                            cRequestNotes = currentValue.RequestNotes;
                        }
                        if (cShortcutDimension1Code == null)
                        {
                            cShortcutDimension1Code = currentValue.ShortcutDimension1Code;
                        }
                        if (cShortcutDimension2Code == null)
                        {
                            cShortcutDimension2Code = currentValue.ShortcutDimension2Code;
                        }
                        if (cLocationCode == null)
                        {
                            cLocationCode = currentValue.LocationCode;
                        }
                        if (model.HeaderTbl.Priority == null)
                        {
                            cPriority = currentValue.Priority.Value;
                        }
                        else
                        {
                            cPriority = model.HeaderTbl.Priority.Value;
                        }
                        //Simpan ke DB
                        currentValue.DueDate = model.HeaderTbl.DueDate;
                        currentValue.RequestNotes = cRequestNotes;
                        currentValue.ShortcutDimension1Code = cShortcutDimension1Code;
                        currentValue.ShortcutDimension2Code = cShortcutDimension2Code;
                        currentValue.LocationCode = cLocationCode;
                        currentValue.Priority = cPriority;
                        currentValue.ExpirationDate = model.HeaderTbl.DueDate;
                        currentValue.LastModifiedBy = currentLogin;
                        currentValue.LastModifiedTime = DateTime.Now;
                        _BalimoonBMLContext.PurchaseRequisitionHeader.Update(currentValue);
                        _BalimoonBMLContext.SaveChanges();

                        var line = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.RequisitionheaderId == model.HeaderTbl.RequisitionHeaderId);
                        if (line != null)
                        {
                            line.DueDate = model.HeaderTbl.DueDate;
                            line.ShortcutDimension1Code = cShortcutDimension1Code;
                            line.LocationCode = cShortcutDimension1Code;
                            line.ShortcutDimension2Code = cShortcutDimension2Code;
                            line.Priority = cPriority;
                            line.ExpirationDate = model.HeaderTbl.DueDate;
                            _BalimoonBMLContext.PurchaseRequisitionLine.Update(line);
                            _BalimoonBMLContext.SaveChanges();
                        }
                        result = "Sukses";

                    }
                }

            }
            return Json(result);
        }

        /*Akhir dari menambah PR*/

        public IActionResult MyPROpen()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");
            return View();
        }

        [HttpPost]
        public IActionResult MyPROpenCode([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string UserName = ViewBag.UserName;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderDescendingDirection = true;
            }
            var result = (from Header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where Header.CreatedBy == UserName && Header.Status == 0
                          select new
                          {
                              RequisitionHeaderId = Header.RequisitionHeaderId,
                              RequisitionNo = Header.RequisitionNo,
                              RequestNotes = Header.RequestNotes,
                              RequesterId = Header.RequesterId,
                              ShortcutDimension1Code = Header.ShortcutDimension1Code,
                              OrderDate = Header.OrderDate,
                              DueDate = Header.DueDate,
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where header.CreatedBy == UserName && header.Status == 0
                              select new
                              {
                                  req = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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

        public IActionResult MyReleasePR()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");
            return View();
        }

        [HttpPost]
        public IActionResult MyReleasePRCode([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string UserName = ViewBag.UserName;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderDescendingDirection = true;
            }
            var result = (from Header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where Header.CreatedBy == UserName && Header.Status == 1
                          select new
                          {
                              RequisitionHeaderId = Header.RequisitionHeaderId,
                              RequisitionNo = Header.RequisitionNo,
                              RequestNotes = Header.RequestNotes,
                              RequesterId = Header.RequesterId,
                              ShortcutDimension1Code = Header.ShortcutDimension1Code,
                              OrderDate = Header.OrderDate,
                              DueDate = Header.DueDate,
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where header.CreatedBy == UserName && header.Status == 1
                              select new
                              {
                                  req = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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

        public IActionResult MyPendingAprPR()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");
            return View();
        }

        [HttpPost]
        public IActionResult MyPendingAprPRCode([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string UserName = ViewBag.UserName;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderDescendingDirection = true;
            }
            var result = (from Header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where Header.CreatedBy == UserName && Header.Status == 2
                          select new
                          {
                              RequisitionHeaderId = Header.RequisitionHeaderId,
                              RequisitionNo = Header.RequisitionNo,
                              RequestNotes = Header.RequestNotes,
                              RequesterId = Header.RequesterId,
                              ShortcutDimension1Code = Header.ShortcutDimension1Code,
                              OrderDate = Header.OrderDate,
                              DueDate = Header.DueDate,
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where header.CreatedBy == UserName && header.Status == 2
                              select new
                              {
                                  req = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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

        public IActionResult MyPostedPR()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");
            return View();
        }

        [HttpPost]
        public IActionResult MyPostedPRCode([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string UserName = ViewBag.UserName;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderDescendingDirection = true;
            }
            var result = (from Header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where Header.CreatedBy == UserName && Header.Status == 6
                          select new
                          {
                              RequisitionHeaderId = Header.RequisitionHeaderId,
                              RequisitionNo = Header.RequisitionNo,
                              RequestNotes = Header.RequestNotes,
                              RequesterId = Header.RequesterId,
                              ShortcutDimension1Code = Header.ShortcutDimension1Code,
                              OrderDate = Header.OrderDate,
                              DueDate = Header.DueDate,
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where header.CreatedBy == UserName && header.Status == 6
                              select new
                              {
                                  req = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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

        public IActionResult MyClosedPR()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");
            return View();
        }

        [HttpPost]
        public IActionResult MyClosedPRCode([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string UserName = ViewBag.UserName;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderDescendingDirection = true;
            }
            var result = (from Header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where Header.CreatedBy == UserName && Header.Status == 5
                          select new
                          {
                              RequisitionHeaderId = Header.RequisitionHeaderId,
                              RequisitionNo = Header.RequisitionNo,
                              RequestNotes = Header.RequestNotes,
                              RequesterId = Header.RequesterId,
                              ShortcutDimension1Code = Header.ShortcutDimension1Code,
                              OrderDate = Header.OrderDate,
                              DueDate = Header.DueDate,
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RequesterId != null && r.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.ShortcutDimension1Code != null && r.ShortcutDimension1Code.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            //Dapatkan Jumlah Total Record
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              where header.CreatedBy == UserName && header.Status == 5
                              select new
                              {
                                  req = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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

        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public IActionResult ApprovePR()
        {
            return View();
        }

        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public IActionResult ApprovePRTable([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserId = _userManager.GetUserId(HttpContext.User);
            string UserId = ViewBag.UserId;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string CurrentLogin = ViewBag.UserName;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionHeaderId";
                orderDescendingDirection = true;
            }
            //Get Role Of User Login
            var myRole = 0;
            var UserLoginNow = _context.AspNetUserRoles.FirstOrDefault(a => a.UserId == UserId);
            if (UserLoginNow.RoleId == "00040")
            {
                myRole = 6;
            }
            else
            {
                myRole = 2;
            }
            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          join approvalE in _BalimoonBMLContext.ApprovalEntry
                          on header.RequisitionNo equals approvalE.DocumentNo
                          where header.Status == myRole && approvalE.NextApproval == CurrentLogin && approvalE.SequenceNo == _BalimoonBMLContext.ApprovalEntry.Where(c => c.DocumentNo == header.RequisitionNo).Max(d => d.SequenceNo)
                          select new
                          {
                              RequisitionHeaderId = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              RequesterId = header.RequesterId,
                              CreatedTime = header.CreatedTime,
                              RequestNotes = header.RequestNotes
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.RequisitionNo != null && a.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RequesterId != null && a.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RequestNotes != null && a.RequestNotes.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join Approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals Approval.DocumentNo
                              where Approval.NextApproval == CurrentLogin && header.Status == myRole && Approval.SequenceNo == _BalimoonBMLContext.ApprovalEntry.Where(b => b.DocumentNo == header.RequisitionNo).Max(c => c.SequenceNo)
                              select new
                              {
                                  RequisitionHeaderId = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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

        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public JsonResult ApprovePRView(int RequisitionHeaderId)
        {
            var result = string.Empty;
            var header = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == RequisitionHeaderId);
            var join = (from Head in _BalimoonBMLContext.PurchaseRequisitionHeader
                        join Line in _BalimoonBMLContext.PurchaseRequisitionLine on Head.RequisitionHeaderId equals Line.RequisitionheaderId
                        into Details
                        from Line in Details.DefaultIfEmpty()
                        where Head.RequisitionHeaderId == RequisitionHeaderId
                        select new
                        {
                            RequisitionHeaderId = Head.RequisitionHeaderId,
                            RequisitionNo = Head.RequisitionNo,
                            RequesterId = Head.RequesterId,
                            OrderDate = Head.OrderDate,
                            DueDate = Head.DueDate,
                            RequestNotes = Head.RequestNotes

                        }).FirstOrDefault();
            result = JsonConvert.SerializeObject(join, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(result);
        }

        [HttpPost]
        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public JsonResult ApprovePRApprove(PurchaseRequestVM model)
        {
            var result = "Process Not Executed";
            var header = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
            if (header == null)
            {
                result = "PR Not Found!!";
            }
            var line = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.RequisitionheaderId == model.HeaderTbl.RequisitionHeaderId);
            //cek data ada?
            if (line == null)
            {
                result = "Blank, PR not contain any item";
            }
            else
            {
                var PRinApproval = _BalimoonBMLContext.ApprovalEntry.FirstOrDefault(a => a.DocumentNo == line.DocumentNo);
                ViewBag.UserId = _userManager.GetUserId(HttpContext.User);
                string UserId = ViewBag.UserId;
                ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
                string UserName = ViewBag.UserName;
                var getUserInSystemUser = _context.AspNetSystemUsers.FirstOrDefault(a => a.UserId == UserId);
                var getAmountPR = _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.RequisitionheaderId == model.HeaderTbl.RequisitionHeaderId).Sum(a => a.CostAmount);
                //lakukan pengecekan apakah akan di approve atau pending approval
                if (getUserInSystemUser.PurchaseAmountApprovalLimit >= getAmountPR || getUserInSystemUser.PurchaseAmountApprovalLimit == 0)
                {
                    var getPurchasingInRole = _context.AspNetUserRoles.FirstOrDefault(a => a.RoleId == "00060");
                    var getPurchasingInUser = _context.AspNetUsers.FirstOrDefault(a => a.Id == getPurchasingInRole.UserId);
                    var PurchasingEmail = getPurchasingInUser.Email;

                    _emailSender.SendEmailAsync(PurchasingEmail, "PR Siap Dijadikan PO",
                      $"Balimoon E-Procurement<br>" +
                      $"Dear  " + getPurchasingInUser.UserName + ",<br>Permohonan Pembelian Yang Diajukan Oleh " + header.RequesterId + " Sudah Siap Untuk Dijadikan PO<br>" +
                      $"<br>" +
                      $"PR Dengan Nomor : " + header.RequisitionNo + "<br>Catatan : " + header.RequestNotes + " dan diajukan pada : " + (header.CreatedTime) + "<br>" +
                      $"Telah disetujui Oleh : " + UserName + " dan siap untuk diajukan menjadi PO<br>" +
                      $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/List'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau PR yang telah Diajukan<br>" +
                      $"<br>" +
                      $"<br>" +
                      $"Regards,<br>" +
                      $"BalimOOn - IT Team"
                     );

                    //Kirim Email ke Pembuat PR
                    var CreatorPR = _context.AspNetUsers.FirstOrDefault(a => a.UserName == header.CreatedBy);

                    _emailSender.SendEmailAsync(CreatorPR.Email, "PR Anda Siap Dijadikan PO",
                        $"Balimoon E-Procurement<br>" +
                        $"Dear " + CreatorPR.UserName + ",<br>Permohonan Pembelian yang Anda Ajukan Sudah Siap Untuk Dijadikan PO<br>" +
                        $"<br> PR Dengan Nomor : " + header.RequisitionNo + "<br>Catatan : " + header.RequestNotes + "Dan Diajukan Pada : " + header.CreatedTime + "<br>" +
                        $"Telah Disetujui Oleh : " + UserName + "dan siap untuk diajukan menjadi PO<br>" +
                        $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/List'><b>Masuk Kedalam Sistem</b></a> Untuk Melihat Status PR yang Anda Ajukan<br><br><br>" +
                        $"Regards,<br>" +
                        $"BalimOOn - IT Team"
                        );

                    PurchaseRequisitionHeader purchaseRequisitionHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
                    purchaseRequisitionHeader.Status = 1;
                    _BalimoonBMLContext.PurchaseRequisitionHeader.Update(purchaseRequisitionHeader);
                    _BalimoonBMLContext.SaveChanges();

                    //Tambahkan Record Kedalam Tabel Approval Entry
                    var newSeq = 0;
                    if (PRinApproval == null)
                    {
                        newSeq = 1;
                    }
                    else
                    {
                        var getMaxSeqinApprovalEntry = _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == line.DocumentNo).Max(a => a.SequenceNo);
                        newSeq = getMaxSeqinApprovalEntry + 1;
                    }
                    //Insert Data Into Approval Entry
                    var ApprovalInsert2 = new ApprovalEntry
                    {
                        TableName = "PR",
                        DocumentType = 0,
                        DocumentNo = header.RequisitionNo,
                        SequenceNo = newSeq,
                        ApprovalCode = ViewBag.UserName,
                        SenderBy = header.RequesterId,
                        SalespersPurchCode = "",
                        ApproverBy = ViewBag.UserName,
                        Status = 4,
                        DueDate = header.DueDate.Value,
                        Amount = getAmountPR.Value,
                        AmountLcy = 0,
                        CurrencyCode = line.CurrencyCode,
                        ApprovalType = 2,
                        LimitType = 3,
                        AvailableCreditLimitLcy = 0,
                        DelegationDateFormula = "",
                        DateTimeSentforApproval = line.EndingDateTime.Value,
                        RowStatus = 0,
                        CreatedBy = ViewBag.UserName,
                        CreatedTime = DateTime.Now,
                        LastModifiedBy = "",
                        NextApproval = "",
                        Message = ""
                    };
                    _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert2);
                    _BalimoonBMLContext.SaveChanges();

                    result = "Sukses";
                }
                else
                {
                    var ApprovalinUser = _context.AspNetUsers.FirstOrDefault(a => a.UserName == getUserInSystemUser.ApproverId);
                    var nextApproval = getUserInSystemUser.ApproverId;
                    var approvalbaru = "";
                    if (nextApproval != null)
                    {
                        approvalbaru = nextApproval;
                    }
                    //send email
                    _emailSender.SendEmailAsync(ApprovalinUser.Email, "Ada PR Baru Menunggu Konfirmasi Anda",
                           $"Balimoon E-Procurement<br>" +
                           $"Dear  " + ApprovalinUser.UserName + ",<br> Ada Permohonan Pembelian Yang Diajukan Oleh " + header.RequesterId + " yang  Memerlukan Konfirmasi Anda<br>" +
                           $"<br>" +
                           $"PR Dengan Nomor : " + header.RequisitionNo + "<br>Catatan PR : " + header.RequestNotes + "<br>Diajukan pada : " + (header.CreatedTime) + "<br>" +
                           $"Telah Disetujui Oleh :" + UserName + "<br>" +
                           $"Pada : " + DateTime.Now + "<br>" +
                           $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/List'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau PR yang telah Diajukan<br>" +
                           $"<br>" +
                           $"<br>" +
                           $"Regards,<br>" +
                           $"BalimOOn - IT Team"
                          );

                    //Kirim Email ke Pembuat PR
                    var CreatorPR = _context.AspNetUsers.FirstOrDefault(a => a.UserName == header.CreatedBy);

                    _emailSender.SendEmailAsync(CreatorPR.Email, "PR Anda Disetujui Approval",
                        $"Balimoon E-Procurement<br>" +
                        $"Dear " + CreatorPR.UserName + ",<br>Permohonan Pembelian yang Anda Ajukan Sudah Disetujui oleh Approval<br>" +
                        $"<br> PR Dengan Nomor : " + header.RequisitionNo + "<br>Catatan : " + header.RequestNotes + "Dan Diajukan Pada : " + header.CreatedTime + "<br>" +
                        $"Telah Disetujui Oleh : " + UserName + "dan siap untuk disetujui Oleh Approval Berikutnya<br>" +
                        $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/List'><b>Masuk Kedalam Sistem</b></a> Untuk Melihat Status PR yang Anda Ajukan<br><br><br>" +
                        $"Regards,<br>" +
                        $"BalimOOn - IT Team"
                        );

                    PurchaseRequisitionHeader purchaseRequisitionHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
                    purchaseRequisitionHeader.Status = 2;
                    _BalimoonBMLContext.PurchaseRequisitionHeader.Update(purchaseRequisitionHeader);
                    _BalimoonBMLContext.SaveChanges();

                    //Tambahkan Record Kedalam Tabel Approval Entry
                    var newSeq = 0;
                    if (PRinApproval == null)
                    {
                        newSeq = 1;
                    }
                    else
                    {
                        var getMaxSeqinApprovalEntry = _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == line.DocumentNo).Max(a => a.SequenceNo);
                        newSeq = getMaxSeqinApprovalEntry + 1;
                    }
                    //Insert Data Into Approval Entry
                    var ApprovalInsert2 = new ApprovalEntry
                    {
                        TableName = "PR",
                        DocumentType = 0,
                        DocumentNo = header.RequisitionNo,
                        SequenceNo = newSeq,
                        ApprovalCode = ViewBag.UserName,
                        SenderBy = header.RequesterId,
                        SalespersPurchCode = "",
                        ApproverBy = ViewBag.UserName,
                        Status = 5,
                        DueDate = header.DueDate.Value,
                        Amount = getAmountPR.Value,
                        AmountLcy = 0,
                        CurrencyCode = line.CurrencyCode,
                        ApprovalType = 2,
                        LimitType = 0,
                        AvailableCreditLimitLcy = 0,
                        DelegationDateFormula = "",
                        DateTimeSentforApproval = line.EndingDateTime.Value,
                        RowStatus = 0,
                        CreatedBy = UserName,
                        CreatedTime = DateTime.Now,
                        LastModifiedBy = "",
                        NextApproval = approvalbaru,
                        Message = ""
                    };
                    _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert2);
                    _BalimoonBMLContext.SaveChanges();

                    result = "Sukses";
                }
            }
            return Json(result);
        }

        [HttpPost]
        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public JsonResult ApprovePRCancelled(PurchaseRequestVM model)
        {
            var result = "Process Not Executed";
            var header = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
            if (header == null)
            {
                result = "PR Not Found";
            }
            var line = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.RequisitionheaderId == model.HeaderTbl.RequisitionHeaderId);
            var PRinApproval = _BalimoonBMLContext.ApprovalEntry.FirstOrDefault(a => a.DocumentNo == line.DocumentNo);
            //cek data ada?
            if (line == null)
            {
                result = "Blank, PR Not Contain any Item";
            }
            else
            {

                ViewBag.UserId = _userManager.GetUserId(HttpContext.User);
                string UserId = ViewBag.UserId;
                ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
                string UserName = ViewBag.UserName;
                var getUserInSystemUser = _context.AspNetSystemUsers.FirstOrDefault(a => a.UserId == UserId);
                var getAmountPR = _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.RequisitionheaderId == model.HeaderTbl.RequisitionHeaderId).Sum(a => a.CostAmount);
                //cari Approval Sebelumnya dan si Pembuat PR
                var PRCreator = header.CreatedBy; //ini pembuat
                var PRCreatorDetail = _context.AspNetUsers.FirstOrDefault(a => a.UserName == PRCreator); //ini detail pembuat, termasuk email
                //cari approval pembuat
                var getApprovalUserName = PRCreator;
                do {
                    var getPRCreatorID = _context.AspNetUsers.FirstOrDefault(a => a.UserName == getApprovalUserName); //ketemu ID si creator/approval sekarang
                    var CreatorInSystemUser = _context.AspNetSystemUsers.FirstOrDefault(a => a.UserId == getPRCreatorID.Id); //ID si creator/approval sekarang di system user
                    var getApproval = _context.AspNetUsers.FirstOrDefault(a => a.UserName == CreatorInSystemUser.ApproverId); //Ketemu si Approval Berikutnya
                    getApprovalUserName = getApproval.UserName; // Ketemu Username si Approval
                    var ApprovalEmail = getApproval.Email; // Ketemu Email si Approval
                    //send email Ketika Ketemu Approval
                    _emailSender.SendEmailAsync(getApproval.Email, "PR Yang Anda Setujui Dibatalkan Approval",
                           $"Balimoon E-Procurement<br>" +
                           $"Dear  " + getApproval.UserName + ",<br>Permohonan Pembelian Yang Diajukan Oleh " + header.RequesterId + " Telah dibatalkan oleh Approval<br>" +
                           $"<br>" +
                           $"PR Dengan Nomor : " + header.RequisitionNo + "<br>Catatan PR : " + header.RequestNotes + "<br>Diajukan pada : " + (header.CreatedTime) + "<br>" +
                           $"Telah Dibatalkan Oleh :" + UserName + "<br>" +
                           $"Pada : " + DateTime.Now + "<br>" +
                           $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/List'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau PR yang telah Dibatalkan<br>" +
                           $"<br>" +
                           $"<br>" +
                           $"Regards,<br>" +
                           $"BalimOOn - IT Team"
                          );
                } while (getApprovalUserName == UserName);

                //send email Kepada PembuatPR
                _emailSender.SendEmailAsync(PRCreatorDetail.Email, "PR Yang Anda Buat Dibatalkan Approval",
                       $"Balimoon E-Procurement<br>" +
                       $"Dear  " + PRCreatorDetail.UserName + ",<br>Permohonan Pembelian Yang Telah Anda Ajukan Telah dibatalkan oleh Approval<br>" +
                       $"<br>" +
                       $"PR Dengan Nomor : " + header.RequisitionNo + "<br>Catatan PR : " + header.RequestNotes + "<br>Diajukan pada : " + (header.CreatedTime) + "<br>" +
                       $"Telah Dibatalkan Oleh :" + UserName + "<br>" +
                       $"Pada : " + DateTime.Now + "<br>" +
                       $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/MyCancelledPR'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau PR yang telah Dibatalkan<br>" +
                       $"<br>" +
                       $"<br>" +
                       $"Regards,<br>" +
                       $"BalimOOn - IT Team"
                      );
                PurchaseRequisitionHeader purchaseRequisitionHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
                purchaseRequisitionHeader.Status = 8;
                _BalimoonBMLContext.PurchaseRequisitionHeader.Update(purchaseRequisitionHeader);
                _BalimoonBMLContext.SaveChanges();

                //Tambahkan Record Kedalam Tabel Approval Entry
                var newSeq = 0;
                if (PRinApproval == null)
                {
                    newSeq = 1;
                }
                else
                {
                    var getMaxSeqinApprovalEntry = _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == line.DocumentNo).Max(a => a.SequenceNo);
                    newSeq = getMaxSeqinApprovalEntry + 1;
                }
                //Insert Data Into Approval Entry
                var ApprovalInsert = new ApprovalEntry
                {
                    TableName = "PR",
                    DocumentType = 0,
                    DocumentNo = header.RequisitionNo,
                    SequenceNo = newSeq,
                    ApprovalCode = ViewBag.UserName,
                    SenderBy = header.RequesterId,
                    SalespersPurchCode = "",
                    ApproverBy = ViewBag.UserName,
                    Status = 2,
                    DueDate = header.DueDate.Value,
                    Amount = getAmountPR.Value,
                    AmountLcy = 0,
                    CurrencyCode = line.CurrencyCode,
                    ApprovalType = 2,
                    LimitType = 4,
                    AvailableCreditLimitLcy = 0,
                    DelegationDateFormula = "",
                    DateTimeSentforApproval = line.EndingDateTime.Value,
                    RowStatus = 0,
                    CreatedBy = UserName,
                    CreatedTime = DateTime.Now,
                    LastModifiedBy = "",
                    NextApproval = "",
                    Message = ""
                };
                _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert);
                _BalimoonBMLContext.SaveChanges();

                result = "Sukses";
            }
            return Json(result);
        }

        [Authorize(Roles = "HODBML, GM, Finance, Director, UserBML")]
        public IActionResult MyCancelledPR()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "HODBML, GM, Finance, Director, UserBML")]
        public IActionResult MyCancelledPR([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserId = _userManager.GetUserId(HttpContext.User);
            string UserId = ViewBag.UserId;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string CurrentLogin = ViewBag.UserName;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionHeaderId";
                orderDescendingDirection = true;
            }

            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          join approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals approval.DocumentNo
                          where (approval.CreatedBy == CurrentLogin || approval.ApprovalCode == CurrentLogin || approval.SenderBy == CurrentLogin) && header.Status == 8 && approval.Status == 2
                          select new
                          {
                              RequisitionHeaderId = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              RequesterId = header.RequesterId,
                              ShortcutDimension1Code = header.ShortcutDimension1Code,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              RequestNotes = header.RequestNotes
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.RequisitionNo != null && a.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RequesterId != null && a.RequesterId.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RequestNotes != null && a.RequestNotes.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals approval.DocumentNo
                              where (approval.CreatedBy == CurrentLogin || approval.ApprovalCode == CurrentLogin) && header.Status == 8
                              select new
                              {
                                  RequisitionHeaderId = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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



        [HttpPost]
        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public JsonResult ApprovePRRejected(PurchaseRequestVM model)
        {
            var result = "Process Not Executed";
            var header = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
            if (header == null)
            {
                result = "PR Not Found";
            }
            var line = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.RequisitionheaderId == model.HeaderTbl.RequisitionHeaderId);
            if (line == null)
            {
                result = "Blank, PR Not Contain Any Item";
            }
            else
            {
                var approvalE = _BalimoonBMLContext.ApprovalEntry.FirstOrDefault(a => a.DocumentNo == line.DocumentNo);
                ViewBag.UserId = _userManager.GetUserId(HttpContext.User);
                string UserId = ViewBag.UserId;
                ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
                string UserName = ViewBag.UserName;
                var getUserInSystemUser = _context.AspNetSystemUsers.FirstOrDefault(a => a.UserId == UserId);
                var getAmountPR = _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.RequisitionheaderId == model.HeaderTbl.RequisitionHeaderId).Sum(a => a.CostAmount);

                //cari Approval Sebelumnya dan si Pembuat PR
                var PRCreator = header.CreatedBy; //ini pembuat
                var PRCreatorDetail = _context.AspNetUsers.FirstOrDefault(a => a.UserName == PRCreator); //ini detail pembuat, termasuk email
                //cari approval pembuat
                var ApprovalUName = _BalimoonBMLContext.ApprovalEntry.FirstOrDefault(a => a.NextApproval == UserName);
                var getApprovalUserName = ApprovalUName.ApproverBy;

                //Kirimkan Email Ke Approval
                while (getApprovalUserName != "")
                {
                    var getApproval = _context.AspNetUsers.FirstOrDefault(a => a.UserName == getApprovalUserName);
                    //send email Ketika Ketemu Approval
                    _emailSender.SendEmailAsync(getApproval.Email, "PR Yang Anda Setujui Ditangguhkan Approval",
                           $"Balimoon E-Procurement<br>" +
                           $"Dear  " + getApproval.UserName + ",<br>Permohonan Pembelian Yang Diajukan Oleh " + header.RequesterId + " Telah ditangguhkan oleh Approval<br>" +
                           $"<br>" +
                           $"PR Dengan Nomor : " + header.RequisitionNo + "<br>Catatan PR : " + header.RequestNotes + "<br>Diajukan pada : " + (header.CreatedTime) + "<br>" +
                           $"Telah Ditangguhkan Oleh :" + UserName + "<br>" +
                           $"Pada : " + DateTime.Now + "<br>" +
                           $"Dengan Pesan Sebagai Berikut:<br>" +
                           $"" + model.ApprovalEntry.Message + "<br><br><br>" +
                           $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/ViewMyReject'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau PR yang telah Ditangguhkan<br>" +
                           $"<br>" +
                           $"<br>" +
                           $"Regards,<br>" +
                           $"BalimOOn - IT Team"
                          );
                    //dapatkan approval sebelumnya
                    var beforeAppr = _BalimoonBMLContext.ApprovalEntry.FirstOrDefault(a => a.NextApproval == getApprovalUserName);
                    getApprovalUserName = beforeAppr.ApproverBy;
                }

                //send email Kepada PembuatPR
                _emailSender.SendEmailAsync(PRCreatorDetail.Email, "PR Yang Anda Buat Ditangguhkan Approval",
                $"Balimoon E-Procurement<br>" +
                $"Dear  " + PRCreatorDetail.UserName + ",<br>Permohonan Pembelian Yang Telah Anda Ajukan Telah ditangguhkan oleh Approval<br>" +
                $"<br>" +
                $"PR Dengan Nomor : " + header.RequisitionNo + "<br>Catatan PR : " + header.RequestNotes + "<br>Diajukan pada : " + (header.CreatedTime) + "<br>" +
                    $"Telah Ditangguhkan Oleh :" + UserName + "<br>" +
                    $"Pada : " + DateTime.Now + "<br>" +
                    $"Dengan Pesan Sebagai Berikut:<br>" +
                    $"" + model.ApprovalEntry.Message + "<br><br><br>" +
                    $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/MyRejectedPR'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau PR yang telah Ditangguhkan<br>" +
                    $"<br>" +
                    $"<br>" +
                    $"Regards,<br>" +
                    $"BalimOOn - IT Team"
               );
                PurchaseRequisitionHeader purchaseRequisitionHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == model.HeaderTbl.RequisitionHeaderId);
                purchaseRequisitionHeader.Status = 7;
                _BalimoonBMLContext.PurchaseRequisitionHeader.Update(purchaseRequisitionHeader);
                _BalimoonBMLContext.SaveChanges();
                //Tambahkan Record Kedalam Tabel Approval Entry
                var newSeq = 0;
                if (approvalE == null)
                {
                    newSeq = 1;
                }
                else
                {
                    var getMaxSeqinApprovalEntry = _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == line.DocumentNo).Max(a => a.SequenceNo);
                    newSeq = getMaxSeqinApprovalEntry + 1;
                }

                //Insert Data Into Approval Entry
                var ApprovalInsert = new ApprovalEntry
                {
                    TableName = "PR",
                    DocumentType = 0,
                    DocumentNo = header.RequisitionNo,
                    SequenceNo = newSeq,
                    ApprovalCode = ViewBag.UserName,
                    SenderBy = header.RequesterId,
                    SalespersPurchCode = "",
                    ApproverBy = ViewBag.UserName,
                    Status = 3,
                    DueDate = header.DueDate.Value,
                    Amount = getAmountPR.Value,
                    AmountLcy = 0,
                    CurrencyCode = line.CurrencyCode,
                    ApprovalType = 2,
                    LimitType = 4,
                    AvailableCreditLimitLcy = 0,
                    DelegationDateFormula = "",
                    DateTimeSentforApproval = line.EndingDateTime.Value,
                    RowStatus = 0,
                    CreatedBy = UserName,
                    CreatedTime = DateTime.Now,
                    LastModifiedBy = "",
                    NextApproval = "",
                    Message = model.ApprovalEntry.Message
                };
                _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert);
                _BalimoonBMLContext.SaveChanges();

                result = "Sukses";
            }
            return Json(result);
        }

        [Authorize(Roles = "HODBML, GM, Finance, Director, UserBML")]
        public IActionResult MyRejectedPR()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "UserBML")]
        public IActionResult MyRejectedTable([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserId = _userManager.GetUserId(HttpContext.User);
            string UserId = ViewBag.UserId;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string CurrentLogin = ViewBag.UserName;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderDescendingDirection = true;
            }
            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          join approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals approval.DocumentNo
                          where (approval.CreatedBy == CurrentLogin || approval.ApproverBy == CurrentLogin || approval.SenderBy == CurrentLogin) && (header.Status == 7) && (approval.Status == 3) && approval.SequenceNo == _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == header.RequisitionNo).Max(a => a.SequenceNo)
                          select new
                          {
                              RequisitionID = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              REQUESTER = header.CreatedBy,
                              Department = header.ShortcutDimension1Code,
                              CreatedTime = header.CreatedTime,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              RequestNotes = header.RequestNotes
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.RequisitionNo != null && a.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                a.REQUESTER != null && a.REQUESTER.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RequestNotes != null && a.RequestNotes.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals approval.DocumentNo
                              where (approval.CreatedBy == CurrentLogin || approval.ApproverBy == CurrentLogin) && header.Status == 7
                              select new
                              {
                                  PRID = header.RequisitionHeaderId,
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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

        [HttpPost]
        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public IActionResult RejectedTable([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserId = _userManager.GetUserId(HttpContext.User);
            string UserId = ViewBag.UserId;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string CurrentLogin = ViewBag.UserName;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderDescendingDirection = true;
            }
            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          join approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals approval.DocumentNo
                          where (header.Status == 7) && (approval.CreatedBy == CurrentLogin || approval.ApproverBy == CurrentLogin)
                          select new
                          {
                              RequisitionID = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              RequestNotes = header.RequestNotes
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                         r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                         r.OrderDate.ToString() != null && r.OrderDate.ToString().ToUpper().Contains(searchBy.ToUpper()) ||
                         r.DueDate != null && r.DueDate.ToString().ToUpper().Contains(searchBy.ToUpper())
                         ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            var totalCount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals approval.DocumentNo
                              where (header.Status == 7) && (approval.CreatedBy == CurrentLogin || approval.ApproverBy == CurrentLogin)
                              select new
                              {
                                  RequisitionID = header.RequisitionHeaderId,
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalCount.Count();
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

        [HttpPost]
        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public IActionResult CancelledTable([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserId = _userManager.GetUserId(HttpContext.User);
            string UserId = ViewBag.UserId;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string CurrentLogin = ViewBag.UserName;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderDescendingDirection = true;
            }
            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          join approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals approval.DocumentNo
                          where (header.Status == 8) && (approval.CreatedBy == CurrentLogin || approval.ApproverBy == CurrentLogin) && (approval.SequenceNo == _BalimoonBMLContext.ApprovalEntry.Where(b=>b.DocumentNo == header.RequisitionNo && b.CreatedBy == CurrentLogin).Max(c=>c.SequenceNo))
                          select new
                          {
                              RequisitionID = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              RequestNotes = header.RequestNotes
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy)){
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                r.OrderDate != null && r.OrderDate.ToString().ToUpper().Contains(searchBy.ToUpper()) ||
                r.DueDate.ToString() != null && r.DueDate.ToString().ToUpper().Contains(searchBy.ToUpper())
                
                ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            var totalCount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals approval.DocumentNo
                              where (header.Status == 8) && (approval.CreatedBy == CurrentLogin || approval.ApproverBy == CurrentLogin) && (approval.SequenceNo == _BalimoonBMLContext.ApprovalEntry.Where(b => b.DocumentNo == header.RequisitionNo && b.CreatedBy == CurrentLogin).Max(c => c.SequenceNo))
                              select new
                              {
                                  RequisitionID = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalCount.Count();
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

        [HttpPost]
        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public IActionResult ApprovedTable([FromBody]DTParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserId = _userManager.GetUserId(HttpContext.User);
            string UserId = ViewBag.UserId;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string CurrentLogin = ViewBag.UserName;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "RequisitionNo";
                orderDescendingDirection = true;
            }
            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          join Approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals Approval.DocumentNo
                          where (Approval.CreatedBy == CurrentLogin || Approval.ApproverBy == CurrentLogin) && (Approval.Status == 4 || Approval.Status == 5) &&(Approval.SequenceNo == _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == header.RequisitionNo && a.ApproverBy == CurrentLogin).Max(a => a.SequenceNo))
                          select new {
                              RequisitionID = header.RequisitionHeaderId,
                              RequisitionNo = header.RequisitionNo,
                              OrderDate = header.OrderDate,
                              DueDate = header.DueDate,
                              RequestNotes = header.RequestNotes
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.RequisitionNo != null && r.RequisitionNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RequestNotes != null && r.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                r.OrderDate != null && r.OrderDate.ToString().ToUpper().Contains(searchBy.ToUpper()) ||
                r.DueDate.ToString() != null && r.DueDate.ToString().ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            var totalCount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join Approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals Approval.DocumentNo
                              where (Approval.CreatedBy == CurrentLogin || Approval.ApproverBy == CurrentLogin) && (Approval.Status == 4 || Approval.Status == 5) && (Approval.SequenceNo == _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == header.RequisitionNo && a.ApproverBy == CurrentLogin).Max(a => a.SequenceNo))
                              select new
                              {
                                  RequisitionID = header.RequisitionHeaderId
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalCount.Count();
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

        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public IActionResult ViewMyCancelled()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public IActionResult ViewMyReject()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public IActionResult ViewMyApproved()
        {
            //List Of Status
            List<Models.LookupField> status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> priority = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOfPriority = new SelectList(priority, "LookupCode", "LookupDescription");

            return View();
        }

        //Untuk Pindah Form dari View My Cancelled
        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public IActionResult ViewMyCancelledDetail(string RequisitionNo)
        {
            var reqNo = RequisitionNo;
            //cek apakah PR Number berhasil ditangkap controller//
            if(reqNo == null)
            {
                //Tampil Not Found Ketika Tidak Ditemukan
                return View("NotFound");
            }
            //cari PR berdasarkan No yang ditangkap tadi
            var PRHead = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionNo == reqNo && a.Status == 8);
            //cek apakah PR ada
            if(PRHead == null)
            {
                // apabila tidak ditemukan tampil error not found
                return View("NotFound");
            }
            else
            {
                var join = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                            join approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals approval.DocumentNo
                            where (header.RequisitionNo == reqNo) && (approval.SequenceNo == _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == reqNo).Max(a => a.SequenceNo))
                            select new PurchaseRequestVM
                            {
                                HeaderTbl = header,
                                ApprovalEntry = approval
                            }).FirstOrDefault();
                if(join == null)
                {
                    return View("NotFound");
                }
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                //List Of Type
                List<Models.LookupField> RecordType = _context.LookupField.Where(a => a.LookupGroup == "RecordType").ToList();
                ViewBag.ListOfRecordType = new SelectList(RecordType, "LookupCode", "LookupDescription");

                //List Of Record No
                List<Models.BalimoonBML.Items> RecordNo = _BalimoonBMLContext.Items.ToList();
                ViewBag.ListOfRecordNo = new SelectList(RecordNo, "ItemNo", "Description");

                //List Of UOM
                List<Models.BalimoonBML.UnitOfMeasures> unitOfMeasures = _BalimoonBMLContext.UnitOfMeasures.ToList();
                ViewBag.ListOfUOM = new SelectList(unitOfMeasures, "Uomdescription", "Uomdescription");

                //List Of  Vendor
                List<Models.BalimoonBML.Vendors> VendorsName = _BalimoonBMLContext.Vendors.ToList();
                ViewBag.ListOfVendors = new SelectList(VendorsName, "VendorNo", "VendorName");

                ViewBag.PRNO = join.HeaderTbl.RequisitionNo;
                ViewBag.ReqID = join.HeaderTbl.RequisitionHeaderId;

                return View(join);
            }
        }

        //Untuk Pindah Form dari View My Reject
        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public IActionResult ViewMyRejectDetail(string RequisitionNo)
        {

            var reqNo = RequisitionNo;
            //cek apakah PRNO berhasil Di Tangkap dari View
            if(reqNo == null)
            {
                return View("NotFound");
            }
            //cari PR berdasarkan PR No.
            var PRHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionNo == reqNo && a.Status == 7);
            //Cek Apakah PR ada
            if (PRHeader == null)
            {
                return View("NotFound");
            }
            //Jika Ada
            else
            {
                //Dapatkan Sequence No. Untuk Mendapat Record PR Terakhir Pada Approval Entry
                var sequenceNo = _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == reqNo).Max(a => a.SequenceNo);
                var Join = (from Header in _BalimoonBMLContext.PurchaseRequisitionHeader
                            join Approval in _BalimoonBMLContext.ApprovalEntry on Header.RequisitionNo equals Approval.DocumentNo
                            where (Header.RequisitionNo == reqNo) && (Approval.SequenceNo == sequenceNo)
                            select new PurchaseRequestVM
                            {
                                HeaderTbl = Header,
                                ApprovalEntry = Approval,
                            }).FirstOrDefault();
                if (Join == null)
                {
                    return View("NotFound");
                }
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                //List Of Type
                List<Models.LookupField> RecordType = _context.LookupField.Where(a => a.LookupGroup == "RecordType").ToList();
                ViewBag.ListOfRecordType = new SelectList(RecordType, "LookupCode", "LookupDescription");

                //List Of Record No
                List<Models.BalimoonBML.Items> RecordNo = _BalimoonBMLContext.Items.ToList();
                ViewBag.ListOfRecordNo = new SelectList(RecordNo, "ItemNo", "Description");

                //List Of UOM
                List<Models.BalimoonBML.UnitOfMeasures> unitOfMeasures = _BalimoonBMLContext.UnitOfMeasures.ToList();
                ViewBag.ListOfUOM = new SelectList(unitOfMeasures, "Uomdescription", "Uomdescription");

                //List Of  Vendor
                List<Models.BalimoonBML.Vendors> VendorsName = _BalimoonBMLContext.Vendors.ToList();
                ViewBag.ListOfVendors = new SelectList(VendorsName, "VendorNo", "VendorName");

                ViewBag.PRNO = Join.HeaderTbl.RequisitionNo;
                ViewBag.ReqID = Join.HeaderTbl.RequisitionHeaderId;

                return View(Join);
            }
        }

        //Untuk Pindah Form dari View My Reject
        [Authorize(Roles = "HODBML, GM, Finance, Director")]
        public IActionResult ViewMyApprovedDetail(string RequisitionNo)
        {
            var currentlogin = _userManager.GetUserName(HttpContext.User);
            var reqNo = RequisitionNo;
            //cek apakah PRNO berhasil Di Tangkap dari View
            if (reqNo == null)
            {
                return View("NotFound");
            }
            //cari PR berdasarkan PR No.
            var PRHeader = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                            join approver in _BalimoonBMLContext.ApprovalEntry on head.RequisitionNo equals approver.DocumentNo
                            where (head.RequisitionNo == reqNo) && (approver.ApproverBy == currentlogin || approver.CreatedBy == currentlogin) && (approver.Status == 4 || approver.Status == 5) && (approver.SequenceNo == _BalimoonBMLContext.ApprovalEntry.Where(a=>a.DocumentNo == reqNo && a.CreatedBy == currentlogin).Max(a=>a.SequenceNo))
                            select new PurchaseRequestVM{ 
                                HeaderTbl = head,
                                ApprovalEntry = approver,
                            }).FirstOrDefault();
            if(PRHeader == null)
            {
                return View("NotFound");
            }
            else
            {
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                //List Of Type
                List<Models.LookupField> RecordType = _context.LookupField.Where(a => a.LookupGroup == "RecordType").ToList();
                ViewBag.ListOfRecordType = new SelectList(RecordType, "LookupCode", "LookupDescription");

                //List Of Record No
                List<Models.BalimoonBML.Items> RecordNo = _BalimoonBMLContext.Items.ToList();
                ViewBag.ListOfRecordNo = new SelectList(RecordNo, "ItemNo", "Description");

                //List Of UOM
                List<Models.BalimoonBML.UnitOfMeasures> unitOfMeasures = _BalimoonBMLContext.UnitOfMeasures.ToList();
                ViewBag.ListOfUOM = new SelectList(unitOfMeasures, "Uomdescription", "Uomdescription");

                //List Of  Vendor
                List<Models.BalimoonBML.Vendors> VendorsName = _BalimoonBMLContext.Vendors.ToList();
                ViewBag.ListOfVendors = new SelectList(VendorsName, "VendorNo", "VendorName");

                ViewBag.PRNO = PRHeader.HeaderTbl.RequisitionNo;
                ViewBag.ReqID = PRHeader.HeaderTbl.RequisitionHeaderId;

                return View(PRHeader);
            }
        }

        [HttpGet]
        [Authorize(Roles = "HODBML, GM, Finance, Director, UserBML")]
        public JsonResult ViewReject(int RequisitionHeaderId)
        {
            var result = string.Empty;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string CurrentLogin = ViewBag.UserName;
            //get header value
            var PHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == RequisitionHeaderId);
            if (PHeader != null)
            {
                var getSeqNo = _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == PHeader.RequisitionNo).Max(a => a.SequenceNo);
                var join = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                            join Approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals Approval.DocumentNo
                            join line in _BalimoonBMLContext.PurchaseRequisitionLine on header.RequisitionHeaderId equals line.RequisitionheaderId
                            where (header.RequisitionHeaderId == RequisitionHeaderId) && (Approval.SequenceNo == getSeqNo)
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
                                UnitOfMeasure = line.UnitofMeasure,
                                VendorNo = line.VendorNo,
                                CurrencyCode = line.CurrencyCode,
                                CurrencyFactor = line.CurrencyFactor,
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
                                QtyperUnitOfMeasure = line.QtyperUnitofMeasure,
                                UnitofMeasureCode = line.UnitofMeasureCode,
                                QuantityBase = line.QuantityBase,
                                UnitCost = line.UnitCost,
                                CostAmount = line.CostAmount,
                                Message = Approval.Message
                            }).FirstOrDefault();
                result = JsonConvert.SerializeObject(join, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            }
            

            return Json(result);
        }

        [Authorize(Roles = "HODBML, GM, Finance, Director, UserBML")]
        public async Task<IActionResult> ShowEdit(string RequisitionNo)
        {
            var getReqID = RequisitionNo;
            if (getReqID == null)
            {
                return View("NotFound");
            }
            var PurchaseRequest = await _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefaultAsync(a => a.RequisitionNo == getReqID && a.Status == 7);
            if(PurchaseRequest == null)
            {
                return View("NotFound");
            }
            else {             
                var getSeqNo = _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == PurchaseRequest.RequisitionNo).Max(a => a.SequenceNo);
                var join = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                            join Approval in _BalimoonBMLContext.ApprovalEntry on header.RequisitionNo equals Approval.DocumentNo
                            where (Approval.SequenceNo == getSeqNo) && (header.RequisitionNo == getReqID)
                            select new PurchaseRequestVM
                            {
                                HeaderTbl =header,
                                ApprovalEntry = Approval
                            }).FirstOrDefault();
                if (join == null)
                {
                    return View("NotFound");
                }
                //List Of Type
                List<Models.LookupField> RecordType = _context.LookupField.Where(a => a.LookupGroup == "RecordType").ToList();
                ViewBag.ListOfRecordType = new SelectList(RecordType, "LookupCode", "LookupDescription");

                //List Of Record No
                List<Models.BalimoonBML.Items> RecordNo = _BalimoonBMLContext.Items.ToList();
                ViewBag.ListOfRecordNo = new SelectList(RecordNo, "ItemNo", "Description");

                //List Of UOM
                List<Models.BalimoonBML.UnitOfMeasures> unitOfMeasures = _BalimoonBMLContext.UnitOfMeasures.ToList();
                ViewBag.ListOfUOM = new SelectList(unitOfMeasures, "Uomdescription", "Uomdescription");

                //List Of  Vendor
                List<Models.BalimoonBML.Vendors> VendorsName = _BalimoonBMLContext.Vendors.ToList();
                ViewBag.ListOfVendors = new SelectList(VendorsName, "VendorNo", "VendorName");

                ViewBag.PRNo = PurchaseRequest.RequisitionNo;
                return View(join);
            }   
        }

        [HttpPost]
        public IActionResult testing([FromBody]DTParameters dtParameters, string RequisitionNo)
        {
            var getreqNo = RequisitionNo;
            var searchBy = dtParameters.Search?.Value;
            var orderCriteria = string.Empty;
            var orderDescendingDirection = true;
            ViewBag.UserId = _userManager.GetUserId(HttpContext.User);
            string UserId = ViewBag.UserId;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string CurrentLogin = ViewBag.UserName;
            if (dtParameters.Order != null)
            {
                orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                orderDescendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "desc";
            }
            else
            {
                orderCriteria = "SeqLineNo";
                orderDescendingDirection = true;
            }
            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          join line in _BalimoonBMLContext.PurchaseRequisitionLine on header.RequisitionHeaderId equals line.RequisitionheaderId
                          join item in _BalimoonBMLContext.Items on line.RecordNo equals item.ItemNo
                          where header.RequisitionNo == RequisitionNo
                          select new {
                              RequisitionLineId = line.RequisitionLineId,
                              SeqLineNo = line.SeqLineNo,
                              ItemName = item.Description,
                              Description = line.Description,
                              Quantity = line.Quantity,
                              UnitOfMeasure = line.UnitofMeasure,
                              UnitCost = line.DirectUnitCost,
                              Amount = line.CostAmount,
                              RequestNotes = line.RequestNotes
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.ItemName != null && a.ItemName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Description != null && a.Description.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RequestNotes != null && a.RequestNotes.ToUpper().Contains(searchBy.ToUpper()) ||
                a.SeqLineNo.ToString().ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            var totalcount = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          join line in _BalimoonBMLContext.PurchaseRequisitionLine on header.RequisitionHeaderId equals line.RequisitionheaderId
                          join item in _BalimoonBMLContext.Items on line.RecordNo equals item.ItemNo
                          where header.RequisitionNo == RequisitionNo
                          select new
                          {
                              RequisitionLineNo = line.RequisitionLineId
                          }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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
        public JsonResult EditLineReject(int RequisitionLineId)
        {
            var result = string.Empty;
            var line = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.RequisitionLineId == RequisitionLineId);
            result = JsonConvert.SerializeObject(line, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> EditLineProcess(IFormFile file, PurchaseRequestVM model)
        {
            var result = "Process Not Executed";
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);

            var vendors = model.LineTbl.VendorNo;
            string currentLogin = ViewBag.UserName;

            //Cek ID Apakah Ada.
            var currentPRLineId = model.LineTbl.RequisitionLineId;
            var currentPR = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.RequisitionLineId == currentPRLineId);
            if(currentPR == null)
            {
                result = "PR Not Found";
            }
            else
            {
                if(vendors == null)
                {
                    vendors = "";
                }
                if(file == null) {
                    //dapatkan detil item dari item yang dipilih user
                    var getDetilItem = _BalimoonBMLContext.Items.FirstOrDefault(b => b.ItemNo == model.LineTbl.RecordNo);
                    //Lakukan Update
                    currentPR.RecordType = model.LineTbl.RecordType;
                    currentPR.RecordNo = model.LineTbl.RecordNo;
                    currentPR.Description = model.LineTbl.Description;
                    currentPR.Quantity = model.LineTbl.Quantity;
                    currentPR.UnitofMeasure = model.LineTbl.UnitofMeasure;
                    currentPR.UnitCost = model.LineTbl.UnitCost;
                    currentPR.VendorNo = vendors;
                    currentPR.RequestNotes = model.LineTbl.RequestNotes;
                    currentPR.DirectUnitCost = model.LineTbl.UnitCost;
                    currentPR.UnitofMeasureCode = model.LineTbl.UnitofMeasure;
                    currentPR.QuantityBase = model.LineTbl.Quantity;
                    currentPR.ItemCategoryCode = getDetilItem.GenProdPostingGroup;
                    currentPR.ProductGroupCode = getDetilItem.InventoryPostingGroup;
                    currentPR.GenProdPostingGroup = getDetilItem.GenProdPostingGroup;
                    currentPR.OriginalQuantity = model.LineTbl.Quantity;
                    currentPR.RemainingQtyBase = model.LineTbl.Quantity;
                    currentPR.RemainingQuantity = model.LineTbl.Quantity;
                    currentPR.CostAmount = model.LineTbl.Quantity * model.LineTbl.UnitCost;
                    currentPR.LastModifiedBy = currentLogin;
                    currentPR.LastModifiedTime = DateTime.Now;
                    _BalimoonBMLContext.Update(currentPR);
                    _BalimoonBMLContext.SaveChanges();
                    result = "Sukses";
                }
                else
                {
                    string uploadImage = await prImages.ImagesUpload(file);
                    if(uploadImage == "")
                    {
                        //dapatkan detil item dari item yang dipilih user
                        var getDetilItem = _BalimoonBMLContext.Items.FirstOrDefault(b => b.ItemNo == model.LineTbl.RecordNo);
                        //Lakukan Update
                        currentPR.RecordType = model.LineTbl.RecordType;
                        currentPR.RecordNo = model.LineTbl.RecordNo;
                        currentPR.Description = model.LineTbl.Description;
                        currentPR.Quantity = model.LineTbl.Quantity;
                        currentPR.UnitofMeasure = model.LineTbl.UnitofMeasure;
                        currentPR.UnitCost = model.LineTbl.UnitCost;
                        currentPR.VendorNo = vendors;
                        currentPR.RequestNotes = model.LineTbl.RequestNotes;
                        currentPR.DirectUnitCost = model.LineTbl.UnitCost;
                        currentPR.UnitofMeasureCode = model.LineTbl.UnitofMeasure;
                        currentPR.QuantityBase = model.LineTbl.Quantity;
                        currentPR.ItemCategoryCode = getDetilItem.GenProdPostingGroup;
                        currentPR.ProductGroupCode = getDetilItem.InventoryPostingGroup;
                        currentPR.GenProdPostingGroup = getDetilItem.GenProdPostingGroup;
                        currentPR.OriginalQuantity = model.LineTbl.Quantity;
                        currentPR.RemainingQtyBase = model.LineTbl.Quantity;
                        currentPR.RemainingQuantity = model.LineTbl.Quantity;
                        currentPR.CostAmount = model.LineTbl.Quantity * model.LineTbl.UnitCost;
                        currentPR.LastModifiedBy = currentLogin;
                        currentPR.LastModifiedTime = DateTime.Now;
                        _BalimoonBMLContext.Update(currentPR);
                        _BalimoonBMLContext.SaveChanges();
                        result = "Sukses";
                    }
                    else if(uploadImage != "File must be either .jpg, .jpeg, .png and Maximum Size is 2MB")
                    {
                        string Delete = deletePRImages.Delete(currentPR.Picture);
                        //dapatkan detil item dari item yang dipilih user
                        var getDetilItem = _BalimoonBMLContext.Items.FirstOrDefault(b => b.ItemNo == model.LineTbl.RecordNo);
                        //Lakukan Update
                        currentPR.RecordType = model.LineTbl.RecordType;
                        currentPR.RecordNo = model.LineTbl.RecordNo;
                        currentPR.Description = model.LineTbl.Description;
                        currentPR.Quantity = model.LineTbl.Quantity;
                        currentPR.UnitofMeasure = model.LineTbl.UnitofMeasure;
                        currentPR.UnitCost = model.LineTbl.UnitCost;
                        currentPR.VendorNo = vendors;
                        currentPR.RequestNotes = model.LineTbl.RequestNotes;
                        currentPR.DirectUnitCost = model.LineTbl.UnitCost;
                        currentPR.UnitofMeasureCode = model.LineTbl.UnitofMeasure;
                        currentPR.QuantityBase = model.LineTbl.Quantity;
                        currentPR.ItemCategoryCode = getDetilItem.GenProdPostingGroup;
                        currentPR.ProductGroupCode = getDetilItem.InventoryPostingGroup;
                        currentPR.GenProdPostingGroup = getDetilItem.GenProdPostingGroup;
                        currentPR.OriginalQuantity = model.LineTbl.Quantity;
                        currentPR.RemainingQtyBase = model.LineTbl.Quantity;
                        currentPR.RemainingQuantity = model.LineTbl.Quantity;
                        currentPR.CostAmount = model.LineTbl.Quantity * model.LineTbl.UnitCost;
                        currentPR.LastModifiedBy = currentLogin;
                        currentPR.LastModifiedTime = DateTime.Now;
                        currentPR.Picture = uploadImage;
                        _BalimoonBMLContext.Update(currentPR);
                        _BalimoonBMLContext.SaveChanges();
                        result = "Sukses";
                    }
                    else
                    {
                        result = "File must be either .jpg, .jpeg, .png and Maximum Size is 1.5 MB";
                    }
                }
                
            }
            return Json(result);
        }

        [HttpPost]
        public IActionResult SaveRejectedProcess(PurchaseRequestVM model)
        {
            var result = "Process Not Executed";

            var reqID = model.HeaderTbl.RequisitionHeaderId;
            
            //Get Detail PR
            var RequisitionHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == reqID);
            if (RequisitionHeader == null)
            {
                result = "PR Cannot Be Found";
            }
            else
            {
                //dapatkan detail Login User
                ViewBag.UserName = _userManager.GetUserId(HttpContext.User);
                string userId = ViewBag.UserName;
                ViewBag.Usersname = _userManager.GetUserName(HttpContext.User);
                string UserNames = ViewBag.Usersname;

                var PRLine = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.RequisitionheaderId == reqID);
                if(PRLine == null)
                {
                    result = "Please Add Some Items Into This PR";
                }
                else
                {
                    var username = _context.AspNetSystemUsers.FirstOrDefault(a => a.UserId == userId);
                    //dapatkan PR pada PR Approval seq Line Terakhir
                    var SeqLinePR = _BalimoonBMLContext.ApprovalEntry.Where(a => a.DocumentNo == RequisitionHeader.RequisitionNo).Max(a => a.SequenceNo);
                    var PRinApproval = _BalimoonBMLContext.ApprovalEntry.FirstOrDefault(a => a.DocumentNo == RequisitionHeader.RequisitionNo && a.SequenceNo == SeqLinePR);
                    if (username.PurchaseAmountApprovalLimit != null)
                    {
                        //Untuk Requester Atasan Tanpa LIMIT
                        var getLine = _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.RequisitionheaderId == reqID).Sum(a => a.CostAmount);
                        if (username.PurchaseAmountApprovalLimit >= getLine || username.PurchaseAmountApprovalLimit == 0)
                        {
                            //dapatkan jumlah purchasing
                            var arrayPurchasing = _context.AspNetUserRoles.Where(a => a.RoleId == "00060").ToArray();
                            var countArray = arrayPurchasing.Count();
                            for (int i = 0; i < countArray; i++)
                            {
                                var getIDPurch = arrayPurchasing[i].UserId; //ID Purchasing
                                var getUserPurchAll = _context.AspNetUsers.FirstOrDefault(a => a.Id == getIDPurch);
                                _emailSender.SendEmailAsync(getUserPurchAll.Email, "PR Siap Dijadikan PO",
                                  $"Balimoon E-Procurement<br>" +
                                  $"Dear  " + getUserPurchAll.UserName + ",<br>Permohonan Pembelian Yang Diajukan Oleh " + RequisitionHeader.RequesterId + " Sudah Siap Untuk Dijadikan PO<br>" +
                                  $"<br>" +
                                  $"PR Dengan Nomor : " + RequisitionHeader.RequisitionNo + "<br>Catatan : " + RequisitionHeader.RequestNotes + " dan diajukan pada : " + (RequisitionHeader.CreatedTime) + "<br><br>" +
                                  $"Di Reject Pada : " + PRinApproval.CreatedTime + "<br>" +
                                  $"Oleh : " + PRinApproval.CreatedBy + "<br>" +
                                  $"Diajukan Kembali Oleh : " + UserNames + "<br>" +
                                  $"Pada : " + DateTime.Now + "<br>" +
                                  $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/List'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau PR yang telah Diajukan<br>" +
                                  $"<br>" +
                                  $"<br>" +
                                  $"Regards,<br>" +
                                  $"BalimOOn - IT Team"
                                 );
                            }
                            //Update Status di Header
                            RequisitionHeader.Status = 1;
                            RequisitionHeader.LastModifiedBy = UserNames;
                            RequisitionHeader.LastModifiedTime = DateTime.Now;
                            _BalimoonBMLContext.PurchaseRequisitionHeader.Update(RequisitionHeader);
                            _BalimoonBMLContext.SaveChanges();

                            //Tambahkan Jejak Pada Tabel Approval Entry

                            var newSeq = SeqLinePR + 1;
                            var ApprovalInsert = new ApprovalEntry
                            {
                                TableName = "PR",
                                DocumentType = 0,
                                DocumentNo = RequisitionHeader.RequisitionNo,
                                SequenceNo = newSeq,
                                ApprovalCode = "",
                                SenderBy = RequisitionHeader.RequesterId,
                                SalespersPurchCode = "",
                                ApproverBy = "",
                                Status = 0,
                                DueDate = RequisitionHeader.DueDate.Value,
                                Amount = getLine.Value,
                                AmountLcy = 0,
                                CurrencyCode = PRLine.CurrencyCode,
                                ApprovalType = 0,
                                LimitType = 3,
                                AvailableCreditLimitLcy = 0,
                                DelegationDateFormula = "",
                                DateTimeSentforApproval = PRLine.EndingDateTime.Value,
                                RowStatus = 0,
                                CreatedBy = ViewBag.Usersname,
                                CreatedTime = DateTime.Now,
                                LastModifiedBy = "",
                                NextApproval = ViewBag.Usersname
                            };
                            _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert);
                            _BalimoonBMLContext.SaveChanges();

                            var ApprovalInsert2 = new ApprovalEntry
                            {
                                TableName = "PR",
                                DocumentType = 0,
                                DocumentNo = RequisitionHeader.RequisitionNo,
                                SequenceNo = newSeq + 1,
                                ApprovalCode = UserNames,
                                SenderBy = RequisitionHeader.RequesterId,
                                SalespersPurchCode = "",
                                ApproverBy = UserNames,
                                Status = 4,
                                DueDate = RequisitionHeader.DueDate.Value,
                                Amount = getLine.Value,
                                AmountLcy = 0,
                                CurrencyCode = PRLine.CurrencyCode,
                                ApprovalType = 2,
                                LimitType = 3,
                                AvailableCreditLimitLcy = 0,
                                DelegationDateFormula = "",
                                DateTimeSentforApproval = PRLine.EndingDateTime.Value,
                                RowStatus = 0,
                                CreatedBy = UserNames,
                                CreatedTime = DateTime.Now,
                                LastModifiedBy = "",
                                NextApproval = ""
                            };
                            _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert2);
                            _BalimoonBMLContext.SaveChanges();

                            result = "Sukses";
                        }
                        else
                        {
                            //Untuk requester Atasan Dengan Limit
                            var Approval = username.ApproverId;
                            var getapprover = _context.AspNetUsers.FirstOrDefault(a => a.UserName == Approval);
                            var ApprovalId = getapprover.Id;
                            var ApprovalEmail = getapprover.Email;

                            _emailSender.SendEmailAsync(ApprovalEmail, "Ada PR Baru Menunggu Konfirmasi Anda",
                                $"Balimoon E-Procurement<br>" +
                                $"Dear  " + getapprover.UserName + ",<br> Ada Permohonan Pembelian Kembali Yang Diajukan Oleh " + RequisitionHeader.RequesterId + " yang  Memerlukan Konfirmasi Anda<br>" +
                                $"<br>" +
                                $"PR Dengan Nomor : " + RequisitionHeader.RequisitionNo + "<br>Catatan : " + RequisitionHeader.RequestNotes + " dan diajukan pada : " + (RequisitionHeader.CreatedTime) + "<br>" +
                                $"Di Reject Oleh :" + PRinApproval.CreatedBy + "<br>" +
                                $"Pada : " + PRinApproval.CreatedTime + " <br>" +
                                $"Diajukan Kembali Oleh : " + UserNames + "<br>" +
                                $"Pada : " + DateTime.Now + "<br>" +
                                $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/List'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau PR yang telah Diajukan<br>" +
                                $"<br>" +
                                $"<br>" +
                                $"Regards,<br>" +
                                $"BalimOOn - IT Team"
                               );

                            PurchaseRequisitionHeader purchaseRequisitionHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == reqID);
                            purchaseRequisitionHeader.Status = 2;
                            purchaseRequisitionHeader.LastModifiedBy = UserNames;
                            purchaseRequisitionHeader.LastModifiedTime = DateTime.Now;
                            _BalimoonBMLContext.PurchaseRequisitionHeader.Update(purchaseRequisitionHeader);
                            _BalimoonBMLContext.SaveChanges();

                            var newSeq = SeqLinePR + 1;
                            //Insert Data Into Approval Entry
                            var ApprovalInsert = new ApprovalEntry
                            {
                                TableName = "PR",
                                DocumentType = 0,
                                DocumentNo = RequisitionHeader.RequisitionNo,
                                SequenceNo = newSeq,
                                ApprovalCode = "",
                                SenderBy = RequisitionHeader.RequesterId,
                                SalespersPurchCode = "",
                                ApproverBy = UserNames,
                                Status = 0,
                                DueDate = purchaseRequisitionHeader.DueDate.Value,
                                Amount = getLine.Value,
                                AmountLcy = 0,
                                CurrencyCode = PRLine.CurrencyCode,
                                ApprovalType = 0,
                                LimitType = 0,
                                AvailableCreditLimitLcy = 0,
                                DelegationDateFormula = "",
                                DateTimeSentforApproval = PRLine.EndingDateTime.Value,
                                RowStatus = 0,
                                CreatedBy = UserNames,
                                CreatedTime = DateTime.Now,
                                LastModifiedBy = "",
                                NextApproval = getapprover.UserName
                            };
                            _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert);
                            _BalimoonBMLContext.SaveChanges();
                            var ApprovalInsert2 = new ApprovalEntry
                            {
                                TableName = "PR",
                                DocumentType = 0,
                                DocumentNo = purchaseRequisitionHeader.RequisitionNo,
                                SequenceNo = newSeq + 1,
                                ApprovalCode = UserNames,
                                SenderBy = purchaseRequisitionHeader.RequesterId,
                                SalespersPurchCode = "",
                                ApproverBy = UserNames,
                                Status = 5,
                                DueDate = purchaseRequisitionHeader.DueDate.Value,
                                Amount = getLine.Value,
                                AmountLcy = 0,
                                CurrencyCode = PRLine.CurrencyCode,
                                ApprovalType = 2,
                                LimitType = 0,
                                AvailableCreditLimitLcy = 0,
                                DelegationDateFormula = "",
                                DateTimeSentforApproval = PRLine.EndingDateTime.Value,
                                RowStatus = 0,
                                CreatedBy = UserNames,
                                CreatedTime = DateTime.Now,
                                LastModifiedBy = "",
                                NextApproval = getapprover.UserName
                            };
                            _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert2);
                            _BalimoonBMLContext.SaveChanges();
                            result = "Sukses";
                        }
                    }
                    else
                    {
                        var getLine = _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.RequisitionheaderId == reqID).Sum(a => a.CostAmount);
                        var Approval = username.ApproverId;
                        var getapprover = _context.AspNetUsers.FirstOrDefault(a => a.UserName == Approval);
                        var ApprovalId = getapprover.Id;
                        var ApprovalEmail = getapprover.Email;

                        _emailSender.SendEmailAsync(ApprovalEmail, "Ada PR Baru Menunggu Konfirmasi Anda",
                            $"Balimoon E-Procurement<br>" +
                            $"Dear  " + getapprover.UserName + ",<br> Ada Permohonan Pembelian Yang Diajukan Oleh " + RequisitionHeader.RequesterId + " yang  Memerlukan Konfirmasi Anda<br>" +
                            $"<br>" +
                            $"PR Dengan Nomor : " + RequisitionHeader.RequisitionNo + "<br>Catatan PR : " + RequisitionHeader.RequestNotes + "<br>Diajukan pada : " + (RequisitionHeader.CreatedTime) + "<br>" +
                            $"Di Reject Oleh :" + PRinApproval.CreatedBy + "<br>" +
                            $"Pada : " + PRinApproval.CreatedTime + " <br>" +
                            $"Diajukan Kembali Oleh : " + UserNames + "<br>" +
                            $"Pada : " + DateTime.Now + "<br>" +
                            $"Segera <a href='https://" + this.Request.Host + "/PurchaseRequest/List'><b>Masuk Kedalam Sistem</b></a> Untuk Meninjau PR yang telah Diajukan<br>" +
                            $"<br>" +
                            $"<br>" +
                            $"Regards,<br>" +
                            $"BalimOOn - IT Team"
                           );

                        PurchaseRequisitionHeader purchaseRequisitionHeader = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionHeaderId == reqID);
                        purchaseRequisitionHeader.Status = 6;
                        purchaseRequisitionHeader.LastModifiedBy = UserNames;
                        purchaseRequisitionHeader.LastModifiedTime = DateTime.Now;
                        _BalimoonBMLContext.PurchaseRequisitionHeader.Update(purchaseRequisitionHeader);
                        _BalimoonBMLContext.SaveChanges();

                        //Add Approval Entry
                        var ApprExist = _BalimoonBMLContext.ApprovalEntry.FirstOrDefault(a => a.DocumentNo == RequisitionHeader.RequisitionNo);
                        var newSeq = SeqLinePR + 1;
                        var StatusPR = Convert.ToInt32(RequisitionHeader.Status);
                        //Insert Data Into Approval Entry
                        var ApprovalInsert = new ApprovalEntry
                        {
                            TableName = "PR",
                            DocumentType = 0,
                            DocumentNo = RequisitionHeader.RequisitionNo,
                            SequenceNo = newSeq,
                            ApprovalCode = "",
                            SenderBy = RequisitionHeader.RequesterId,
                            SalespersPurchCode = "",
                            ApproverBy = "",
                            Status = 0,
                            DueDate = RequisitionHeader.DueDate.Value,
                            Amount = getLine.Value,
                            AmountLcy = 0,
                            CurrencyCode = PRLine.CurrencyCode,
                            ApprovalType = 0,
                            LimitType = 2,
                            AvailableCreditLimitLcy = 0,
                            DelegationDateFormula = "",
                            DateTimeSentforApproval = PRLine.EndingDateTime.Value,
                            RowStatus = 0,
                            CreatedBy = ViewBag.Usersname,
                            CreatedTime = DateTime.Now,
                            LastModifiedBy = "",
                            NextApproval = getapprover.UserName
                        };
                        _BalimoonBMLContext.ApprovalEntry.Add(ApprovalInsert);
                        _BalimoonBMLContext.SaveChanges();

                        result = "Sukses";
                    }
                }
                
            }
           
            return Json(result);
        }

        [Authorize(Roles = "HODBML, GM, Finance, Director, UserBML")]
        public IActionResult EditLineSubmit(string RequisitionNo)
        {
            var getPRId = RequisitionNo;
            if(getPRId== null)
            {
                return View("NotFound");
            }
            var header = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where head.RequisitionNo == getPRId
                          select new PurchaseRequestVM
                          {
                              HeaderTbl = head
                          }).FirstOrDefault();
            if (header == null)
            {
                return View("NotFound");
            }
            //List Of Type
            List<Models.LookupField> RecordType = _context.LookupField.Where(a => a.LookupGroup == "RecordType").ToList();
            ViewBag.ListOfRecordType = new SelectList(RecordType, "LookupCode", "LookupDescription");

            //List Of Record No
            List<Models.BalimoonBML.Items> RecordNo = _BalimoonBMLContext.Items.ToList();
            ViewBag.ListOfRecordNo = new SelectList(RecordNo, "ItemNo", "Description");

            //List Of UOM
            List<Models.BalimoonBML.UnitOfMeasures> unitOfMeasures = _BalimoonBMLContext.UnitOfMeasures.ToList();
            ViewBag.ListOfUOM = new SelectList(unitOfMeasures, "Uomdescription", "Uomdescription");

            //List Of  Vendor
            List<Models.BalimoonBML.Vendors> VendorsName = _BalimoonBMLContext.Vendors.ToList();
            ViewBag.ListOfVendors = new SelectList(VendorsName, "VendorNo", "VendorName");
            ViewBag.PRNO = header.HeaderTbl.RequisitionNo;
            ViewBag.ReqID = header.HeaderTbl.RequisitionHeaderId;

            return View(header);
        }

        [HttpPost]
        [Authorize(Roles = "HODBML, GM, Finance, Director, UserBML")]
        public IActionResult DisposeLine(int RequisitionLineId)
        {
            var result = "";
            var getLineId = RequisitionLineId;
            if(getLineId != 0)
            {
                var getDetilLine = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.RequisitionLineId == getLineId);
                var picture = getDetilLine.Picture;
                if(picture != null)
                {
                    //delete
                    string hapus = deletePRImages.Delete(picture);
                    if(hapus == "Sukses")
                    {
                        _BalimoonBMLContext.PurchaseRequisitionLine.Remove(getDetilLine);
                        _BalimoonBMLContext.SaveChanges();
                        result = "Sukses";
                    }
                    else
                    {
                        _BalimoonBMLContext.PurchaseRequisitionLine.Remove(getDetilLine);
                        _BalimoonBMLContext.SaveChanges();
                        result = "Sukses";
                    }
                }
                else
                {
                    _BalimoonBMLContext.PurchaseRequisitionLine.Remove(getDetilLine);
                    _BalimoonBMLContext.SaveChanges();
                    result = "Sukses";
                }
            }
            return Json(result);
        }

        [HttpPost]
        [Authorize(Roles ="HODBML, GM, Finance, Director, UserBML")]
        public async Task<IActionResult> AddPRonReject(IFormFile file, PurchaseRequestVM model)
        {
            var result = "";
            var Doc2 = model.HeaderTbl.RequisitionNo;

            ViewBag.Nama = _userManager.GetUserName(HttpContext.User);
            string CurrentLoginName = ViewBag.Nama;
            //tangkap inputan user
            var cRecordType = model.LineTbl.RecordType;
            var cRecordNo = model.LineTbl.RecordNo;
            var cQuantity = model.LineTbl.Quantity;
            var cUOM = model.LineTbl.UnitofMeasure;
            var cDesc = model.LineTbl.Description;
            var cUnitCost = model.LineTbl.UnitCost;
            var cVendorNo = model.LineTbl.VendorNo;
            var cRequestnote = model.LineTbl.RequestNotes;

            if(Doc2 != null)
            {
                //Cek Isi Setiap Varabel
                if(cRecordType == null)
                {
                    result = "Record Type Cannot Be Null";
                }
                else if(cRecordNo == null)
                {
                    result = "Description Cannot Be Null";
                }
                else if(cUOM == null)
                {
                    result = "Unit of Measure Cannot Be Null";
                }
                else
                {
                    int seqline = 0;
                    var header = _BalimoonBMLContext.PurchaseRequisitionHeader.FirstOrDefault(a => a.RequisitionNo == Doc2);
                    var line = _BalimoonBMLContext.PurchaseRequisitionLine.FirstOrDefault(a => a.DocumentNo == Doc2);
                    var getdesc = _BalimoonBMLContext.Items.FirstOrDefault(a => a.ItemNo == cRecordNo);
                    var shortcutdimension2 = header.ShortcutDimension2Code;
                    if (line == null)
                    {
                        seqline = 1000;
                    }
                    else
                    {
                        var getMax = _BalimoonBMLContext.PurchaseRequisitionLine.Where(a => a.DocumentNo == Doc2).Max(a => a.SeqLineNo);
                        seqline = getMax + 1000;
                    }
                   
                    if(cVendorNo == null)
                    {
                        cVendorNo = "";
                    }
                    if(cRequestnote == null)
                    {
                        cRequestnote = "";
                    }
                    if(file == null)
                    {
                        var insert = new PurchaseRequisitionLine
                        {
                            RequisitionheaderId = header.RequisitionHeaderId,
                            DocumentNo = Doc2,
                            SeqLineNo = seqline,
                            RecordType = cRecordType,
                            RecordNo = cRecordNo,
                            Description = cDesc,
                            Description2 = "",
                            Quantity = cQuantity,
                            UnitofMeasure = cUOM,
                            VendorNo = cVendorNo,
                            DirectUnitCost = cUnitCost,
                            VatbusPostingGroup = "",
                            VatprodPostingGroup = getdesc.VatprodPostingGroup,
                            InventoryPostingGroup = getdesc.InventoryPostingGroup,
                            DueDate = header.DueDate,
                            RequesterId = CurrentLoginName,
                            Confirmed = 0,
                            ShortcutDimension1Code = header.ShortcutDimension1Code,
                            ShortcutDimension2Code = header.ShortcutDimension2Code,
                            LocationCode = header.LocationCode,
                            RecurringMethod = 0,
                            ExpirationDate = header.ExpirationDate,
                            RecurringFrequency = "",
                            OrderDate = header.OrderDate,
                            VendorItemNo = cVendorNo,
                            SalesOrderNo = "",
                            SalesOrderLineNo = 0,
                            SelltoCustomerNo = "",
                            ShiptoCode = "",
                            OrderAddressCode = "",
                            CurrencyCode = "",
                            CurrencyFactor = 1,
                            ProdOrderNo = "",
                            VariantCode = "",
                            BinCode = "",
                            QtyperUnitofMeasure = 1,
                            UnitofMeasureCode = cUOM,
                            QuantityBase = cQuantity,
                            DemandType = 0,
                            DemandSubtype = 0,
                            DemandOrderNo = "",
                            DemandLineNo = 0,
                            DemandRefNo = 0,
                            Status = 0,
                            DemandQuantity = 0,
                            DemandQuantityBase = 0,
                            NeededQuantity = 0,
                            NeededQuantityBase = 0,
                            Reserve = 0,
                            QtyperUomdemand = 0,
                            UnitOfMeasureCodeDemand = "",
                            SupplyFrom = cVendorNo,
                            OriginalItemNo = "",
                            OriginalVariantCode = "",
                            Level = 0,
                            DemandQtyAvailable = 0,
                            UserId = "",
                            ItemCategoryCode = getdesc.ItemCategoryCode,
                            Nonstock = 0,
                            PurchasingCode = "",
                            ProductGroupCode = getdesc.ProductGroupCode,
                            TransferfromCode = "",
                            LineDiscountPercent = 0,
                            OrderPromisingSubLineNo = 0,
                            RoutingNo = "",
                            OperationNo = "",
                            WorkCenterNo = "",
                            ProdOrderLineNo = 0,
                            Mpsorder = 0,
                            PlanningFlexibility = 0,
                            RoutingReferenceNo = 0,
                            GenProdPostingGroup = getdesc.GenProdPostingGroup,
                            GenBusinessPostingGroup = "",
                            LowLevelCode = 0,
                            ProductionBomversionCode = "",
                            RoutingVersionCode = "",
                            RoutingType = 0,
                            OriginalQuantity = cQuantity,
                            FinishedQuantity = 0,
                            RemainingQuantity = cQuantity,
                            ScrapPercent = 0,
                            ProductionBomno = "",
                            IndirectCostPercent = 0,
                            OverheadRate = 0,
                            UnitCost = cUnitCost,
                            CostAmount = cQuantity * cUnitCost,
                            ReplenishmentSystem = 0,
                            RefOrderNo = "",
                            RefOrderType = 0,
                            RefOrderStatus = 0,
                            RefLineNo = 0,
                            NoSeries = "",
                            FinishedQtyBase = 0,
                            QuantityPo = 0,
                            RemainingQtyBase = 0,
                            RelatedtoPlanningLine = 0,
                            PlanningLevel = 0,
                            PlanningLineOrigin = 0,
                            ActionMessage = 0,
                            AcceptActionMessage = 0,
                            NetQuantityBase = 0,
                            OrderPromisingId = "",
                            OrderPromisingLineId = 0,
                            OrderPromisingLineNo = 0,
                            Priority = header.Priority,
                            RequestNotes = cRequestnote,
                            RowStatus = 0,
                            CreatedBy = header.CreatedBy,
                            CreatedTime = header.CreatedTime,
                            LastModifiedBy = CurrentLoginName,
                            LastModifiedTime = DateTime.Now,
                        };
                        _BalimoonBMLContext.PurchaseRequisitionLine.Add(insert);
                        _BalimoonBMLContext.SaveChanges();

                        //Update Modified Time dan Modified By
                        header.LastModifiedBy = CurrentLoginName;
                        header.LastModifiedTime = DateTime.Now;
                        _BalimoonBMLContext.PurchaseRequisitionHeader.Update(header);
                        _BalimoonBMLContext.SaveChanges();

                        result = "Sukses";
                    }
                    else
                    {
                        string uploadImage = await prImages.ImagesUpload(file);
                        if (uploadImage == "")
                        {
                            var insert = new PurchaseRequisitionLine
                            {
                                RequisitionheaderId = header.RequisitionHeaderId,
                                DocumentNo = Doc2,
                                SeqLineNo = seqline,
                                RecordType = cRecordType,
                                RecordNo = cRecordNo,
                                Description = cDesc,
                                Description2 = "",
                                Quantity = cQuantity,
                                UnitofMeasure = cUOM,
                                VendorNo = cVendorNo,
                                DirectUnitCost = cUnitCost,
                                VatbusPostingGroup = "",
                                VatprodPostingGroup = getdesc.VatprodPostingGroup,
                                InventoryPostingGroup = getdesc.InventoryPostingGroup,
                                DueDate = header.DueDate,
                                RequesterId = CurrentLoginName,
                                Confirmed = 0,
                                ShortcutDimension1Code = header.ShortcutDimension1Code,
                                ShortcutDimension2Code = header.ShortcutDimension2Code,
                                LocationCode = header.LocationCode,
                                RecurringMethod = 0,
                                ExpirationDate = header.ExpirationDate,
                                RecurringFrequency = "",
                                OrderDate = header.OrderDate,
                                VendorItemNo = cVendorNo,
                                SalesOrderNo = "",
                                SalesOrderLineNo = 0,
                                SelltoCustomerNo = "",
                                ShiptoCode = "",
                                OrderAddressCode = "",
                                CurrencyCode = "",
                                CurrencyFactor = 1,
                                ProdOrderNo = "",
                                VariantCode = "",
                                BinCode = "",
                                QtyperUnitofMeasure = 1,
                                UnitofMeasureCode = cUOM,
                                QuantityBase = cQuantity,
                                DemandType = 0,
                                DemandSubtype = 0,
                                DemandOrderNo = "",
                                DemandLineNo = 0,
                                DemandRefNo = 0,
                                Status = 0,
                                DemandQuantity = 0,
                                DemandQuantityBase = 0,
                                NeededQuantity = 0,
                                NeededQuantityBase = 0,
                                Reserve = 0,
                                QtyperUomdemand = 0,
                                UnitOfMeasureCodeDemand = "",
                                SupplyFrom = cVendorNo,
                                OriginalItemNo = "",
                                OriginalVariantCode = "",
                                Level = 0,
                                DemandQtyAvailable = 0,
                                UserId = "",
                                ItemCategoryCode = getdesc.ItemCategoryCode,
                                Nonstock = 0,
                                PurchasingCode = "",
                                ProductGroupCode = getdesc.ProductGroupCode,
                                TransferfromCode = "",
                                LineDiscountPercent = 0,
                                OrderPromisingSubLineNo = 0,
                                RoutingNo = "",
                                OperationNo = "",
                                WorkCenterNo = "",
                                ProdOrderLineNo = 0,
                                Mpsorder = 0,
                                PlanningFlexibility = 0,
                                RoutingReferenceNo = 0,
                                GenProdPostingGroup = getdesc.GenProdPostingGroup,
                                GenBusinessPostingGroup = "",
                                LowLevelCode = 0,
                                ProductionBomversionCode = "",
                                RoutingVersionCode = "",
                                RoutingType = 0,
                                OriginalQuantity = cQuantity,
                                FinishedQuantity = 0,
                                RemainingQuantity = cQuantity,
                                ScrapPercent = 0,
                                ProductionBomno = "",
                                IndirectCostPercent = 0,
                                OverheadRate = 0,
                                UnitCost = cUnitCost,
                                CostAmount = cQuantity * cUnitCost,
                                ReplenishmentSystem = 0,
                                RefOrderNo = "",
                                RefOrderType = 0,
                                RefOrderStatus = 0,
                                RefLineNo = 0,
                                NoSeries = "",
                                FinishedQtyBase = 0,
                                QuantityPo = 0,
                                RemainingQtyBase = 0,
                                RelatedtoPlanningLine = 0,
                                PlanningLevel = 0,
                                PlanningLineOrigin = 0,
                                ActionMessage = 0,
                                AcceptActionMessage = 0,
                                NetQuantityBase = 0,
                                OrderPromisingId = "",
                                OrderPromisingLineId = 0,
                                OrderPromisingLineNo = 0,
                                Priority = header.Priority,
                                RequestNotes = cRequestnote,
                                RowStatus = 0,
                                CreatedBy = header.CreatedBy,
                                CreatedTime = header.CreatedTime,
                                LastModifiedBy = CurrentLoginName,
                                LastModifiedTime = DateTime.Now,
                            };
                            _BalimoonBMLContext.PurchaseRequisitionLine.Add(insert);
                            _BalimoonBMLContext.SaveChanges();

                            //Update Modified Time dan Modified By
                            header.LastModifiedBy = CurrentLoginName;
                            header.LastModifiedTime = DateTime.Now;
                            _BalimoonBMLContext.PurchaseRequisitionHeader.Update(header);
                            _BalimoonBMLContext.SaveChanges();

                            result = "Sukses";
                        }
                        else if(uploadImage != "File must be either .jpg, .jpeg, .png and Maximum Size is 2MB")
                        {
                            var insert = new PurchaseRequisitionLine
                            {
                                RequisitionheaderId = header.RequisitionHeaderId,
                                DocumentNo = Doc2,
                                SeqLineNo = seqline,
                                RecordType = cRecordType,
                                RecordNo = cRecordNo,
                                Description = cDesc,
                                Description2 = "",
                                Quantity = cQuantity,
                                UnitofMeasure = cUOM,
                                VendorNo = cVendorNo,
                                DirectUnitCost = cUnitCost,
                                VatbusPostingGroup = "",
                                VatprodPostingGroup = getdesc.VatprodPostingGroup,
                                InventoryPostingGroup = getdesc.InventoryPostingGroup,
                                DueDate = header.DueDate,
                                RequesterId = CurrentLoginName,
                                Confirmed = 0,
                                ShortcutDimension1Code = header.ShortcutDimension1Code,
                                ShortcutDimension2Code = header.ShortcutDimension2Code,
                                LocationCode = header.LocationCode,
                                RecurringMethod = 0,
                                ExpirationDate = header.ExpirationDate,
                                RecurringFrequency = "",
                                OrderDate = header.OrderDate,
                                VendorItemNo = cVendorNo,
                                SalesOrderNo = "",
                                SalesOrderLineNo = 0,
                                SelltoCustomerNo = "",
                                ShiptoCode = "",
                                OrderAddressCode = "",
                                CurrencyCode = "",
                                CurrencyFactor = 1,
                                ProdOrderNo = "",
                                VariantCode = "",
                                BinCode = "",
                                QtyperUnitofMeasure = 1,
                                UnitofMeasureCode = cUOM,
                                QuantityBase = cQuantity,
                                DemandType = 0,
                                DemandSubtype = 0,
                                DemandOrderNo = "",
                                DemandLineNo = 0,
                                DemandRefNo = 0,
                                Status = 0,
                                DemandQuantity = 0,
                                DemandQuantityBase = 0,
                                NeededQuantity = 0,
                                NeededQuantityBase = 0,
                                Reserve = 0,
                                QtyperUomdemand = 0,
                                UnitOfMeasureCodeDemand = "",
                                SupplyFrom = cVendorNo,
                                OriginalItemNo = "",
                                OriginalVariantCode = "",
                                Level = 0,
                                DemandQtyAvailable = 0,
                                UserId = "",
                                ItemCategoryCode = getdesc.ItemCategoryCode,
                                Nonstock = 0,
                                PurchasingCode = "",
                                ProductGroupCode = getdesc.ProductGroupCode,
                                TransferfromCode = "",
                                LineDiscountPercent = 0,
                                OrderPromisingSubLineNo = 0,
                                RoutingNo = "",
                                OperationNo = "",
                                WorkCenterNo = "",
                                ProdOrderLineNo = 0,
                                Mpsorder = 0,
                                PlanningFlexibility = 0,
                                RoutingReferenceNo = 0,
                                GenProdPostingGroup = getdesc.GenProdPostingGroup,
                                GenBusinessPostingGroup = "",
                                LowLevelCode = 0,
                                ProductionBomversionCode = "",
                                RoutingVersionCode = "",
                                RoutingType = 0,
                                OriginalQuantity = cQuantity,
                                FinishedQuantity = 0,
                                RemainingQuantity = cQuantity,
                                ScrapPercent = 0,
                                ProductionBomno = "",
                                IndirectCostPercent = 0,
                                OverheadRate = 0,
                                UnitCost = cUnitCost,
                                CostAmount = cQuantity * cUnitCost,
                                ReplenishmentSystem = 0,
                                RefOrderNo = "",
                                RefOrderType = 0,
                                RefOrderStatus = 0,
                                RefLineNo = 0,
                                NoSeries = "",
                                FinishedQtyBase = 0,
                                QuantityPo = 0,
                                RemainingQtyBase = 0,
                                RelatedtoPlanningLine = 0,
                                PlanningLevel = 0,
                                PlanningLineOrigin = 0,
                                ActionMessage = 0,
                                AcceptActionMessage = 0,
                                NetQuantityBase = 0,
                                OrderPromisingId = "",
                                OrderPromisingLineId = 0,
                                OrderPromisingLineNo = 0,
                                Priority = header.Priority,
                                RequestNotes = cRequestnote,
                                RowStatus = 0,
                                CreatedBy = header.CreatedBy,
                                CreatedTime = header.CreatedTime,
                                LastModifiedBy = CurrentLoginName,
                                LastModifiedTime = DateTime.Now,
                                Picture = uploadImage,
                            };
                            _BalimoonBMLContext.PurchaseRequisitionLine.Add(insert);
                            _BalimoonBMLContext.SaveChanges();

                            //Update Modified Time dan Modified By
                            header.LastModifiedBy = CurrentLoginName;
                            header.LastModifiedTime = DateTime.Now;
                            _BalimoonBMLContext.PurchaseRequisitionHeader.Update(header);
                            _BalimoonBMLContext.SaveChanges();

                            result = "Sukses";
                        }
                        else
                        {
                            result = "File must be either .jpg, .jpeg, .png and Maximum Size is 1.5 MB";
                        }

                    }
                    
                }
            }
            return Json(result);
        }
        
        //Untuk Form  DetilPRList
        public IActionResult DetilPRListView(int RequisitionHeaderId)
        {
            var getReqId = RequisitionHeaderId;
            var PRLineHead = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join line in _BalimoonBMLContext.PurchaseRequisitionLine on head.RequisitionHeaderId equals line.RequisitionheaderId
                              where head.RequisitionHeaderId == getReqId
                              select new PurchaseRequestVM
                              {
                                  HeaderTbl = head,
                                  LineTbl = line
                              }).FirstOrDefault();
            if(PRLineHead== null)
            {
                return View("NotFound");
            }
            else
            {
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                return View(PRLineHead);
            }
           
        }

        //Untuk Form PR Open Details
        public IActionResult DetilPROpenView(int RequisitionHeaderId)
        {
            var getReqId = RequisitionHeaderId;
            var PRLineHead = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join line in _BalimoonBMLContext.PurchaseRequisitionLine on head.RequisitionHeaderId equals line.RequisitionheaderId
                              where head.RequisitionHeaderId == getReqId && head.Status == 0
                              select new PurchaseRequestVM
                              {
                                  HeaderTbl = head,
                                  LineTbl = line
                              }).FirstOrDefault();
            if (PRLineHead == null)
            {
                return View("NotFound");
            }
            else
            {
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                return View(PRLineHead);
            }
           
        }

        //Untuk Form PR Release Details
        public IActionResult DetilPRReleaseView(int RequisitionHeaderId)
        {
            var getReqId = RequisitionHeaderId;
            var PRLineHead = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join line in _BalimoonBMLContext.PurchaseRequisitionLine on head.RequisitionHeaderId equals line.RequisitionheaderId
                              where head.RequisitionHeaderId == getReqId && head.Status == 1
                              select new PurchaseRequestVM
                              {
                                  HeaderTbl = head,
                                  LineTbl = line
                              }).FirstOrDefault();
            if(PRLineHead== null) {
                return View("NotFound");
            }
            else { 
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                return View(PRLineHead);
            }
        }

        //Untuk Form PR Pending Approval
        public IActionResult DetilPRPAView(int RequisitionHeaderId)
        {
            var getReqId = RequisitionHeaderId;
            var PRLineHead = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join line in _BalimoonBMLContext.PurchaseRequisitionLine on head.RequisitionHeaderId equals line.RequisitionheaderId
                              where head.RequisitionHeaderId == getReqId && head.Status == 2
                              select new PurchaseRequestVM
                              {
                                  HeaderTbl = head,
                                  LineTbl = line
                              }).FirstOrDefault();
            if(PRLineHead == null)
            {
                return View("NotFound");
            }
            else
            {
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                return View(PRLineHead);
            }
            
        }

        //Untuk Form PR Pending PrePayment
        public IActionResult DetilPRPPPView(int RequisitionHeaderId)
        {
            var getReqId = RequisitionHeaderId;
            var PRLineHead = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join line in _BalimoonBMLContext.PurchaseRequisitionLine on head.RequisitionHeaderId equals line.RequisitionheaderId
                              where head.RequisitionHeaderId == getReqId && head.Status == 3
                              select new PurchaseRequestVM
                              {
                                  HeaderTbl = head,
                                  LineTbl = line
                              }).FirstOrDefault();
            if (PRLineHead == null)
            {
                return View("NotFound");
            }
            else
            {
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                return View(PRLineHead);
            }
           
        }

        //Untuk Form PR Archived
        public IActionResult DetilPRArchived(int RequisitionHeaderId)
        {
            var getReqId = RequisitionHeaderId;
            
            var PRLineHead = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join line in _BalimoonBMLContext.PurchaseRequisitionLine on head.RequisitionHeaderId equals line.RequisitionheaderId
                              where head.RequisitionHeaderId == getReqId && head.Status == 4
                              select new PurchaseRequestVM
                              {
                                  HeaderTbl = head,
                                  LineTbl = line
                              }).FirstOrDefault();
            if (PRLineHead == null) {
                return View("NotFound");
            }
            else
            {
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                return View(PRLineHead);
            }
           
        }

        //Untuk Form PR Closed
        public IActionResult DetilPRClosed(int RequisitionHeaderId)
        {
            var getReqId = RequisitionHeaderId;
            var PRLineHead = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join line in _BalimoonBMLContext.PurchaseRequisitionLine on head.RequisitionHeaderId equals line.RequisitionheaderId
                              where head.RequisitionHeaderId == getReqId && head.Status == 5
                              select new PurchaseRequestVM
                              {
                                  HeaderTbl = head,
                                  LineTbl = line
                              }).FirstOrDefault();
            if(PRLineHead== null)
            {
                return View("NotFound");
            }
            else
            {
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                return View(PRLineHead);
            }
            
        }

        //Untuk Form PR Closed
        public IActionResult DetilPRPostedView(int RequisitionHeaderId)
        {
            var getReqId = RequisitionHeaderId;
            var PRLineHead = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join line in _BalimoonBMLContext.PurchaseRequisitionLine on head.RequisitionHeaderId equals line.RequisitionheaderId
                              where head.RequisitionHeaderId == getReqId && head.Status == 6
                              select new PurchaseRequestVM
                              {
                                  HeaderTbl = head,
                                  LineTbl = line
                              }).FirstOrDefault();
            if(PRLineHead == null)
            {
                return View("NotFound");
            }
            else
            {
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                return View(PRLineHead);
            }
           
        }

        //Untuk Form PR Rejected
        public IActionResult DetilPRRejectedView(int RequisitionHeaderId)
        {
            var getReqId = RequisitionHeaderId;
            var PRLineHead = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join line in _BalimoonBMLContext.PurchaseRequisitionLine on head.RequisitionHeaderId equals line.RequisitionheaderId
                              where head.RequisitionHeaderId == getReqId && head.Status == 7
                              select new PurchaseRequestVM
                              {
                                  HeaderTbl = head,
                                  LineTbl = line
                              }).FirstOrDefault();
            if (PRLineHead == null)
            {
                return View("NotFound");
            }
            else
            {
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                return View(PRLineHead);
            }

        }

        //Untuk Form PR Cancelled
        public IActionResult DetilPRCnclView(int RequisitionHeaderId)
        {
            var getReqId = RequisitionHeaderId;
            var PRLineHead = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join line in _BalimoonBMLContext.PurchaseRequisitionLine on head.RequisitionHeaderId equals line.RequisitionheaderId
                              where head.RequisitionHeaderId == getReqId && head.Status == 8
                              select new PurchaseRequestVM
                              {
                                  HeaderTbl = head,
                                  LineTbl = line
                              }).FirstOrDefault();
            if(PRLineHead == null)
            {
                return View("NotFound");
            }
            else { 
            //List Of Status
            List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

            return View(PRLineHead);
            }
        }

        //Untuk Pidah Form Dari MyPROpen ke MyPROpenDetails
        public IActionResult MyPROpenDetails(string RequisitionNo)
        {
            var getReqID = RequisitionNo;
            if(getReqID== null)
            {
                return View("NotFound");
            }
            var Header = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where header.RequisitionNo == getReqID && header.Status == 0
                          select new PurchaseRequestVM
                          {
                              HeaderTbl = header,
                          }).FirstOrDefault();
            if (Header == null)
            {
                return View("NotFound");
            }

            //List Of Status
            List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

            ViewBag.PRNO = Header.HeaderTbl.RequisitionNo;
            ViewBag.ReqID = Header.HeaderTbl.RequisitionHeaderId;

            return View(Header);
        }

        //Untuk Pindah Form Dari MyCancelledPR ke MyCancelledPRDetails
        public IActionResult MyCancelledPRDetails(string RequisitionNo)
        {
            var getReqID = RequisitionNo;
            if (getReqID== null)
            {
                return View("NotFound");
            }
            var Header = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where header.RequisitionNo == getReqID && header.Status == 8
                          select new PurchaseRequestVM
                          {
                              HeaderTbl = header,
                          }).FirstOrDefault();
            if(Header == null)
            {
                return View("NotFound");
            }
            //List Of Status
            List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

            ViewBag.PRNO = Header.HeaderTbl.RequisitionNo;
            ViewBag.ReqID = Header.HeaderTbl.RequisitionHeaderId;


            return View(Header);
        }

        //Untuk Pindah Form Dari MyReleasePR ke MyReleasePRDetails
        public IActionResult MyReleasePRDetail(string RequisitionNo)
        {
            var getPrNo = RequisitionNo;

            if(getPrNo == null)
            {
                return View("NotFound");
            }
            var Header = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where head.RequisitionNo == getPrNo && head.Status == 1
                          select new PurchaseRequestVM
                          {
                              HeaderTbl = head,
                          }).FirstOrDefault();
            if (Header== null)
            {
                return View("NotFound");
            }

            //List Of Status
            List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

            ViewBag.PRNO = Header.HeaderTbl.RequisitionNo;
            ViewBag.ReqID = Header.HeaderTbl.RequisitionHeaderId;

            return View(Header);
        }

        //Untuk Pindah Form Dari MyPendingAprPR ke MyPendingAprPRDetails
        public IActionResult MyPendingAprPRDetail(string RequisitionNo)
        {
            var getPrNo = RequisitionNo;
            if(getPrNo == null)
            {
                return View("NotFound");
            }
            var Header = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where head.RequisitionNo == getPrNo && head.Status == 2
                          select new PurchaseRequestVM
                          {
                              HeaderTbl = head
                          }).FirstOrDefault();
            if (Header == null)
            {
                return View("NotFound");
            }
            //List Of Status
            List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

            ViewBag.PRNO = Header.HeaderTbl.RequisitionNo;
            ViewBag.ReqID = Header.HeaderTbl.RequisitionHeaderId;

            return View(Header);
        }

        //Untuk Pindah Form Dari MyPostedPR ke MyPostedPRDetails
        public IActionResult MyPostedPRDetails(string RequisitionNo)
        {
            var getPrNo = RequisitionNo;
            if (getPrNo == null)
            {
                return View("NotFound");
            }
            var Header = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                          where head.RequisitionNo == getPrNo && head.Status == 6
                          select new PurchaseRequestVM
                          {
                              HeaderTbl = head
                          }).FirstOrDefault();
            if(Header == null)
            {
                return View("NotFound");
            }
            //List Of Status
            List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

            ViewBag.PRNO = Header.HeaderTbl.RequisitionNo;
            ViewBag.ReqID = Header.HeaderTbl.RequisitionHeaderId;

            return View(Header);
        }

        //Untuk Pindah Form Dari MyClosedPR ke MyClosedPRDetails
        public IActionResult MyClosedPRDetails(string RequisitionNo)
        {
            var getPrNo = RequisitionNo;
            if (getPrNo == null)
            {
                return View("NotFound");
            }
            var Header = (from head in _BalimoonBMLContext.PurchaseRequisitionHeader
                         where head.RequisitionNo == getPrNo && head.Status == 5
                         select new PurchaseRequestVM
                         {
                             HeaderTbl = head
                         }).FirstOrDefault();
            if (Header == null)
            {
                return View("NotFound");
            }

            //List Of Status
            List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
            ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

            //List Of Priority
            List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
            ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

            ViewBag.PRNO = Header.HeaderTbl.RequisitionNo;
            ViewBag.ReqID = Header.HeaderTbl.RequisitionHeaderId;

            return View(Header);
        }

        //Untuk MyDetil PR Yang Baru
        [HttpPost]
        public IActionResult GetMyPRDetails([FromBody]DTParameters dtParameters, string RequisitionNo)
        {
            var getPRNO = RequisitionNo;
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
                orderCriteria = "SeqLineNo";
                orderDescendingDirection = true;
            }
            var result = (from linetbl in _BalimoonBMLContext.PurchaseRequisitionLine
                          where linetbl.DocumentNo == getPRNO
                          select new
                          {
                            RequisitionLineId = linetbl.RequisitionLineId,
                            SeqLineNo = linetbl.SeqLineNo,
                            Description = linetbl.Description,
                            CurrencyCode = linetbl.CurrencyCode,
                            Quantity = linetbl.Quantity,
                            UnitCost = linetbl.UnitCost,
                            CostAmount = linetbl.CostAmount
                           }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.Description != null && r.Description.ToUpper().Contains(searchBy.ToUpper())).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
           var totalcount = (from linetbl in _BalimoonBMLContext.PurchaseRequisitionLine
                             where linetbl.DocumentNo == getPRNO
                             select new
                             {
                                 RequisitionLineId = linetbl.RequisitionLineId,
                                 
                             }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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

        //Digunakan Semua Form PR List Untuk Detil Modal dan Tabel
        [HttpPost]
        public IActionResult TabelPRList([FromBody]DTParameters dtParameters, int PRID)
        {
            var getPRID = PRID;
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
                orderCriteria = "SeqLineNo";
                orderDescendingDirection = true;
            }
            var recordtype = _context.LookupField.Where(a => a.LookupGroup == "RecordType").ToList();
            var result = (from Header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          join Line in _BalimoonBMLContext.PurchaseRequisitionLine on Header.RequisitionHeaderId equals Line.RequisitionheaderId
                          join Item in _BalimoonBMLContext.Items on Line.RecordNo equals Item.ItemNo
                          join vendor in _BalimoonBMLContext.Vendors on Line.VendorNo equals vendor.VendorNo into VendorDetails
                          from vendor in VendorDetails.DefaultIfEmpty() 
                          join record in recordtype on Line.RecordType.ToString() equals record.LookupCode
                          where Header.RequisitionHeaderId == getPRID
                          select new
                          {
                              LineID = Line.RequisitionLineId,
                              SeqLineNo = Line.SeqLineNo,
                              recordtype = record.LookupDescription,
                              itemname = Item.Description,
                              description = Line.Description,
                              qty = Line.Quantity,
                              UoM = Line.UnitofMeasure,
                              vendor = vendor.VendorName,
                              itemcat = Line.ItemCategoryCode,
                              UnitCost = Line.UnitCost,
                              Amount = Line.CostAmount,
                              ReqNotes = Line.RequestNotes,
                              Currency = Line.CurrencyCode
                          }).ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.itemname != null && r.itemname.ToUpper().Contains(searchBy.ToUpper()) ||
                      r.description != null && r.description.ToUpper().Contains(searchBy.ToUpper()) ||
                      r.UoM != null && r.UoM.ToUpper().Contains(searchBy.ToUpper()) ||
                      r.itemcat != null && r.itemcat.ToUpper().Contains(searchBy.ToUpper()) ||
                      r.Currency != null && r.Currency.ToUpper().Contains(searchBy.ToUpper())
                      ).ToList();
            }
            result = orderDescendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();
            var totalcount = (from Header in _BalimoonBMLContext.PurchaseRequisitionHeader
                              join Line in _BalimoonBMLContext.PurchaseRequisitionLine on Header.RequisitionHeaderId equals Line.RequisitionheaderId
                              join Item in _BalimoonBMLContext.Items on Line.RecordNo equals Item.ItemNo
                              join record in recordtype on Line.RecordType.ToString() equals record.LookupCode
                              where Header.RequisitionHeaderId == getPRID
                              select new
                              {
                                  LineID = Line.RequisitionLineId,
                              }).ToList();
            var filteredResultsCount = result.Count();
            var totalResultsCount = totalcount.Count();
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
        public JsonResult ModalDetailPR(int LineID)
        {
            var result = string.Empty;
            var join = (from line in _BalimoonBMLContext.PurchaseRequisitionLine
                        join item in _BalimoonBMLContext.Items on line.RecordNo equals item.ItemNo
                        join record in _context.LookupField.Where(a => a.LookupGroup == "RecordType").ToList() on line.RecordType.ToString() equals record.LookupCode
                        join vendor in _BalimoonBMLContext.Vendors on line.VendorNo equals vendor.VendorNo
                        into vendordetails
                        from vendor in vendordetails.DefaultIfEmpty()
                        where line.RequisitionLineId == LineID
                        select new
                        {
                            LineID = line.RequisitionLineId,
                            SeqLineNo = line.SeqLineNo,
                            RecordType = record.LookupDescription,
                            PRNO = line.DocumentNo,
                            recordNo = item.Description,
                            Description = line.Description,
                            qty = line.Quantity,
                            UoM = line.UnitofMeasure,
                            Vendor = vendor.VendorName,
                            CatCode = line.ItemCategoryCode,
                            Cost = line.UnitCost,
                            Amount = line.CostAmount,
                            picture = line.Picture
                        }).FirstOrDefault();
            result = JsonConvert.SerializeObject(join, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(result);
        }
        //Get Dynamic UoM
        public JsonResult GetDynamicUOM(string id)
        {
            var result = string.Empty;
            var join = (from item in _BalimoonBMLContext.Items
                       join unit in _BalimoonBMLContext.UnitOfMeasures on item.BaseUnitofMeasure equals unit.Uomcode
                        where item.ItemNo == id
                        select new
                        {
                            UoM = unit.Uomdescription,
                            UnitCost = item.LastDirectCost
                        }).FirstOrDefault();
            result = JsonConvert.SerializeObject(join, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(result);
        }

        //Pindah Form Untuk Approvve
        public IActionResult InfoPRApprove(string RequisitionNo)
        {
            var getPRNO = RequisitionNo;
            ViewBag.UserId = _userManager.GetUserId(HttpContext.User);
            string UserId = ViewBag.UserId;
            ViewBag.UserName = _userManager.GetUserName(HttpContext.User);
            string UserName = ViewBag.UserName;
            var myRole = 0;
            var UserLoginNow = _context.AspNetUserRoles.FirstOrDefault(a => a.UserId == UserId);
            if (UserLoginNow.RoleId == "00040")
            {
                myRole = 6;
            }
            else
            {
                myRole = 2;
            }
            if (getPRNO == null)
            {
                return View("NotFound");
            }
            var result = (from header in _BalimoonBMLContext.PurchaseRequisitionHeader
                          join approvalE in _BalimoonBMLContext.ApprovalEntry
                          on header.RequisitionNo equals approvalE.DocumentNo
                          where header.Status == myRole && approvalE.NextApproval == UserName && approvalE.SequenceNo == _BalimoonBMLContext.ApprovalEntry.Where(c => c.DocumentNo == getPRNO).Max(d => d.SequenceNo) && header.RequisitionNo == getPRNO
                          select new PurchaseRequestVM
                          {
                              HeaderTbl = header,
                              ApprovalEntry = approvalE,

                          }).FirstOrDefault();
            if(result == null)
            {
                return View("NotFound");
            }
            else
            {
                //List Of Status
                List<Models.LookupField> Status = _context.LookupField.Where(a => a.LookupGroup == "PurchaseStatus").ToList();
                ViewBag.ListOfStatus = new SelectList(Status, "LookupCode", "LookupDescription");

                //List Of Priority
                List<Models.LookupField> Prioritas = _context.LookupField.Where(a => a.LookupGroup == "Priority").ToList();
                ViewBag.ListOf123 = new SelectList(Prioritas, "LookupCode", "LookupDescription");

                ViewBag.PRNO = result.HeaderTbl.RequisitionNo;
                return View(result);
            }           
        }

        public IActionResult RecordList()
        {
            return View();
        }
    }
}