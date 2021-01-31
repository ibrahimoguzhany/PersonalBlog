using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Entities
{
    public class Comment:BaseEntity
    {
        public string Text { get; set; }


        public User User { get; set; }

    }
}