using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Data;
using System.Data.SqlClient;
using CustomerApp.Models;

namespace CustomerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAppController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public CustomerAppController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                            select * from Customer_tbl
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("CustomerAppCon");
            SqlDataReader myReader;

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Customer customer)
        {
           string query = @"
                          INSERT INTO Customer_tbl(Name,Surname,[Cell Number],[Physical Address],[Postal Address],Comment)
	                      VALUES (@Name, @Surname, @Cell_Number,@Physical_Address,@Postal_Address,@Comment)
                         ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("CustomerAppCon");
            SqlDataReader myReader;

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Name", customer.Name); 
                    myCommand.Parameters.AddWithValue("@Surname", customer.Surname); 
                    myCommand.Parameters.AddWithValue("@Cell Number", customer.Cell_Number);
                    myCommand.Parameters.AddWithValue("@Physical Address", customer.Physical_Address);
                    myCommand.Parameters.AddWithValue("@Postal Address", customer.Postal_Address);
                    myCommand.Parameters.AddWithValue("@Comment", customer.Comment);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);
        }
    }
}
