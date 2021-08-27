﻿using RestaurantReviews.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Data.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Review1 { get; set; }
        public int? RestaurantId { get; set; }
        public int? UserId { get; set; }
        public int? Stars { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual User User { get; set; }
    }
}
