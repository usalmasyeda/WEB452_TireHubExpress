2023-10-10
(2:22 PM)

Created by: Umme Salma Syeda
Program Name: TireHubExpress
Purpose: To build a robust MVC web application to generate a product (Tire) catalogue allowing for CRUD operations.

*Attempt #1 - Something is wrong with Visual Studio 2019 not opening, installing again on personal computer.

--------------------------------------------------------------------------------------------------------------------
2023-10-11
(12:10 PM)

*Attempt #2 Connecting to GitHub was not working when working with a personal device (Laptop).
- Going to try again with a college computer. 

----------------------------------------------------------------------------------------------------------------------

2023-10-11 
(2:25 PM)

*Attempt #3 - Included Individual User Accounts authentication and configure for HTTPS.
- Due to adding Individual User authentication, additional code was added as well as the Data Folder.
- Came across many errors: connetionString errors
- Tried to fix it, realized that since the Data folder is already there, I can maybe skip over that step in the tutorial. 

-----------------------------------------------------------------------------------------------------------------------

2023-10-12
(5:32 PM)

*Attempt #4

- Created a new ASP.NET Core Web App (MVC)
- With no authentication
- Using .NET Core 3.1 (out-of-support)
- Included Individual User Accounts authentication and configure for HTTPS.
- Created a Github repository (Git > Create Git repository...) to backup my application.
- properties/launchsettings.json, [Line 7 commented out //"sslPort": 44321]

- Tested Application, Successful!
- Created README.txt file
- Updated README.txt
- Commit & Push to GitHub

------------------------------------------------------------------------------------------------------------------------

Making sure Index Method works! 

- Replaced Index method with IActionResult Index() in HelloWorldController class
- Created a new folder 'HelloWorld' > Add > New Item > Razor View - Empty > Index.cshtml
- Added Content @{ViewData}, <h2> and <p> tag information about the product "Tires"
- Application tested for view template, Successfull!

- In Views/Shared/_Layout.cshtml file three changes were made: 
  * <title>@ViewData["Title"] - Tire Hub Express</title>
  * <a class="navbar-brand" asp-controller="Tires" asp-action="Index">Tire Hub Express</a>
  * &copy; 2020 - Tire Hub Express - <a asp-area="" asp-controller="Tires" asp-action="Privacy">Privacy</a>
  
- Tested Application, Successfull! 
- Updated README.txt
- Commited & Push to GitHub

--------------------------------------------------------------------------------------------------------------------------

