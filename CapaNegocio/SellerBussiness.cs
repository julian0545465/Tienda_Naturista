using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class SellerBussiness
    {
        Connection connection;

        public SellerBussiness()
        {
            connection = new Connection();
        }
        public DataSet GetData()
        {
            connection.Open();
            DataSet data = new DataSet();
            data = connection.Consult($"SELECT * FROM scrip.employee;");
            connection.Close();
            return data;

        }

        public DataSet GetDataSeller(int user)
        {
            connection.Open();
            DataSet data = new DataSet();
            data = connection.Consult($"SELECT * FROM scrip.products WHERE User = {user};");
            connection.Close();
            return data;

        }
    }
}