select * from Employee;

select Fname, Lname, Salary , Dno from Employee ;

select Pname, Plocation, Departments.Dname as departtmentname from Project ,Departments ;



 select CONCAT(Fname, ' ', Lname) AS fullname , Salary * 1/10 as ANNUAL_COMM from Employee ;

 select SSN , CONCAT(Fname, ' ', Lname) AS fullname  from Employee where Salary >1000;

 select SSN , CONCAT(Fname, ' ', Lname) AS fullname  from Employee where Salary*12 >10000;
 select  CONCAT(Fname, ' ', Lname) AS fullname , Salary from Employee where Sex ='F';
 select Dname ,Dnum  from Departments WHERE MGRSSN = 968574 ;
 select Pnumber, Pname, Plocation from Project WHERE Dnum=10;