using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasP8
{
    public class Order
    {
        public Guid Id { get; set; } //primary key di database
        public string Kopi { get; set; } = string.Empty;
        public string Gula { get; set; } = string.Empty;
        public string Topping { get; set; } = string.Empty;
        public int Harga { get; set; }
        public DateTime Waktu { get; set; }
    }
}
