CREATE DATABASE IF NOT EXISTS `login_schema` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `login_schema`;
CREATE TABLE IF NOT EXISTS `login` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `user` VARCHAR(255) NOT NULL,
    `password` VARCHAR(255) NOT NULL,
    PRIMARY KEY (`id`)
) ENGINE = InnoDB;
INSERT INTO `login_schema`.`login` (`user`, `password`) VALUES ('leo', '123');