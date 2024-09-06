-- DBCC CHECKIDENT ('Role', RESEED, 0)

Select * from dbo.[Table] -- Lấy hết thông tin
Select * from dbo.[Table] where ID = 1 -- Lấy thông tin có điều kiện
Insert into dbo.[Table] ID(4) -- Thêm dữ liệu vào bảng
Update dbo.[Table] Set [Name] = N'Chao Ban' Where ID = 3 -- Cập nhật dữ liệu
Delete from dbo.[Table] Where ID = 2 -- Xoá dữ liệu
-- [Table]_GetAll: Lấy hết dữ liệu của bảng
-- [Table]_GetByID: Lấy thông tin dữ liệu bảng theo ID(Khóa ngoại)
-- [Table]_Insert: Chèn dữ liệu vào bảng
-- [Table]_Update: Cập nhật dữ liệu bảng
-- [Table]_Delete: Xóa dữ liệu bảng theo khóa ngoại

Select * from dbo.RoleAccount 

Select * from dbo.Bills

Select * from dbo.BillDetails

Select * from dbo.Account

Select * from dbo.Food

Select * from dbo.[Role]

--------------- CATEGORY --------------
Category_GetAll:
------- Thủ tụ lấy hết dữ liệu trong bảng Category
CREATE PROCEDURE Category_GetAll
AS
BEGIN
		SELECT * FROM dbo.Category
END 
GO

Category_GetByID:
-------Thủ tục lấy hết dữ liệu trong bảng Category theo ID
CREATE PROCEDURE Category_GetAll
(
	@ID INT
)
AS
BEGIN
	SELECT * FROM dbo.Category WHERE ID = @ID
END
GO

Category_Insert:
------- Thủ tục thêm dữ liệu vào bảng Category
CREATE PROCEDURE Category_Insert
(
	@Name NVARCHAR(1000),
	@Type INT
)
AS
BEGIN
	-- Kiểm tra tồn tại Name: Lệnh này có thể không cần thiết trong một số bảng
		IF(NOT EXISTS (SELECT [Name] FROM dbo.Category WHERE [Name] = @Name))
		INSERT INTO dbo.Category ([Name], Type)
						VALUES (@Name, @Type)
END
GO

Category_Update:
------- Thủ tục cập nhật dữ liệu trong bảng Category
CREATE PROCEDURE Category_Update
(
	@ID INT,
	@Name NVARCHAR(1000),
	@Type INT
)
AS
BEGIN
		UPDATE dbo.Category
		SET [Name] = @Name, [Type] = @Type
		WHERE ID = @ID
END
GO

Category_Delete:
------- Thủ tục xóa mẫu tin trong bảng Category
CREATE PROCEDURE Category_Delete
(
	@ID INT
)
AS
BEGIN
		DELETE FROM dbo.Category
		WHERE ID = @ID
END
GO

EXEC dbo.Category_Insert N'Tráng miệng', 1
SELECT * FROM Category

-------------------------------------------------------
