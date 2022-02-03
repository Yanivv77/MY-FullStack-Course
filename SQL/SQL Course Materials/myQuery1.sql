
----------- targil 1
use sql_inventory;
Select name , unit_price ,  (unit_price*1.1) as new_unit_price
From products;

----------- targil 2 
use sql_store;
select *
from orders
where order_date > '2018-01-01';


----------- targil 3 
use sql_inventory;
Select *
From products
where quantity_in_stock in (49,38,72);

----------- targil 4
use sql_store;
select *
from customers
where birth_date between '1990-01-01' and '2000-01-01';

----------- targil 5
use sql_store;
select *
from customers
where last_name like  '%ey' or first_name like '%on' and first_name like "Elka" or first_name like "Ambur";

----------- targil 6
use sql_store;
select *
from orders
where shipped_date IS NOT NULL;


----------- targil 7
use sql_store;
select * , (quantity * unit_price) as new_price
from order_items
order by new_price desc;

----------- targil 8
use sql_invoicing;
select  c.name as client_name , c.address , c.city ,c.state  , c.phone ,p.date , p.amount ,pm.name as payment_method
from clients c join payments p on c.client_id = p.client_id  join payment_methods pm on  pm.payment_method_id = p.payment_method;





