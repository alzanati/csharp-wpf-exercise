using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace csharp_wpf_exercise.Models
{
    public class SalesDbAdoModel : IDisposable
    {
        private const string ConnectionString = "Data Source = DESKTOP-L1P2R3A; Initial Catalog = salesdb; User ID = sa; Password = 123";

        private static readonly SalesDbAdoModel _salesDbAdoModel = new SalesDbAdoModel();

        public static SalesDbAdoModel Instance => _salesDbAdoModel;

        private SqlConnection _sqlConnection;

        private SqlDataReader _sqlDataReader;

        private SqlCommand _sqlCommand;

        public SalesDbAdoModel()
        {
            _sqlConnection = new SqlConnection(ConnectionString);
            _sqlCommand = new SqlCommand();
        }

        public List<string> GetUniqueCustomers(string commandText = "")
        {
            var queryResult = new List<string>();
            _sqlConnection.Open();
            _sqlCommand.CommandText = commandText;
            _sqlCommand.Connection = _sqlConnection;
            _sqlDataReader = _sqlCommand.ExecuteReader();

            while (_sqlDataReader.Read())
                queryResult.Add(_sqlDataReader[0].ToString());

            _sqlConnection.Close();
            return queryResult;
        }

        public void Dispose()
        {
            _sqlDataReader?.Close();
            _sqlConnection?.Close();
            _sqlCommand?.Dispose();
        }
    }
}
