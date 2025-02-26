# DealAPI - Deal Management System
Overview
DealAPI is an ASP.NET Core API that helps manage deals and their associated hotels. This API allows users to perform CRUD operations on deals and associated hotels. It provides endpoints for creating, retrieving, updating, and deleting deals, while also supporting Swagger-based API documentation for easy interaction and testing.

<b><span style="color: #2B547E;">✨ Key Features</span></b>
Deal Management: Create, read, update, and delete deals.
Hotel Management: Add hotels to deals, with each hotel having a name, location, and description.
Swagger API Documentation: Interactive documentation for easy testing of the API.
PostgreSQL Database: Uses PostgreSQL as the database for storing deal and hotel data.
Prerequisites
Before running the application, make sure you have the following installed on your machine:

.NET 6 SDK (or later): Download .NET SDK
PostgreSQL: A PostgreSQL database server to store the application data.
Visual Studio 2022 (or later) or any code editor: Download Visual Studio
Postman (Optional for testing): Download Postman
Setting Up the Application Locally
1. Clone the Repository
Clone the repository to your local machine using the following command:

bash
Copy
git clone https://github.com/your-username/DealAPI.git
cd DealAPI
2. Install Dependencies
If you’re using Visual Studio:

Open the solution file (DealAPI.sln).
Visual Studio will automatically restore the required NuGet packages. If not, you can manually restore them from NuGet Package Manager.
Alternatively, using the .NET CLI, run:

bash
Copy
dotnet restore
3. Configure the Database Connection
This application uses PostgreSQL for storing data. To configure the database:

Open the appsettings.json file.
In the "ConnectionStrings" section, replace the "DealConnectionString" value with your PostgreSQL connection string.
Example:

json
Copy
{
  "ConnectionStrings": {
    "DealConnectionString": "Host=localhost;Port=5432;Database=DealDB;Username=your-username;Password=your-password"
  }
}
4. Run the Application
To run the application, you can use either Visual Studio or the .NET CLI.

Option 1: Using Visual Studio
Open the solution (DealAPI.sln) in Visual Studio.
Set the API project as the startup project.
Press Ctrl + F5 to run the application.
Option 2: Using the .NET CLI
Open a terminal/command prompt.
Navigate to the project directory.
Run the following command:
bash
Copy
dotnet run
By default, the application will run at https://localhost:5001 (HTTPS) and http://localhost:5000 (HTTP). You can modify the port in Properties/launchSettings.json if needed.

5. Verify the Application is Running
Once the application is running, visit:

Swagger API Documentation: http://localhost:5000/ (or https://localhost:5001/ if using HTTPS).
Swagger will provide an interactive interface where you can test all the API endpoints (such as creating deals, retrieving them, etc.).

API Documentation (Swagger/OpenAPI)
The API documentation is automatically generated using Swagger/OpenAPI. You can access it through Swagger UI:

Swagger UI: http://localhost:5000/
Swagger will allow you to:

View all available endpoints.
Interact with the API by sending test requests.
View the expected request/response models and error messages.
Example Endpoints:
POST /api/deals: Create a new deal.
GET /api/deals: Get all deals.
GET /api/deals/{id}: Get a deal by ID.
PUT /api/deals/{id}: Update an existing deal.
DELETE /api/deals/{id}: Delete a deal.
Running Migrations
If this is your first time running the application and you need to set up the database:

Open the Package Manager Console or terminal.
Run the following command to apply migrations:
bash
Copy
dotnet ef database update
This will create the database and apply any necessary migrations.

Testing the API (Optional)
You can test the API endpoints using Postman or the Swagger UI.

Example Test Using Swagger UI:
Open Swagger UI at http://localhost:5000/.
Navigate to POST /api/deals and click Try it out.
Fill in the request body with valid data (as described in the API documentation).
Press Execute to create a deal.
Example Test Using Postman:
You can also test API endpoints in Postman by sending POST, GET, PUT, or DELETE requests to the corresponding endpoints.

Troubleshooting
Common Issues:
PostgreSQL Connection Issues: Ensure PostgreSQL is running and your connection string in appsettings.json is correct.
Missing Dependencies: If you encounter missing dependencies, make sure to run dotnet restore to restore the NuGet packages.
