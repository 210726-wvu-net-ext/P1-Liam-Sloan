﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RestaurantReviews.Data.Entities
{
    public partial class Review
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
