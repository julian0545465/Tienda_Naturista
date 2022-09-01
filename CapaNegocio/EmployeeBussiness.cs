using DataAccess;
using Entities;
using System.Data;

namespace Bussiness
{
    public class EmployeeBussiness
    {
        Connection connection;
        public EmployeeBussiness()
        {
            connection = new Connection();
        }

        public bool SelectEmployee(Employee employee)
        {
            
            connection.Open();
            DataSet data = new DataSet();
            data = connection.Consult($"SELECT * FROM scrip.employee WHERE USER='{employee.User}' AND PASSWORD='{employee.Password}';");
            connection.Close();
            if (data.Tables[0].Rows.Count > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }




    }
}
