using MyCompony.Employee;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyCompany.WebService
{
    /// <summary>
    /// Сводное описание для MyCompanyService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class MyCompanyService : System.Web.Services.WebService
    {
        public string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompanyConnectionString"].ConnectionString; 
           

        [WebMethod]
        public ObservableCollection<Employee> Load()
        {
            ObservableCollection<Employee> staff = new ObservableCollection<Employee>();
            string sqlExpression = "SELECT * FROM Staff";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        var employee = new Employee();
                        employee.LastName = reader["LastName"].ToString();
                        employee.FirstName = reader["FirstName"].ToString();
                        employee.SecondName = reader["SecondName"].ToString();
                        employee.Category = (DepartmentCategory)reader.GetInt32(3);
                        staff.Add(employee);
                    }
                }
                return staff;
            }
        }

        [WebMethod]
        public int Add(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sqlExpression = $@"INSERT INTO Staff (LastName, FirstName, SecondName, CategoryID)
                    VALUES('{employee.LastName}', '{employee.FirstName}', '{employee.SecondName}',{(int)employee.Category})";
                var command = new SqlCommand(sqlExpression, connection);
                return command.ExecuteNonQuery();
            }
        }

        [WebMethod]
        public int Update(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlExpression = $@"UPDATE Staff
                    SET FirstName ='{employee.FirstName}', SecondName = '{employee.SecondName}', CategoryId = {(int)employee.Category}
                    WHERE LastName = '{employee.LastName}'";
                var command = new SqlCommand(sqlExpression, connection);
                return command.ExecuteNonQuery();
            }
        }

        [WebMethod]
        public int Remove(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlExpression = $@"DELETE FROM Staff WHERE LastName = '{employee.LastName}'";
                var command = new SqlCommand(sqlExpression, connection);
                return command.ExecuteNonQuery();
            }
        }

       
    }
}
