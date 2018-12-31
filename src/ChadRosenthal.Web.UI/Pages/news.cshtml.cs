using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChadRosenthal.Application.Domain;
using ChadRosenthal.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChadRosenthal.Web.UI.Pages
{
    public class NewsModel : PageModel
    {
        private readonly INewsService _newsService;

        public bool DisplaySingleArticle { get; private set; }

        public IList<NewsArticle> Articles { get; private set; }

        public NewsArticle SingleArticle { get; private set; }


        public NewsModel(INewsService newsService)
        {
            this._newsService = newsService;
        }

        public void OnGet(string slug)
        {
            if (string.IsNullOrEmpty(slug))
            {
                DisplaySingleArticle = false;
                Articles = _newsService.GetAll().ToList();
            }
            else
            {
                DisplaySingleArticle = true;
                SingleArticle = _newsService.Get(slug);
            }
        }
    }
}