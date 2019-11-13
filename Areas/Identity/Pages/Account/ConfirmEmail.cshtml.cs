using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;

using System.Threading.Tasks;
using Balimoon_E_Procurement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Balimoon_E_Procurement.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ConfirmEmailModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly MainSystemContext _mainSystemContext;
        private readonly IEmailSender _emailSender;

        public ConfirmEmailModel(UserManager<IdentityUser> userManager,
            IEmailSender emailSender,
            MainSystemContext mainSystemContext)
        {
            _mainSystemContext = mainSystemContext;
            _userManager = userManager;
            _emailSender = emailSender;
        }

        public async Task<IActionResult> OnGetAsync(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException($"Error confirming email for user with ID '{userId}':");
            }

            //disini ditambahkan email untuk admin & purchasing bahwa ada email masuk
            var getRuleAdm = _mainSystemContext.AspNetUserRoles.Where(a => a.RoleId == "00010" || a.RoleId == "00060").ToArray();
            var countUser = getRuleAdm.Count();
            //var
            for(var i=0; i<countUser; i++)
            {
                //Dapatkan ID User
                var getUID = getRuleAdm[i].UserId;
                //dapatkan email
                var getUserinTable = _mainSystemContext.AspNetUsers.FirstOrDefault(a => a.Id == getUID);
                //get user by user manager
                var GetUserinUM = await _userManager.FindByIdAsync(getUID);
               

                //kirim Emailnya
                await _emailSender.SendEmailAsync(getUserinTable.Email, "User Baru Terdaftar",
                    $"Dear "+getUserinTable.UserName+",<br>" +
                    $"Ada User Baru Dengan Username : <b>"+user.UserName+"</b> telah terdaftar<br>" +
                    $"Segera <a href='https://"+this.Request.Host+ "/Users/Userrole'>Masuk Kedalam Sistem</a> untuk meninjau dan memberikan role kepada user baru tersebut.<br>" +
                    $"Regards,<br>" +
                    $"BalimOOn - IT Team"
                    );
            }

            return Page();
        }
    }
}
