
----1. Retrieve a list of MANAGERS. 
select * from emp where job='MANAGER'

----2. Find out the names and salaries of all employees earning more than 1000 per months
select ename,sal from emp where sal>1000

----3. Display the names and salaries of all employees except JAMES. 
select ename,sal from emp where ename !='james'

----4. Find out the details of employees whose names begin with ‘S’. 
select * from emp where ename like 's%'

----5. Find out the names of all employees that have ‘A’ anywhere in their name.
select ename from emp where ename like '%a%'

----6. Find out the names of all employees that have ‘L’ as their third character in their name.
select ename from emp where ename like '__L%'

----7. Compute daily salary of JONES. 
select ename,(sal/22) as daily_Salary from emp where ename='jones'----22 working days

----8. Calculate the total monthly salary of all employees.
select sum(sal) as 'Total Monthly Salary' from emp

----9. Print the average annual salary .
 declare @salary int
set @salary=(select avg(sal*12) from EMP)
print 'Average Annual Valary :'+ cast(@salary as varchar(10))

----10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select ename,job,sal,deptno from emp where deptno!=30 or job!='SALESMAN'

----11. List unique departments of the EMP table. 
select distinct deptno from emp

----12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename as Employee,sal as 'Monthly Salary' from emp where sal>1500 and deptno in (10,20)

----13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ename,job,sal from emp where job in('MANAGER','ANALYST') and sal not in(1000,3000,5000)

----14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.
select ename,sal,comm from emp where comm>sal*1.1

----15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
select * from emp where ename like '%L%L%' and deptno=30 or mgr_id=7782

----16. Display the names of employees with experience of over 30 years and under 40 yrs. Count the total number of employees. 



----17. Retrieve the names of departments in ascending order and their employees in descending order.
 select emp.ename,dept.dname from emp join dept on emp.deptno=dept.deptno order by dept.dname asc,emp.ename desc

 ----18. Find out experience of MILLER. 
 select ename,datediff(year,hiredate,getdate()) as Experience from emp where ename='MILLER'
