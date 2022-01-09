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
VALUES 
   -- ('Honda','Very Cool','Cool','A5','105000'),
     -- ('Volkswagen','Very Nice','Nice','G2','150000'),
    --  ('Kia','Very Good','Good','R3','120000'),
	--  ('Ford','Cool','Cool','X75','160000');
		('Alfa Rome','Very Good','Good','M5','220000');

        
call insert_procedure ('Audi','cool car','Cool','Q3','162200');
call insert_procedure ('Audi','best ca','Cool','Q3','142200');
call insert_procedure ('Audi','cool car','Cool','Q3','142200');
call insert_procedure ('Audi','good car','good','Q3','122200');
call insert_procedure ('Audi','best car','nice','Q3','172200');
call insert_procedure ('Audi','cool car','Cool','Q3','122200');
call insert_procedure ('Audi','very nice','Cool','Q3','122200');
call insert_procedure ('Audi','cool car','Cool','Q3','422200');
call insert_procedure ('Bentley','very nice','nice','4wd','622200');  
call insert_procedure ('Ferrari','cool car','Cool','California','2212200');  
call insert_procedure ('Jaguar','best car,Cool','E-Pace','422200');