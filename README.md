# Overview of Database

This database I built is for a mock company called Maple Estate Investments. The company is a real estate brokerage that specializes in growing and managing real estate portfolios for investors. There are a few things that make Maple Estate Investments so unique. The company tracks the MLS and off-market deals for any properties that have good capitalization rates and cash flow potential for investing. Maple Estate Investments also monitor investors' current portfolio making sure all properties have good returns. If a home isn't performing well, they want to diversify, or they want to grow their portfolio we can conduct any transactions needed through the brokerage. The brokerage also tracks all current loans to factor in interest payments and amortization. If an investor qualifies for a better loan that is more aligned with their unique needs and goals, we work heavily with loan officers to help them get the best possible loans. We meet with our investors regularly to discuss the current goals for their portfolio and the amount of risk/return they are willing to take, and based on those factors we take any needed actions to help them achieve those goals.

With all this information being recorded, stored, and analyzed, Maple Estate Investments needs a database. That is why I built Maple_Estate_Investments_Database. I've included a build script for the database as well as views, stored procedures, and user-defined functions in Microsoft SQL Server Management Studios. I created forms and reports for the database in Microsoft Visual Studios to help track the database and add data entries as needed. Lastly, I created a dashboard for management to track ongoing sales and other important metrics in Power BI.

---

# Build Database for Maples Estate Investments
for build script, see [BuildMapleEstateInvestments.sql](https://github.com/Retzio/MapleEstateInvestments_Database/blob/main/BuildMapleEstateInvestments.sql) and for the .csv files for the build script, see [BuildMapleEstateInvestments_CSV](https://github.com/Retzio/MapleEstateInvestments_Database/tree/main/BuildMapleEstateInvestments_CSV).

---

# SROC, UDF, View
The [VS_Forms_Reports_MapleEstateInvestments](https://github.com/Retzio/MapleEstateInvestments_Database/tree/main/VS_Forms_Reports_MapleEstateInvestments)
builds usefull SPROC, UDF, and View for the database. See file READMe for more details and specific use cases.

---

# Power BI Dashboard
For a dashboard created to view important metrics for the brokers and management to view, see [PowerBI_Dashboard_MapleEstateInvestments](https://github.com/Retzio/MapleEstateInvestments_Database/tree/main/PowerBI_Dashboard_MapleEstateInvestments)

---

# Microsoft Visual Studios Reports and Forms
See [VS_Forms_Reports_MapleEstateInvestments](https://github.com/Retzio/MapleEstateInvestments_Database/tree/main/VS_Forms_Reports_MapleEstateInvestments) for sulutions files to the Microsoft Visual Studios Forms and Reports. 

See the file READMe for further detail on the purpose and use cases for each form and report, and see the video below for a walkthrough of them all.

---

# ERD Diagram of OLTP Database
![ERD_MapleEstInv](https://user-images.githubusercontent.com/105741175/169903508-ba2700a8-b0e0-4bf4-8fd6-782307879864.PNG)

---

# Walkthrough of Microsoft Visual Studios Reports and Forms

https://user-images.githubusercontent.com/105741175/169918144-5dc6b2c2-7064-4a1d-b035-74f0d76e9e69.mp4

