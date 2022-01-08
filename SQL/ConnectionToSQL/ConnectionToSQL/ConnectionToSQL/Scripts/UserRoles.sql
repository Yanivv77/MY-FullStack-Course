-- MySQL Script generated by MySQL Workbench
-- Sat Jan  5 19:58:25 2019
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema SignInTutorial
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `SignInTutorial` ;

-- -----------------------------------------------------
-- Schema SignInTutorial
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `SignInTutorial` DEFAULT CHARACTER SET utf8 ;
USE `SignInTutorial` ;

-- -----------------------------------------------------
-- Table `SignInTutorial`.`Users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SignInTutorial`.`Users` (
  `userName` VARCHAR(45) NOT NULL,
  `Password` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`userName`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SignInTutorial`.`Roles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SignInTutorial`.`Roles` (
  `RoleName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`RoleName`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SignInTutorial`.`UserRoles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SignInTutorial`.`UserRoles` (
  `userName` VARCHAR(45) NULL,
  `RoleName` VARCHAR(45) NULL,
  INDEX `userName_idx` (`userName` ASC),
  INDEX `RoleName_idx` (`RoleName` ASC),
  CONSTRAINT `userName`
    FOREIGN KEY (`userName`)
    REFERENCES `SignInTutorial`.`Users` (`userName`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `RoleName`
    FOREIGN KEY (`RoleName`)
    REFERENCES `SignInTutorial`.`Roles` (`RoleName`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `SignInTutorial`.`Users`
-- -----------------------------------------------------
START TRANSACTION;
USE `SignInTutorial`;
INSERT INTO `SignInTutorial`.`Users` (`userName`, `Password`) VALUES ('root', 'admin');
INSERT INTO `SignInTutorial`.`Users` (`userName`, `Password`) VALUES ('john', 'john1234');

COMMIT;


-- -----------------------------------------------------
-- Data for table `SignInTutorial`.`Roles`
-- -----------------------------------------------------
START TRANSACTION;
USE `SignInTutorial`;
INSERT INTO `SignInTutorial`.`Roles` (`RoleName`) VALUES ('System Administrator');
INSERT INTO `SignInTutorial`.`Roles` (`RoleName`) VALUES ('System Customizer');

COMMIT;


-- -----------------------------------------------------
-- Data for table `SignInTutorial`.`UserRoles`
-- -----------------------------------------------------
START TRANSACTION;
USE `SignInTutorial`;
INSERT INTO `SignInTutorial`.`UserRoles` (`userName`, `RoleName`) VALUES ('root', 'System Administrator');
INSERT INTO `SignInTutorial`.`UserRoles` (`userName`, `RoleName`) VALUES ('John', 'System Customizor');

COMMIT;
