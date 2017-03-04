create table Profile_Role_Master
(
PRM_ID varchar(10) Primary key,
PM_ID varchar(10),
RM_ID varchar(10),
REM_ID varchar(10),
REM_Role varchar(10),
REM_Form_Name varchar(50),
PRM_Permission varchar(50),
PRM_Status varchar(10)
);

create table Role_Elements_Master
(
REM_ID varchar(10) primary key,
RM_ID varchar(10),
REM_Role varchar(50),
REM_Form_Name varchar(50),
REM_Status varchar(10)
);

create table Role_Master
(
RM_ID varchar(50) primary key,
RM_Role varchar(50),
RM_Status varchar(10)
);

create table Profile_Master
(
PM_ID varchar(10) primary key,
PM_UserID varchar(50),
PM_Password varchar(50),
PM_FirstName varchar(50),
PM_LastName varchar(50),
PM_Gender varchar(10),
PM_DOB datetime,
PM_DOJ datetime,
PM_Email varchar(150),
PM_Mobile varchar(50),
PM_Location varbinary(100),
PM_Present_Address varchar(1000),
PM_Permanent_Address varchar(1000),
PM_Acc_No varchar(50),
PM_Tax_No varchar(50),
RM_ID varchar(10),
PM_Status varchar(10)
);

Insert into Profile_Master(PM_ID, PM_UserID, PM_Password)
Values('1', 'PM1', 'PM1P');

Insert into Profile_Master(PM_ID, PM_UserID, PM_Password)
Values('2', 'PM2', 'PM2P'), ('3', 'PM3', 'PM3P'), ('4', 'PM4', 'PM4P');




