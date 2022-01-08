SELECT c.Id ,t.type_name , c.Model, c.Description, c.SubDescription, c.Price
FROM cars c inner join types t ON c.type_name = t.type_name

