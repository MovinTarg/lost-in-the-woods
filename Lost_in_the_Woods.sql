-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Lost_in_the_Woods
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Lost_in_the_Woods
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Lost_in_the_Woods` DEFAULT CHARACTER SET utf8 ;
USE `Lost_in_the_Woods` ;

-- -----------------------------------------------------
-- Table `Lost_in_the_Woods`.`trails`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Lost_in_the_Woods`.`trails` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NULL,
  `description` VARCHAR(255) NULL,
  `length` FLOAT NULL,
  `elevation` FLOAT NULL,
  `longitude` DOUBLE NULL,
  `latitude` DOUBLE NULL,
  `created_at` DATETIME NULL,
  `updated_at` DATETIME NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
