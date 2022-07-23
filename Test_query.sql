create table products (id int not null, product_name text);

create table category (id int not null, category_name text);

insert into products (id, product_name) values 
(1, 'Milk'),
(2, 'Beer'),
(3, 'Bread'),
(4, 'Paper');

insert into category (id, category_name) values 
(1, 'Drink'),
(2, 'Food');

create table result (id int not null, product_id int, category_id int);

insert into result (id, product_id, category_id) values 
(1, 1, 1),
(2, 2, 1),
(3, 3, 2),
(4, 4, null);

SELECT products.product_name, category.category_name
FROM result
left join products ON result.product_id = products.id
left join category ON result.category_id = category.id;