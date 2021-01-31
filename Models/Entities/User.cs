using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Entities
{
    public class User:BaseEntity
    {
        
        public string Name { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }


        //Relational Properties
        public List<Article> Articles { get; set; }
        public List<Comment> Comments{ get; set; }


    }
}