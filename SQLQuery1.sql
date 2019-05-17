--CREATE Table 	JobSeeker_Details
--(
-- EmployeeId int not null primary key,
-- Name nvarchar(50) null,
-- ContactDetails nvarchar(max), 
-- Address nvarchar(Max),
-- Email nvarchar(Max),
-- TelephoneNUmber nvarchar(Max), 
-- MobileNumber nvarchar(Max) 

--  )
--  create table 	Employer_Details 
--  (
--  CompanyName nvarchar(50),
--  JobCategory nvarchar(50),
--  RequiredSKills nvarchar(50),
--  Designation nvarchar(50), 
--  MinQualification nvarchar(50),
--  ExtraSkill nvarchar(50),
--  Age int,
--  ExpectedSalary nvarchar(50),
--  JobLocation nvarchar(50),
--  CurrentOpenings nvarchar(50),
--  Location nvarchar(50),
--  LastApplyDate datetime,
--  EntryDate datetime
--  )

-- CREATE TABLE Firsttimeuser(
--    [UserId] [INT] IDENTITY(1,1) ,
--    [Name] [varchaR](50),
--	[Password] [varchar](25)  ,	
--	[Emailid] [nvarchar](25),	
--	[TelNo] [nvarchar](100) ,
--	[MobileNo] [nvarchar](100)  ,
--	[Address] [nvarchar](500)  ,
--    CONSTRAINT [pk_Firsttimeuser] PRIMARY KEY (UserId)
--	)
	
	 create table JobSeeker
	 (
	
	 Name varchar(50) primary key,
	 Password varchar(25),  	 
	 Emailid nvarchar(50),
	 MobileNo varchar(20),	 	
	 Location nvarchar(50),
	 photo IMAGE ,
	 Position nvarchar(50) ,
	 Experience nvarchar(50) ,
	 PreferredJobLocation varchar(20),
	 Skills nvarchar(50) ,
	 Dateofapplication date ,
	 Resume image ,
	 Status varchar(50)

	 )
	
	 select * from FirstTimeUser
	 drop table Employer
	  create table Employer
	  (
	 Name varchar(50) primary key ,
	 Password varchar(25),  	 
	 Emailid nvarchar(50),
	 MobileNo varchar(20),	 	
	 LocationOfTheOpenings nvarchar(50),
	 photo image,
	 Designation nvarchar(50) ,
	 CurrentOpenings int,
	 Experience nvarchar(50) ,
	 EmployerClients varchar(100),
	 Skills nvarchar(50) ,
	 Updated date
	 )

	 
	 create table Search(
	  Designation nvarchar(50) ,
	   Experience nvarchar(50) ,
	    Location nvarchar(50),
		SkillsSet nvarchar(50) ,
		Profession nvarchar(50)
		)
		SELECT * FROM JobSeeker

		 create table Job
	 (
	 Jobid int primary key, 	
	 Designation varchar(50) ,
	 Company varchar(50),
	 ComapnyName varchar(50),
	 Salary nvarchar(50)

	 )
	 create table Approved
	 (
	  Name varchar(50) primary key,
	  status varchar(50)
	  )
	  select * from JobSeeker
	  select * from FirstTimeUser