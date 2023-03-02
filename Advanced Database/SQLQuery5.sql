use Company_SD
--	Create a cursor for Employee 
declare  EMPCUR  cursor
for select	Salary from Employee
for update
declare @sal int
open EMPCUR
fetch  EMPCUR into @sal
while @@FETCH_STATUS=0
begin
			if @sal < 3000
				update Employee
				set Salary=@sal *1.1
				where current of EMPCUR
		   else if @sal>=3000
				update Employee
				set Salary=@sal *1.2
				where current of EMPCUR
		  	fetch EMPCUR into @sal

end

close EMPCUR
deallocate EMPCUR

---Display Department name with its manager name using cursor. Use ITI DB
use ITI
declare  DEPTEMP  cursor

for select	Department.Dept_Name,Instructor.Ins_Name from Department inner join Instructor
on Department.Dept_Id = Instructor.Dept_Id
where Department.Dept_Manager=Instructor.Dept_Id

for Read only
declare @Dept varchar(50),@Ins varchar(50)
open DEPTEMP
fetch DEPTEMP into @Dept,@Ins
while @@FETCH_STATUS=0

begin
		select @Dept,@Ins
		fetch DEPTEMP into @Dept,@Ins
	end

close DEPTEMP
deallocate DEPTEMP


--Try to display all students first name in one cell separated by comma. Using Cursor 

declare names cursor
for select Student.St_Lname from Student where Student.St_Fname is not null
	for read only
declare @name varchar(50),@all_names varchar(250)
open names
fetch names into @name
while @@FETCH_STATUS=0
	begin
	set @all_names=CONCAT(@all_names,',',@name)
	fetch names into @name
	end
select @all_names

close names
deallocate names


--tasks-->export Data -->

create sequence seq
start with 1
increment by 1
minvalue 1
maxvalue 10
no cycle

create table test
(
id int,
name varchar(50)
)
insert into test values (next value for seq,'rehab')
select * from test

