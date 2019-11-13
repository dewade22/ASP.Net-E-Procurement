using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Balimoon_E_Procurement.Models;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using Balimoon_E_Procurement.Models.DatatableModels;
using Balimoon_E_Procurement.Services;
using Balimoon_E_Procurement.Models.BalimoonBML;
using Microsoft.AspNetCore.Identity;

namespace Balimoon_E_Procurement.Controllers
{
    public class UsersController : Controller
    {
        private readonly MainSystemContext _context;
        private readonly BalimoonBMLContext _balimoonBMLContext;
        private readonly UserManager<IdentityUser> _userManager;

        public UsersController(MainSystemContext context,
            BalimoonBMLContext balimoonBMLContext,
            UserManager<IdentityUser> userManager)
        {
            _balimoonBMLContext = balimoonBMLContext;
            _context = context;
            _userManager = userManager;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            List<AspNetRoles> aspNetRoles = _context.AspNetRoles.ToList();
            ViewBag.ListOfRoles = new SelectList(aspNetRoles, "Id", "Name");
            return View();
        }

        //get user with jason
        [HttpPost]
        [Authorize(Roles="Admin")]
        public async Task<IActionResult> GetUserList([FromBody]DTParameters dtParameters)
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
                orderCriteria = "UserName";
                orderAscendingDirection = true;
            }

            var jointable = from userroles in _context.AspNetUserRoles
                            join user in _context.AspNetUsers on userroles.UserId equals user.Id
                            join roles in _context.AspNetRoles on userroles.RoleId equals roles.Id
                            select new
                            {
                                UId = user.Id,
                                username = user.UserName,
                                Nusername = user.NormalizedUserName,
                                email = user.Email,
                                Nemail = user.NormalizedEmail,
                                emailconf = user.EmailConfirmed,
                                securitystamp = user.SecurityStamp,
                                concurrencystamp = user.ConcurrencyStamp,
                                phone = user.PhoneNumber,
                                phoneconf = user.PhoneNumberConfirmed,
                                twofenable = user.TwoFactorEnabled,
                                lockoutend = user.LockoutEnd,
                                lockoutenable = user.LockoutEnabled,
                                accessfailed = user.AccessFailedCount,
                                Juid = userroles.UserId,
                                Rid = userroles.RoleId,
                                RoleId= roles.Id,
                                rolename = roles.Name,
                                rolenormalized = roles.NormalizedName,
                                roleconcurrency = roles.ConcurrencyStamp
                            };
            var result = jointable.ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.UId != null && r.UId.ToUpper().Contains(searchBy.ToUpper()) ||
                r.username != null && r.username.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Nusername != null && r.Nusername.ToUpper().Contains(searchBy.ToUpper()) ||
                r.email != null && r.email.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Nemail != null && r.Nemail.ToUpper().Contains(searchBy.ToUpper()) ||
                r.phone != null && r.phone.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Juid != null && r.Juid.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Rid != null && r.Rid.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RoleId != null && r.RoleId.ToUpper().Contains(searchBy.ToUpper()) ||
                r.rolename != null && r.rolename.ToUpper().Contains(searchBy.ToUpper()) ||
                r.rolenormalized != null && r.rolenormalized.ToUpper().Contains(searchBy.ToUpper()) ||
                r.roleconcurrency != null && r.roleconcurrency.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            //Dapatkan Jumlah Total Record
            var filteredResultsCount = result.Count();
            var totalResultsCount = await _context.AspNetUserRoles.CountAsync();
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

        //Passing Data Into Modal Index
        [Authorize(Roles = "Admin")]
        public JsonResult GetUserById(string id)
        {
            AspNetUsers aspNetUsers = _context.AspNetUsers.Where(a => a.Id == id).SingleOrDefault();
            var join = (from userroles in _context.AspNetUserRoles
                        join user in _context.AspNetUsers on userroles.UserId equals user.Id
                        join roles in _context.AspNetRoles on userroles.RoleId equals roles.Id
                        where user.Id == aspNetUsers.Id
                        select new
                        {
                            UId = user.Id,
                            username = user.UserName,
                            Nusername = user.NormalizedUserName,
                            email = user.Email,
                            Nemail = user.NormalizedEmail,
                            emailconf = user.EmailConfirmed,
                            password = user.PasswordHash,
                            securitystamp = user.SecurityStamp,
                            concurrencystamp = user.ConcurrencyStamp,
                            phone = user.PhoneNumber,
                            phoneconf = user.PhoneNumberConfirmed,
                            twofenable = user.TwoFactorEnabled,
                            lockoutend = user.LockoutEnd,
                            lockoutenable = user.LockoutEnabled,
                            accessfailed = user.AccessFailedCount,
                            Juid = userroles.UserId,
                            Rid = userroles.RoleId,
                            RoleId = roles.Id,
                            rolename = roles.Name,
                            rolenormalized = roles.NormalizedName,
                            roleconcurrency = roles.ConcurrencyStamp
                        }).FirstOrDefault();                            

            string value = string.Empty;
            value = JsonConvert.SerializeObject(join, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value);
        }

        //Update Data(Phone Number) User
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public JsonResult UpdateUserRecord(UserRoleVM model)
        {
            var result = false;
            try
            {
                if(model.usertbl.PhoneNumber != null)
                {
                    AspNetUsers aspNetUser = _context.AspNetUsers.SingleOrDefault(a => a.Id == model.usertbl.Id);
                    aspNetUser.PhoneNumber = model.usertbl.PhoneNumber;
                    _context.AspNetUsers.Update(aspNetUser);
                    _context.SaveChanges();
                    result = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return Json(result);
        }

        //Get: Users/Waiting
        [Authorize(Roles="Admin")]
        public ActionResult Waiting()
        {
           
            return View();
        }

        //Get: User/Waiting to Data Table
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetUserWaiting([FromBody]DTParameters dtParameters)
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
                orderCriteria = "UserName";
                orderAscendingDirection = true;
            }

            var data = _context.AspNetUsers.Where(a => a.EmailConfirmed == false).Select(a=> new AspNetUsers{
                Id= a.Id,
                UserName = a.UserName,
                NormalizedUserName = a.NormalizedUserName,
                Email = a.Email,
                NormalizedEmail = a.NormalizedEmail,
                EmailConfirmed = a.EmailConfirmed,
                PhoneNumber = a.PhoneNumber,
                AccessFailedCount=a.AccessFailedCount
            });
            var result = data.ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.Id != null && r.Id.ToUpper().Contains(searchBy.ToUpper()) ||
                r.UserName !=null && r.UserName.ToUpper().Contains(searchBy.ToUpper()) ||
                r.NormalizedUserName != null && r.NormalizedUserName.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Email != null && r.Email.ToUpper().Contains(searchBy.ToUpper()) ||
                r.NormalizedEmail != null && r.NormalizedEmail.ToUpper().Contains(searchBy.ToUpper()) ||
                r.PhoneNumber != null && r.PhoneNumber.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            //Dapatkan Jumlah Total Record
            var filteredResultsCount = result.Count();
            var totalResultsCount = await _context.AspNetUsers.Where(a => a.EmailConfirmed == false).CountAsync();
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

        //Get Userrole view
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult Userrole()
        {
            List<AspNetRoles> aspNetRoles = _context.AspNetRoles.Where(a=>a.Id != "00010").ToList();
            ViewBag.ListOfRoles = new SelectList(aspNetRoles, "Id", "Name");
            return View();
        }

        //Get: User/GetUserRoleList
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> GetUserRoleList([FromBody]DTParameters dtParameters)
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
                orderCriteria = "UserName";
                orderAscendingDirection = true;
            }

            var jointable = (from user in _context.AspNetUsers
                            join userrole in _context.AspNetUserRoles on user.Id equals userrole.UserId
                            into Details
                            from defaultVal in Details.DefaultIfEmpty()
                            join roles in _context.AspNetRoles on defaultVal.RoleId equals roles.Id
                            into Details2
                            from defaultval2 in Details2.DefaultIfEmpty()
                            where (user.EmailConfirmed == true) && (defaultval2.Id != "00010") 
                            select new
                            {
                                Id = user.Id,
                                UserName = user.UserName,
                                NormalizedUserName = user.NormalizedUserName,
                                Email = user.Email,
                                NormalizedEmail = user.NormalizedEmail,
                                EmailConfirmed = user.EmailConfirmed,
                                SecurityStamp = user.SecurityStamp,
                                ConcurrencyStamp = user.ConcurrencyStamp,
                                PhoneNumber = user.PhoneNumber,
                                PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                                TwoFactorEnabled = user.TwoFactorEnabled,
                                LockoutEnd = user.LockoutEnd,
                                LockoutEnabled = user.LockoutEnabled,
                                AccessFailedCount = user.AccessFailedCount,
                                Juid = defaultVal.UserId,
                                Rid = defaultVal.RoleId,
                                RoleId = defaultval2.Id,
                                rolename = defaultval2.Name,
                                rolenormalized = defaultval2.NormalizedName,
                                roleconcurrency = defaultval2.ConcurrencyStamp
                            });
            var result = jointable.ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.Id != null && r.Id.ToUpper().Contains(searchBy.ToUpper()) ||
                r.UserName != null && r.UserName.ToUpper().Contains(searchBy.ToUpper()) ||
                r.NormalizedUserName != null && r.NormalizedUserName.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Email != null && r.Email.ToUpper().Contains(searchBy.ToUpper()) ||
                r.NormalizedEmail != null && r.NormalizedEmail.ToUpper().Contains(searchBy.ToUpper()) ||
                r.PhoneNumber != null && r.PhoneNumber.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Juid != null && r.Juid.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Rid != null && r.Rid.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RoleId != null && r.RoleId.ToUpper().Contains(searchBy.ToUpper()) ||
                r.rolename != null && r.rolename.ToUpper().Contains(searchBy.ToUpper()) ||
                r.rolenormalized != null && r.rolenormalized.ToUpper().Contains(searchBy.ToUpper()) ||
                r.roleconcurrency != null && r.roleconcurrency.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            //Dapatkan Jumlah Total Record
            var filteredResultsCount = result.Count();
            var totalResultsCount = await _context.AspNetUsers.CountAsync();

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

        //passing data userrole into modal
        [Authorize(Roles = "Admin")]
        public JsonResult GetUserRoleById(string id)
        {
            string value = string.Empty;
            AspNetUsers aspNetUsers = _context.AspNetUsers.Where(a => a.Id == id).SingleOrDefault();
            AspNetUserRoles aspNetUserRoles = _context.AspNetUserRoles.Where(b => b.UserId == id).SingleOrDefault();
            if(aspNetUserRoles != null) { 
            var join = (from user in _context.AspNetUsers
                            join userrole in _context.AspNetUserRoles on user.Id equals userrole.UserId
                            join roles in _context.AspNetRoles on userrole.RoleId equals roles.Id
                            where user.Id ==aspNetUsers.Id 
                            select new
                            {
                                Id = user.Id,
                                UserName = user.UserName,
                                NormalizedUserName = user.NormalizedUserName,
                                Email = user.Email,
                                NormalizedEmail = user.NormalizedEmail,
                                EmailConfirmed = user.EmailConfirmed,
                                SecurityStamp = user.SecurityStamp,
                                ConcurrencyStamp = user.ConcurrencyStamp,
                                PhoneNumber = user.PhoneNumber,
                                PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                                TwoFactorEnabled = user.TwoFactorEnabled,
                                LockoutEnd = user.LockoutEnd,
                                LockoutEnabled = user.LockoutEnabled,
                                AccessFailedCount = user.AccessFailedCount,
                                Juid = userrole.UserId,
                                Rid = userrole.RoleId,
                                RoleId = roles.Id,
                                rolename = roles.Name,
                                rolenormalized = roles.NormalizedName,
                                roleconcurrency = roles.ConcurrencyStamp
                            }).FirstOrDefault();

                value = JsonConvert.SerializeObject(join, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });

            }
            else
            {
                var rolesview = _context.AspNetUsers.Where(a => a.Id==id).Select(a => new AspNetUsers
                {
                    Id = a.Id,
                    UserName = a.UserName,
                    NormalizedUserName = a.NormalizedUserName,
                    Email = a.Email,
                    NormalizedEmail = a.NormalizedEmail,
                    EmailConfirmed = a.EmailConfirmed,
                    SecurityStamp = a.SecurityStamp,
                    ConcurrencyStamp = a.ConcurrencyStamp,
                    PhoneNumber = a.PhoneNumber,
                    PhoneNumberConfirmed = a.PhoneNumberConfirmed,
                    TwoFactorEnabled = a.TwoFactorEnabled,
                    LockoutEnabled = a.LockoutEnabled,
                    LockoutEnd =a.LockoutEnd,
                    AccessFailedCount = a.AccessFailedCount
                }).FirstOrDefault();
                value = JsonConvert.SerializeObject(rolesview, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            }            
            return Json(value);
        }

        //Save Data into DataBase
        [HttpPost]
        [Authorize(Roles ="Admin")]
        public JsonResult UpdateUserRole(UserRoleVM model)
        {
            var result = false;
            if(model.roletbl.Id != null) { 
                var checkUserInSystem = _context.AspNetSystemUsers.FirstOrDefault(a => a.UserId == model.usertbl.Id);
                var checkUserInRole = _context.AspNetUserRoles.FirstOrDefault(a => a.UserId == model.usertbl.Id);
                if(checkUserInRole != null)
                {
                    checkUserInRole.RoleId = model.roletbl.Id;
                    _context.AspNetUserRoles.Update(checkUserInRole);
                    _context.SaveChanges();
                    result = true;
                }
                else
                {
                    var InsertUserRole = new AspNetUserRoles
                    {
                        UserId = model.usertbl.Id,
                        RoleId = model.roletbl.Id
                    };
                    _context.AspNetUserRoles.Add(InsertUserRole);
                    _context.SaveChanges();
                    result = true;
                }
                if(checkUserInSystem == null)
                {
                    var checkIsVendor = _context.AspNetUserRoles.FirstOrDefault(a => a.UserId == model.usertbl.Id);
                    var notVendor = checkIsVendor.RoleId;
                    if (notVendor == "00100" || notVendor == "00010")
                    {
                    }
                    else
                    { 
                        var insertSystem = new AspNetSystemUsers
                        {
                            UserId = model.usertbl.Id
                        };
                        _context.AspNetSystemUsers.Add(insertSystem);
                        _context.SaveChanges();
                        result = true;
                    }
                }
            }
            return Json(result);

        }

        //Show Vendor Data Form
        [Authorize(Roles ="Admin")]
        public IActionResult VendorData()
        {
            return View();
        }

        //Get Vendor With Json
        [HttpPost]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> GetVendorList([FromBody]DTParameters dtParameters)
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
                orderCriteria = "UserName";
                orderAscendingDirection = true;
            }

            var data = from user in _context.AspNetUsers
                       join vendor in _context.AspNetVendor on user.Id equals vendor.UserId
                       join userrole in _context.AspNetUserRoles on user.Id equals userrole.UserId
                       into Details
                       from DataDetails in Details.DefaultIfEmpty()
                       join role in _context.AspNetRoles on DataDetails.RoleId equals role.Id
                       into Details2
                       from DataDetails2 in Details2.DefaultIfEmpty()
                       
                       select new
                       {
                           Id = user.Id,
                           UserName = user.UserName,
                           NormalizedUserName = user.NormalizedUserName,
                           Email = user.Email,
                           NormalizedEmail = user.NormalizedEmail,
                           EmailConfirmed = user.EmailConfirmed,
                           SecurityStamp = user.SecurityStamp,
                           ConcurrencyStamp = user.ConcurrencyStamp,
                           PhoneNumber = user.PhoneNumber,
                           VendorId = vendor.Id,
                           CompanyName = vendor.CompanyName,
                           Address = vendor.Address,
                           NpwpNo = vendor.NpwpNo,
                           SiupNo = vendor.SiupNo,
                           SalesName = vendor.ContactName,
                           SalesContact = vendor.Contact, 
                           SalesEmail = vendor.ContactEmail,
                           InvoiceName = vendor.InvoiceName,
                           InvoiceContact = vendor.InvoiceContact,
                           InvoiceEmail = vendor.InvoiceEmail,
                           FileLocation = vendor.FileLocation,
                           RoleId = DataDetails.RoleId,
                           RoleName = DataDetails2.Name
                       };
            var result = data.ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.UserName != null && r.UserName.ToUpper().Contains(searchBy.ToUpper()) ||
                r.NormalizedUserName != null && r.NormalizedUserName.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Email != null && r.Email.ToUpper().Contains(searchBy.ToUpper()) ||
                r.NormalizedEmail != null && r.NormalizedEmail.ToUpper().Contains(searchBy.ToUpper()) ||
                r.PhoneNumber != null && r.PhoneNumber.ToUpper().Contains(searchBy.ToUpper()) ||
                r.CompanyName != null && r.CompanyName.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Address != null && r.Address.ToUpper().Contains(searchBy.ToUpper()) ||
                r.NpwpNo != null && r.NpwpNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.SiupNo != null && r.SiupNo.ToUpper().Contains(searchBy.ToUpper()) ||
                r.SalesName != null && r.SalesName.ToUpper().Contains(searchBy.ToUpper()) ||
                r.SalesContact != null && r.SalesContact.ToUpper().Contains(searchBy.ToUpper()) ||
                r.SalesEmail != null && r.SalesEmail.ToUpper().Contains(searchBy.ToUpper()) ||
                r.InvoiceName != null && r.InvoiceName.ToUpper().Contains(searchBy.ToUpper()) ||
                r.InvoiceEmail != null && r.InvoiceEmail.ToUpper().Contains(searchBy.ToUpper()) ||
                r.InvoiceContact != null && r.InvoiceContact.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RoleId != null && r.RoleId.ToUpper().Contains(searchBy.ToUpper()) ||
                r.RoleName != null && r.RoleName.ToUpper().Contains(searchBy.ToUpper()) 
                ).ToList();
            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            //Dapatkan Jumlah Total Record
            var filteredResultsCount = result.Count();
            var totalResultsCount = await _context.AspNetUserRoles.Where(a=>a.RoleId == "00100").CountAsync();
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

        //Get and Pass Vendor Data to Modal
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public JsonResult GetVendorById(string id)
        {
            string result = string.Empty;
            AspNetUsers aspNetUsers = _context.AspNetUsers.Where(a => a.Id == id).SingleOrDefault();
            var GetData = (from user in _context.AspNetUsers
                           join vendor in _context.AspNetVendor on user.Id equals vendor.UserId
                           join userrole in _context.AspNetUserRoles on user.Id equals userrole.UserId
                           into Details
                           from DataDetails in Details.DefaultIfEmpty()
                           join role in _context.AspNetRoles on DataDetails.RoleId equals role.Id
                           into Details2
                           from DataDetails2 in Details2.DefaultIfEmpty()
                           where user.Id == aspNetUsers.Id
                           select new
                           {
                               Id = user.Id,
                               UserName = user.UserName,
                               NormalizedUserName = user.NormalizedUserName,
                               Email = user.Email,
                               NormalizedEmail = user.NormalizedEmail,
                               EmailConfirmed = user.EmailConfirmed,
                               SecurityStamp = user.SecurityStamp,
                               ConcurrencyStamp = user.ConcurrencyStamp,
                               PhoneNumber = user.PhoneNumber,
                               VendorId = vendor.Id,
                               CompanyName = vendor.CompanyName,
                               Address = vendor.Address,
                               NpwpNo = vendor.NpwpNo,
                               SiupNo = vendor.SiupNo,
                               swiftcode = vendor.swiftcode,
                               SalesName = vendor.ContactName,
                               SalesContact = vendor.Contact,
                               SalesEmail = vendor.ContactEmail,
                               InvoiceName = vendor.InvoiceName,
                               InvoiceContact = vendor.InvoiceContact,
                               InvoiceEmail = vendor.InvoiceEmail,
                               FileLocation = vendor.FileLocation,
                               RoleId = DataDetails.RoleId,
                               RoleName = DataDetails2.Name
                           }).FirstOrDefault();

            result = JsonConvert.SerializeObject(GetData, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(result);
        }

        // GET: Users/Details/5
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspNetUsers = await _context.AspNetUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aspNetUsers == null)
            {
                return NotFound();
            }
            var join = (from user in _context.AspNetUsers
                       join userrole in _context.AspNetUserRoles on user.Id equals userrole.UserId
                       join role in _context.AspNetRoles on userrole.RoleId equals role.Id
                       where user.Id == aspNetUsers.Id
                       select new UserRoleVM
                       {
                           roletbl = role,
                           userroletbl = userrole,
                           usertbl = user
                       }).FirstOrDefault();
            return View(join);
        }

        //Get List of Roles
        [Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult Userroleform(string id)
        {
            //mendapatkan data dari db untuk tbl user
            if (id == null)
            {
                return NotFound();
            }

            var aspNetUsers = (from user in _context.AspNetUsers
                               where (user.Id == id)
                               select new UserRoleVM
                               {
                                   usertbl = user
                               }).FirstOrDefault();
            if (aspNetUsers == null)
            {
                return NotFound();
            }
            //mendapatkan data dari db ke combobox
            List<AspNetRoles> listroles = new List<AspNetRoles>();

            //Getting Data From DB Using Entity Framework
            listroles = (from a in _context.AspNetRoles
                         select a).ToList();
            if (listroles == null)
            {
                return NotFound();
            }
            //inserting data to combobox
            listroles.Insert(0, new AspNetRoles { Id = "0", Name = "Select" });

            //Asign data to view.bag 
            ViewBag.ListOfRoles = listroles;

            return View(aspNetUsers);
        }

        //Post The Data
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Userroleform(string id, UserRoleVM userrole)
        {
            if (id == null)
            {
                return NotFound();
            }
            //validasi role ID
            if (userrole.roletbl.Id == "0")
            {
                ModelState.AddModelError("", "Select Roles");

            }
            //Getting selected value
            string SelectValue = userrole.roletbl.Id;

            //Getting ID User
            string iduser = id;

            //get the same value id in db user role
            var cekid = _context.AspNetUserRoles.FirstOrDefault(a => a.UserId == id);

            if (cekid == null)
            {
                var AddDb = new AspNetUserRoles
                {
                    UserId = iduser,
                    RoleId = SelectValue
                };
                //validasi sebelum masuk ke db
                if (ModelState.IsValid)
                {
                    _context.AspNetUserRoles.Add(AddDb);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Userrole));
                }
            }
            else
            {
                var userid = _context.AspNetUserRoles.FirstOrDefault(a => a.UserId == id);
                //validasi sebelum masuk ke db
                if (userid != null)
                {
                    userid.RoleId = userrole.roletbl.Id;
                    

                    _context.AspNetUserRoles.Update(userid);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Userrole));
                }
            }
            return View();
        }

        //View Page Manage Vendor Data
        [Authorize(Roles ="Admin")]
        public IActionResult ManageVendorData()
        {
            //Get User ID Online
            ViewBag.userId = _userManager.GetUserId(HttpContext.User);
            string uid = ViewBag.userId;

            //Get List of product Posting Group
            List<VendorPostingGroup> vendorPostingGroups = _balimoonBMLContext.VendorPostingGroup.ToList();
            ViewBag.ListOfVendorPostingGroup = new SelectList(vendorPostingGroups, "Code", "Code");
            //Get List Of Currency
            List<Currency> currencies = _balimoonBMLContext.Currency.ToList();
            ViewBag.ListOfCurrency = new SelectList(currencies, "Code", "Description");
            //Get List of Payment Terms
            List<PaymentTerms> PaymentTerms = _balimoonBMLContext.PaymentTerms.ToList();
            ViewBag.ListOfPaymentTerms = new SelectList(PaymentTerms, "Code", "Description");
            //Get List of Countries
            List<CountryRegion> countries = _balimoonBMLContext.CountryRegion.ToList();
            ViewBag.ListOfCountry = new SelectList(countries, "Code", "Name");
            //Get Gen Buss Posting Group
            List<GenBusinessPostingGroup> genBusinessPostingGroups = _balimoonBMLContext.GenBusinessPostingGroup.ToList();
            ViewBag.ListOfGenBusPost = new SelectList(genBusinessPostingGroups, "Code", "Description");
            //Get VAT Buss Posting Group
            List<VatbusinessPostingGroup> vatBussPostingGroup = _balimoonBMLContext.VatbusinessPostingGroup.ToList();
            ViewBag.ListOfVATBussPost = new SelectList(vatBussPostingGroup, "Code", "Description");
            //Get Location Code
            List<Locations> locations = _balimoonBMLContext.Locations.ToList();
            ViewBag.ListOfLocations = new SelectList(locations, "LocationCode", "LocationName");

            //View form
            return View();
        }

        //Passing Data Vendor To Data Table
        [HttpPost]
        public async Task<IActionResult> GetVendorData([FromBody]DTParameters dtParameters)
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
                orderCriteria = "CompanyName";
                orderAscendingDirection = true;
            }

            var data = (from vendor in _context.AspNetVendor
                        join user in _context.AspNetUsers on vendor.UserId equals user.Id
                        join userrole in _context.AspNetUserRoles on user.Id equals userrole.UserId
                        where user.EmailConfirmed == true
                        select new
                        {
                            Id = vendor.Id,
                            CompanyName = vendor.CompanyName,
                            Address = vendor.Address,
                            NPWPNO = vendor.NpwpNo,
                            SIUPNO = vendor.SiupNo,
                            SalesName = vendor.ContactName,
                            SalesContact = vendor.Contact,
                            SalesEmail = vendor.ContactEmail,
                            InvoiceName = vendor.InvoiceName,
                            InvoiceEmail = vendor.InvoiceEmail,
                            InvoiceContact = vendor.InvoiceContact,
                            Username = user.UserName,
                            VendorNo = vendor.VendorNo,
                            swiftcode = vendor.swiftcode
                        });
            var result = data.ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(r => r.CompanyName != null && r.CompanyName.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Address != null && r.Address.ToUpper().Contains(searchBy.ToUpper()) ||
                r.NPWPNO != null && r.NPWPNO.ToUpper().Contains(searchBy.ToUpper()) ||
                r.SIUPNO != null && r.SIUPNO.ToUpper().Contains(searchBy.ToUpper()) ||
                r.SalesName != null && r.SalesName.ToUpper().Contains(searchBy.ToUpper()) ||
                r.SalesContact != null && r.SalesContact.ToUpper().Contains(searchBy.ToUpper()) ||
                r.SalesEmail != null && r.SalesEmail.ToUpper().Contains(searchBy.ToUpper()) ||
                r.InvoiceName != null && r.InvoiceName.ToUpper().Contains(searchBy.ToUpper()) ||
                r.InvoiceEmail != null && r.InvoiceEmail.ToUpper().Contains(searchBy.ToUpper()) ||
                r.InvoiceContact != null && r.InvoiceContact.ToUpper().Contains(searchBy.ToUpper()) ||
                r.Username != null && r.Username.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            //Dapatkan Jumlah Total Record
            var filteredResultsCount = result.Count();
            var totalResultsCount = await _context.AspNetVendor.CountAsync();

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

        //Passing Data Vendor on AspNetVendor to Modal
        [Authorize(Roles ="Admin")]
        public JsonResult GetVendorDataById(int id)
        {
            var result = string.Empty;
            //get Vendor ID
            var aspNetVendor = _context.AspNetVendor.Where(a => a.Id == id).SingleOrDefault();
          
            //Join the database
            var join = (from a in _context.AspNetVendor
                       
                       where a.Id == aspNetVendor.Id
                       select new 
                       {
                           Id = a.Id,
                           CompanyName = a.CompanyName,
                           VendorNo = a.VendorNo,
                           Address = a.Address,
                           ContactName = a.ContactName,
                           Contact = a.Contact,
                           Email = a.ContactEmail,
                           swiftcode = a.swiftcode,
                       }).FirstOrDefault();
            
            var vendors = _balimoonBMLContext.Vendors.Where(a => a.VendorNo == join.VendorNo).SingleOrDefault();
            if(vendors != null) { 

            var join2 = (from b in _balimoonBMLContext.Vendors
                         where b.VendorNo == @join.VendorNo
                         select new
                         {
                             VendorNo = b.VendorNo,
                             Id = @join.Id,
                             CompanyName = b.VendorName,
                             Address = b.VendorAddress,
                             Address2 = b.VendorAddress2,
                             ContactName = b.VendorContact,
                             Contact = b.VendorPhoneNo,
                             FaxNo = b.VendorFaxNo,
                             VendorCity = b.VendorCity,
                             VendorPostingGroup = b.VendorPostingGroup,
                             Currency = b.CurrencyCode,
                             PaymentTerms = b.PaymentTermsCode,
                             Country = b.Country,
                             GenBusPostingGroup = b.GenBusPostingGroup,
                             MobileNo = b.MobileNo,
                             Email = b.Email,
                             VATBusPost = b.VatbusPostingGroup,
                             Locations = b.LocationCode,
                             swiftcode = b.swiftcode
                         }).FirstOrDefault();


                result = JsonConvert.SerializeObject(join2, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            }
            else
            {
                result = JsonConvert.SerializeObject(join, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            }            
            return Json(result);
        }

        //Get Data From Modal to Store in Vendor tbl in BalimoonBML Database
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public JsonResult UpdateVendorDataBM(VendorsModel model)
        {
            var result = "Task Not Executed";

            //Get User ID Online
            ViewBag.userId = _userManager.GetUserName(HttpContext.User);
            string uid = ViewBag.userId;
            var NewId = "";

            //Tampung Semua yang diinputka user dan sesuaikan dengan DB\\
            var currencycode = model.BalimoonBMLVendorTbl.CurrencyCode;
            var namavendor = model.BalimoonBMLVendorTbl.VendorName;
            var namavendor2 = model.BalimoonBMLVendorTbl.VendorName2;
            var alamatvendor = model.BalimoonBMLVendorTbl.VendorAddress;
            var alamatvendor2 = model.BalimoonBMLVendorTbl.VendorAddress2;
            var vendorcity = model.BalimoonBMLVendorTbl.VendorCity;
            var vendorcontact = model.BalimoonBMLVendorTbl.VendorContact;
            var vendorphoneno = model.BalimoonBMLVendorTbl.VendorPhoneNo;
            var vendorfaxno = model.BalimoonBMLVendorTbl.VendorFaxNo;
            var vendortelexno = model.BalimoonBMLVendorTbl.VendorTelexNo;
            var ouraccountno = model.BalimoonBMLVendorTbl.OurAccountNo;
            var territorycode = model.BalimoonBMLVendorTbl.TerritoryCode;
            var globaldimension1code = model.BalimoonBMLVendorTbl.GlobalDimension1Code;
            var globaldimension2code = model.BalimoonBMLVendorTbl.GlobalDimension2Code;
            var budgetamont = model.BalimoonBMLVendorTbl.BudgetedAmount; // default = 0
            var vendorpostinggroup = model.BalimoonBMLVendorTbl.VendorPostingGroup;
            var languagecode = model.BalimoonBMLVendorTbl.LanguageCode;
            var statisticsgroup = model.BalimoonBMLVendorTbl.StatisticsGroup; // default = 0
            var paymenttermscode = model.BalimoonBMLVendorTbl.PaymentTermsCode;
            var finchargetermscode = model.BalimoonBMLVendorTbl.FinChargeTermsCode;
            var purchasercode = model.BalimoonBMLVendorTbl.PurchaserCode;
            var shipmentmethodcode = model.BalimoonBMLVendorTbl.ShipmentMethodCode;
            var shippingagentcode = model.BalimoonBMLVendorTbl.ShippingAgentCode;
            var invoicedisccode = model.BalimoonBMLVendorTbl.InvoiceDiscCode;
            var country = model.BalimoonBMLVendorTbl.Country;
            var blocked = model.BalimoonBMLVendorTbl.Blocked; // default = 0
            var PaytoVendorNo = model.BalimoonBMLVendorTbl.PaytoVendorNo;
            var priority = model.BalimoonBMLVendorTbl.Priority; // default = 0
            var paymentmethodcode = model.BalimoonBMLVendorTbl.PaymentMethodCode;
            var aplicationmethod = model.BalimoonBMLVendorTbl.ApplicationMethod; // default = 0
            var priceincludingvat = model.BalimoonBMLVendorTbl.PricesIncludingVat; // default = 0
            var telexanswerback = model.BalimoonBMLVendorTbl.TelexAnswerBack;
            var VATregistrationNo = model.BalimoonBMLVendorTbl.VatregistrationNo;
            var genbuspostinggroup = model.BalimoonBMLVendorTbl.GenBusPostingGroup;
            var mobileno = model.BalimoonBMLVendorTbl.MobileNo;
            var POSTCode = model.BalimoonBMLVendorTbl.PostCode;
            var EMail = model.BalimoonBMLVendorTbl.Email;
            var HomePage = model.BalimoonBMLVendorTbl.HomePage;
            var NoSeries = model.BalimoonBMLVendorTbl.NoSeries;
            var TaxAreaCode = model.BalimoonBMLVendorTbl.TaxAreaCode;
            var TaxLiable = model.BalimoonBMLVendorTbl.TaxLiable; // default = 0
            var VATBusPostingGroup = model.BalimoonBMLVendorTbl.VatbusPostingGroup;
            var BlockPaymenttolerance = model.BalimoonBMLVendorTbl.BlockPaymentTolerance; // default = 0
            var ICPartnerCode = model.BalimoonBMLVendorTbl.IcpartnerCode;
            var PrePaymentPercent = model.BalimoonBMLVendorTbl.PrepaymentPercent; // default = 0
            var PrimaryContactNo = model.BalimoonBMLVendorTbl.PrimaryContactNo;
            var ResponsibilityCenter = model.BalimoonBMLVendorTbl.ResponsibilityCenter;
            var LocationCode = model.BalimoonBMLVendorTbl.LocationCode;
            var LeadTimeCalculation = model.BalimoonBMLVendorTbl.LeadTimeCalculation;
            var BaseCalenderCode = model.BalimoonBMLVendorTbl.BaseCalendarCode;
            var RTCFilterField = model.BalimoonBMLVendorTbl.RtcfilterField; // default = 0
            var BuyerGroupCode = model.BalimoonBMLVendorTbl.BuyerGroupCode;
            var BuyerID = model.BalimoonBMLVendorTbl.BuyerId;
            var swiftcode = model.BalimoonBMLVendorTbl.swiftcode;
            //Akhir Dari Tampung Semua yang diinputkan user dan sesuaikan dengan DB\\

                ///Filter Input\\\
                ///ThrowBack Error\\\ Server Side
            if (vendorpostinggroup == null)
            {
                result = "Vendor Posting Group Cannot be Null";
            }
            else if (currencycode == null)
            {
                result = "Currency Cannot be Null";
            }
            else if (EMail == null)
            {
                result = "E-Mail Cannot be Null";
            }
            else if (paymenttermscode == null)
            {
                result = "Payment Terms Cannot be Null";
            }
            else if (country == null)
            {
                result = "Country Cannot be Null";
            }
            else if (namavendor == null)
            {
                result = "Vendor Name Cannot be Null";
            }
            else if (alamatvendor == null)
            {
                result = "Vendor Address Cannot be Null";
            }
            else if (vendorcontact == null)
            {
                result = "Vendor Contact Cannot be Null";
            }
            else if (vendorcity == null)
            {
                result = "Vendor City Cannot be Null";
            }
            else if (vendorphoneno == null)
            {
                result = "Vendor Phone Number Cannot be Null";
            }
            else if (genbuspostinggroup == null)
            {
                result = "Gen Business Group Cannot be Null";
            }
            else if (VATBusPostingGroup == null)
            {
                result = "VAT Business Posting Group Cannot be Null";
            }
            ///End of ThrowBack Error\\\ Server Side
            else
            {
                ///Filter Null Input\\\
                if (namavendor2 == null)
                {
                    namavendor2 = "";
                }
                if (alamatvendor2 == null)
                {
                    alamatvendor2 = "";
                }
                if (vendorfaxno == null)
                {
                    vendorfaxno = "";
                }
                if (vendortelexno == null)
                {
                    vendortelexno = "";
                }
                if (ouraccountno == null)
                {
                    ouraccountno = "";
                }
                if (territorycode == null)
                {
                    territorycode = "";
                }
                if (globaldimension1code == null)
                {
                    globaldimension1code = "";
                }
                if (globaldimension2code == null)
                {
                    globaldimension2code = "";
                }
                if (budgetamont == null)
                {
                    budgetamont = 0;
                }
                if (vendorpostinggroup == null)
                {
                    vendorpostinggroup = "";
                }
                if (languagecode == null)
                {
                    languagecode = "";
                }
                if (statisticsgroup == null)
                {
                    statisticsgroup = 0;
                }
                if (finchargetermscode == null)
                {
                    finchargetermscode = "";
                }
                if (purchasercode == null)
                {
                    purchasercode = "";
                }
                if (shipmentmethodcode == null)
                {
                    shipmentmethodcode = "";
                }
                if (shippingagentcode == null)
                {
                    shippingagentcode = "";
                }
                if (invoicedisccode == null)
                {
                    invoicedisccode = "";
                }
                if (blocked == null)
                {
                    blocked = 0;
                }
                if (PaytoVendorNo == null)
                {
                    PaytoVendorNo = "";
                }
                if (priority == null)
                {
                    priority = 0;
                }
                if (paymentmethodcode == null)
                {
                    paymentmethodcode = "";
                }
                if (aplicationmethod == null)
                {
                    aplicationmethod = 0;
                }
                if (priceincludingvat == null)
                {
                    priceincludingvat = 0;
                }
                if (telexanswerback == null)
                {
                    telexanswerback = "";
                }
                if (VATregistrationNo == null)
                {
                    VATregistrationNo = "";
                }
                if (mobileno == null)
                {
                    mobileno = "";
                }
                if (POSTCode == null)
                {
                    POSTCode = "";
                }
                if (HomePage == null)
                {
                    HomePage = "";
                }
                if (NoSeries == null)
                {
                    NoSeries = "";
                }
                if (TaxAreaCode == null)
                {
                    TaxAreaCode = "";
                }
                if (TaxLiable == null)
                {
                    TaxLiable = 0;
                }
                if (BlockPaymenttolerance == null)
                {
                    BlockPaymenttolerance = 0;
                }
                if (ICPartnerCode == null)
                {
                    ICPartnerCode = "";
                }
                if (PrePaymentPercent == null)
                {
                    PrePaymentPercent = 0;
                }
                if (PrimaryContactNo == null)
                {
                    PrimaryContactNo = "";
                }
                if (ResponsibilityCenter == null)
                {
                    ResponsibilityCenter = "";
                }
                if (LocationCode == null)
                {
                    LocationCode = "";
                }
                if (LeadTimeCalculation == null)
                {
                    LeadTimeCalculation = "";
                }
                if (BaseCalenderCode == null)
                {
                    BaseCalenderCode = "";
                }
                if (RTCFilterField == null)
                {
                    RTCFilterField = 0;
                }
                if (BuyerGroupCode == null)
                {
                    BuyerGroupCode = "";
                }
                if (BuyerID == null)
                {
                    BuyerID = "";
                }
                if (swiftcode == null)
                {
                    swiftcode = "";
                }
                ///Akhir Filter Null Input\\\
                ///Akhir Filter \\\
                //cek apakah vendor sudah ada?
                var checkVendor = _context.AspNetVendor.FirstOrDefault(a => a.Id == model.MainSystemVendorTbl.Id);
                if (checkVendor == null)
                {
                    result = "Please Add The Vendor Role and Make Sure Vendor Data was confirmed in View Vendor Data Page";
                }
                else
                {
                    var getCheck = checkVendor.VendorNo;
                    if (getCheck == null || getCheck == "")
                    {
                        //Make new Vendor ID
                        var getVendorNoNew = _balimoonBMLContext.Vendors.Max(i => i.VendorNo);
                        if (getVendorNoNew == null)
                        {
                            NewId = "V00001";
                        }
                        else
                        {
                            char[] trimmed = { 'V' };
                            var getVendorNoNew1 = getVendorNoNew.Trim(trimmed);
                            int getVendorNoNew2 = Convert.ToInt32(getVendorNoNew1);
                            int got = getVendorNoNew2 + 1;
                            if (got < 10)
                            {
                                NewId = "V0000" + got;
                            }
                            else if (got < 100 && got >= 10)
                            {
                                NewId = "V000" + got;
                            }
                            else if (got < 1000 && got >= 100)
                            {
                                NewId = "V00" + got;
                            }
                            else if (got < 10000 && got >= 1000)
                            {
                                NewId = "V0" + got;
                            }
                            else
                            {
                                NewId = "V" + got;
                            }
                        }

                        //update tabel aspnetVendor in MainSystem Database adding NewId in VendorNo
                        checkVendor.VendorNo = NewId;
                        checkVendor.Address = alamatvendor;
                        checkVendor.Contact = vendorphoneno;
                        checkVendor.ContactName = vendorcontact;
                        checkVendor.ContactEmail = EMail;
                        _context.AspNetVendor.Update(checkVendor);
                        _context.SaveChanges();

                        //Adding New Value To Table Vendor In BalimoonBML Database
                        var insertToVendor = new Vendors
                        {
                            VendorNo = NewId,
                            VendorName = namavendor,
                            VendorName2 = namavendor2,
                            VendorAddress = alamatvendor,
                            VendorAddress2 = alamatvendor2,
                            VendorCity = vendorcity,
                            VendorContact = vendorcontact,
                            VendorPhoneNo = vendorphoneno,
                            VendorFaxNo = vendorfaxno,
                            VendorTelexNo = vendortelexno,
                            OurAccountNo = ouraccountno,
                            TerritoryCode = territorycode,
                            GlobalDimension1Code = globaldimension1code,
                            GlobalDimension2Code = globaldimension2code,
                            BudgetedAmount = budgetamont,
                            VendorPostingGroup = vendorpostinggroup,
                            CurrencyCode = currencycode,
                            LanguageCode = languagecode,
                            StatisticsGroup = statisticsgroup,
                            PaymentTermsCode = paymenttermscode,
                            FinChargeTermsCode = finchargetermscode,
                            PurchaserCode = purchasercode,
                            ShipmentMethodCode = shipmentmethodcode,
                            ShippingAgentCode = shippingagentcode,
                            InvoiceDiscCode = invoicedisccode,
                            Country = country,
                            Blocked = blocked,
                            PaytoVendorNo = PaytoVendorNo,
                            Priority = priority,
                            PaymentMethodCode = paymentmethodcode,
                            ApplicationMethod = aplicationmethod,
                            PricesIncludingVat = priceincludingvat,
                            TelexAnswerBack = telexanswerback,
                            VatregistrationNo = VATregistrationNo,
                            GenBusPostingGroup = genbuspostinggroup,
                            MobileNo = mobileno,
                            PostCode = POSTCode,
                            Email = EMail,
                            HomePage = HomePage,
                            NoSeries = NoSeries,
                            TaxAreaCode = TaxAreaCode,
                            TaxLiable = TaxLiable,
                            VatbusPostingGroup = VATBusPostingGroup,
                            BlockPaymentTolerance = BlockPaymenttolerance,
                            IcpartnerCode = ICPartnerCode,
                            PrepaymentPercent = PrePaymentPercent,
                            PrimaryContactNo = PrimaryContactNo,
                            ResponsibilityCenter = ResponsibilityCenter,
                            LocationCode = LocationCode,
                            LeadTimeCalculation = LeadTimeCalculation,
                            BaseCalendarCode = BaseCalenderCode,
                            RtcfilterField = RTCFilterField,
                            BuyerGroupCode = BuyerGroupCode,
                            BuyerId = BuyerID,
                            RowStatus = 0,
                            CreatedBy = uid,
                            CreatedTime = DateTime.Now,
                            swiftcode = swiftcode
                        };
                        _balimoonBMLContext.Vendors.Add(insertToVendor);
                        _balimoonBMLContext.SaveChanges();
                        result = "Sukses";

                    }
                    else
                    {
                        var getVendorInBMLTable = _balimoonBMLContext.Vendors.FirstOrDefault(a => a.VendorNo == getCheck);
                        var vendorId = getVendorInBMLTable.VendorId;
                        var getIDVendor = _balimoonBMLContext.Vendors.FirstOrDefault(a => a.VendorId == vendorId);
                        if (getIDVendor != null)
                        {
                            //get the value for update in model
                            getIDVendor.VendorName = namavendor;
                            getIDVendor.VendorName2 = namavendor2;
                            getIDVendor.VendorAddress = alamatvendor;
                            getIDVendor.VendorAddress2 = alamatvendor2;
                            getIDVendor.VendorCity = vendorcity;
                            getIDVendor.VendorContact = vendorcontact;
                            getIDVendor.VendorPhoneNo = vendorphoneno;
                            getIDVendor.VendorFaxNo = vendorfaxno;
                            getIDVendor.VendorTelexNo = vendortelexno;
                            getIDVendor.OurAccountNo = ouraccountno;
                            getIDVendor.TerritoryCode = territorycode;
                            getIDVendor.GlobalDimension1Code = globaldimension1code;
                            getIDVendor.GlobalDimension2Code = globaldimension2code;
                            getIDVendor.BudgetedAmount = budgetamont;
                            getIDVendor.VendorPostingGroup = vendorpostinggroup;
                            getIDVendor.CurrencyCode = currencycode;
                            getIDVendor.LanguageCode = languagecode;
                            getIDVendor.StatisticsGroup = statisticsgroup;
                            getIDVendor.PaymentTermsCode = paymenttermscode;
                            getIDVendor.FinChargeTermsCode = finchargetermscode;
                            getIDVendor.PurchaserCode = purchasercode;
                            getIDVendor.ShipmentMethodCode = shipmentmethodcode;
                            getIDVendor.ShippingAgentCode = shippingagentcode;
                            getIDVendor.InvoiceDiscCode = invoicedisccode;
                            getIDVendor.Country = country;
                            getIDVendor.Blocked = blocked;
                            getIDVendor.PaytoVendorNo = PaytoVendorNo;
                            getIDVendor.Priority = priority;
                            getIDVendor.PaymentMethodCode = paymentmethodcode;
                            getIDVendor.ApplicationMethod = aplicationmethod;
                            getIDVendor.PricesIncludingVat = priceincludingvat;
                            getIDVendor.TelexAnswerBack = telexanswerback;
                            getIDVendor.VatregistrationNo = VATregistrationNo;
                            getIDVendor.GenBusPostingGroup = genbuspostinggroup;
                            getIDVendor.MobileNo = mobileno;
                            getIDVendor.PostCode = POSTCode;
                            getIDVendor.Email = EMail;
                            getIDVendor.HomePage = HomePage;
                            getIDVendor.NoSeries = NoSeries;
                            getIDVendor.TaxAreaCode = TaxAreaCode;
                            getIDVendor.TaxLiable = TaxLiable;
                            getIDVendor.VatbusPostingGroup = VATBusPostingGroup;
                            getIDVendor.BlockPaymentTolerance = BlockPaymenttolerance;
                            getIDVendor.IcpartnerCode = ICPartnerCode;
                            getIDVendor.PrepaymentPercent = PrePaymentPercent;
                            getIDVendor.PrimaryContactNo = PrimaryContactNo;
                            getIDVendor.ResponsibilityCenter = ResponsibilityCenter;
                            getIDVendor.LocationCode = LocationCode;
                            getIDVendor.LeadTimeCalculation = LeadTimeCalculation;
                            getIDVendor.BaseCalendarCode = BaseCalenderCode;
                            getIDVendor.RtcfilterField = RTCFilterField;
                            getIDVendor.BuyerGroupCode = BuyerGroupCode;
                            getIDVendor.BuyerId = BuyerID;
                            getIDVendor.RowStatus = 0;
                            getIDVendor.LastModifiedBy = uid;
                            getIDVendor.LastModifiedTime = DateTime.Now;
                            getIDVendor.swiftcode = swiftcode;

                            //update the database
                            _balimoonBMLContext.Vendors.Update(getIDVendor);
                            _balimoonBMLContext.SaveChanges();


                            //update tabel aspnetVendor in MainSystem Database adding NewId in VendorNo
                            checkVendor.Address = alamatvendor;
                            checkVendor.Contact = vendorphoneno;
                            checkVendor.ContactName = vendorcontact;
                            checkVendor.ContactEmail = EMail;
                            checkVendor.swiftcode = swiftcode;
                            _context.AspNetVendor.Update(checkVendor);
                            _context.SaveChanges();
                            result = "Sukses";
                        }
                        else
                        {
                            result = "Vendor Not Found";
                        }

                    }
                }
            }
            return Json(result);
        }
    }
}
