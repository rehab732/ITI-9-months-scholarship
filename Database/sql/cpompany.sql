----query 1


select D.Dnum, D.Dname ,E.Fname as manager
from Departments D , Employee E
where D.MGRSSN=E.SSN




------query 2


select D.Dname as Department_name ,P.Pname as project_name
from Departments D , Project P
where D.Dnum=P.Dnum


-----query 3

select D.*, E.Fname as Employee_Name
from Dependent D left outer join Employee E
on D.ESSN=E.SSN


------query 4

select p.Dnum as project_id, p.Dnum as project_name,p.Plocation as project_location
from Project P 
where p.City='cairo' or p.City='Alex'


------query 5


select p.*
from Project p
where p.Pname like 'a%'


--------query 6
select E.*,D.Dnum
from Employee E, Departments D
where D.Dnum=30 

and E.Salary Between 1000 and 2000



------query 7



select Fname,Lname  from employee  , Works_for ,Project 
where ESSN = SSN   and pno = pnumber 
and Dno=10 and Hours >=10 and pname = 'AL Rabwah';



-----------query 8

select X.Fname   from employee X , employee Y
where  Y.SSN = X.Superssn and y.Fname = 'Kamel' and  y.Lname = 'Mohamed';

/*
select * from Employee

*/

------query 9


select E.Fname , p.Pname
from Employee E left outer join Works_for w
on E.SSN=w.ESSn
left outer join Project p
on w.Pno=p.Pnumber
 order by p.Pname

 ------querey 10

 select p.City,p.Pnumber,D.Dname,E.Lname,E.Address,E.Bdate
 from Project p inner join Departments D
 on p.Dnum=D.Dnum
 and p.City='cairo'
 inner join Employee E
 on E.SSN=D.MGRSSN


 --------query 11
 select E.*
 from Employee E, Departments D
 where D.MGRSSN=E.SSN
 /*
 select * from Departments*/


 ----------query 12
 select E.* , D.*
 from Employee E left outer join Dependent D
 on e.SSN=D.ESSN


 ------------query 13
 insert into Employee (Dno,SSN,Superssn,Salary) values(30,102672,112233,3000)

 insert into Employee(Dno,SSN) values(30,102660)



 update  Employee E
set Salary *=0.2
where ssn=102660


