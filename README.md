# DealAPI - Deal Management System

**DealAPI** is an **ASP.NET Core API** that helps manage deals and their associated hotels. This API allows users to perform CRUD operations on deals and associated hotels. It provides endpoints for creating, retrieving, updating, and deleting deals, while also supporting Swagger-based API documentation for easy interaction and testing.</br>

<b><span>✨ Key Features</span></b>:</br>
- **Deal Management**: Create, read, update, and delete deals.</br>
- **Hotel Management**: Add hotels to deals, with each hotel having a name, location, and description.</br>
- **Swagger API Documentation**: Interactive documentation for easy testing of the API.</br>
- **PostgreSQL Database**: Uses PostgreSQL as the database for storing deal and hotel data.</br>

---

## **✨ Prerequisites**

Before running the application, make sure you have the following installed on your machine:</br>
- **.NET 6 SDK** (or later): [Download .NET SDK](https://dotnet.microsoft.com/download/dotnet)</br>
- **PostgreSQL**: A PostgreSQL database server to store the application data.</br>
- **Visual Studio 2022** (or later) or any code editor: [Download Visual Studio](https://visualstudio.microsoft.com/downloads/)</br>
- **Postman** (Optional for testing): [Download Postman](https://www.postman.com/downloads/)</br>

---

## **✨ Setting Up the Application Locally**

 1. Clone the Repository:
Clone the repository to your local machine using the following command:</br>
git clone https://github.com/your-username/DealAPI.git</br>
cd DealAPI</br>

## **✨ Install Dependencies
If you’re using Visual Studio:</br>
Open the solution file (DealAPI.sln).</br>
Visual Studio will automatically restore the required NuGet packages. If not, you can manually restore them from NuGet Package Manager.</br>
Alternatively, using the .NET CLI, run:</br>
dotnet restore</br>

## **✨ Configure the Database Connection
This application uses PostgreSQL for storing data. To configure the database:</br>
Open the appsettings.json file.</br>
In the "ConnectionStrings" section, replace the "DealConnectionString" value with your PostgreSQL connection string.</br>
Example:</br>
{
  "ConnectionStrings": {
    "DealConnectionString": "Host=localhost;Port=5432;Database=DealDB;Username=your-username;Password=your-password"
  }
}


## **✨ Run the Application
To run the application, you can use either Visual Studio or the .NET CLI.</br>
Option 1: Using Visual Studio:</br>
Open the solution (DealAPI.sln) in Visual Studio.</br>
Set the API project as the startup project.</br>
Press Ctrl + F5 to run the application.</br>
Option 2: Using .NET CLI:</br>
Open a terminal/command prompt.</br>
Navigate to the project directory.</br>
Run the following command:</br>
dotnet run</br>
By default, the application will run at https://localhost:5001 (HTTPS) and http://localhost:5000 (HTTP). You can modify the port in Properties/launchSettings.json if needed.</br>

## **✨ Verify the Application is Running
Once the application is running, visit:</br>
Swagger API Documentation: http://localhost:5000/ (or https://localhost:5001/ if using HTTPS).</br> Swagger will provide an interactive interface where you can test all the API endpoints (such as creating deals, retrieving them, etc.).</br>


## **✨ API Documentation (Swagger/OpenAPI)
The API documentation is automatically generated using Swagger/OpenAPI. You can access it through Swagger UI:</br>
Swagger UI: http://localhost:5000/</br> Swagger will allow you to:</br>
View all available endpoints.</br>
Interact with the API by sending test requests.</br>
View the expected request/response models and error messages.</br>

Example Endpoints:</br>
POST /api/deals: Create a new deal.</br>
GET /api/deals: Get all deals.</br>
GET /api/deals/{id}: Get a deal by ID.</br>
PUT /api/deals/{id}: Update an existing deal.</br>
DELETE /api/deals/{id}: Delete a deal.</br>

## **✨ Running Migrations
If this is your first time running the application and you need to set up the database:</br>
Open the Package Manager Console or terminal.</br>
Run the following command to apply migrations:</br>
dotnet ef database update</br>
This will create the database and apply any necessary migrations.</br>

## **✨ Testing the API 
You can test the API endpoints using Postman or the Swagger UI.</br>
Example Test Using Swagger UI:</br>
Open Swagger UI at http://localhost:5000/.</br>
Navigate to POST /api/deals and click Try it out.</br>
Fill in the request body with valid data (as described in the API documentation).</br>
Press Execute to create a deal.</br>
Example Test Using Postman:</br> You can also test API endpoints in Postman by sending POST, GET, PUT, or DELETE requests to the corresponding endpoints.</br>

✨ Troubleshooting
Common Issues:
PostgreSQL Connection Issues: Ensure PostgreSQL is running and your connection string in appsettings.json is correct.</br>
Missing Dependencies: If you encounter missing dependencies, make sure to run dotnet restore to restore the NuGet packages.</br>
