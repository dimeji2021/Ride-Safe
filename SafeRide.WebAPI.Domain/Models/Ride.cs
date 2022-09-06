﻿using SafeRide.WebAPI.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Ride
    {
        [Key]
        public string RideId { get; set; } 
        public int Rating { get; set; }
        [Required]
        public string PickUpLocation { get; set; }
        [Required]
        public string Destination { get; set; } 
        public decimal Payment { get; set; }
        public double DistanceCovered { get; set; }
        [Required]
        public bool Completed { get; set; }
        public DateTime CreatedAt { get; set; }

        public Reviews Reviews { get; set; }

        public Payment Payments { get; set; }

        public string DriverId { get; set; } 
        public Drivers? Cars { get; set; }

        public string CustomersId { get; set; } 
        public Customer? Customer { get; set; }
    }
}
