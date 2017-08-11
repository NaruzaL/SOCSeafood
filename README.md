# Son of Cod Seafood

#### Week 2 .NET independent project, 08.11.2017

#### **By Pete Lazuran**

## Description

A webpage for Jesus Quintana's (of "The Big Lebowski" fame) seafood company.
## Specs

|Behavior|User Action/Selection|Description|
|---|:---:|:---:|
|Subscribe to newsletter|User enters their interests and submits|User's email added to subscription list|
|List all newsletter subscribers|Click "View list of Subscribers"|Display emails of all subscribers |
|Delete user subscription|Delete: "user@gmail.com"|A delete function. |
|Update a user's subscription info|User updates email or interests|An update function. |

## Setup/Installation Requirements

**Note that this project was made using MSSQL server management studio 17 and Visual Studio 2015**

To run this project:

* Clone this repository.
* In PowerShell navigate to the directory that contains the project.json file (...\SOCSeafood\src\SOCSeafood>)
* Enter the command "dotnet ef database update" to create the database
* Open the project in visual studio and press the "IIS Express" button located in the top center


## Support and contact details

If you have any issues or have questions, ideas, concerns, or contributions please contact me through through Github.

## Known Bugs

2nd layer of background not applied to account home link in detail page becauase of the way the styling is setup. Not really a bug, just a continuity error.

## Technologies Used

* MSSQL Server Management Stuido 17
* Visual Studio 2015
* C# / ASP.NET
* CSS

### License
This software is licensed under the MIT license.

Copyright (c) 2017 **Pete Lazuran**
