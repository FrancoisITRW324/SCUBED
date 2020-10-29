using System;

namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public DateTime DatePublished { get; set; }

        public string Publisher { get; set; }

        public string Name { get; set; }
    }
}