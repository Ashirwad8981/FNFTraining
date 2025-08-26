create table EmployeeNew(

Emp_ID INT Primary key,
Name nvarchar(100) NOT NULL,
Salary money NOT NULL,
Manager_ID INT 
)

insert into EmployeeNew values(1,'Rohit',20000,3);
insert into EmployeeNew values(2,'Sangeeta',12000,5);
insert into EmployeeNew values(3,'Sanjay',10000,5);
insert into EmployeeNew values(4,'Arun',25000,3);
insert into EmployeeNew values(5,'Zaheer',30000,NULL);
SELECT * FROM EmployeeNew


SELECT 
    
    e.Name AS emp_Name,
   
    m.Name AS Mgr_name
    FROM EmployeeNew as e
LEFT JOIN 
    EmployeeNew  as m
ON 
    e.manager_ID = m.Emp_ID
    ORDER BY emp_Name;