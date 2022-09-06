using MySql.Data.MySqlClient;
using System.Data;

namespace DataAccess
{
    public class Connection
    {
        string cadenaConexion = "Server=Localhost;User=root;Password=julian05;Port=3306;database=scrip2";

        MySqlConnection mySqlConnection;

        public Connection()
        {
            mySqlConnection = new MySqlConnection(this.cadenaConexion);
        }
        public bool Open()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexión no fue exitosa." + ex.Message);
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexión no se pudo cerrar." + ex.Message);
                return false;
            }
        }

        public bool Execute(string query)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                if (mySqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El query no se ejecuto." + ex.Message);
                return false;
            }
        }


        public DataSet Consult(string query)
        {
            DataSet dataSet = new DataSet();
            try
            {
                MySqlDataAdapter Adaptador = new MySqlDataAdapter(query, mySqlConnection);
                Adaptador.Fill(dataSet, "tbl");

                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El select no se ejecuto." + ex.Message);
                return dataSet;
            }
        }
    }
}