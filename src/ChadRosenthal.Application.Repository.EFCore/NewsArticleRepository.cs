using ChadRosenthal.Application.Domain;
using ChadRosenthal.Application.Repository.EFCore;
using ChadRosenthal.Application.Services.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChadRosenthal.Application.Repository.EFCore
{
    public class NewsArticleRepository : INewsArticleRepository
    {
        private readonly ChadRosenthalContext _context;

        public NewsArticleRepository(ChadRosenthalContext context)
        {
            _context = context;
        }

        public NewsArticle Get(int id)
        {
            return _context.NewsArticles.FirstOrDefault(x => x.Id == id);
        }

        public NewsArticle Get(string slug)
        {
            if (string.IsNullOrEmpty(slug))
            {
                throw new ArgumentNullException("slug cannot be empty or null");
            }

            return _context.NewsArticles.FirstOrDefault(x => x.Slug == slug.ToLower());
        }

        public IEnumerable<NewsArticle> GetAll()
        {
            return _context.NewsArticles;
        }

        public IEnumerable<NewsArticle> GetMostRecent(int numberOfArticles)
        {
            if (numberOfArticles <=0)
            {
                throw new ArgumentOutOfRangeException("number of articles needs to be greater than 0");
            }

            return _context.NewsArticles.OrderByDescending(x => x.DatePosted).Take(numberOfArticles);
        }
    }
}