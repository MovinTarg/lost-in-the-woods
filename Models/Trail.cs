using System;
using System.ComponentModel.DataAnnotations;
using Lost_in_the_Woods.Models;

namespace Lost_in_the_Woods.Models
{
    public class Trail : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Length { get; set; }
        public float Elevation { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}