using System;

namespace LabAspMvc.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Pic { get; set; }
        public int Price { get; set; }

        public DateTime created { get; set; }
        public DateTime edited { get; set; }

        public int CategoryId { get; set; }
        public Category Categories { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
