using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoplistMauiBlazorHybrid.Models
{
    public class Shoplist
    {
        public int Id { get; set; }
        public string Item { get; set; } = string.Empty;
        public int Amount { get; set; }
    }


}
