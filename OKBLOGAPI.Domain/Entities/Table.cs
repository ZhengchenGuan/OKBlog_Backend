using System;

namespace OKBLOGAPI.Domain.Entities
{
    public class Table
    {
        public Guid Id { get; set; }

        public Guid RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }

        public int Position { get; set; }
    }
}
