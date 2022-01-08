-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Cars_DB
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Cars_DB
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Cars_DB` DEFAULT CHARACTER SET utf8 ;
USE `Cars_DB` ;

-- -----------------------------------------------------
-- Table `Cars_DB`.`types`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Cars_DB`.`types` (
  `type_name` VARCHAR(255) NOT NULL,
  UNIQUE INDEX `name_UNIQUE` (`type_name` ASC) VISIBLE,
  PRIMARY KEY (`type_name`));


-- -----------------------------------------------------
-- Table `Cars_DB`.`Cars`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Cars_DB`.`Cars` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `type_name` VARCHAR(45) NOT NULL,
  `Model` VARCHAR(45) NOT NULL,
  `Description` LONGTEXT NULL,
  `SubDescription` VARCHAR(255) NULL,
  `Price` INT NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `fk_Cars_types_idx` (`type_name` ASC) VISIBLE,
  CONSTRAINT `fk_Cars_types`
    FOREIGN KEY (`type_name`)
    REFERENCES `Cars_DB`.`types` (`type_name`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `Cars_DB` ;

-- -----------------------------------------------------
-- Placeholder table for view `Cars_DB`.`view`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Cars_DB`.`view` (`Id` INT, `type_name` INT, `Model` INT, `Description` INT, `SubDescription` INT, `Price` INT);

-- -----------------------------------------------------
-- View `Cars_DB`.`view`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Cars_DB`.`view`;
USE `Cars_DB`;
CREATE  OR REPLACE VIEW `view` AS
SELECT c.Id ,t.type_name , c.Model, c.Description, c.SubDescription, c.Price
FROM cars c inner join types t ON c.type_name = t.type_name;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
