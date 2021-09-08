-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_AddPersonDetails]
(
	-- Add the parameters for the stored procedure here	
	@AddressBookName varchar(25),
	@Type varchar(25),
	@FirstName varchar(25),
	@LastName varchar(25),
	@Address varchar(150),
	@PhoneNumber varchar(15),
	@zipcode int,
	@City varchar(25),
	@State varchar(25),
	@EmailId varchar(50)	
)
AS
BEGIN
	INSERT into AddressBook values 
	(@AddressBookName,@Type, @FirstName, @LastName, @Address, @PhoneNumber, @zipcode, @City, @State, @EmailId)
END
GO
