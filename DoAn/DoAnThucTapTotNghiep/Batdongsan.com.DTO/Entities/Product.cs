using System;

namespace Batdongsan.com.DTO.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal price { get; set; }
        public string Address { get; set; }
        public string Acreage { get; set; }
        public int NumberOfFloors { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfToilets { get; set; }
        public string Description { get; set; }
        public bool Furniture { get; set; }
        public string Juridical { get; set; }
        public string HomeDirection { get; set; }
        public DateTime DateCreated { get; set; }
        public int ViewCount { get; set; }
        public bool Status { get; set; }
    }
}