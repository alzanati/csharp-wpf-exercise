using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_wpf_exercise.Models;

namespace csharp_wpf_exercise.Business.Products
{
    internal class HighestProductV
    {
        public static List<highest_product_v> GetHighestProducts()
        {
            return SalesDbObject.Instance.highest_product_v.ToList();
        }
    }
}
