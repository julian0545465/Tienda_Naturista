using MySql.Data.MySqlClient;
using System.Data;

namespace DataAccess
{
    public class Connection
    {
        string cadenaConexion = "Server=Localhost;User=root;Password=julian05;Port=3306;database=scrip";

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

  //              CREATE TABLE `scrip2`.`client` (
  //`Document` INT NOT NULL,
  //`Name` VARCHAR(45) NOT NULL,
  //`Address` VARCHAR(50) NOT NULL,
  //`Numberphone` INT NOT NULL,
  //`Email` VARCHAR(45) NOT NULL,
  //PRIMARY KEY(`Document`),
  //UNIQUE INDEX `Name_UNIQUE` (`Name` ASC) VISIBLE,
  //UNIQUE INDEX `Document_UNIQUE` (`Document` ASC) VISIBLE);


  //              CREATE TABLE `scrip2`.`invoice` (
  //`Number` INT NOT NULL,
  //`Date` DATE NOT NULL,
  //`IdClient` INT NOT NULL,
  //`TotalValue` INT NOT NULL,
  //`IdEmployee` INT NOT NULL,
  //PRIMARY KEY(`Number`),
  //INDEX `fk_client_Invoice_idx` (`IdClient` ASC) VISIBLE,
  //INDEX `fk_Employee_Invoice_idx` (`IdEmployee` ASC) VISIBLE,
  //CONSTRAINT `fk_client_Invoice`
  //  FOREIGN KEY(`IdClient`)
  //  REFERENCES `scrip`.`client` (`Document`),
  //CONSTRAINT `fk_Employee_Invoice`
  //  FOREIGN KEY(`IdEmployee`)
  //  REFERENCES `scrip`.`employee` (`IdEmployee`));


  //              CREATE TABLE `scrip2`.`detail` (
  //`IdDetail` INT NOT NULL,
  //`Number` INT NOT NULL,
  //`Product` VARCHAR(45) NOT NULL,
  //`Code` INT NOT NULL,
  //PRIMARY KEY(`IdDetail`),
  //INDEX `fk_products_detail_idx` (`Code` ASC) VISIBLE,
  //INDEX `fk_Invoice_detail_idx` (`Number` ASC) VISIBLE,
  //CONSTRAINT `fk_Invoice_detail`
  //  FOREIGN KEY(`Number`)
  //  REFERENCES `scrip`.`invoice` (`Number`),
  //CONSTRAINT `fk_products_detail`
  //  FOREIGN KEY(`Code`)
  //  REFERENCES `scrip`.`products` (`Code`));

  //              CREATE TABLE `scrip2`.`products` (
  //`Code` INT NOT NULL,
  //`Description` VARCHAR(45) NOT NULL,
  //`Value` DECIMAL(50, 0) NOT NULL,
  //`Quantity` INT NOT NULL,
  //PRIMARY KEY(`Code`),
  //UNIQUE INDEX `Code_UNIQUE` (`Code` ASC) VISIBLE);

  //              CREATE TABLE `scrip2`.`employee` (
  //`IdEmployee` INT NOT NULL,
  //`Usuario` VARCHAR(45) NOT NULL,
  //`Password` VARCHAR(45) NOT NULL,
  //PRIMARY KEY(`IdEmployee`),
  //UNIQUE INDEX `Usser_UNIQUE` (`IdEmployee` ASC) VISIBLE,
  //UNIQUE INDEX `Password_UNIQUE` (`Password` ASC) VISIBLE,
  //UNIQUE INDEX `Usuario_UNIQUE` (`Usuario` ASC) VISIBLE);

            }
        }
    }
}