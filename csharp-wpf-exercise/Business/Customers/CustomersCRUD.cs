using System.Collections.Generic;
using System.Linq;
using csharp_wpf_exercise.Models;
using csharp_wpf_exercise.ViewModels;

namespace csharp_wpf_exercise.Business.Customers
{
    internal class CustomersCrud
    {
        public static List<Customer> GetAllCustomers()
        {
            return SalesDbObject.Instance.Customers.ToList();
        }
    }
}
