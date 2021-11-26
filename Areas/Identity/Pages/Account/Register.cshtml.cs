using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using OfficeWork.Models;

namespace OfficeWork.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<Register> _signInManager;
        private readonly UserManager<Register> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<Register> userManager,
            SignInManager<Register> signInManager,
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

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }
            

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
            public string Device_id { get; set; }

            public string DateOfBirth { get; set; }
            public string Contact { get; set; }

            public string BloodGroup { get; set; }
            public string UserType { get; set; }
            public string Gender { get; set; }
            public string Bio { get; set; }
            public string First_name { get; set; }
            public string Middle_name { get; set; }
            public string Last_name { get; set; }
            public string NickName { get; set; }
            public string Address { get; set; }
            public string MaritalStatus { get; set; }

            public string Designation { get; set; }
            public string DesignationDate { get; set; }
            public string Company_id { get; set; }
            public string Department { get; set; }
            public string Branch { get; set; }

            public string Fb { get; set; }
            public string Linkedin { get; set; }
            public string Image { get; set; }
            public string City { get; set; }

            public DateTime UpdateDate { get; set; }
            public DateTime Addeddate { get; set; } = DateTime.Now;

            public DateTime EntrollDate { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new Register { UserName = Input.NickName,
                    Email = Input.Email,
                    Device_id = Input.Device_id,
                    DateOfBirth = Input.DateOfBirth,
                    Contact = Input.Contact,
                    BloodGroup = Input.BloodGroup,
                    UserType = Input.UserType,
                    Gender = Input.Gender,
                    Bio = Input.Bio,
                    First_name = Input.First_name,
                    Middle_name = Input.Middle_name,
                    Last_name = Input.Last_name,
                    Address = Input.Address,
                    MaritalStatus = Input.MaritalStatus,
                    Designation = Input.Designation,
                    DesignationDate = Input.DesignationDate,
                    Company_id = Input.Company_id,
                    Department = Input.Department,
                    Branch = Input.Branch,
                    

                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/Login",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
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
