using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class InventoryBussiness
    {
        Connection connection;
        public InventoryBussiness()
        {
            connection = new Connection();
        }

        public DataSet GetDataProduct(int code)
        {
            connection.Open();
            DataSet data = new DataSet();
            data = connection.Consult($"SELECT * FROM scrip3.products WHERE CODE = {code};");
            connection.Close();
            return data;

        }
    }
}
