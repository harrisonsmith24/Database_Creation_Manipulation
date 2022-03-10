CREATE TABLE [dbo].[Patients]
(
	[patientId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [patientName] NVARCHAR(50) NOT NULL, 
    [patientAddress] NVARCHAR(100) NULL, 
    [patientPhone] NVARCHAR(14) NOT NULL, 
    [patientEmail] NVARCHAR(50) NULL, 
    [pateintDeductibleLimit] MONEY NOT NULL
)
