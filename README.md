# Employee Data Manager - Blazor Server App

A Blazor Server application to manage employee records with a modern, responsive UI.
It allows users to add, edit, and soft delete employee data inline within a Bootstrap-styled table.

### Why use it?
- Managing tabular data interactively is a common requirement in business apps. This project:
- Demonstrates inline editing, soft delete, and validation using Blazor Server
- Uses data annotations for enforcing input correctness
- Offers a clean and responsive UI with Bootstrap 5
- Provides a foundation for extending to database-backed apps

###  Features
- Add Employees: Add entries with form validation.
- Inline Edit: Edit employee data directly in the table with Save/Cancel actions.
- Soft Delete: Deletes are non-destructive (records are hidden, not removed).
- Form Validation: Uses [Required], [EmailAddress], [Range], etc.
- Auto ID Assignment: Automatically increments IDs for new entries.
- Responsive UI: Styled with Bootstrap for cross-device compatibility.

## Tech Stack

- .NET 6
- Blazor Server
- Bootstrap 5

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/Employee-Data-Manager-Blazor-Server-App.git
2. Open the solution in Visual Studio 2022

3. Make sure .NET 6 SDK is installed

4. Run the app and navigate to
   ```
   /showdata

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
