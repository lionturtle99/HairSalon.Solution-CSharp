<h1 align="center">HairSalon</h1>

#### By: Liam Eller

#### __

## Technologies Used

* C#
* html
* Markdown
* CSS
* Razor
* ASP .NET Core
* ASP .NET Core MVC


## Description

__

## Setup/Installation Requirements

1. Clone this repository to your desktop.
2. Open your terminal.
3. Navigate to the downloaded project by typing "cd (name of the project)".
4. Run "code ." to open program in VSCode to edit or view code.
5. Navigate to the (name of the project) directory
6. type "dotnet build" then "dotnet run" to run application in your the terminal.

## Connection String

_Next, we need to add the database connection to our app. We'll do this using the connection string we currently have as a property of the DBConfiguration class in our Startup.cs file._

_Before we move forward with this, it's important to note that the file we are about to create will store sensitive information that we don't want to share with the world. As such, before we make any commits with it in our project, we should add this "*/appsettings.json" to our .gitignore:_

_Now we'll store the connection string in a new file called appsettings.json in the directory of our project's production folder, HairSalon/:_

#### Inside HairSalon/appsettings.json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
_Note that the database will change based on the database we are connecting to and that uid and pwd may vary as well depending on MySql configurations._

## Known Bugs

* No known bugs at this time.

## License

_[MIT](https://opensource.org/licenses/MIT)_

Copyright (c) 2022 Liam Eller
