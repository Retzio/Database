--- Phase I Build 
--- Writen By Retzio Gredig
--- Created On 4/23/2021
--- Peer Reviewed By Nicholas Brinich
--- Last Edited 5/18/21
---
-------------------------------------------------------------------------------------------------------------------------
--
--- If Not Exist Build
--
IF NOT EXISTS(SELECT * FROM sys.databases
	WHERE NAME = N'MapleEstInvest')
	CREATE DATABASE MapleEstInvest
GO
USE MapleEstInvest
--
--- Alter the path so the script can find the CSV files 
--
DECLARE @data_path NVARCHAR(256);
SELECT @data_path = 'C:\__________\BuildMapleEstateInvestments\';    --- Change File Path
--
--- Delete existing tables
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'TRANSACTION'
       )
	DROP TABLE [TRANSACTION];
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'LISTING'
       )
	DROP TABLE LISTING;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'PROPERTY'
       )
	DROP TABLE PROPERTY;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'PORTFOLIO_PROPERTY'
       )
	DROP TABLE PORTFOLIO_PROPERTY;	
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'INVESTOR'
       )
	DROP TABLE INVESTOR;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'BROKER'
       )
	DROP TABLE BROKER;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'PROPERTY_TYPE'
       )
	DROP TABLE PROPERTY_TYPE;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'RISK_LEVEL'
       )
	DROP TABLE RISK_LEVEL;	
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'LICENSE_STATUS'
       )
	DROP TABLE LICENSE_STATUS;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'TRANSACTION_TYPE'
       )
	DROP TABLE TRANSACTION_TYPE;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'FUNDING_METHOD'
       )
	DROP TABLE FUNDING_METHOD;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'LOAN_TYPE'
       )
	DROP TABLE LOAN_TYPE;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'SALES_STATUS'
       )
	DROP TABLE SALES_STATUS;
--
IF EXISTS(
	SELECT *
	FROM sys.tables
	WHERE NAME = N'PROPERTY_HISTORY'
       )
	DROP TABLE PROPERTY_HISTORY;
--
-- Create tables
--
CREATE TABLE PROPERTY_HISTORY
	(Property_History_ID		INT CONSTRAINT pk_property_history_id PRIMARY KEY,
	Start_Date					DATE,
	Value_History				MONEY,
	Tax_History					MONEY,
	Expense_History				MONEY,
	HOA_Expense_History			MONEY,
	Insurance_History			MONEY
	);
--
CREATE TABLE SALES_STATUS
	(Sales_Status_ID			INT CONSTRAINT pk_sales_status_id PRIMARY KEY,
	SaleStatus					NVARCHAR(10) CONSTRAINT nn_sales_status NOT NULL
	);
--
CREATE TABLE LOAN_TYPE
	(Loan_Type_ID				INT CONSTRAINT pk_loan_type_id PRIMARY KEY,
	Loan_Type					NVARCHAR(25) CONSTRAINT nn_loan_type NOT NULL,
	Principle					MONEY CONSTRAINT nn_principle NOT NULL,
	Interest_Rate				FLOAT CONSTRAINT nn_interst_rate NOT NULL,
	Term_Months					INT CONSTRAINT nn_term_months NOT NULL
	);
--
CREATE TABLE FUNDING_METHOD
	(Funding_Method_ID			INT CONSTRAINT pk_funding_method_id PRIMARY KEY,
	Loan_Type_ID				INT CONSTRAINT fk_funding_method_loan_type_id FOREIGN KEY
		REFERENCES LOAN_TYPE(Loan_Type_ID),
	Down_Payment				MONEY CONSTRAINT nn_down_payment NOT NULL,
	Funding_Date				DATE CONSTRAINT nn_funding_date NOT NULL
	);
--
CREATE TABLE TRANSACTION_TYPE
	(Transaction_Type_ID		INT CONSTRAINT pk_transaction_type_id PRIMARY KEY,
	Transaction_Type			NVARCHAR (5) CONSTRAINT nn_transaction_type NOT NULL
	);
--
CREATE TABLE LICENSE_STATUS
	(License_Status_ID			INT IDENTITY(1001,1) CONSTRAINT pk_license_status_id PRIMARY KEY,
	StatusText					NVARCHAR(25) CONSTRAINT nn_status_text NOT NULL
	);
--
CREATE TABLE RISK_LEVEL
	(Risk_Level_ID				INT CONSTRAINT pk_risk_level_id PRIMARY KEY,
	Risk_level					NVARCHAR (7) CONSTRAINT nn_risk_level NOT NULL
	);
--
CREATE TABLE PROPERTY_TYPE
	(Property_Type_ID			INT CONSTRAINT pk_property_type_id PRIMARY KEY,
	Type						NVARCHAR(30) CONSTRAINT nn_property_type NOT NULL,
	Zone						NVARCHAR(4) CONSTRAINT nn_property_zone NOT NULL
	);
--
CREATE TABLE BROKER				
	(Broker_ID					INT CONSTRAINT pk_broker_id PRIMARY KEY,
	License_Status_ID			INT CONSTRAINT fk_broker_license_id FOREIGN KEY 
		REFERENCES LICENSE_STATUS(License_Status_ID),
	Risk_Level_ID				INT CONSTRAINT fk_broker_level_id FOREIGN KEY
		REFERENCES RISK_LEVEL(Risk_Level_ID),
	First_Name					NVARCHAR(30) CONSTRAINT nn_broker_fname NOT NULL,
	Last_Name					NVARCHAR(30) CONSTRAINT nn_broker_lname NOT NULL,
	Hire_Date					DATE CONSTRAINT nn_broker_hire_date NOT NULL,					
	Birth_Date					DATE CONSTRAINT nn_broker_birth_date NOT NULL,					
	Gender						NVARCHAR(15), 
	Email						NVARCHAR(50),
	Work_Phone					NVARCHAR(14),
	Cell_Phone					NVARCHAR(14) CONSTRAINT nn_broker_cell_phone NOT NULL CONSTRAINT un_agent_cell_phone UNIQUE,
	Title						NVARCHAR(20) CONSTRAINT nn_broker_title NOT NULL,
	TaxID						NVARCHAR(12) CONSTRAINT nn_broker_tax_id NOT NULL,
	License_ID					NVARCHAR(10) CONSTRAINT nn_broker_license_id NOT NULL,
	License_Date				DATE CONSTRAINT nn_broker_license_date NOT NULL,
	License_Expire				DATE	 
	);	
--
CREATE TABLE INVESTOR			
	(Investor_ID				INT CONSTRAINT pk_investor_id PRIMARY KEY,
	Investor_Risk_Level			INT CONSTRAINT fk_investor_risk_level_id FOREIGN KEY
		REFERENCES RISK_LEVEL(Risk_Level_ID),
	First_Name					NVARCHAR(30) CONSTRAINT nn_investor_first_name NOT NULL,
	Last_Name					NVARCHAR(30) CONSTRAINT nn_investor_last_name NOT NULL,
	Credit_Score				INT CONSTRAINT ck_Credit_Score CHECK ((Credit_Score > 300) AND (Credit_Score < 850)),
	Email						NVARCHAR(50),
	Cell_Phone					NVARCHAR(14) CONSTRAINT nn_investor_cell_phone NOT NULL CONSTRAINT un_customer_cellphone UNIQUE,
	Address						NVARCHAR(35) CONSTRAINT nn_investor_address NOT NULL,
	City						NVARCHAR(20) CONSTRAINT nn_investor_city NOT NULL,
	State						NVARCHAR(15) CONSTRAINT nn_investor_state NOT NULL,
	Zipcode						NVARCHAR(10) CONSTRAINT nn_investor_zip_code NOT NULL,
	Social_Security_Number		NVARCHAR(11) CONSTRAINT nn_investor_social_number NOT NULL
	);
--
CREATE TABLE PORTFOLIO_PROPERTY	
	(Portfolio_Property_ID		INT CONSTRAINT pk_portfolio_property_id PRIMARY KEY,
	Investor_ID					INT CONSTRAINT fk_portfolio_investor_id FOREIGN KEY
		REFERENCES INVESTOR(Investor_ID),
	Property_Type_ID			INT CONSTRAINT fk_portfolio_property_type_id FOREIGN KEY 
		REFERENCES PROPERTY_TYPE(Property_Type_ID),
	Property_Value				MONEY CONSTRAINT nn_portfolio_property_value NOT NULL,
	Average_ROI					FLOAT CONSTRAINT nn_portfolio_average_roi NOT NULL,		
	Equity_Percent				FLOAT CONSTRAINT nn_portfolio_equity_percent NOT NULL,
	Year_Purchased				NUMERIC(4) CONSTRAINT nn_portfolio_property_year_purchased NOT NULL,
	Property_Tax				MONEY CONSTRAINT nn_portfolio_property_tax NOT NULL,
	Address						NVARCHAR(30) CONSTRAINT nn_portfolio_property_address NOT NULL,
	City						NVARCHAR(30) CONSTRAINT nn_portfolio_property_city NOT NULL,
	State						NVARCHAR(20) CONSTRAINT nn_portfolio_property_state NOT NULL,
	Zipcode						NVARCHAR(10) CONSTRAINT nn_portfolio_property_zip_code NOT NULL,
	Bedrooms					INT CONSTRAINT nn_portfolio_property_beds NOT NULL,
	Bathrooms					INT CONSTRAINT nn_portfolio_property_baths NOT NULL,
	Square_Feet					INT CONSTRAINT nn_portfolio_property_baths NOT NULL,
	Insurance					MONEY CONSTRAINT nn_portfolio_property_insurance NOT NULL,
	HOA_Expenses				MONEY,
	Property_Expenses			MONEY CONSTRAINT nn_portfolio_property_expenses NOT NULL,
	Year_Built					NUMERIC(4) CONSTRAINT nn_portfolio_property_year_built NOT NULL
	);
--
CREATE TABLE PROPERTY
	(Property_ID				INT CONSTRAINT pk_property_id PRIMARY KEY,
	Owner_ID						INT CONSTRAINT fk_property_investor_id FOREIGN KEY 
		REFERENCES INVESTOR(Investor_ID),
	Property_Type_ID				INT CONSTRAINT fk_property_property_type_id FOREIGN KEY 
		REFERENCES PROPERTY_TYPE(Property_Type_ID),
	Property_History_ID			INT CONSTRAINT fk_poperty_property_history FOREIGN KEY
		REFERENCES PROPERTY_HISTORY(Property_History_ID),
	Value						MONEY,
	Address						NVARCHAR(30) CONSTRAINT nn_property_address NOT NULL,
	City						NVARCHAR(30) CONSTRAINT nn_property_city NOT NULL,
	State						NVARCHAR(20) CONSTRAINT nn_property_state NOT NULL,
	Zipcode						NVARCHAR(10) CONSTRAINT nn_property_zip_code NOT NULL,
	Bedrooms					INT CONSTRAINT nn_property_beds NOT NULL,
	Bathrooms					NUMERIC(4) CONSTRAINT nn_property_baths NOT NULL,
	SqFt						INT CONSTRAINT nn_property_sqft NOT NULL CONSTRAINT ck_property_sqft CHECK (SqFt > 0),
	Tax_Expenses				MONEY,
	HOA_Expenses				MONEY,
	Insurance_Expenses			MONEY,
	Property_Expense			MONEY,
	Year_Built					NUMERIC(4) CONSTRAINT nn_property_year_built NOT NULL
	);
--
CREATE TABLE LISTING
	(Listing_ID					INT CONSTRAINT pk_listing_id PRIMARY KEY,
	Property_ID					INT CONSTRAINT fk_listing_property_id FOREIGN KEY 
		REFERENCES PROPERTY(Property_ID),
	Listing_Broker_ID			INT CONSTRAINT fk_listing_agent_id FOREIGN KEY 
		REFERENCES BROKER(Broker_ID),
	Sale_Status_ID				INT CONSTRAINT fk_listing_sale_status_id FOREIGN KEY 
		REFERENCES SALES_STATUS(Sales_Status_ID),
	Begin_List_Date				DATE DEFAULT GETDATE() CONSTRAINT nn_begin_list_date NOT NULL,
	End_List_Date				DATE DEFAULT GETDATE() + 150,
	Asking_Price				MONEY CONSTRAINT nn_listing_asking_price NOT NULL
	);
--
CREATE TABLE [TRANSACTION]
	(Transaction_ID				INT CONSTRAINT pk_transaction_id PRIMARY KEY,
	Investor_ID					INT CONSTRAINT fk_transaction_investor_id FOREIGN KEY 
		REFERENCES INVESTOR(Investor_ID),
	Broker_ID					INT CONSTRAINT fk_transaction_broker_id FOREIGN KEY 
		REFERENCES BROKER(Broker_ID),
	Listing_ID					INT CONSTRAINT fk_transaction_listing_id FOREIGN KEY 
		REFERENCES LISTING(Listing_ID),
	Transaction_Type_ID			INT CONSTRAINT fk_transaction_transaction_type_id FOREIGN KEY 
		REFERENCES TRANSACTION_TYPE(Transaction_Type_ID),
	Funding_Method_ID			INT CONSTRAINT fk_transaction_funding_method_id FOREIGN KEY 
		REFERENCES FUNDING_METHOD(Funding_Method_ID),
	Transaction_Date			DATE,
	Transaction_Price			MONEY CONSTRAINT nn_transaction_bid_price NOT NULL,
	Transaction_Commission_Rate	NUMERIC(4,4) CONSTRAINT nn_transaction_commission_rate NOT NULL
	);

--
--- Load table data
--
EXECUTE (N'BULK INSERT PROPERTY_HISTORY FROM ''' + @data_path + N'PropertyHistory.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	TABLOCK
	);
');
--
--
EXECUTE (N'BULK INSERT SALES_STATUS FROM ''' + @data_path + N'SaleStatus.csv''		
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT LOAN_TYPE FROM ''' + @data_path + N'LoanType.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT FUNDING_METHOD FROM ''' + @data_path + N'FundingMethod.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT TRANSACTION_TYPE FROM ''' + @data_path + N'TransactionType.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT LICENSE_STATUS FROM ''' + @data_path + N'LicenseStatus.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT RISK_LEVEL FROM ''' + @data_path + N'RiskLevel.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT PROPERTY_TYPE FROM ''' + @data_path + N'PropertyType.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT BROKER FROM ''' + @data_path + N'Broker.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT INVESTOR FROM ''' + @data_path + N'Investor.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT PORTFOLIO_PROPERTY FROM ''' + @data_path + N'PortfolioProperty.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT PROPERTY FROM ''' + @data_path + N'Property.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT Listing FROM ''' + @data_path + N'Listing.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
EXECUTE (N'BULK INSERT [TRANSACTION] FROM ''' + @data_path + N'Transaction.csv''
WITH (
	CHECK_CONSTRAINTS,
	CODEPAGE=''ACP'',
	DATAFILETYPE = ''char'',
	FIELDTERMINATOR= '','',
	ROWTERMINATOR = ''\n'',
	KEEPIDENTITY,
	TABLOCK
	);
');
--
--- List table names and row counts for confirmation				'
--
GO
SET NOCOUNT ON
SELECT 'PROPERTY_HISTORY' AS "Table",	COUNT(*) AS "Rows"	FROM PROPERTY_HISTORY		UNION
SELECT 'SALES_STATUS',					COUNT(*)			FROM SALES_STATUS    		UNION
SELECT 'LOAN_TYPE',						COUNT(*)			FROM LOAN_TYPE  			UNION
SELECT 'FUNDING_METHOD',				COUNT(*)			FROM FUNDING_METHOD   		UNION
SELECT 'TRANSACTION_TYPE',				COUNT(*)			FROM TRANSACTION_TYPE       UNION
SELECT 'LICENSE_STATUS',				COUNT(*)			FROM LICENSE_STATUS			UNION
SELECT 'RISK_LEVEL',					COUNT(*)			FROM RISK_LEVEL     		UNION
SELECT 'PROPERTY_TYPE',					COUNT(*)			FROM PROPERTY_TYPE  		UNION
SELECT 'PORTFOLIO_PROPERTY',			COUNT(*)			FROM PORTFOLIO_PROPERTY		UNION
SELECT 'BROKER',						COUNT(*)			FROM BROKER					UNION
SELECT 'INVESTOR',						COUNT(*)			FROM INVESTOR      			UNION
SELECT 'PROPERTY',						COUNT(*)			FROM PROPERTY      			UNION
SELECT 'LISTING',						COUNT(*)			FROM LISTING       			UNION
SELECT 'TRANSACTION',					COUNT(*)			FROM [TRANSACTION]
ORDER BY 1;
SET NOCOUNT OFF
GO
