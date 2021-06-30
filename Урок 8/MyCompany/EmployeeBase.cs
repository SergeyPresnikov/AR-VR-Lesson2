using MyCompany.Communication.MyCopmanyService;
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
        public MyCompanyServiceSoapClient myCompanyServiceSoapClient = new MyCompanyServiceSoapClient();

        public ObservableCollection<Employee> Staff { get; set; }


        public EmployeeBase()
        {
            Staff = new ObservableCollection<Employee>();
            Load();
        }


        public int Add(Employee employee)
        {
            var res = myCompanyServiceSoapClient.Add(employee);
            if(res > 0)
            {
                Staff.Add(employee);
            }
            return res;
        }


        public int Update(Employee employee)
        {
            return myCompanyServiceSoapClient.Update(employee);
           
        }

        public int Remove(Employee employee)
        {
            var res = myCompanyServiceSoapClient.Remove(employee);
            if (res > 0)
            {
                Staff.Remove(employee);
            }
            return res;
        }

        public void Load()
        {
            foreach (var employee in myCompanyServiceSoapClient.Load()) 
            {
                Staff.Add(employee);
            }
        }      
    }
}
