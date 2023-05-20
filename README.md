# Hair Salon

### By Amanda Guan

## Technology Used

* C#
* .Net6
* MSTest
* ASP.NET Core MVC
* HTML
* CSS
* Razer
* Bootstrap

### Description

- This application allows the user to input stylists and clients to the database. For each stylist, the user can add client who see that sylist. The user can also delete stylists and clients from the database.

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

### Set up the Databases

Follow the instructions in the LearnHowToProgram.com lesson ["Creating a Test Database: Exporting and Importing Databases with MySQL Workbench"](https://www.learnhowtoprogram.com/lessons/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench) to use the `first_last` file located at the top level of this repo to create a new database in MySQL Workbench with the name `first_last`.

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "ToDoList".
3. Within the production directory "ToDoList", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. 

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

5. Within the production directory "ToDoList", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs + Limitations 
* No known bugs.

## License

_Copyright (c) 2023, Amanda GUan_

## Contact Information

Amanda Guan <ag.amandaguan@gmail.com>