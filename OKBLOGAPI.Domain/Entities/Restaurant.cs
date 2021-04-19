using System;
using System.Collections.Generic;

namespace OKBLOGAPI.Domain.Entities
{
    public class Restaurant
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<Table> Tables { get; set; }
    }
}
