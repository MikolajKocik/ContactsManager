# ContactsManager

Aplikacja desktopowa stworzona przy użyciu technologii WinForms (wersja standardowa, nie .NET Framework). Projekt umożliwia zarządzanie kontaktami w bazie PostgreSQL, korzystając z ADO.NET jako warstwy komunikacji z bazą danych.

## Opis

ContactsManager to prosta aplikacja typu CRUD (Create, Read, Update, Delete), umożliwiająca:

- Przeglądanie listy kontaktów w kontrolce DataGridView
- Dodawanie nowych rekordów kontaktów
- Edytowanie istniejących danych
- Usuwanie wybranych rekordów
- Wyszukiwanie kontaktów na podstawie numeru telefonu
- Podstawową walidację pól (imię, nazwisko, numer telefonu)

## Technologie

- **C#** – aplikacja Windows Forms
- **ADO.NET** – komunikacja z bazą danych PostgreSQL
- **PostgreSQL** – baza danych przechowująca kontakty
- **Npgsql** – sterownik ADO.NET dla PostgreSQL

## Konfiguracja

W pliku `Form1.cs` należy ustawić poprawny łańcuch połączenia do bazy danych PostgreSQL:

"Host=localhost;Port=5432;Username=postgres;Password=haslo;Database=kontakty";

Mój connection string ustawiłem za pomocą dotnet user-secrets aby chronić wrażliwe dane.

Upewnij się, że baza danych kontakty istnieje i zawiera odpowiednią tabelę (data), np.:

```
CREATE TABLE data (
    id SERIAL PRIMARY KEY,
    FirstName VARCHAR(255),
    LastName VARCHAR(255),
    PhoneNumber VARCHAR(20)
);
```

## Uruchomienie

 - Otwórz projekt w Visual Studio.

- Skonfiguruj łańcuch połączenia (ConnectionString) zgodnie z ustawieniami swojej bazy PostgreSQL.

- Uruchom projekt (F5 lub Ctrl+F5).
