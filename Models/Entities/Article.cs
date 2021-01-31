using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Entities
{
    public class Article:BaseEntity
    {
        public string Heading { get; set; }
        public string Text { get; set; }


        //Relational Props

        public User User { get; set; }



    }
}