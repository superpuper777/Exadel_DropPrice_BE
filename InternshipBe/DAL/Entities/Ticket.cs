﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        public User User { get; set; }

        public int DiscountId { get; set; }
        
        public Discount Discount { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
    }
}
