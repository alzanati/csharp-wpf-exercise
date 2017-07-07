using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_wpf_exercise.Models;

namespace csharp_wpf_exercise.Business
{
    internal class SalesDbObject : salesdbEntities
    {
        private static readonly SalesDbObject _instance = new SalesDbObject();

        public static SalesDbObject Instance => _instance;

        private SalesDbObject()
        {
            
        }
    }
}
