create database Coding_test
----question 1
----table books
create table books(id numeric(4) primary key,title varchar(25),author varchar(25),isbn numeric(12) unique,publisher_date datetime)
----------------------------------------------------------------------------------------------------------------------------------
insert into books values (1,'My First SQL Book','Mary parker',981483029127, convert(datetime, '2012-02-22 12:08:17')),
 (2,'My Second SQL book','John Mayer',857300923713,convert (datetime,'1972-07-03 09:22:45')),
 (3,'My Third SQL book','Cary Flint',523120967812,convert (datetime,'2015-10-18 14:05:44'))

 ---- Write a query to fetch the details of the books written by author whose name ends with er.
 select * from books where author like'%er'
 --------------------------------------------------------------------------------------------------------
 ----question2
 ---table reviews
create table reviews(id numeric(4) primary key,book_id numeric(4) foreign key references books(id) ,ReviewerName varchar(25),content varchar(200),rating int,publisher_date datetime)

insert into reviews values(1, 1, 'John Smith','My first review', 4,convert(datetime,'2017-12-10 05:50:11')),
(2, 2, 'John Smith', 'My Second review', 5,convert(datetime,'2017-10-13 15:05:12')),
(3, 3, 'Alice Walker','Another review', 1,convert(datetime,'2017-10-22 23:47:10'))

----Display the Title ,Author and ReviewerName for all the books from the above table 
select * from books
select * from reviews
select b.title,b.Author,r.ReviewerName from books b join reviews r on r.book_id=b.id 

----Display the  reviewer name who reviewed more than one book.
select ReviewerName from reviews group by ReviewerName having count(distinct book_id) > 1
----------------------------------------------------------------------------------------------------------
----question3
--table customers
create table customers(ID int primary key,Name varchar(25),Age int,Address varchar(25),Salary float)

insert into customers values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',4500.00),
(7,'Muffy',24,'Indore',10000.00)

----Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address
select Name from customers where Address like '%o%'
---------------------------------------------------------------------------------------------------------------------------------------
----question5

----table employee 
create table employee(ID int primary key,Name varchar(25),Age int,Address varchar(25),Salary float)

insert into employee values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',null),
(7,'Muffy',24,'Indore',null)

----Display the Names of the Employee in lower case, whose salary is null 
select lower(name) as lowercase_name from employee where salary is null

-- Table StudentDetails
create table StudentDetails (RegisterNo int,Name varchar(25),Age int, Qualification varchar(25), MobileNo numeric(20), Mail_id varchar(50),Location varchar(25), Gen varchar(1))

insert into StudentDetails (RegisterNo, Name, Age, Qualification, MobileNo, Mail_id, Location, Gen)
values
(2, 'Sai', 22, 'B.E', 9952836777, 'Sai@gmail.com', 'Chennai', 'M'),
(3, 'Kumar',20, 'BSC', 7890125648, 'Kumar@gmail.com', 'Madurai', 'M'),
(4, 'Selvi', 22, 'B.Tech', 8904567342, 'selvi@gmail.com', 'Selam', 'F'),
(5, 'Nisha', 25, 'M.E', 7834672310, 'Nisha@gmail.com', 'Theni', 'F'),
(6, 'SaiSaran',21, 'B.A', 7890345678, 'saran@gmail.com','Madurai', 'F'),
(7, 'Tom', 23, 'BCA', 8901234675, 'Tom@gmail.com', 'Pune', 'M'
 
-- to display gender and total number of males and females
select Gen as Gender,COUNT(*) as Total from StudentDetails where Gen is not null group by Gen

-----question 4
--table customer
create table customer(ID int primary key,Name varchar(25),Age int,Address varchar(25),Salary float)

insert into customer values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',4500.00),
(7,'Muffy',24,'Indore',10000.00)

create table orders(Order_ID int,Date Datetime,Customer_ID int references customer(id),Amount float)

insert into orders values
(102,'2009-10-08',3,3000),
(100,'2009-10-08',3,1500),
(101,'2009-11-20',2,1560),
(103,'2008-05-20',4,2060)

----Write a query to display the   Date,Total no of customer  placed order on same Date 
select * from orders select date, count(distinct customer_id) as total_customers from orders group by date order by date;