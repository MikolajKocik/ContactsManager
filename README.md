# ContactsManager

A desktop application created using WinForms technology (standard version, not .NET Framework). The project allows you to manage contacts in a PostgreSQL database, using ADO.NET as a database communication layer.

## Description

ContactsManager is a simple CRUD (Create, Read, Update, Delete) application that allows you to:

- Browse the contact list in the DataGridView control
- Add new contact records
- Edit existing data
- Delete selected records
- Search for contacts based on phone number
- Basic field validation (name, surname, phone number)

## Technologies

- **C#** – Windows Forms application
- **ADO.NET** – communication with the PostgreSQL database
- **PostgreSQL** – database storing contacts
- **Npgsql** – ADO.NET driver for PostgreSQL

## Configuration

In the `Form1.cs` file, set the correct connection string to the PostgreSQL database:

"Host=localhost;Port=yourPort;Username=yourUsername;Password=yourPassword;Database=databaseName";

I set my connection string using dotnet user-secrets to protect sensitive data.

Make sure the contacts database exists and contains the appropriate table (data), e.g.:

```
CREATE TABLE data (
id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
FirstName VARCHAR(255),
LastName VARCHAR(255),
PhoneNumber VARCHAR(20)
);
```

## Start

- Open the project in Visual Studio.

- Configure the ConnectionString according to your PostgreSQL database settings.

- Run the project (F5 or Ctrl+F5).
