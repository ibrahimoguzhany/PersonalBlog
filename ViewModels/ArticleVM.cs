using Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.ViewModels
{
    public class ArticleVM
    {
        public Article Article { get; set; }
        public User User { get; set; }
        public List<Article> Articles { get; set; }
        public List<Comment> Comments { get; set; }

    }
}