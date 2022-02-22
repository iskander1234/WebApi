# WebApi.Task Tracker
Web application for task tasks<br>

## Used database
Used database **Postgres SQL**<br>
To connect PostgresSQL, the library **Npgsql.EntityFrameworkCore.PostgresSQL** was used<br>

## Application Options
The project is implemented on the Web API platform.
Using the Swagger library for project documentation. Also used EntityFrameworkDesin for DB optimizations.
The project implements Controller and Model .
Didn't implement Service so IService interfaces for logic description
To add **Web Api** to the project, we need to add the following NuGet packages.<br>

## To launch a project
You need to add the database in PGAdmin to the local database
And you need to change the appsetings.json DefaultConnection for yourself
dotnet ef migrations add
dotnet ef database update - procedure update 
And click on run in development environment<br>
