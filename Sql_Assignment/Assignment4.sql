
----1.	Write a T-SQL Program to find the factorial of a given number.
create function factorial(@num int)
returns int
begin
declare @x int
declare @result int
set @x = @num
set @result = 1
while @x > 1
begin
    set @result = @result * @x
    set @x = @x - 1
end
return @result
end
select dbo.factorial(5) as FACTORIAL

----2.	Create a stored procedure to generate multiplication tables up to a given number.
create or alter proc multiplication(@num int,@range int)
as 
begin
declare @a int
set @a=1
declare @result int
while(@a<=@range)
begin
set @result=@a*@num
print(cast(@num as varchar)+' * '+cast(@a as varchar(2))+' = '+cast(@result as varchar(2)))
set @a=@a+1
end
end

 multiplication 3,10

 ----Create a trigger to restrict data manipulation on EMP table during General holidays. 
 ----Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc
 

create Table Holiday(
holiday_date Date,
holiday_name NVARCHAR(25)
);
Insert into Holiday(holiday_date, holiday_name)
values
('2024-12-25', 'Christmas'),
('2024-04-15', 'Eid'),
('2024-01-14', 'Pongal'),
('2024-11-01', 'Diwali'),
('2024-08-15', 'Independence Day'),
('2024-03-25', 'Holi')


select * from Holiday


create or alter trigger HolidayManipulationErrorTrigger
on holiday
after insert, update, delete
as
begin
    declare @holidayMessage nvarchar(50);
    declare @errorMessage nvarchar(50); 

    if exists (select 1 from holiday where holiday_date in (select holiday_date from inserted)) begin
         select @holidayMessage = holiday_name from holiday where holiday_date in (select holiday_date from inserted);
         select @errorMessage = 'Due to ' +@holidayMessage+ ' You cannot manipulate data';
        rollback;
        raiserror(@errorMessage, 16, 1)
    end
end
update Holiday set holiday_name = 'Independence Day' where holiday_date='2024-12-25';


