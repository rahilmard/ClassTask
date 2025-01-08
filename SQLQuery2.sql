Create Table Students(
ID int primary key Identity(1,1),
Name nvarchar(10) Not NUll,
Surname Nvarchar(10) Not null,
Age int Not  Null,
AvgPoint int Not Null

)
insert into Students
Values 
('Hikmet','Aliyev',19,86)

Select * From Students
Where AvgPoint>51

Select * From Students 
Where AvgPoint >51 And AvgPoint<90


SELECT * FROM Students
WHERE Name LIKE 'A%i';

