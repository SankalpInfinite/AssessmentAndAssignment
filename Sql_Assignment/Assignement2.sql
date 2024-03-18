
create table DEPT(deptno numeric(2) primary key, dname varchar(15), loc varchar(15)) 

insert into DEPT(deptno, dname, loc) values(10,'ACCOUNTING','NEW YORK'), 
(20,'RESEARCH','DALLAS'),
(30,'SALES','CHICAGO'), 
(40,'OPERATIONS','BOSTON')

create table EMP(empno numeric(4) primary key, ename varchar(20), job varchar(20),mgr_id numeric(4), hiredate date, sal int check(sal>0), comm int, deptno numeric(2) foreign key references dept(deptno)) 

insert into EMP(empno, ename, job, mgr_id, hiredate, sal, comm, deptno) 
values
    (7369, 'SMITH', 'CLERK', 7902, '17-DEC-80', 800, NULL, 20),
    (7499, 'ALLEN', 'SALESMAN', 7698, '20-FEB-81', 1600, 300, 30),
    (7521, 'WARD', 'SALESMAN', 7698, '22-FEB-81', 1250, 500, 30),
    (7566, 'JONES', 'MANAGER', 7839, '02-APR-81', 2975, NULL, 20),
    (7654, 'MARTIN', 'SALESMAN', 7698, '28-SEP-81', 1250, 1400, 30),
    (7698, 'BLAKE', 'MANAGER', 7839, '01-MAY-81', 2850, NULL, 30),
    (7782, 'CLARK', 'MANAGER', 7839, '09-JUN-81', 2450, NULL, 10),
    (7788, 'SCOTT', 'ANALYST', 7566, '19-APR-87', 3000, NULL, 20),
    (7839, 'KING', 'PRESIDENT', NULL, '17-NOV-81', 5000, NULL, 10),
    (7844, 'TURNER', 'SALESMAN', 7698, '08-SEP-81', 1500, 0, 30),
    (7876, 'ADAMS', 'CLERK', 7788, '23-MAY-87', 1100, NULL, 20),
    (7900, 'JAMES', 'CLERK', 7698, '03-DEC-81', 950, NULL, 30),
    (7902, 'FORD', 'ANALYST', 7566, '03-DEC-81', 3000, NULL, 20),
    (7934, 'MILLER', 'CLERK', 7782, '23-JAN-82', 1300, NULL, 10)

	------ Query
	------1. List all employees whose name begins with 'A'. 
	select ename from EMP where ename like 'a%'

	------2. Select all those employees who don't have a manager. 
	select * from Emp where mgr_id is NULL

	------3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
	select ename,sal,empno from emp where sal between 1200 and 1400

	------4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.
	---Before
	          select ename,empno,job,sal from emp join DEPT on emp.deptno=DEPT.deptno where EMP.deptno=DEPT.deptno and DEPT.dname ='RESEARCH'
    ----After
	        select ename,empno,job,(sal+(sal*.1))as salary from emp join DEPT on emp.deptno=DEPT.deptno where EMP.deptno=DEPT.deptno and DEPT.dname ='RESEARCH'

	-------5.Find the number of CLERKS employed. Give it a descriptive heading.
	 select count(job) from emp where job = 'clerk'

	 ------6. Find the average salary for each job type and the number of people employed in each job. 
	 select avg(sal)as 'Average Salary', job from emp group by job

	 -----7. List the employees with the lowest and highest salary.
	 select * from emp where sal=(select max(sal) from emp)
	  select * from emp where sal=(select min(sal) from emp)

	  ----8. List full details of departments that don't have any employees.
	  select * from DEPT where DeptNo not in (select distinct DeptNo from EMP);

	  -----9.Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
	  select ename,sal from emp where deptno=20  order by ename asc

	  -----10. For each department, list its name and number together with the total salary paid to employees in that department.
      select d.Dname, D.DeptNo, sum(E.Sal) as "Total Salary Paid" from DEPT D left join EMP E ON D.DeptNo = E.DEPTNO group by D.DNAME, D.DEPTNO;
 
	  -----11. Find out salary of both MILLER and SMITH.
		select Ename, Sal from EMP where Ename in ('MILLER', 'SMITH');
 
	  ------12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
	  select * from EMP where Ename like 'a%' or Ename like 'm%';
 
	 ------13. Compute yearly salary of SMITH. 
	 select Ename, Sal * 12 as "Yearly Salary" from EMP where Ename = 'SMITH';
 
	 -----14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850
     select Ename, Sal from EMP where SAL not between 1500 and 2850;

    ------15. Find all managers who have more than 2 employees reporting to them
	 select Mgr_id from EMP Group By Mgr_id HAVING count(*)>2;
	 