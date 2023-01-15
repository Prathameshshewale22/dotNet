-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema test
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `test` ;

-- -----------------------------------------------------
-- Schema test
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `test` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `test` ;

-- -----------------------------------------------------
-- Table `test`.`product`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `test`.`product` ;

CREATE TABLE IF NOT EXISTS `test`.`product` (
  `pid` INT NOT NULL,
  `pname` VARCHAR(30) NULL DEFAULT NULL,
  `description` VARCHAR(30) NULL DEFAULT NULL,
  `price` DOUBLE NULL DEFAULT NULL,
  `quntity` INT NULL DEFAULT NULL,
  PRIMARY KEY (`pid`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `test`.`student`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `test`.`student` ;

CREATE TABLE IF NOT EXISTS `test`.`student` (
  `sid` INT NOT NULL,
  `sname` VARCHAR(20) NULL DEFAULT NULL)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `test`.`studentinfo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `test`.`studentinfo` ;

CREATE TABLE IF NOT EXISTS `test`.`studentinfo` (
  `sid` INT NOT NULL,
  `sname` VARCHAR(35) NULL DEFAULT NULL,
  `email` VARCHAR(40) NOT NULL,
  `password` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`sid`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
