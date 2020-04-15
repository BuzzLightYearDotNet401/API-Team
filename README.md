# Health At Home

## Team BuzzLightYear
---
### We are deployed on Azure!

<!-- [project url here] -->

---
## Web Application
<!-- ***[Explain your app, should be at least a paragraph. What does it do? Why should I use? Sell your product!]***

The web application consists of a frontend written in Razor views, HTML, CSS,
Bootstrap, Popper, and jQuery. The backend was written in C# using ASP.NET Core 2, Entity Framework Core, and the MVC framework.

An interface is provided to create new blog
posts, view existing blog posts, edit existing blog posts, delete existing
blog posts, and search by both keywords and usernames. All blog posts can be
enriched using Azure Language Services (part of Microsoft's Cognitive Services
suite), Bing Image API, and Parallel Dots (for automated tagging of posts via
key phrases detected within the post's body). Image enrichments can be added
based on the overall sentiment score (a range 0.0 - 1.0 related to the mood
of the post) and key phrases / keywords detected in the posts. Optionally, users
can choose to opt-out of these features for privacy or data collection concerns. -->

---

## Tools Used
Microsoft Visual Studio Community 2019 

- C#
- ASP.Net Core
- Entity Framework
- MVC
- Azure
<!-- - Parallel Dots API -->

---

## Recent Updates

#### V 1.4
<!-- *Added OAuth for MySpace* - 23 Jan 2003 -->

---

## Getting Started

Clone this repository to your local machine.

```
$ git clone https://github.com/BuzzLightYearDotNet401/API-Team.git
```
Once downloaded, you can either use the dotnet CLI utilities or Visual Studio 2017 (or greater) to build the web application. The solution file is located in the AmandaFE subdirectory at the root of the repository.
```
cd YourRepo/YourProject
dotnet build
```
The dotnet tools will automatically restore any NuGet dependencies. Before running the application, the provided code-first migration will need to be applied to the SQL server of your choice configured in the /AmandaFE/AmandaFE/appsettings.json file. This requires the Microsoft.EntityFrameworkCore.Tools NuGet package and can be run from the NuGet Package Manager Console:
```
Update-Database
```
Once the database has been created, the application can be run. Options for running and debugging the application using IIS Express or Kestrel are provided within Visual Studio. From the command line, the following will start an instance of the Kestrel server to host the application:
```
cd YourRepo/YourProject
dotnet run
```
Unit testing is included in the AmandaFE/FrontendTesting project using the xUnit test framework. Tests have been provided for models, view models, controllers, and utility classes for the application.

---

## Usage
<!-- ***[Provide some images of your app with brief description as title]*** -->

### Overview of Recent Posts
<!-- ![Overview of Recent Posts](https://via.placeholder.com/500x250) -->

### Creating a Post
<!-- ![Post Creation](https://via.placeholder.com/500x250) -->

### Enriching a Post
<!-- ![Enriching Post](https://via.placeholder.com/500x250) -->

### Viewing Post Details
<!-- ![Details of Post](https://via.placeholder.com/500x250) -->

---
## Data Flow (Frontend, Backend, REST API)
- When the user "logs in" to the app, a request is made to the Users table of the database and determines if that user exists.
  - If the user exists, then the username is returned, and they are "logged in".
  - If the user does not exist, then a user is created and inserted into the DB, and then they are "logged in".
- When the user views the list of routines, a request is made to the Routines table, and returns a list of all routines in the database. The data is then enumerated over and rendered on the routines View.
- When the user decides to view a specific routine, a request is made to the DB for the routine, which then returns the exercies associated with that routine and renders them on the specific routine View.
- When a user clicks to give a routine a rating, a form is submitted to the Ratings table that associates the rating given to the entry matched by the UserID and the RoutineID.
- When a user views the "Liked Routines" View, the DB is queried for all Routines that match the UserID and have a Rating of at least three stars.  
![Domain Model](./assets/DomainModel410.png)

---
## Data Model

### Overall Project Schema
<!-- ***[Add a description of your DB schema. Explain the relationships to me.]***
![Database Schema](/assets/img/ERD.png) -->
Our schema consists of 5 tables: User, Rating, Exercise, Routine Name, Routine. 
User:  
Rating:  
Exercise:  
Routing Name:  
Routine:  

![Database Schema](./assets/HealthAtHomeERD.png)

---
## Model Properties and Requirements

### Blog

<!-- | Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
| Summary | string | YES |
| Content | string | YES |
| Tags | string(s) | NO |
| Picture | img jpeg/png | NO |
| Sentiment | float | NO |
| Keywords | string(s) | NO |
| Related Posts | links | NO |
| Date | date/time object | YES | -->


### User

<!-- | Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
| Name/Author | string | YES |
| Posts | list | YES | -->

---

## Change Log
1.5: *Created DTOs for Users, Exercises, and Ratings* - 14 April 2020 
1.4: *Users, Exercises, and RoutineNames successfully renders to Postman* - 14 April 2020  
1.3: *Created the Interface, Service, and Controllers for Exercises, Rating, User, and RoutineName models* - 14 April 2020  
1.2: *Seeded dummy data into the database for deployment and deployed web app and database on azure* - 13 April 2020  
1.1: *Created initial skeleton for our database* - 12 April 2020   

---

## Authors
[Sue Tarazi](https://www.linkedin.com/in/sue-tarazi-b792b520/)  
[Allyson Reyes](https://www.linkedin.com/in/allyson-reyes/)  
[Brandon Johnson](https://www.linkedin.com/in/brandon-johnson-33a581109/)   
[Robert Neilsen](https://www.linkedin.com/in/robertjnielsen/)  
[Carrington Beard](https://www.linkedin.com/in/carrington-beard/)

---
