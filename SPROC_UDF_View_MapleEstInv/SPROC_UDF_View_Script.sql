--- PHASE I SCRIPT
--- Writen By Retzio Gredig
--- Originally Writen 4/22/21
--- Peer Reviewed By Nicholas Brinich
--- Last Edited 5/3/21
---
-------------------------------------------------------------------------------------------------------------------------
--
--- VIEW
--

--	This View is for managers to keep track of the sales and listings all of the brokers have. 
--	This will allow the brokers to keep track of the amount of revenue the Broker is bringing in for the firm and themselves.
--	This will also show if a broker has sold yet and also if they have a current listing as well as how many days it has been since their last sale.


---Go To Maple Estate Investments
USE MapleEstInvest
GO
--- Delete if Exists
IF EXISTS	(SELECT * FROM sys.objects
			WHERE NAME = N'BrokerView')
			DROP VIEW BrokerView
GO

CREATE VIEW BrokerView
AS 
	SELECT	BROKER.First_Name AS 'Broker First Name', 
			BROKER.Last_Name AS 'Broker Last Name', 
			COUNT(LISTING.Listing_Broker_ID) AS 'Total Listings',
			COUNT([TRANSACTION].Broker_ID) AS 'Total Sales',
			MAX([TRANSACTION].Transaction_Date) AS 'Last Transaction',
			SUM([TRANSACTION].Transaction_Price) AS 'Total Value Sold'
	FROM BROKER
	INNER JOIN LISTING
		ON BROKER.Broker_ID = LISTING.Listing_Broker_ID
	LEFT JOIN [TRANSACTION]
		ON LISTING.Listing_ID = [TRANSACTION].Listing_ID
	INNER JOIN PROPERTY
		ON PROPERTY.Property_ID = LISTING.Property_ID
	INNER JOIN PROPERTY_TYPE
		ON PROPERTY_TYPE.Property_Type_ID = PROPERTY.Property_Type_ID
	GROUP BY BROKER.First_Name, BROKER.Last_Name
WITH CHECK OPTION;
GO

SELECT	[Broker First Name], [Broker Last Name], ([Total Listings] - [Total Sales]) AS 'Current Listings', [Total Sales], [Last Transaction],
		DATEDIFF(DAY, [Last Transaction], GETDATE()) AS 'Days Since Last Sold',
		'$' + CONVERT(NVARCHAR, [Total Value Sold], 1) As 'Properties Sold'
FROM BrokerView
ORDER BY 1;

-------------------------------------------------------------------------------------------------------------------------
--
---UDF
--

--	This UDF will let you know the average home prices in a City. 
--	This is good for people moving to colorado who want to get a good idea of what the average home price is for different areas.

---Go To Maple Estate Investments
USE MapleEstInvest
GO

--- Delete if Exists
IF EXISTS	(SELECT * FROM sys.objects
			WHERE NAME = N'ufn_home_prices')
			DROP FUNCTION ufn_home_prices
GO

-- Create Function
Create FUNCTION ufn_home_prices
				(@City NVARCHAR (30))
				RETURNS MONEY
BEGIN
	DECLARE @Tally INT, @HomePrices MONEY
	SELECT @Tally = COUNT(*)
	FROM PROPERTY
	WHERE PROPERTY.City = @City
	IF @Tally = 0
		SET @HomePrices = -1
	ELSE
		BEGIN
			SELECT @HomePrices = AVG(PROPERTY.Value)
			FROM PROPERTY 
			WHERE PROPERTY.City = @City
		END
	RETURN @HomePrices
END;

--- Test Function
GO

SELECT dbo.ufn_home_prices ('Pueblo') AS "Home Prices in Denver"; 

SELECT dbo.ufn_home_prices ('Denver') AS "Home Prices in Denver";

SELECT dbo.ufn_home_prices ('NotATown') AS "No Such Town";


-------------------------------------------------------------------------------------------------------------------------
--
---SPROC
--

-- This SPROC will be used to monitor the value of an investors portfolio, ROI, Revenue, Expenses and other helpful ratios.
-- Grouping by property type will allow the brokerage to better understand in what sector they have the most money as well as what is providing them with the most ROI.
-- Knowing these metrics will alow us to more accuretly adice the investor on what to buy and sell.

---Go To Maple Estate Investments
USE MapleEstInvest
GO
--- Delete if Exists
IF EXISTS	(SELECT * FROM sys.objects
			WHERE NAME = N'usp_InvestorAnalysis')
			DROP PROCEDURE usp_InvestorAnalysis
GO

-- Create Sproc
CREATE PROCEDURE usp_InvestorAnalysis(@FName NVARCHAR(30)=NULL, @LName NVARCHAR(30)=NULL)
AS
BEGIN
	DECLARE @InvestorPropertyCt INT
	IF @FName IS NULL OR @LName IS NULL
	BEGIN
		SELECT 'Omitted parameter: The form to use this procedure is: EXEC CustomerOrder''<FirstName>'''' <LastName>'''  AS 'Warning Message'
		RETURN (-1)
		END
	ELSE
		BEGIN
		SELECT @InvestorPropertyCt = COUNT (INVESTOR.Investor_ID)
		FROM PORTFOLIO_PROPERTY
		INNER JOIN INVESTOR
			On INVESTOR.Investor_ID = PORTFOLIO_PROPERTY.Investor_ID
		WHERE INVESTOR.First_Name = @Fname AND INVESTOR.Last_Name = @Lname
		IF @InvestorPropertyCt = 0 
			BEGIN
				SELECT 'The investor' + ' ' + @Fname + ' ' + @Lname + ' does not have any properties in our records.' AS 'Warning Message'
				RETURN (-1)
			END
		SELECT	(CASE WHEN PROPERTY_TYPE.Type IS NOT NULL THEN PROPERTY_TYPE.Type ELSE 'Total' END) AS 'Property Type',
		'$' + CONVERT(NVARCHAR, SUM(PORTFOLIO_PROPERTY.Property_Value), 1) AS 'Total Property Value',
		'$' + CONVERT(NVARCHAR, SUM(CONVERT (MONEY, (PORTFOLIO_PROPERTY.Property_Value * PORTFOLIO_PROPERTY.Equity_Percent))), 1) AS 'Total Equity In Properties',
		'$' + CONVERT(NVARCHAR, SUM(PORTFOLIO_PROPERTY.Insurance + PORTFOLIO_PROPERTY.Property_Expenses + ISNULL(PORTFOLIO_PROPERTY.HOA_Expenses, 0)),1) AS 'Total Expenses',
		'$' + CONVERT(NVARCHAR, SUM(CONVERT (MONEY, (PORTFOLIO_PROPERTY.Property_Value * PORTFOLIO_PROPERTY.Average_ROI))), 1) AS 'Total Profit',
		CONVERT(NVARCHAR, ROUND(AVG(PORTFOLIO_PROPERTY.Equity_Percent),2)) + '%' AS 'Average Equity %',
		CONVERT(VARCHAR, ROUND(AVG(PORTFOLIO_PROPERTY.Average_ROI),2)) + '%' AS 'Average ROI %'
		FROM INVESTOR
		INNER JOIN PORTFOLIO_PROPERTY
			On INVESTOR.Investor_ID = PORTFOLIO_PROPERTY.Investor_ID
		INNER JOIN PROPERTY_TYPE
			ON PROPERTY_TYPE.Property_Type_ID = PORTFOLIO_PROPERTY.Property_Type_ID
		WHERE INVESTOR.First_Name = @FName AND INVESTOR.Last_Name = @LName
			GROUP BY PROPERTY_TYPE.Type WITH ROLLUP
		ORDER BY SUM(CONVERT (MONEY, (PORTFOLIO_PROPERTY.Property_Value * PORTFOLIO_PROPERTY.Average_ROI),1)) DESC
		RETURN (0)
	END
END;

--- Test SPROC
GO

EXEC usp_InvestorAnalysis 'Herman','McEwan';

EXEC usp_InvestorAnalysis 'Izabel','Odam';

EXEC usp_InvestorAnalysis @Lname='Gredig', @Fname='Retzio';

EXEC usp_InvestorAnalysis;