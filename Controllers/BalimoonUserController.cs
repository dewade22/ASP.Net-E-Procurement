using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balimoon_E_Procurement.Models;
using Balimoon_E_Procurement.Models.BalimoonBMI;
using Balimoon_E_Procurement.Models.BalimoonBMI.ViewModel;
using Balimoon_E_Procurement.Models.BalimoonBML;
using Balimoon_E_Procurement.Models.BalimoonBML.ViewModel;
using Balimoon_E_Procurement.Models.DatatableModels;
using Balimoon_E_Procurement.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;

namespace Balimoon_E_Procurement.Controllers
{
    public class BalimoonUserController : Controller
    {
        private readonly MainSystemContext _mainSystemContext;
        private readonly BalimoonBMLContext _balimoonBMLContext;
        private readonly BalimoonBMIContext _balimoonBMIContext;
        private readonly UserManager<IdentityUser> _userManager;
        
        public BalimoonUserController(
            MainSystemContext mainSystemContext,
            BalimoonBMLContext balimoonBMLContext,
            BalimoonBMIContext balimoonBMIContext,
            UserManager<IdentityUser> userManager
            )
        {
            _mainSystemContext = mainSystemContext;
            _balimoonBMLContext = balimoonBMLContext;
            _balimoonBMIContext = balimoonBMIContext;
            _userManager = userManager;
        }

        /// <summary>
        /// Baris Code Dibawah Merupakan Code yang Digunakan Pada Halaman Internal User Accuont Balimoon BML
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles="Admin")]
        public IActionResult BMLIndex()
        {
            //Get Select Lis Location
            List<Models.BalimoonBML.Locations> locations = _balimoonBMLContext.Locations.ToList();
            ViewBag.ListOfLocations = new SelectList(locations, "LocationCode", "LocationName");

            //Get Departement Code
            List<Models.BalimoonBML.DimensionValue> dimensionValues = _balimoonBMLContext.DimensionValue.Where(a => a.DimensionCode == "DEPARTMENT").ToList();
            ViewBag.ListOfDimension = new SelectList(dimensionValues, "DimensionValueCode", "DimensionValueName");

            //Show the Form
            return View();
        }

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> GetBMLIndex([FromBody]DTParameters dtParameters)
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

            var join = from user in _mainSystemContext.AspNetUsers
                       join userrole in _mainSystemContext.AspNetUserRoles on user.Id equals userrole.UserId
                       join role in _mainSystemContext.AspNetRoles on userrole.RoleId equals role.Id
                       join UserBML in _mainSystemContext.AspNetSystemUsers on user.Id equals UserBML.UserId
                       where userrole.RoleId == "00020" || userrole.RoleId == "00030" || userrole.RoleId == "00040" || userrole.RoleId == "00070" || userrole.RoleId == "00041"
                       select new
                       {
                           UserId = UserBML.UserId,
                           UserName = user.UserName,
                           RoleName = role.Name,
                           Departement = UserBML.DepartmentCode,
                           Locations = UserBML.LocationCode
                         
                       };
            var result = join.ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.UserName != null && a.UserName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RoleName != null && a.RoleName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Departement != null && a.Departement.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Locations != null && a.Locations.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            //Dapatkan Jumlah Total Record
            var filteredResultsCount = result.Count();
            var totalResultsCount = await _mainSystemContext.AspNetSystemUsers.CountAsync();

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
        public JsonResult GetBMLDetail(string UserId)
        {
            var result = string.Empty;
            //Get User Id on System User
            var aspNetSystemUser = _mainSystemContext.AspNetSystemUsers.Where(a => a.UserId == UserId).SingleOrDefault();

            //Join The Table To Get UserName
            if(aspNetSystemUser != null) {
                var join1 = (from User in _mainSystemContext.AspNetUsers
                             join UserRole in _mainSystemContext.AspNetUserRoles on User.Id equals UserRole.UserId
                             join Role in _mainSystemContext.AspNetRoles on UserRole.RoleId equals Role.Id
                             join SystemUser in _mainSystemContext.AspNetSystemUsers on User.Id equals SystemUser.UserId
                             where User.Id == aspNetSystemUser.UserId
                             select new
                             {
                                 UserId = User.Id,
                                 UserName = User.UserName,
                                 RoleAccess = Role.Name,
                                 DepartementCode = SystemUser.DepartmentCode,
                                 LocationCode = SystemUser.LocationCode
                             }).FirstOrDefault();
                var getDepartement = aspNetSystemUser.DepartmentCode;
                var getLocation = aspNetSystemUser.LocationCode;
                if (getDepartement != null && getDepartement !="")
                {
                    var join2 = (from departement in _balimoonBMLContext.DimensionValue
                                 where departement.DimensionValueCode == getDepartement
                                 select new
                                 {
                                     UserId = join1.UserId,
                                     UserName = join1.UserName,
                                     RoleAccess = join1.RoleAccess,
                                     DepartementCode = departement.DimensionValueCode
                                 }).FirstOrDefault();
                    

                    if (getLocation != null && getLocation !="")
                    {
                        var join3 = (from location in _balimoonBMLContext.Locations
                                     where location.LocationCode == getLocation
                                     select new
                                     {

                                         UserId = join1.UserId,
                                         UserName = join1.UserName,
                                         RoleAccess = join1.RoleAccess,
                                         DepartementCode = join2.DepartementCode,
                                         LocationCode = location.LocationCode
                                     }).FirstOrDefault();
                        result = JsonConvert.SerializeObject(join3, Formatting.Indented, new JsonSerializerSettings
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                    }
                    else
                    {
                        result = JsonConvert.SerializeObject(join2, Formatting.Indented, new JsonSerializerSettings
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                    }
                }
                else if ((getDepartement == null && getDepartement == "") && (getLocation != null && getLocation != ""))
                {
                    var join3 = (from location in _balimoonBMLContext.Locations
                                 where location.LocationCode == getLocation
                                 select new
                                 {

                                     UserId = join1.UserId,
                                     UserName = join1.UserName,
                                     RoleAccess = join1.RoleAccess,
                                     LocationCode = location.LocationCode
                                 }).FirstOrDefault();
                    result = JsonConvert.SerializeObject(join3, Formatting.Indented, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                }
                else
                {
                    result = JsonConvert.SerializeObject(join1, Formatting.Indented, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                }
            }
            return Json(result);
        }

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public JsonResult UpdateBMLUser(BMLUserVM model)
        {
            var result = false;

            //Check System User ID Exist?
            var aspNetSystemUser = _mainSystemContext.AspNetSystemUsers.FirstOrDefault(a => a.UserId == model.aspNetSystemUsers.UserId);
            var getUserId = aspNetSystemUser.UserId;
            if(getUserId != null)
            {
                //Update Table where id = model.id
                if(model.aspNetSystemUsers.DepartmentCode != null && model.aspNetSystemUsers.LocationCode != null)
                {
                    aspNetSystemUser.DepartmentCode = model.aspNetSystemUsers.DepartmentCode;
                    aspNetSystemUser.LocationCode = model.aspNetSystemUsers.LocationCode;
                    _mainSystemContext.AspNetSystemUsers.Update(aspNetSystemUser);
                    _mainSystemContext.SaveChanges();
                    result = true;
                }
                else if(model.aspNetSystemUsers.DepartmentCode != null)
                {
                    aspNetSystemUser.DepartmentCode = model.aspNetSystemUsers.DepartmentCode;
                    _mainSystemContext.AspNetSystemUsers.Update(aspNetSystemUser);
                    _mainSystemContext.SaveChanges();
                    result = true;
                }
                else if(model.aspNetSystemUsers.LocationCode != null)
                {
                    aspNetSystemUser.LocationCode = model.aspNetSystemUsers.LocationCode;
                    _mainSystemContext.AspNetSystemUsers.Update(aspNetSystemUser);
                    _mainSystemContext.SaveChanges();
                    result = true;
                }
                else
                {
                    result = false;
                }
               
               
            }
            
            return Json(result);
        }

        [Authorize(Roles ="Admin")]
        public IActionResult AddApprovalBML()
        {
            //Get HOD Data
            var getlist = (from user in _mainSystemContext.AspNetUsers
                           join role in _mainSystemContext.AspNetUserRoles on user.Id equals role.UserId
                           join systemUser in _mainSystemContext.AspNetSystemUsers on user.Id equals systemUser.UserId
                           where role.RoleId == "00020" || role.RoleId == "00030" || role.RoleId == "00040" || role.RoleId == "00070"
                           select new
                           {
                               Id = user.Id,
                               UserName = user.UserName,
                               DepartmentCode = systemUser.DepartmentCode
                           }).ToList();
            
            ViewBag.ListOfHOD = new SelectList(getlist, "UserName", "UserName");

            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddBMLApproval([FromBody]DTParameters dtParameters)
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
            var jointbl = (from User in _mainSystemContext.AspNetUsers
                           join UserRole in _mainSystemContext.AspNetUserRoles on User.Id equals UserRole.UserId
                           join Role in _mainSystemContext.AspNetRoles on UserRole.RoleId equals Role.Id
                           join SystemUser in _mainSystemContext.AspNetSystemUsers on User.Id equals SystemUser.UserId
                           where Role.Id == "00020" || Role.Id == "00030" || Role.Id == "00060" || Role.Id == "00070" || Role.Id == "00040" || Role.Id == "00041"
                           select new
                           {
                               UserId = SystemUser.UserId,
                               UserName = User.UserName,
                               Role = Role.Name,
                               Department = SystemUser.DepartmentCode,
                               Approver = SystemUser.ApproverId
                           });
            var result = jointbl.ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.UserName != null && a.UserName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Role != null && a.Role.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Approver != null && a.Approver.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Department != null && a.Department.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            var getCountResult = (from SystemUser in _mainSystemContext.AspNetSystemUsers
                                  join UserRole in _mainSystemContext.AspNetUserRoles on SystemUser.UserId equals UserRole.UserId
                                  where UserRole.RoleId == "00020" || UserRole.RoleId == "00030" || UserRole.RoleId == "00040" || UserRole.RoleId == "00041" || UserRole.RoleId == "00060" || UserRole.RoleId == "00070"
                                  select new
                                  {
                                      Id = SystemUser.UserId
                                  }).ToList();

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            //Dapatkan Jumlah Total Record
            var filteredResultsCount = result.Count();

            var totalResultsCount = getCountResult.Count();
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

        [Authorize(Roles = "Admin")]
        public JsonResult SelectApproval(string UserId)
        {
            var result = string.Empty;

            //Get SystemUser Data
            var aspNetSystemUser = _mainSystemContext.AspNetSystemUsers.Where(a => a.UserId == UserId).SingleOrDefault();

            //Join Tabel To Get User Name
            var jointbl = (from systemUser in _mainSystemContext.AspNetSystemUsers
                           join user in _mainSystemContext.AspNetUsers on systemUser.UserId equals user.Id
                           join UserRole in _mainSystemContext.AspNetUserRoles on systemUser.UserId equals UserRole.UserId
                           join Role in _mainSystemContext.AspNetRoles on UserRole.RoleId equals Role.Id
                           where systemUser.UserId == UserId
                           select new
                           {
                               UserId = systemUser.UserId,
                               UserName = user.UserName,
                               Role = Role.Name,
                               ApproverId = systemUser.ApproverId
                           }).FirstOrDefault();
            result = JsonConvert.SerializeObject(jointbl, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(result);
        }

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public JsonResult UpdateBMLApproval(BMLUserVM model)
        {
            var result = false;

            var aspNetSystemUser = _mainSystemContext.AspNetSystemUsers.FirstOrDefault(a => a.UserId == model.aspNetSystemUsers.UserId);

            if(aspNetSystemUser.UserId != null)
            {
                // Get The Data From Model
                if(model.aspNetSystemUsers.ApproverId != null)
                {
                    aspNetSystemUser.ApproverId = model.aspNetSystemUsers.ApproverId;
                    _mainSystemContext.AspNetSystemUsers.Update(aspNetSystemUser);
                    _mainSystemContext.SaveChanges();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return Json(result);
        }
      
        [Authorize(Roles ="Admin")]
        public IActionResult BudgetApprovalBML()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public IActionResult AddBMLBudget([FromBody]DTParameters dtParameters)
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
            var join = (from User in _mainSystemContext.AspNetUsers
                        join UserRole in _mainSystemContext.AspNetUserRoles on User.Id equals UserRole.UserId
                        join Role in _mainSystemContext.AspNetRoles on UserRole.RoleId equals Role.Id
                        join SystemUser in _mainSystemContext.AspNetSystemUsers on User.Id equals SystemUser.UserId
                        where Role.Id == "00020" || Role.Id == "00040" || Role.Id == "00030" || Role.Id == "00070"
                        select new
                        {
                            UserId = SystemUser.UserId,
                            UserName = User.UserName,
                            Role = Role.Name,
                            Department = SystemUser.DepartmentCode,
                            MaksimumBudget = SystemUser.PurchaseAmountApprovalLimit
                        });
            var result = join.ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.UserName != null && a.UserName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Role != null && a.Role.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Department != null && a.Department.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            var getCountResult = (from SystemUser in _mainSystemContext.AspNetSystemUsers
                                  join UserRole in _mainSystemContext.AspNetUserRoles on SystemUser.UserId equals UserRole.UserId
                                  where UserRole.RoleId == "00020" || UserRole.RoleId == "00030" || UserRole.RoleId == "00040" || UserRole.RoleId == "00070"
                                  select new
                                  {
                                      Id = SystemUser.UserId
                                  }).ToList();

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            //Dapatkan Jumlah Total Record
            var filteredResultsCount = result.Count();

            var totalResultsCount = getCountResult.Count();
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

        [Authorize(Roles = "Admin")]
        public JsonResult ManageBudgetBML(string UserId)
        {
            var result = string.Empty;

            //Get SystemUser Data
            var aspNetSystemUser = _mainSystemContext.AspNetSystemUsers.Where(a => a.UserId == UserId).SingleOrDefault();

            //Join Tabel To Get User Name
            var jointbl = (from systemUser in _mainSystemContext.AspNetSystemUsers
                           join user in _mainSystemContext.AspNetUsers on systemUser.UserId equals user.Id
                           join UserRole in _mainSystemContext.AspNetUserRoles on systemUser.UserId equals UserRole.UserId
                           join Role in _mainSystemContext.AspNetRoles on UserRole.RoleId equals Role.Id
                           where systemUser.UserId == UserId
                           select new
                           {
                               UserId = systemUser.UserId,
                               UserName = user.UserName,
                               Role = Role.Name,
                               ApproverId = systemUser.ApproverId,
                               MaksimumBudget = systemUser.PurchaseAmountApprovalLimit
                           }).FirstOrDefault();
            result = JsonConvert.SerializeObject(jointbl, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(result);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public JsonResult UpdateBudgetBML(BMLUserVM model)
        {
            var result = false;

            var aspNetSystemUser = _mainSystemContext.AspNetSystemUsers.FirstOrDefault(a => a.UserId == model.aspNetSystemUsers.UserId);

            if (aspNetSystemUser.UserId != null)
            {
                // Get The Data From Model
                if (model.aspNetSystemUsers.PurchaseAmountApprovalLimit != null)
                {
                    aspNetSystemUser.PurchaseAmountApprovalLimit = model.aspNetSystemUsers.PurchaseAmountApprovalLimit;
                    _mainSystemContext.AspNetSystemUsers.Update(aspNetSystemUser);
                    _mainSystemContext.SaveChanges();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return Json(result);
        }

        /// <summary>
        /// Ini Merupakan Batas Akhir Dari Kumpulan Code Diatas
        ///  
        /// --------------------------------------------------------
        /// 
        /// Selanjutnya Code Dibawah ini Merupakan Code yang Digunakan Pada Halaman Internal User Accuont Balimoon BMI
        /// </summary>
        /// 

        [Authorize(Roles = "Admin")]
        public IActionResult BMIIndex()
        {
            //Get Select Lis Location
            List<Models.BalimoonBMI.Locations> locations = _balimoonBMIContext.Locations.ToList();
            ViewBag.ListOfLocations = new SelectList(locations, "LocationCode", "LocationName");

            //Get Departement Code
            List<Models.BalimoonBMI.DimensionValue> dimensionValues = _balimoonBMIContext.DimensionValue.Where(a => a.DimensionCode == "DEPARTMENT").ToList();
            ViewBag.ListOfDimension = new SelectList(dimensionValues, "DimensionValueCode", "DimensionValueName");

            //Show the Form
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetBMIIndex([FromBody]DTParameters dtParameters)
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

            var join = from user in _mainSystemContext.AspNetUsers
                       join userrole in _mainSystemContext.AspNetUserRoles on user.Id equals userrole.UserId
                       join role in _mainSystemContext.AspNetRoles on userrole.RoleId equals role.Id
                       join UserBMI in _mainSystemContext.AspNetSystemUsers on user.Id equals UserBMI.UserId
                       where userrole.RoleId == "00050" || userrole.RoleId == "00051"
                       select new
                       {
                           UserId = UserBMI.UserId,
                           UserName = user.UserName,
                           RoleName = role.Name,
                           Departement = UserBMI.DepartmentCode,
                           Locations = UserBMI.LocationCode

                       };
            var result = join.ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.UserName != null && a.UserName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.RoleName != null && a.RoleName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Departement != null && a.Departement.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Locations != null && a.Locations.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            //Dapatkan Jumlah Total Record
            var filteredResultsCount = result.Count();
            var totalResultsCount = await _mainSystemContext.AspNetSystemUsers.CountAsync();

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
        public JsonResult GetBMIDetail(string UserId)
        {
            var result = string.Empty;
            //Get User Id on System User
            var aspNetSystemUser = _mainSystemContext.AspNetSystemUsers.Where(a => a.UserId == UserId).SingleOrDefault();

            //Join The Table To Get UserName
            if (aspNetSystemUser != null)
            {
                var join1 = (from User in _mainSystemContext.AspNetUsers
                             join UserRole in _mainSystemContext.AspNetUserRoles on User.Id equals UserRole.UserId
                             join Role in _mainSystemContext.AspNetRoles on UserRole.RoleId equals Role.Id
                             join SystemUser in _mainSystemContext.AspNetSystemUsers on User.Id equals SystemUser.UserId
                             where User.Id == aspNetSystemUser.UserId
                             select new
                             {
                                 UserId = User.Id,
                                 UserName = User.UserName,
                                 RoleAccess = Role.Name,
                                 DepartementCode = SystemUser.DepartmentCode,
                                 LocationCode = SystemUser.LocationCode
                             }).FirstOrDefault();
                var getDepartement = aspNetSystemUser.DepartmentCode;
                var getLocation = aspNetSystemUser.LocationCode;
                if (getDepartement != null && getDepartement != "")
                {
                    var join2 = (from departement in _balimoonBMIContext.DimensionValue
                                 where departement.DimensionValueCode == getDepartement
                                 select new
                                 {
                                     UserId = join1.UserId,
                                     UserName = join1.UserName,
                                     RoleAccess = join1.RoleAccess,
                                     DepartementCode = departement.DimensionValueCode
                                 }).FirstOrDefault();


                    if (getLocation != null && getLocation != "")
                    {
                        var join3 = (from location in _balimoonBMIContext.Locations
                                     where location.LocationCode == getLocation
                                     select new
                                     {

                                         UserId = join1.UserId,
                                         UserName = join1.UserName,
                                         RoleAccess = join1.RoleAccess,
                                         DepartementCode = join2.DepartementCode,
                                         LocationCode = location.LocationCode
                                     }).FirstOrDefault();
                        result = JsonConvert.SerializeObject(join3, Formatting.Indented, new JsonSerializerSettings
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                    }
                    else
                    {
                        result = JsonConvert.SerializeObject(join2, Formatting.Indented, new JsonSerializerSettings
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                    }
                }
                else if ((getDepartement == null && getDepartement == "") && (getLocation != null && getLocation != ""))
                {
                    var join3 = (from location in _balimoonBMIContext.Locations
                                 where location.LocationCode == getLocation
                                 select new
                                 {

                                     UserId = join1.UserId,
                                     UserName = join1.UserName,
                                     RoleAccess = join1.RoleAccess,
                                     LocationCode = location.LocationCode
                                 }).FirstOrDefault();
                    result = JsonConvert.SerializeObject(join3, Formatting.Indented, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                }
                else
                {
                    result = JsonConvert.SerializeObject(join1, Formatting.Indented, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                }
            }
            return Json(result);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public JsonResult UpdateBMIUser(BMIUserVM model)
        {
            var result = false;

            //Check System User ID Exist?
            var aspNetSystemUser = _mainSystemContext.AspNetSystemUsers.FirstOrDefault(a => a.UserId == model.aspNetSystemUsers.UserId);
            var getUserId = aspNetSystemUser.UserId;
            if (getUserId != null)
            {
                //Update Table where id = model.id
                if (model.aspNetSystemUsers.DepartmentCode != null && model.aspNetSystemUsers.LocationCode != null)
                {
                    aspNetSystemUser.DepartmentCode = model.aspNetSystemUsers.DepartmentCode;
                    aspNetSystemUser.LocationCode = model.aspNetSystemUsers.LocationCode;
                    _mainSystemContext.AspNetSystemUsers.Update(aspNetSystemUser);
                    _mainSystemContext.SaveChanges();
                    result = true;
                }
                else if (model.aspNetSystemUsers.DepartmentCode != null)
                {
                    aspNetSystemUser.DepartmentCode = model.aspNetSystemUsers.DepartmentCode;
                    _mainSystemContext.AspNetSystemUsers.Update(aspNetSystemUser);
                    _mainSystemContext.SaveChanges();
                    result = true;
                }
                else if (model.aspNetSystemUsers.LocationCode != null)
                {
                    aspNetSystemUser.LocationCode = model.aspNetSystemUsers.LocationCode;
                    _mainSystemContext.AspNetSystemUsers.Update(aspNetSystemUser);
                    _mainSystemContext.SaveChanges();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return Json(result);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddApprovalBMI()
        {
            //Get HOD Data
            var getlist = (from user in _mainSystemContext.AspNetUsers
                           join role in _mainSystemContext.AspNetUserRoles on user.Id equals role.UserId
                           join systemUser in _mainSystemContext.AspNetSystemUsers on user.Id equals systemUser.UserId
                           where role.RoleId == "00030" || role.RoleId == "00050"
                           select new
                           {
                               Id = user.Id,
                               UserName = user.UserName,
                               DepartmentCode = systemUser.DepartmentCode
                           }).ToList();

            ViewBag.ListOfHOD = new SelectList(getlist, "UserName", "UserName");

            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddBMIApproval([FromBody]DTParameters dtParameters)
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
            var jointbl = (from User in _mainSystemContext.AspNetUsers
                           join UserRole in _mainSystemContext.AspNetUserRoles on User.Id equals UserRole.UserId
                           join Role in _mainSystemContext.AspNetRoles on UserRole.RoleId equals Role.Id
                           join SystemUser in _mainSystemContext.AspNetSystemUsers on User.Id equals SystemUser.UserId
                           where Role.Id == "00050" || Role.Id == "00051"
                           select new
                           {
                               UserId = SystemUser.UserId,
                               UserName = User.UserName,
                               Role = Role.Name,
                               Department = SystemUser.DepartmentCode,
                               Approver = SystemUser.ApproverId
                           });
            var result = jointbl.ToList();

            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.UserName != null && a.UserName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Role != null && a.Role.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Department != null && a.Department.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }

            var getCountResult = (from SystemUser in _mainSystemContext.AspNetSystemUsers
                                  join UserRole in _mainSystemContext.AspNetUserRoles on SystemUser.UserId equals UserRole.UserId
                                  where UserRole.RoleId == "00050" || UserRole.RoleId == "00051"
                                  select new
                                  {
                                      Id = SystemUser.UserId
                                  }).ToList();

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            //Dapatkan Jumlah Total Record
            var filteredResultsCount = result.Count();

            var totalResultsCount = getCountResult.Count();
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

        [Authorize(Roles = "Admin")]
        public JsonResult SelectApprovalBMI(string UserId)
        {
            var result = string.Empty;

            //Get SystemUser Data
            var aspNetSystemUser = _mainSystemContext.AspNetSystemUsers.Where(a => a.UserId == UserId).SingleOrDefault();

            //Join Tabel To Get User Name
            var jointbl = (from systemUser in _mainSystemContext.AspNetSystemUsers
                           join user in _mainSystemContext.AspNetUsers on systemUser.UserId equals user.Id
                           join UserRole in _mainSystemContext.AspNetUserRoles on systemUser.UserId equals UserRole.UserId
                           join Role in _mainSystemContext.AspNetRoles on UserRole.RoleId equals Role.Id
                           where systemUser.UserId == UserId
                           select new
                           {
                               UserId = systemUser.UserId,
                               UserName = user.UserName,
                               Role = Role.Name,
                               ApproverId = systemUser.ApproverId
                           }).FirstOrDefault();
            result = JsonConvert.SerializeObject(jointbl, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(result);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public JsonResult UpdateBMIApproval(BMIUserVM model)
        {
            var result = false;

            var aspNetSystemUser = _mainSystemContext.AspNetSystemUsers.FirstOrDefault(a => a.UserId == model.aspNetSystemUsers.UserId);

            if (aspNetSystemUser.UserId != null)
            {
                // Get The Data From Model
                if (model.aspNetSystemUsers.ApproverId != null)
                {
                    aspNetSystemUser.ApproverId = model.aspNetSystemUsers.ApproverId;
                    _mainSystemContext.AspNetSystemUsers.Update(aspNetSystemUser);
                    _mainSystemContext.SaveChanges();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return Json(result);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult BudgetApprovalBMI()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult AddBMIBudget([FromBody]DTParameters dtParameters)
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
            var join = (from User in _mainSystemContext.AspNetUsers
                        join UserRole in _mainSystemContext.AspNetUserRoles on User.Id equals UserRole.UserId
                        join Role in _mainSystemContext.AspNetRoles on UserRole.RoleId equals Role.Id
                        join SystemUser in _mainSystemContext.AspNetSystemUsers on User.Id equals SystemUser.UserId
                        where Role.Id == "00050"
                        select new
                        {
                            UserId = SystemUser.UserId,
                            UserName = User.UserName,
                            Role = Role.Name,
                            Department = SystemUser.DepartmentCode,
                            MaksimumBudget = SystemUser.PurchaseAmountApprovalLimit
                        });
            var result = join.ToList();
            if (!String.IsNullOrEmpty(searchBy))
            {
                result = result.Where(a => a.UserName != null && a.UserName.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Role != null && a.Role.ToUpper().Contains(searchBy.ToUpper()) ||
                a.Department != null && a.Department.ToUpper().Contains(searchBy.ToUpper())
                ).ToList();
            }
            var getCountResult = (from SystemUser in _mainSystemContext.AspNetSystemUsers
                                  join UserRole in _mainSystemContext.AspNetUserRoles on SystemUser.UserId equals UserRole.UserId
                                  where UserRole.RoleId == "00050"
                                  select new
                                  {
                                      Id = SystemUser.UserId
                                  }).ToList();

            result = orderAscendingDirection ? result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Asc).ToList() : result.AsQueryable().OrderByDynamic(orderCriteria, LinqExtension.Order.Desc).ToList();

            //Dapatkan Jumlah Total Record
            var filteredResultsCount = result.Count();

            var totalResultsCount = getCountResult.Count();
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

        [Authorize(Roles = "Admin")]
        public JsonResult ManageBudgetBMI(string UserId)
        {
            var result = string.Empty;

            //Get SystemUser Data
            var aspNetSystemUser = _mainSystemContext.AspNetSystemUsers.Where(a => a.UserId == UserId).SingleOrDefault();

            //Join Tabel To Get User Name
            var jointbl = (from systemUser in _mainSystemContext.AspNetSystemUsers
                           join user in _mainSystemContext.AspNetUsers on systemUser.UserId equals user.Id
                           join UserRole in _mainSystemContext.AspNetUserRoles on systemUser.UserId equals UserRole.UserId
                           join Role in _mainSystemContext.AspNetRoles on UserRole.RoleId equals Role.Id
                           where systemUser.UserId == UserId
                           select new
                           {
                               UserId = systemUser.UserId,
                               UserName = user.UserName,
                               Role = Role.Name,
                               ApproverId = systemUser.ApproverId,
                               MaksimumBudget = systemUser.PurchaseAmountApprovalLimit
                           }).FirstOrDefault();
            result = JsonConvert.SerializeObject(jointbl, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(result);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public JsonResult UpdateBudgetBMI(BMIUserVM model)
        {
            var result = false;

            var aspNetSystemUser = _mainSystemContext.AspNetSystemUsers.FirstOrDefault(a => a.UserId == model.aspNetSystemUsers.UserId);

            if (aspNetSystemUser.UserId != null)
            {
                // Get The Data From Model
                if (model.aspNetSystemUsers.PurchaseAmountApprovalLimit != null)
                {
                    aspNetSystemUser.PurchaseAmountApprovalLimit = model.aspNetSystemUsers.PurchaseAmountApprovalLimit;
                    _mainSystemContext.AspNetSystemUsers.Update(aspNetSystemUser);
                    _mainSystemContext.SaveChanges();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return Json(result);
        }
    }
}