CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_procedure`(type_name varchar(45),
Description longtext , SubDescription varchar(255) , Model varchar(45), Price int)

BEGIN

INSERT IGNORE INTO types (type_name)
VALUES (type_name);




END