using ChadRosenthal.Application.Domain;
using System;
using System.Collections.Generic;

namespace ChadRosenthal.Application.Services
{
    public interface INewsService
    {
        IEnumerable<NewsArticle> GetMostRecent(int numberOfArticles);

        IEnumerable<NewsArticle> GetAll();

        NewsArticle Get(int id);

        NewsArticle Get(string slug);
    }
}
