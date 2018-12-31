using System;

namespace ChadRosenthal.Application.Domain
{
    public class NewsArticle
    {
        public int Id { get; private set; }

        public string Title { get; private set; }

        public string Author { get; private set; }

        public DateTime DatePosted { get; private set; }

        public string Slug { get; private set; }

        public string ShortDescription {get; private set; }

        public string Text { get; private set; }

        private NewsArticle() { }

        public NewsArticle(int id, string title, string author, DateTime datePosted, string slug, string shortDescription, string text)
        {
            Id = id;
            Title = title;
            Author = author;
            DatePosted = datePosted;
            Slug = slug;
            ShortDescription = shortDescription;
            Text = text;
        }
    }
}
