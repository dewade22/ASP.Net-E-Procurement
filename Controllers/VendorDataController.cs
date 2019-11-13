using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Balimoon_E_Procurement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace Balimoon_E_Procurement.Controllers
{
    public class VendorDataController : Controller
    {
        private readonly MainSystemContext _context;
        private readonly UserManager<IdentityUser> _usermanager;
        private readonly IHostingEnvironment _hostingEnvironment;
        PDFUpload pdfUpload;

       public VendorDataController(
           IHostingEnvironment hostingEnvironment,
           MainSystemContext context,
           UserManager<IdentityUser> userManager)
        {
            pdfUpload = new PDFUpload();
            _context = context;
            _usermanager = userManager;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            ViewBag.userId = _usermanager.GetUserId(HttpContext.User);
            return View();
        }

        [HttpGet]
        public JsonResult ViewinModal(string id)
        {
            string value = string.Empty;
            var getVendor = _context.AspNetVendor.FirstOrDefault(a => a.UserId == id);

            value = JsonConvert.SerializeObject(getVendor, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value);
        }

        [HttpPost]
        public async Task<ViewResult> PDFUpload(IFormFile file, AspNetVendor aspNetVendor)
        {
           
            ViewBag.userId = _usermanager.GetUserId(HttpContext.User);
            string uid = ViewBag.userId;
            try
            {
                string uploadSuccess = await pdfUpload.UploadPDF(file);
                if(uploadSuccess == "")
                {
                    
                    var CheckUser = _context.AspNetVendor.FirstOrDefault(a => a.UserId == uid);

                    if (CheckUser == null)
                    {
                       const string msg = "For The First Time, You Must Upload Yor Comapany Data with Pdf, or Docx Extension";
                       throw new Exception(msg);
                    }
                    else
                    {
                        var CheckId = _context.AspNetVendor.FirstOrDefault(a => a.UserId == uid);
                        if (CheckId != null)
                        {
                            //CheckId.UserId = aspNetVendor.UserId;
                            CheckId.NpwpNo = aspNetVendor.NpwpNo;
                            CheckId.CompanyName = aspNetVendor.CompanyName;
                            CheckId.Address = aspNetVendor.Address;
                            CheckId.SiupNo = aspNetVendor.SiupNo;
                            CheckId.SuplierType = "Null";
                            CheckId.ContactName = aspNetVendor.ContactName;
                            CheckId.Contact = aspNetVendor.Contact;
                            CheckId.ContactEmail = aspNetVendor.ContactEmail;
                            CheckId.InvoiceName = aspNetVendor.InvoiceName;
                            CheckId.InvoiceEmail = aspNetVendor.InvoiceEmail;
                            CheckId.InvoiceContact = aspNetVendor.InvoiceContact;
                            CheckId.swiftcode = aspNetVendor.swiftcode;
                            //CheckId.FileLocation = uploadSuccess;

                            _context.AspNetVendor.Update(CheckId);

                            await _context.SaveChangesAsync();
                        }
                    }
                }            
                else if (uploadSuccess != "File must be either .pdf, .docx, .doc, .zip, or .rar")
                {
                    ViewBag.Message = "File Uploaded Successfully";
                    var data = new AspNetVendor
                    {
                        UserId = uid,
                        CompanyName = aspNetVendor.CompanyName,
                        Address = aspNetVendor.Address,
                        NpwpNo = aspNetVendor.NpwpNo,
                        SiupNo = aspNetVendor.SiupNo,
                        SuplierType = "Null",
                        ContactName = aspNetVendor.ContactName,
                        Contact = aspNetVendor.Contact,
                        ContactEmail = aspNetVendor.ContactEmail,
                        InvoiceName = aspNetVendor.InvoiceName,
                        InvoiceContact = aspNetVendor.InvoiceContact,
                        InvoiceEmail = aspNetVendor.InvoiceEmail,
                        swiftcode = aspNetVendor.swiftcode,
                        FileLocation = uploadSuccess
                        
                    };

                    var CheckUser = _context.AspNetVendor.FirstOrDefault(a => a.UserId == uid);
                    if (CheckUser == null)
                    {
                        if (ModelState.IsValid)
                        {
                            _context.AspNetVendor.Add(data);
                            await _context.SaveChangesAsync();
                        }
                    }
                    else
                    {
                        var CheckId = _context.AspNetVendor.FirstOrDefault(a => a.UserId == uid);
                        if (CheckId != null)
                        {
                            //CheckId.UserId = aspNetVendor.UserId;
                            CheckId.NpwpNo = aspNetVendor.NpwpNo;
                            CheckId.CompanyName = aspNetVendor.CompanyName;
                            CheckId.Address = aspNetVendor.Address;
                            CheckId.SiupNo = aspNetVendor.SiupNo;
                            CheckId.SuplierType = "Null";
                            CheckId.ContactName = aspNetVendor.ContactName;
                            CheckId.Contact = aspNetVendor.Contact;
                            CheckId.ContactEmail = aspNetVendor.ContactEmail;
                            CheckId.InvoiceName = aspNetVendor.InvoiceName;
                            CheckId.InvoiceEmail = aspNetVendor.InvoiceEmail;
                            CheckId.InvoiceContact = aspNetVendor.InvoiceContact;
                            CheckId.FileLocation = uploadSuccess;
                            CheckId.swiftcode = aspNetVendor.swiftcode;

                            _context.AspNetVendor.Update(CheckId);
                        
                            await _context.SaveChangesAsync();
                        }
                    }
                }
                return View("Index");
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel()
                { ErrorMessage = ex.Message });
            }
            
        }
        [HttpGet]
        public FileContentResult Download(string id)
        {
            AspNetVendor aspNetVendor = _context.AspNetVendor.SingleOrDefault(a => a.UserId == id);
            var filename = aspNetVendor.FileLocation;
            string tempFilePath = System.IO.Path.Combine(_hostingEnvironment.WebRootPath, "VendorData", filename);
            byte[] filebytes = System.IO.File.ReadAllBytes(tempFilePath);
            return File(filebytes, "application/force-download", "Data Vendor " + aspNetVendor.CompanyName+".pdf");
        }
    }
}