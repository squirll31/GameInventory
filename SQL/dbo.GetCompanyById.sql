CREATE PROCEDURE [dbo].[GetCompanyById]
	@id int = 0
AS
BEGIN
	SELECT 
		gc.GameCompanyName as Title
	FROM GameCompanies gc
	WHERE gc.GameCompanyId = @id
END
