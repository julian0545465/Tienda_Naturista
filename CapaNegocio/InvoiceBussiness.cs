using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class InvoiceBussiness
    {
        public int ConsultarPrecioFac(int Codigo)
        {
            string cadenaConexion = "Server=Localhost;User=root;Password=julian05;Port=3306;database=scrip3";

            int Precio = 0;
            DataTable tabla = new DataTable();
            try
            {
                using (var adaptador = new MySqlDataAdapter("select Value from products where Code=" + Codigo, cadenaConexion))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);
                    Precio = Convert.ToInt16(tabla.Rows[0][0]);
                }

            }
            catch (MySqlException e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return Precio;
        }

    }
}
