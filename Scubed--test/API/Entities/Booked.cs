using System;

namespace API.Entities
{
    public class Booked
    {
        public int Id { get; set; }

        public int AppUserId { get; set; }
        public int ProductId { get; set; }

        public DateTime DateBooked{ get; set; }

        public DateTime ReturnDue{ get; set; }

        public DateTime ActualReturn{ get; set; }
    }
}