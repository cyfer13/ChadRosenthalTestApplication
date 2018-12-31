using ChadRosenthal.Application.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChadRosenthal.Application.Services.Interfaces.Repository
{
    public interface INewsArticleRepository
    {
        NewsArticle Get(int id);

        NewsArticle Get(string slug);

        IEnumerable<NewsArticle> GetAll();

        IEnumerable<NewsArticle> GetMostRecent(int numberOfArticles);
    }
}
