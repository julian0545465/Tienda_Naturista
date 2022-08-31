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
    }
}
