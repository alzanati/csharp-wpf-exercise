using System.Collections.ObjectModel;
using csharp_wpf_exercise.Models;

namespace csharp_wpf_exercise.ViewModels
{
    internal class CustomerViewModel : Base
    {
        private ObservableCollection<string> _customersCollection;

        public ObservableCollection<string> CustomersCollection
        {
            get { return _customersCollection; }
            private set
            {
                _customersCollection = value;
                OnPropertyChanged();
            }
        }

        public CustomerViewModel()
        {
            using (var salesDbAdo = SalesDbAdoModel.Instance)
            {
                const string cmdTxt = @"SELECT DISTINCT FirstName FROM Customers";
                var data = salesDbAdo.GetUniqueCustomers(cmdTxt);
                CustomersCollection = new ObservableCollection<string>(data);
            }
        }
    }
}
