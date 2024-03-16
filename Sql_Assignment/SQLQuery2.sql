create database Sql_Assignment_1

create table Clients(Client_ID numeric(4) Primary Key,Cname VARCHAR(40) Not Null,Address VARCHAR(30),Email Varchar(30) Unique,Phone numeric(10),Business Varchar(20) Not Null)

select * from Clients

create table Departments (DeptNo numeric(2) primary key,DName varchar(15) not null,Loc varchar(20))

INSERT INTO Clients (Client_ID, Cname, Address, Email, Phone, Business)
VALUES
    (1001, 'ACME Utilities', 'Noida', 'contact@acmeutil.com', '9567880032', 'Manufacturing'),
    (1002, 'Trackon Consultants', 'Mumbai', 'consult@trackon.com', '8734210090', 'Consultant'),
    (1003, 'MoneySaver Distributors', 'Kolkata', 'save@moneysaver.com', '7799886655', 'Reseller'),
    (1004, 'Lawful Corp', 'Chennai', 'justice@lawful.com', '9210342219', 'Professional');

	INSERT INTO Departments(DEPTNO, DNAME, LOC)
VALUES
    (10, 'Design', 'Pune'),
    (20, 'Development', 'Pune'),
    (30, 'Testing', 'Mumbai'),
    (40, 'Document', 'Mumbai')

create table Employees(Empno numeric(4) primary key,Ename varchar(20) not null,job varchar(15),salary numeric(7)
check (salary>0),deptno numeric(2) Foreign key references Departments(deptno) )

INSERT INTO Employees (Empno, Ename, Job, Salary, Deptno)
VALUES
    (7001, 'Sandeep', 'Analyst', 25000, 10),
    (7002, 'Rajesh', 'Designer', 30000, 10),
    (7003, 'Madhav', 'Developer', 40000, 20),
    (7004, 'Manoj', 'Developer', 40000, 20),
    (7005, 'Abhay', 'Designer', 35000, 10),
    (7006, 'Uma', 'Tester', 30000, 30),
    (7007, 'Gita', 'Tech. Writer', 30000, 40),
    (7008, 'Priya', 'Tester', 35000, 30),
    (7009, 'Nutan', 'Developer', 45000, 20),
    (7010, 'Smita', 'Analyst', 20000, 10),
    (7011, 'Anand', 'Project Mgr', 65000, 10);

	select * from Employees

	create table Projects(Project_ID numeric(3) primary key,descr varchar(30) not null,Start_Date date,Planned_End_Date date,
	Actual_End_date date,Budget numeric(10) check (Budget>0),
	Client_ID numeric(4) foreign key references  Clients(Client_ID) )
	
	alter table Projects
	add constraint CHK_Actual_End_Date check(actual_end_date>Planned_end_date)

	INSERT INTO Projects (Project_ID, Descr, Start_Date, Planned_End_Date, Actual_End_date, Budget, Client_ID)
VALUES
    (401, 'Inventory', '2011-04-01', '2011-10-01', '2011-10-31', 150000, 1001),
    (402, 'Accounting', '2011-08-01', '2012-01-01', NULL, 500000, 1002),
    (403, 'Payroll', '2011-10-01', '2011-12-31', NULL, 75000, 1003),
    (404, 'Contact Mgmt', '2011-11-01', '2011-12-31', NULL, 50000, 1004);

create table EmpProjectTasks(Project_ID numeric(3) foreign key references projects(project_id),
Empno numeric(4) foreign key references Employees(Empno) primary key(Project_ID,Empno),start_Date date,end_date date,
task varchar(25) not null,status varchar(15) not null)

INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES
    (401, 7001, '01-Apr-11', '20-Apr-11', 'System Analysis', 'Completed'),
    (401, 7002, '21-Apr-11', '30-May-11', 'System Design', 'Completed'),
    (401, 7003, '01-Jun-11', '15-Jul-11', 'Coding', 'Completed'),
    (401, 7004, '18-Jul-11', '01-Sep-11', 'Coding', 'Completed'),
    (401, 7006, '03-Sep-11', '15-Sep-11', 'Testing', 'Completed'),
    (401, 7009, '18-Sep-11', '05-Oct-11', 'Code Change', 'Completed'),
    (401, 7008, '06-Oct-11', '16-Oct-11', 'Testing', 'Completed'),
    (401, 7007, '06-Oct-11', '22-Oct-11', 'Documentation', 'Completed'),
    (401, 7011, '22-Oct-11', '31-Oct-11', 'Sign off', 'Completed'),
    (402, 7010, '01-Aug-11', '20-Aug-11', 'System Analysis', 'Completed'),
    (402, 7002, '22-Aug-11', '30-Sep-11', 'System Design', 'Completed'),
    (402, 7004, '01-Oct-11', NULL, 'Coding', 'In Progress');

