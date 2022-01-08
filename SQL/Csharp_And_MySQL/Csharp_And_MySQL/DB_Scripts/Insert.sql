use cars_db;

-- -----------------------------------------------------
-- Add Types
-- -----------------------------------------------------
INSERT INTO types (type_name)
VALUES ('Toyota'),('Honda'),('Volkswagen'),
		('BMW'),('Alfa Romeo'),('Kia'),
		('Audi'),('Subaru'),('Ford');
	    
-- -----------------------------------------------------
-- Add Cars
-- -----------------------------------------------------
INSERT INTO cars (`type_name`,`Description`,`SubDescription`,`Model`,`Price`)
VALUES ('Honda','Very Cool','Cool','A5','105000'),
	   ('Volkswagen','Very Nice','Nice','G2','150000'),
       ('Kia','Very Good','Good','R3','120000'),
       ('Ford','Cool','Cool','X75','160000');
		
call insert_procedure ('Audi','cool car','Cool','Q3','222200');
	    