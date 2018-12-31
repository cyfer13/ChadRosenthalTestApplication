using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChadRosenthal.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChadRosenthal.Web.UI.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; }

        private readonly ITestInterface testInterface;

        public IndexModel(ITestInterface testInterface)
        {
            this.testInterface = testInterface;
        }
        public void OnGet()
        {
            Message = testInterface.Add();
        }
    }
}