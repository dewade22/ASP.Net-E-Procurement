using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Balimoon_E_Procurement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Balimoon_E_Procurement.Services;

namespace Balimoon_E_Procurement.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        public readonly List<AspDepartement> db = new List<AspDepartement>();

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "User Name")]
            public string UserName { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }
        //tambahan tgl 12/07/19 untuk setting email confirmation
       
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                
                var user = new IdentityUser { UserName = Input.UserName, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var callbackUrl = Url.EmailConfirmationLink(user.Id, code, Request.Scheme);
                     var callbackUrl = Url.Page(
                         "/Account/ConfirmEmail",
                         pageHandler: null,
                         values: new { userId = user.Id, userEmail=user.Email, Code = code },
                         protocol: Request.Scheme);
                         
                    await _emailSender.SendEmailAsync(Input.Email, "Konfirmasi Email Anda",
                        $"Terimakasih telah mendaftar.<br>"+
                        $"Akun anda dengan rincian sebagai berikut: <br>" +
                        $"-------------------------------<br>" +
                        $"User Name = " +user.UserName+ "<br> " +
                        $"E-Mail = "+user.Email+ "<br> " +
                        $"Password = " + Input.Password + " <br>" +
                        $"-------------------------------" + " <br>" +
                        $"Akan segera diaktifkan ketika anda mengklik tautan dibawah ini <br>" +
                        $" <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>Klik Disini</a>.<br>"+
                        $"<br>" +
                        $"====================================================================================================<br>" +
                        $"<br>" +
                        $"Thanks for signing up<br>" +
                        $"Your account has been created,<br>" +
                        $"You can login with the following credentials after you have activated your account by pressing the link below.<br>" +
                        $"-------------------------------<br>" +
                        $"User Name = " +user.UserName+ " <br> " +
                        $"E-Mail = " + user.Email + "<br> " +
                        $"Password = " + Input.Password + " <br>" +
                        $"-------------------------------<br>" +
                        $"Please click this link to activate your account:<br>" +
                        $"<a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>Click Here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                   return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
