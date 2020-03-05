--CREATE TABLE [dbo].[RevenueExpenditureBooks]
--(
--	[Id] INT NOT NULL PRIMARY KEY,
--	[Date] DATE NOT NULL,
--	[Income] DECIMAL NOT NULL,
--	[RawMaterials] DECIMAL NOT NULL,
--	[Expense] DECIMAL NOT NULL,
--	[Balance] DECIMAL NOT NULL,
--	[Counted] DECIMAL NOT NULL,
--	[CheckOutPlusAndMinus] DECIMAL NOT NULL
--)
CREATE TABLE [dbo].[PersonRegisters]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Username] NVARCHAR(16) NOT NULL,
	[Password] NVARCHAR(16) NOT NULL,
)
CREATE TABLE [dbo].[PersonAccounts]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[BookType] NVARCHAR(18) NOT NULL,
	--[RavenueBookId] INT,
	[PersonLoginId] INT NOT NULL,
	CONSTRAINT fk_PersonAccount_PersonRegisters
	FOREIGN KEY (PersonLoginId)
	REFERENCES PersonRegisters(Id),
    --CONSTRAINT fk_PersonAccounts_RevenueExpenditureBooks
	--FOREIGN KEY (RavenueBookId)
	--REFERENCES dbo.RevenueExpenditureBooks(Id)
)
