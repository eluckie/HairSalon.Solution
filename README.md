# Eau Claire's Salon

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

This application is intended to help a salon owner keep track of all their stylists and salon clients. The owner is able to view a list of all current stylists, see details for each specific stylist, add new stylists to the system, and add new clients to a specific stylist. There is also functionality (in the form of buttons and clickable links) to edit and delete specified clients or stylists.

### Paths
**/** Home page welcoming user to the salon. Contains links to view or add stylists, and view or add clients

**/Stylists** Stylists main page showing full list of current stylists and their specialties

**/Clients** Clients main page showing full list of current clients and their respective stylists

**/{Stylists or Clients}/Create** A form to add a new client or stylist (depending on which link was clicked)

**/Stylists/Details/{id}** A page that displays the selected stylist's name, pronouns, specialty, hire date, and any current clients. Includes links to add a new client to this stylist, edit this stylist, delete this stylist, or return back to the full list of stylists or home page

**/{Stylists or Clients}/Edit/{id}** A form to edit the current client or stylist (depending on which link was clicked). Both forms include links that say _Nevermind_ and take the user back to the respective main pages, and a link instead go back to the main welcome page

**/{Stylists or Clients}/Delete/{id}** A page confirming you'd like to delete the selected Stylist or Client. Clicking the _Take them away_ button officially deletes them, and re-routes the user back to the respective main pages displaying the full list of stylists or clients. If user clicks the _Nevermind_ link instead of the button, the selected client or stylist is not deleted, and the user is re-routed back to the respective main page

**/Clients/Details/{id}** A page that displays the selected client's name, pronouns, and stylist. From there, the user is also able to choose to edit or delete the selected client.

## Setup/Installation Requirements

### Recreating the Database
1. Clone this repository to your desktop
2. Open MySQL Workbench and navigate to the _Administration_ tab
3. Under the _Management_ label, click **Data Import/Restore**
4. Under the _Import Options_ tab, select the circle for **Import from Self-Contained File** and click the small button with two dots after the text box
5. In the window that pops up, navigate to the root level of this project, titled _**HairSalon.Solution**_ and select the file titled **elizabeth_luckie.sql**
6. Under the _Default Target Schema_ tab, select the _New_ button and create a name for your new database
7. Verify your database is named properly and click the _Start Import_ button. Once complete, you will receive a confirmation from MySQL
8. Once your import is complete, navigate to the _Schemas_ tab at the top of the page. Once you click the small refresh icon in the upper right corner, your new database should populate within the list
* You will be able to click the new database name, and click the tables tab to verify that both the _clients_ and _stylists_ tables were imported properly 

### Connecting the Database
9. Return to your computer's terminal application to your newly cloned project
10. Within the production level of this directory, called _**HairSalon**_, create a new file called **appsettings.json**
11. Input the following code into your _**appsettings.json**_ file
![screenshot of appsettings.json code](HairSalon/wwwroot/img/appsettingstext.png)
* Replace _[ YOUR-DB-NAME ]_ with the name of the database you just imported to MySQL Workbench
* Replace _[ YOUR-USER-HERE ]_ with your username for MySQL Workbench
* Replace _[ YOUR-PASSWORD-HERE ]_ with your password for MySQL Workbench
* Make sure you save all changes you've made to the file
* If you are planning on pushing your work back to GitHub to a new repository, _make sure to commit your .gitignore file first so that your sensitive information is kept private_

### Viewing the Active Project
12. In your computer's terminal, navigate to the production level of this directory called _**HairSalon**_
13. In the command line, run the command ``dotnet watch run`` to compile and execute the webpage in Development mode
* This will also run the command ``dotnet restore`` to restore all necessary packages for the project. You may also choose to run this command separately before ``dotnet watch run`` to manually restore the project
* Optionally, you can run the command ``dotnet build`` to compile the program without running it

### Database Schema
![screenshot of tables used in database](HairSalon/wwwroot/img/schema.png)

## Known Bugs

* No known bugs.

## Stretch Plans

* Include forms to search for stylists &/or clients by name. Display list of results
* Add functionality to add appointments to a client
* Add functionality to add appointments to a stylist & check to ensure no conflicting appointments
* Add functionality to track how much stylists are paid for each appointment

## License

MIT License

Copyright (c) 2023 Luckie