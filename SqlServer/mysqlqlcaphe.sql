CREATE TABLE `quanlynhanviencofeshop`.`employee` (
  `idEmployee` INT NOT NULL,
  `Name` NVARCHAR(50) NOT NULL,
  `Sex` VARCHAR(5) NOT NULL,
  `Address` VARCHAR(50) NOT NULL,
  `Birthday` DATE NOT NULL,
  `Basic_Salary` FLOAT NOT NULL,
  PRIMARY KEY (`idEmployee`));
CREATE TABLE `quanlynhanviencofeshop`.`workingday` (
  `idWorkingDay` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `idEmployee` INT NOT NULL,
  `idDaywatch` INT NOT NULL,
  `DayWatch` DATE NOT NULL,
  PRIMARY KEY (`idWorkingDay`, `idwatch`, `idEmployee`));
CREATE TABLE `quanlynhanviencofeshop`.`daywatch` (
  `idDayWatch` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `NameWatch` VARCHAR(10) NOT NULL,
  `TimeTo` INT NOT NULL,
  `TimeFrom` INT NOT NULL,
  PRIMARY KEY (`idDayWatch`));
