using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Balimoon_E_Procurement.Models;
using Microsoft.AspNetCore.Authorization;

namespace Balimoon_E_Procurement.Controllers
{
    public class UsersController : Controller
    {
        private readonly MainSystemContext _context;

        public UsersController(MainSystemContext context)
        {
            _context = context;
        }

        // GET: Users
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            // return View(await _context.AspNetUsers.ToListAsync());
            var db = new MainSystemContext();
            var join = from a in db.AspNetUsers
                       join b in db.AspNetUserRoles on a.Id equals b.UserId

                       join c in db.AspNetRoles on b.RoleId equals c.Id

                       select new UserRoleVM
                       {
                           userroletbl = b,
                           usertbl = a,
                           roletbl = c
                       };
            return View(join);
        }

        //Get: Users/Waiting
        [Authorize(Roles="Admin")]
        public ActionResult Waiting()
        {
            var waiting = _context.AspNetUsers.Where(a => a.EmailConfirmed == false);
            return View(waiting);
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

        // GET: Users/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AspNetUsers aspNetUsers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aspNetUsers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aspNetUsers);
        }

        // GET: Users/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspNetUsers = await _context.AspNetUsers.FindAsync(id);
            if (aspNetUsers == null)
            {
                return NotFound();
            }
            return View(aspNetUsers);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AspNetUsers aspNetUsers)
        {
            if (id != aspNetUsers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aspNetUsers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AspNetUsersExists(aspNetUsers.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aspNetUsers);
        }

        // GET: Users/Delete/5
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Delete(string id)
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

            return View(aspNetUsers);
        }

        // POST: Users/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var aspNetUsers = await _context.AspNetUsers.FindAsync(id);
            _context.AspNetUsers.Remove(aspNetUsers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AspNetUsersExists(string id)
        {
            return _context.AspNetUsers.Any(e => e.Id == id);
        }

        //Get Data User to Tabel User Role With Left Join
        [Authorize(Roles ="Admin")]
        [HttpGet]
        public ActionResult Userrole()
        {
            var join = from user in _context.AspNetUsers
                       join userrole in _context.AspNetUserRoles on user.Id equals userrole.UserId
                       into Details
                       from defaultVal in Details.DefaultIfEmpty()
                       join role in _context.AspNetRoles on defaultVal.RoleId equals role.Id
                       into Details2
                       from defaultval2 in Details2.DefaultIfEmpty()
                       where user.EmailConfirmed == true
                       select new UserRoleVM
                       {
                           usertbl = user,
                           userroletbl = defaultVal,
                           roletbl = defaultval2
                       };

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
            var cekid = _context.AspNetUserRoles.Where(a => a.UserId == id);

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
    }
}
