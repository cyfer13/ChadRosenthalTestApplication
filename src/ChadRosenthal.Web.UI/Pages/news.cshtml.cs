using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChadRosenthal.Web.UI.Pages
{
    public class NewsModel : PageModel
    {
        public string NewsMessage { get; private set; }

        public void OnGet(int? id)
        {
            if (id == null)
            {
                NewsMessage = "no id";
            }
            else
            {
                NewsMessage = id.Value.ToString();
            }
        }
    }
}