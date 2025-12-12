create database edutrackdb

create table Students(
   StudentId int primary key identity(1,1),
   FullName varchar(100) not null,
   Email varchar(100) unique,
   Department varchar(50) not null,
   YearOfStudy int not null
)

create table Courses(
   CourseId int primary key identity(1,1),
   CourseName varchar(100) not null,
   Credits int not null,
   Semester varchar(20) not null
)

create table Enrollments(
   EnrollmentId int primary key identity(1,1),
   StudentId int foreign key references Students(StudentId),
   CourseId int foreign key references Courses(CourseId),
   EnrollDate datetime not null,
   Grade varchar(5) null
)

insert into Students values
('Humera Shaikh','humera@gmail.com','Computer Science',1),
('Soni Harpude','soni@gmail.com','Computer Application',2),
('Akshada Patil','akshada@gmail.com','Electronics',4),
('Pradnya Kadam','pradnya@gmail.com','Mechanics',1),
('Mansi Sharma','mansi@gmail.com','Electronics',3)
 
insert into Courses values
('Blockchain',3,'Sem 4'),
('Deep Learning',4,'Sem 5'),
('Operating System',2,'Sem 3'),
('Optimization Techniques',4,'Sem 2'),
('Machine Learning',5,'Sem 4'),
('Artificial Intelligence',3,'Sem 3')
 
insert into Enrollments values
(1,2,getdate(),'A'),
(3,1,getdate(),'B'),
(2,1,getdate(),'C'),
(1,3,getdate(),'D'),
(5,4,getdate(),'C'),
(4,5,getdate(),'B')

select * from Enrollments
select * from Courses

alter table Enrollments
drop constraint [FK__Enrollmen__Stude__3B75D760]
alter table Enrollments
add constraint FK_Enrollment_Student
foreign key(StudentId) references Students(StudentId)
on delete cascade

select * from Students

create procedure usp_GetCoursesBySemester(@semester VARCHAR(20))
as
begin
select CourseId,CourseName,Credits,Semester from Courses
where Semester = @semester
end

exec usp_GetCoursesBySemester 'Sem 2'