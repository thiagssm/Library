﻿using Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.Book
{
    public class BookViewModel
    {
        public BookViewModel(string title, string description, string author, string iSBN, string publisher, string category, int publicationYear, int pageCount, string coverImage, decimal averageRating, List<Rating> ratings)
        {
            Title = title;
            Description = description;
            Author = author;
            ISBN = iSBN;
            Publisher = publisher;
            Category = category;
            PublicationYear = publicationYear;
            PageCount = pageCount;
            CoverImage = coverImage;
            AverageRating = averageRating;
            Ratings = ratings;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public string Publisher { get; private set; }
        public string Category { get; private set; }
        public int PublicationYear { get; private set; }
        public int PageCount { get; private set; }
        // Adicionar os bytes criptografados quando for utilizar a CoverImage
        public string CoverImage { get; private set; }
        public decimal AverageRating { get; private set; }
        public List<Rating> Ratings { get; private set; }
    }
}
