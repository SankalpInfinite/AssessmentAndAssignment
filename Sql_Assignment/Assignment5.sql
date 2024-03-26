
create or alter proc payslip @ename varchar(10)
as 
begin

select empno,ename,
(.1*sal) as HRA,
(.2*sal) as DA,
(.08*sal) as PF,
(0.05*sal) as IT ,
((.08*sal)+(0.05*sal))as Deductions , ---- Deductions = PF + IT
(sal+(.1*sal)+(.2*sal)) as GrossSalary,----GrossSalary = Salary + HRA + DA
((sal+(.1*sal)+(.2*sal))-((.08*sal)+(0.05*sal))) as	NetSalary ----NetSalary = GrossSalary - Deductions
from emp where ename=@ename

end
exec payslip SMITH
---------------------------------------------------------------------------------------------------------------------------------
