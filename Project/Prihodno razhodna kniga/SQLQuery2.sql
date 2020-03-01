CREATE TABLE [dbo].[RevenueExpenditureBooks]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Datetime] DATETIME NOT NULL,
	[Income] DECIMAL NOT NULL,
	[Raw materials] DECIMAL NOT NULL,
	[Costs] DECIMAL NOT NULL,
	[Balance] DECIMAL NOT NULL,
	[Counted] DECIMAL NOT NULL,
	[Checkout+-] DECIMAL NOT NULL
)
CREATE TABLE [dbo].[PersonAccounts]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[BookType] NVARCHAR(60) NOT NULL,
	[RavenueBookId] INT,
    CONSTRAINT fk_PersonAccounts_RavenueBooks
	FOREIGN KEY (RavenueBookId)
	REFERENCES dbo.RavenueBooks(Id)
)
CREATE TABLE [dbo].[PersonRegisters]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Username] NVARCHAR(16) NOT NULL,
	[Password] NVARCHAR(16) NOT NULL,
	[PersonAccountId] INT,
	CONSTRAINT fk_PersonRegister_PersonAccount
	FOREIGN KEY (PersonAccountId)
	REFERENCES dbo.PersonAccounts(Id)
)
