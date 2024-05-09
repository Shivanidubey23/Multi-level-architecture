using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Ecommerce.DAL.Helper
{
    public class ECommerceDbHelper
    {
        private readonly string _connectionString;

        public ECommerceDbHelper(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public DataTable ExecuteStoredProcedure(string storedProcName, Dictionary<string, object> parameters)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand(storedProcName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                // Handle exception appropriately, e.g., log it
                Console.WriteLine($"Error executing stored procedure: {ex.Message}");
                throw;
            }
        }
    }
}
