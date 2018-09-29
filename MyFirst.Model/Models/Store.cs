using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirst.Model.Models
{
    public class Store:Base
    {
        public string Name { get; set; }
        public int NumberOfProducts { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }
}
