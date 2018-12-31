using System;
using System.Collections.Generic;
using ChadRosenthal.Application.Domain;
using ChadRosenthal.Application.Services.Interfaces.Repository;

namespace ChadRosenthal.Application.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsArticleRepository _newsArticleRepository;

        public NewsService(INewsArticleRepository newsArticleRepository)
        {
            this._newsArticleRepository = newsArticleRepository;
        }

        public NewsArticle Get(int id)
        {
            return _newsArticleRepository.Get(id);
        }

        public NewsArticle Get(string slug)
        {
            return _newsArticleRepository.Get(slug);
        }

        public IEnumerable<NewsArticle> GetAll()
        {
            return _newsArticleRepository.GetAll();
        }

        public IEnumerable<NewsArticle> GetMostRecent(int numberOfArticles)
        {
            return _newsArticleRepository.GetMostRecent(numberOfArticles);
        }
    }
}
