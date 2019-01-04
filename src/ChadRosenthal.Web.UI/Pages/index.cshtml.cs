using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChadRosenthal.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ChadRosenthal.Web.UI.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; }

        private readonly ILogger _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogDebug("index page loaded");
            Message = "this is the message";
        }
    }
}