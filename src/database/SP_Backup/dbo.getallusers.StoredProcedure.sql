USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getallusers]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getallusers]
as 
begin 
select * from Users
end
GO
