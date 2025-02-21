USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InitializeUsers]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeUsers]
AS
BEGIN
    -- Insert users with the same password '123'
    INSERT INTO Users (UserName, Email, Address, Password, Phone, Gender)
    VALUES ('Ahmed', 'ahmed@example.com', 'Address1', '123', '1234567890', 'M'),
           ('Maryam', 'maryam@example.com', 'Address2', '123', '0987654321', 'F'),
           ('Omar', 'omar@example.com', 'Address3', '123', '9876543210', 'M'),
           ('Abdo', 'abdo@example.com', 'Address4', '123', '0123456789', 'M'),
           ('Saber', 'saber@example.com', 'Address5', '123', '5678901234', 'M');
END
GO
