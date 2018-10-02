USE AdventureWorks2014
GO

CREATE PROCEDURE sp_DeleteCurrency (
	@currencyCode NVARCHAR(3)
)
AS
DELETE FROM Sales.Currency
WHERE CurrencyCode = @currencyCode