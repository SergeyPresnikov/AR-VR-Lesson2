using MyCompony.Employee;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    public class EmployeeBase
    {

        public const string ConnectionString = "Data Source=HOME-PS\\SQLEXPRESS;Initial Catalog=MyCompanyPSA;User ID=MyCompanyPSA;Password=123456";

        private static int CHAR_BOUND_L = 65; // Номер начального символа (для генерации последовательности символов)
        private static int CHAR_BOUND_H = 90; // Номер конечного  символа (для генерации последовательности символов)
        private Random random = new Random();

        public ObservableCollection<Employee> Staff { get; set; }


        public EmployeeBase()
        {
            Staff = new ObservableCollection<Employee>();
            LoadFromEmployeeBase();
        }


        public int Add(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sqlExpression = $@"INSERT INTO Staff (LastName, FirstName, SecondName, CategoryID)
                    VALUES('{employee.LastName}', '{employee.FirstName}', '{employee.SecondName}',{(int)employee.Category})";
                var command = new SqlCommand(sqlExpression, connection);
                var res = command.ExecuteNonQuery();
                if (res > 0)
                {
                    Staff.Add(employee);
                }
                return res;
            }
        }


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

        public int Remove(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlExpression = $@"DELETE FROM Staff WHERE LastName = '{employee.LastName}'";
                var command = new SqlCommand(sqlExpression, connection);
                var res = command.ExecuteNonQuery();
                if (res > 0)
                {
                    Staff.Remove(employee);
                }
                return res;
            }
        }

        public void LoadFromEmployeeBase()
        {
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
                        Staff.Add(employee);
                    }
                }
            }
        }      
    }
}
