CREATE TABLE [dbo].[PersonRegisters]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Username] NVARCHAR(16) NOT NULL,
	[Password] NVARCHAR(16) NOT NULL,
)
CREATE TABLE [dbo].[PersonBookTypes]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[BookType] NVARCHAR(18) NOT NULL,
	[PersonAccountId] INT NOT NULL UNIQUE
)
CREATE TABLE [dbo].[RevenueExpenditureBooks]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Date] DATE NOT NULL,
	[Income] DECIMAL NOT NULL,
	[RawMaterials] DECIMAL NOT NULL,
	[Expense] DECIMAL NOT NULL,
	[Balance] DECIMAL NOT NULL,
	[Counted] DECIMAL NOT NULL,
	[CheckOutPlusAndMinus] DECIMAL NOT NULL,
	[AccountRavenueBookId] INT,
    CONSTRAINT fk_RevenueExpenditureBooks_PersonAccounts       
    FOREIGN KEY (AccountRavenueBookId)
    REFERENCES dbo.PersonBookTypes(Id)
)
CREATE TABLE [dbo].[PersonAccounts]
(
    [PersonRegistersId] INT,
    [PersonBookTypesId] INT,
    CONSTRAINT PK_PersonAccounts
    PRIMARY KEY (PersonRegistersId, PersonBookTypesId),
    CONSTRAINT FK_PersonAccounts_PersonRegisters
    FOREIGN KEY (PersonRegistersId)
    REFERENCES dbo.PersonRegisters(Id),
    CONSTRAINT FK_PersonAccounts_PersonBookTypes
    FOREIGN KEY (PersonBookTypesId)
    REFERENCES dbo.PersonBookTypes(Id)
)

