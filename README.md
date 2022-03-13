<h1 align="center">Eau Claire's Salon</h1>

#### By: Liam Eller

#### _A website make Claire's business run smoother_

## Technologies Used

* C#
* html
* Markdown
* CSS
* Razor
* Entity
* ASP .NET Core
* ASP .NET Core MVC

## Description

_An Applications where Claire can add stylists and clients to better stay organized._
_User can navigate between pages to add stylists and clients to a database made on MySQL Work Bench._

## Setup/Installation Requirements
  
1. Follow the instruction on this [website](https://www.simplilearn.com/tutorials/mysql-tutorial/mysql-workbench-installation) for installing MySQL server, MySQL Workbench, and MySQL shell.  
5. Clone the repository to your desktop and open your terminal then Navigate to the downloaded project by typing "cd (project-name)"
2.  Open project in your desired text editor. I recommend [visual studio code.](https://code.visualstudio.com/download)
3. Create your own database from the .sql file located in the projects top most level by following these steps: 
  
    1. In the Administrations tab, under the MANAGEMENT section, click on the Data Import/Restore option.
    2. In the new window, select Import from Self-Contained File in the Import Option section
    3. Click the ".." button and select the .sql file in the project directory
    4. In the Default Schema to be Imported To section, click the "New..." button to create a new schema
    5. Hit the "Start Import" button at the bottom right of the page (enlarge the window if not seen). And then, confirm it worked in the Schemas tab by right clicking in the SCHEMAS drop down and choosing refresh all from the options
    
4. Add a new file called appsettings.json in the project's production folder and store the following
        `{
            "ConnectionStrings": {
                "DefaultConnection": "Server=localhost;Port=3306;database=[NAME-OF-THE-DATABASE-YOU-CREATED-ABOVE];uid=root;pwd=[YOUR-PASSWORD-HERE];"
            }
        }`
5. Once in the project's production folder, type "dotnet watch run" in the terminal - then navigate to your web browser and type http://localhost:5000/ in your url bar to see the application.
  
## Known Bugs

* No known bugs at this time.

## License

_[MIT](https://opensource.org/licenses/MIT)_

Copyright (c) 2022 Liam Eller
