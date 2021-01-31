﻿using Portfolio.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Entities
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus? Status { get; set; }
    }
}