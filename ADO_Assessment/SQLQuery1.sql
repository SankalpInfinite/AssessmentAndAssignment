create database Employeemanagement

create table employeeDetails (empno int primary key ,empname varchar(20) not null,empsal int check (empsal >= 25000),
    emptype varchar check (emptype in ('p', 'c')))
	
	insert into employeeDetails values(1,'yash',30000,'P')
create or alter proc InsertEmployee
    @EmpName VARCHAR(20),
    @Empsal int,
    @Emptype varchar
as
begin
declare @Emp_no int
set @Emp_no = (SELECT MAX(Empno)+1 from EmployeeDetails)
select @Emp_no
insert into EmployeeDetails (empno, empName, empsal, emptype)
values (@Emp_no, @EmpName, @Empsal, @Emptype)
end


exec InsertEmployee @EmpName='Syam',@Empsal=400000,@Emptype='P'



SELECT * FROM EmployeeDetails


