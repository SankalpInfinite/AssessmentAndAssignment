----1.Write a query to display your birthday( day of week)
select DATENAME(dw, '2000-07-27') as 'Week Day Name';
-------------------------------------------------------------------------------------------------------------
----2.Write a query to display your age in days
 select DATEDIFF(DAY,'2000-07-27',GETDATE()) as 'Age in Day'
 -------------------------------------------------------------------------------------------------------------------------------
---- 3.Write a query to display all employees information those who joined before 5 years in the current month
 
 select ename from emp 
 where  DATEDIFF(YEAR,'2019-03-28',GETDATE())>=  DATEDIFF(YEAR,hiredate,GETDATE()) 
 ----------------------------------------------------------------------------------------------------
 ----4.	Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
----	a. First insert 3 rows 
----	b. Update the second row sal with 15% increment  
----    c. Delete first row.
----    After completing above all actions how to recall the deleted row without losing increment of second row.

create table employee (empno int primary key,ename varchar(10),sal float,doj datetime)

insert into employee values (1,'joy',1000,'2000-10-23'),(2,'ram',2000,'2000-10-23'),(3,'lucky',3000,'2000-10-23')

update employee set sal=sal+(sal*.15) where empno=2

begin  transaction
delete from employee where empno=1
rollback

-------------------------------------------------------------------------------------------------------------------------------------------------------
 ----5.      Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
----	a.     For Deptno 10 employees 15% of sal as bonus.
----	b.     For Deptno 20 employees  20% of sal as bonus
----	c      For Others employees 5%of sal as bonus


create or alter function Bonus (@deptno int)
returns float
as
begin
declare @bon float
SELECT @bon = CASE
WHEN  @deptno =10 THEN sal*.1
WHEN @deptno = 20 THEN sal*.2
WHEN @deptno= 30 THEN sal*.05 END
FROM emp
return @bon
end
dbo.Bonus 10 

