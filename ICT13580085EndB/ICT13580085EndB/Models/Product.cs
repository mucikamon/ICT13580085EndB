using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ICT13580085EndB.Models
{
    public class Product
    {
        [PrimaryKey , AutoIncrement]
        public int Id { get; set; }

        public string Category { get; set; }

        public string Brand { get; set; }

        public string Gen { get; set; }

        public decimal Years { get; set; }

        public decimal Miles { get; set; }
        public string Color { get; set; }
        public string Deler { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Province { get; set; }
        public decimal Tel { get; set; }


    }
}
