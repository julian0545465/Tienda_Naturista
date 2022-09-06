using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Bussiness
{

    public class ProductsBussiness
    {

        Connection connection;


        public ProductsBussiness()
        {
            connection = new Connection();
        }
        public bool InsertProduct(Products products)
        {

            connection.Open();
            bool state = connection.Execute($"INSERT INTO `scrip`.`products`(`Code`,`Description`,`Value`,`Quantity`)VALUES({products.Code}, '{products.Description}', {products.Value}, {products.Quantity});");
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
        public DataSet ConsultValue(int code)
        {
                connection.Open();
                DataSet data = new DataSet();
                data = connection.Consult($"SELECT Value from scrip.products where Code  = {code};");
                connection.Close();
                return data;

            
        }
    }
}
