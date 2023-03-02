select S.St_Fname,D.Dept_Name
from Student  S full outer join Department  D
on D.Dept_Id=S.Dept_Id 



/*s.St_Fname as studentname,ss.St_Fname as manager */
select distinct s.St_Fname
from Student S inner join Student SS
on ss.St_Id=s.St_super




update  cs
set Grade+=10



from Stud_Course cs, Student s
where s.St_Id=cs.St_Id and St_Address='cairo'


create table test(

eid int primary key identity(1,1),
ename varchar(20)


)
insert into test values('rehab')
insert into test values('rehab')
insert into test values('rehab')
insert into test values('rehab')
select * from test

--builtin function 

select getdate() as date

select month(getdate())


select isnull(st_fname,St_Lname)--colease
from Student