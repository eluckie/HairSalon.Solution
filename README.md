# Eau Claire Salon

#### By E. Luckie ☀️

#### This MVC application acts as a tool for a salon owner to manage their stylists and salon clients.

## Technologies Used

* C#
* .NET 7.0
* EF Core 7.0
* MySQL Workbench
* HTML
* Markdown
* Git

## Description

This application is intended to help a salon owner keep track of all their stylists and salon clients. The owner is able to see a list of all current stylists, see details for each specific stylist (including specialty, etc.), add new stylists to the system, and add new clients to a specific stylist.

## Setup/Installation Requirements

1. Clone this repository to your desktop
2. In your computer's terminal, navigate to the production level of this directory called _**HairSalon**_
3. In the command line, run the command ``dotnet watch run`` to compile and execute the webpage in Development mode
* Optionally, you can run the command ``dotnet build`` to compile the program without running it

### Recreating the Database
1. Within the production level of this directory, called _**HairSalon**_, create a new file called **appsettings.json**
2. Input the following code into your _**appsettings.json**_ file
_**{ADD SCREENSHOT OF APPSETTINGS CODE}**_
* replace _[ YOUR-DB-NAME ]_ with the name of the database from MySQL Workbench: _**elizabeth_luckie**_
* replace _[ YOUR-USER-HERE ]_ with your username for MySQL Workbench
* replace _[ YOUR-PASSWORD-HERE ]_ with your password for MySQL Workbench
* make sure you save the changes you've made to the file

### Flow Chart
_**{ADD SCREENSHOT OF FLOW CHART}**_

_{Leave nothing to chance! You want it to be easy for potential users, employers and collaborators to run your app. Do I need to run a server? How should I set up my databases? Is there other code this application depends on? We recommend deleting the project from your desktop, re-cloning the project from GitHub, and writing down all the steps necessary to get the project working again.}_

## Known Bugs

* No known bugs.

## Stretch Plans

* Include forms to search for stylists &/or clients by name. Display list of results
* Add functionality to add appointments to a client
* Add functionality to add appointments to a stylist & check to ensure no conflicting appointments
* Add functionality to track how much stylists are paid for each appointment
* Add styling

## License

MIT License

Copyright (c) 2023 Luckie