using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChadRosenthal.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChadRosenthal.Web.UI.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginViewModel LoginViewModel { get; set; }

        public string Message { get; private set; }

        public async void OnGetAsync()
        {
            if (LoginViewModel == null)
            {
                LoginViewModel = new LoginViewModel();
            }

            Message = "hi";
        }

        public async void OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                Message = "valid";
            }
            else
            {
                Message = "invalid";
            }
        }
    }
}