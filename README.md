# Employee Data Manager - Blazor Server App

A simple Blazor Server application to manage employee records. It supports:

- Adding new employees
- Inline editing of employee details
- Soft deletion (records are hidden, not removed)
- Form validation using data annotations
- Bootstrap-styled responsive UI

## Tech Stack

- .NET 6
- Blazor Server
- Bootstrap 5

## Features

- Inline editing with Save/Cancel
- Validation for name, email, age, and department
- Auto-generated IDs for new entries
- Soft delete implementation
- Clean UI using Bootstrap table

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/Employee-Data-Manager-Blazor-Server-App.git
2. Open the solution in Visual Studio 2022

3. Make sure .NET 6 SDK is installed

4. Run the app and navigate to /showdata

## Validation Rules
Name: Required, max 15 characters, alphanumeric

Email: Required, valid email format

Age: Required, between 18 and 99

Department: Required

## Future Enhancements
- Add database (e.g., EF Core + SQL Server/SQLite)
- Search and filter functionality
- Sorting columns
- Improved UI/UX
