using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerWeb_App.Data;

namespace CustomerWeb_App.Data
{
    public static class ServicesExtensions
    {
        public static string CustomersConnectionString { get; set; }

        public static void CustomersConnectionStringService(this IServiceCollection services, string connectionString)
        {
            System.Data.SqlClient.SqlConnection myCon = new System.Data.SqlClient.SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CustomersDB;Integrated Security=True");

            CustomersConnectionString = connectionString;

            Microsoft.Data.SqlClient.SqlConnectionStringBuilder builder = new Microsoft.Data.SqlClient.SqlConnectionStringBuilder(connectionString)
            {
                ColumnEncryptionSetting = SqlConnectionColumnEncryptionSetting.Enabled
            };
            CustomersConnectionString = builder.ConnectionString;
        }
    }
}
