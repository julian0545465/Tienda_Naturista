using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
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
        public bool InsertProduct(Client client)
        {

            connection.Open();
            bool state = connection.Execute($"INSERT INTO `scrip`.`client`(`Code`,`Description`,`Value`,`Quantity`)VALUES({client.Document}, '{client.Name}', {client.Address}, {client.Numberphone}, {client.Email});");
            connection.Close();
            return state;

        }

        public bool UpdateProduct(Products products)
        {

            connection.Open();
            bool state = connection.Execute($"update `scrip`.`products` set Quantity={products.Quantity},Description='{products.Description}',Value={products.Value} WHERE CODE= {products.Code};");
            connection.Close();
            return state;

        }

        public bool DeleteProduct(int code)
        {

            connection.Open();
            bool state = connection.Execute($"delete FROM`scrip`.`products` WHERE CODE= {code};");
            connection.Close();
            return state;

        }

        public DataSet GetData()
        {
            connection.Open();
            DataSet data = new DataSet();
            data = connection.Consult($"SELECT * FROM scrip.products;");
            connection.Close();
            return data;

        }

        public DataSet GetDataProduct(int code)
        {
            connection.Open();
            DataSet data = new DataSet();
            data = connection.Consult($"SELECT * FROM scrip.products WHERE CODE = {code};");
            connection.Close();
            return data;

        }

    }
}