using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class SignedInUser
    {
        /// <summary>
        /// Validation for a user-sign in
        /// </summary>

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
