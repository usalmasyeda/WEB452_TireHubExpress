
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

(6:23 PM)

- Models folder > Add > Class > Tire.cs
- Updated Tire.cs with the following attributes: 
* Name
* Type
* Material 
* Durability
* Stock
* Price
* Review

- NuGet Package Manager > Package Manager Console (PMC) > Installed Microsoft.EntityFrameworkCore.SqlServer (VERSION 3.0.0)
- NOT GOING TO CREATE A DATA FOLDER SINCE ITS ALREADY THERE. 
- I dont need to make any changes to Startup.cs, Startup.ConfigureServices, appsettings.json file because after all the failed attempts I have realized that 
because I (Included Individual User Accounts authentication and configure for HTTPS.) It already made those changes for me.

BUILD THE PROJECT AND NO COMPILER ERRORS!!

- Controllers folder > Add > New Scaffolded Item > MVC Controller with views, using Entity Framework > Add
- Model class: Tire(TireHubExpress.Models)
- Default value for Data Context Class

ERROR!! (The entity type tire requires a primary key to be defined. If you intended to use a keyless entity call 'hasnokey()'. 

15 Mins Later : Realized that I was missing : public int Id { get; set; } in Tire.cs folder!!!!!

- Scaffolded it again, and Successfull!!

TRYING TO FIGURE OUT HOW TO CALL DbClass when there are two!!
20 Mins later!! Successfull!

Initial Migration: 
- Add-Migration -Context TireHubExpressContext InitialCreate
- Update-Database -Context TireHubExpressContext 

TESTING THE APP, SUCCESSFULL!
- Commit & Push to GitHub

---------------------------------------------------------------------------------------------------------------------------------

(7:10 PM)

- Created a SeedData Class in Models Folder
- Update README.txt
- Commit & Push to GitHub

(11:21 PM)

- Updated Product Information in the SeedData Class
- Added the seed initializer
- Updated content in Program.cs based on the product 'Tire'

GETTING ERRORS!!
- Migration is not working after updating the SeedData.cs File
- Something is wrong with my laptop, need to use college computer

--------------------------------------------------------------------------------------------------------------------------------

2023-10-13
(9:31 AM)

- Using St Clair College Computer, Clone Repo from GitHub
- Clean and Build application
- Using (Update-Database -Context TireHubExpressContext) to update the data to show up on the browser. 
- Update was successfull
- Running Application, Data was successfully shown on the table on the brower.
- Made some adjustments in the Models > Tire.cs File > Added some validation

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Material { get; set; }

        [Required]
        public string  Durability { get; set; }

        [Required]
        public int Stock { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Range(1, 5)]
        public int Review { get; set; }

- Updated README.txt
- Committed & Push to GitHub

----------------------------------------------------------------------------------------------------------------------

(10:00 AM)

- Adding a Search function
- Updated the Index method inside Controllers/TiresControllers.cs
- Added a search by Type to the Index view
- Testing Application, Successfull

(10:15 AM)

- Created two new pages in the Views > Home Folder 
- Page About.cshtml and Catalogue.cshtml
- Connected them to the HomeController.cs File in Controllers Folder
- In the _Layout.cshtml, added the navagation links for the two new pages I created. 
- Tested the pages, everything works great!
- Updated README.txt, Committed & Push to GitHub

(3:00 PM)
- Worked more on the content of About page and Catalogue Page
- Made an img folder, added images
- Used Bootstrap to playa round with styling useing site.css
- Downloaded Fonts folder and changed the font
- Making more I have comments throughout the application






