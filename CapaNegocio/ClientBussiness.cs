using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class ClientBussiness
    {
        Connection connection;
        public ClientBussiness()
        {
            connection = new Connection();
        }
        public bool InsertClient(Client client)
        {

            connection.Open();
            bool state = connection.Execute($"INSERT INTO `scrip3`.`cliente`(`Document`,`Name`,`Address`,`Numberphone`, `Email`)VALUES('{client.Document}', '{client.Name}', '{client.Address}', '{client.Numberphone}', '{client.Email}');");
            connection.Close();
            return state;
            

        }

        public bool UpdateClient(Client client)
        {

            connection.Open();
            bool state = connection.Execute($"update `scrip3`.`cliente` set Document='{client.Document}',Name='{client.Name}',Address='{client.Address}',Numberphone='{client.Numberphone}',Email='{client.Email}' WHERE DOCUMENT= {client.Document};");
            connection.Close();
            return state;
           
        }

        public bool DeleteClient(int document)
        {

            connection.Open();
            bool state = connection.Execute($"delete FROM`scrip3`.`cliente` WHERE DOCUMENT= '{document}';");
            connection.Close();
            return state;
            //DELETE FROM `scrip`.`client` WHERE(`Document` = '12');

        }

        public DataSet GetData()
        {
            connection.Open();
            DataSet data = new DataSet();
            data = connection.Consult($"SELECT * FROM scrip3.cliente;");
            connection.Close();
            return data;

        }

        public DataSet GetDataClient(int document)
        {
            connection.Open();
            DataSet data = new DataSet();
            data = connection.Consult($"SELECT * FROM scrip3.cliente WHERE DOCUMENT = '{document}';");
            connection.Close();
            return data;

        }

    }
}