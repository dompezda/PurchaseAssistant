using System.Collections.Generic;

namespace PracaInz.Models
{
    public class List
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductList> ProductList { get; set; }

    }
}