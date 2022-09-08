create database scrip3;



CREATE TABLE `scrip3`.`cliente` (
  `Document` INT NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  `Address` VARCHAR(45) NOT NULL,
  `Numberphone` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Document`));
  
  
  INSERT INTO `scrip3`.`employee` (`IdEmployee`, `User`, `Password`) VALUES ('1', 'Julian', '1111');
  
  
  CREATE TABLE `scrip3`.`products` (
  `Code` INT NOT NULL,
  `Description` VARCHAR(45) NOT NULL,
  `Value` DECIMAL(50) NOT NULL,
  `Quantity` INT NOT NULL,
  PRIMARY KEY (`Code`));



CREATE TABLE `scrip3`.`employee` (
  `IdEmployee` INT NOT NULL,
  `User` VARCHAR(45) NOT NULL,
  `Password` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`IdEmployee`));
  
  
  
  
  CREATE TABLE `scrip3`.`invoice` (
  `Number` INT NOT NULL,
  `Date` DATE NOT NULL,
  `IdCliente` INT NOT NULL,
  `TotalValue` INT NOT NULL,
  `IdEmployee` INT NOT NULL,
  PRIMARY KEY (`Number`),
  INDEX `fk_invoice_client_idx` (`IdCliente` ASC) VISIBLE,
  INDEX `fk_invoice_employee_idx` (`IdEmployee` ASC) VISIBLE,
  CONSTRAINT `fk_invoice_client`
    FOREIGN KEY (`IdCliente`)
    REFERENCES `scrip3`.`cliente` (`Document`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_invoice_employee`
    FOREIGN KEY (`IdEmployee`)
    REFERENCES `scrip3`.`employee` (`IdEmployee`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);





CREATE TABLE `scrip3`.`detail` (
  `IdDetail` INT NOT NULL,
  `Number` INT NOT NULL,
  `Product` VARCHAR(45) NOT NULL,
  `Code` INT NOT NULL,
  PRIMARY KEY (`IdDetail`),
  INDEX `fk_detail_products_idx` (`Code` ASC) VISIBLE,
  INDEX `fk_detail_invoice_idx` (`Number` ASC) VISIBLE,
  CONSTRAINT `fk_detail_products`
    FOREIGN KEY (`Code`)
    REFERENCES `scrip3`.`products` (`Code`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detail_invoice`
    FOREIGN KEY (`Number`)
    REFERENCES `scrip3`.`invoice` (`Number`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);