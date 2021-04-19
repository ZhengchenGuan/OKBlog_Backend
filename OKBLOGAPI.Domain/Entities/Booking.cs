using System;

namespace OKBLOGAPI.Domain.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }

        public Customer Customer { get; set; }

        public Table Table { get; set; }

        public DateTime Date { get; set; }
    }
}
