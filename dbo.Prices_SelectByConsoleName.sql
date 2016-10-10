CREATE PROCEDURE dbo.Prices_SelectByConsoleName
	@console VARCHAR(MAX)
AS
BEGIN
	SELECT
		p.Id as Id,
		p.ConsoleName as ConsoleName,
		p.LoosePrice as LoosePrice,
		p.CIBPrice as CIBPrice,
		p.NewPrice as NewPrice,
		p.Genre as Genre,
		p.ReleaseDate as ReleaseDate,
		p.UPC as UPC
	FROM dbo.Prices_09Oct16 p
	WHERE p.ConsoleName = @console
END