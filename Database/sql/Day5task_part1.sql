
---1.	Retrieve number of students who have a value in their age. 
select count(St_Id) as student_number
from Student
where St_Age is not null ;
---2.	Get all instructors Names without repetition
select Distinct  Ins_Name
from Instructor
----3.	Display student with the following Format (use isNull function)******
select St_Id , concat(St_Fname, ' ',St_Lname) as fullname ,d.Dept_Name
from Student s ,Department d
where s.Dept_Id=d.Dept_Id and St_Id is null and St_Fname is null and St_Lname is null and Dept_Name is null
----4.	Display instructor Name and Department Name 
--Note: display all the instructors if they are attached to a department or not
select Ins_Name , d.Dept_Name
from Instructor i left outer join Department d
on i.Ins_Id=d.Dept_Manager;
-------5.	Display student full name and the name of the course he is taking
--For only courses which have a grade  
select  st.St_Id , concat(St_Fname, ' ',St_Lname) as fullname ,c.Crs_Name
from Stud_Course s ,Course c ,Student st
where c.Crs_Id=s.Crs_Id and s.St_Id= st.St_Id and s.Grade is not null;
---6.	Display number of courses for each topic name
select t.Top_Name ,count(Crs_Name) as numberofcourses
from Course c ,Topic t
where c.Top_Id= t.Top_Id
group by t.Top_Name;
-----7	Display max and min salary for instructors
select min(Salary) as minimum, MAX(salary) as maximum
from Instructor;
---8.	Display instructors who have salaries less than the average salary of all instructors.
select *
from Instructor
where Salary<( select AVG(salary)from Instructor );
----9.	Display the Department name that contains the instructor who receives the minimum salary
select d.Dept_Name
from Instructor i , Department d
where i.Ins_Id=d.Dept_Manager and Salary =( select min(salary)from Instructor );
---10.	 Select max two salaries in instructor table. 
select TOP(2) Salary 
from Instructor order by Salary desc;
----11.Select instructor name and his salary but if there is no salary display instructor bonus keyword. “use coalesce Function”
SELECT  Ins_Name, COALESCE( convert(nvarchar,Salary) , 'instructor bonus')
from Instructor;
-----12.	Select Average Salary for instructors 
select avg(salary)from Instructor;
----13.	Select Student first name and the data of his supervisor 
select s1.St_Fname , s2.*
from Student s1 ,Student s2
where s1.St_super=s2.St_Id;
---14.	Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”
select * from (select i.* ,ROW_NUMBER()
over(order by salary desc ) 
as RN from Instructor i , Department d where i.Ins_Id=d.Dept_Manager) as newt 
where RN <=2 ;
-----15 Write a query to select a random  student from each department.  “using one of Ranking Functions”
SELECT TOP 5 s.* FROM Department d ,Student s
where s.dept_id= d.dept_id
ORDER BY NEWID();
