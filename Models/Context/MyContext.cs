using Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Context
{
    public class MyContext:DbContext
    {
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }





    }
}