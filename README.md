# Medical Store Management System

A fully functional **Medical Store Management System** built with **C# Windows Forms** and **SQL Server**.  
Supports **Admin** and **Pharmacist** roles with separate functionalities.

---

## Features

### Admin
- Add, view, update, and delete users
- Manage user profiles

### Pharmacist
- Add, view, delete, and search medicines
- Check validity of medicines (Valid / Expired)
- Sell medicines and generate bills

---

## Tools & Technologies
- **Programming Language:** C#  
- **IDE:** Visual Studio (Windows Forms with UserControls)  
- **Database:** SQL Server  
- **Screenshots:** Provided in `Screens/` folder  

---



## Setup Instructions

1. **Install prerequisites**:  
   - [Visual Studio](https://visualstudio.microsoft.com/)  
   - [SQL Server / SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

2. **Create the database**:  
   - Open **SQL Server Management Studio (SSMS)**  
   - Open the SQL script located in `Database/MedicalStoreDB.sql`  
   - Execute the script to create the database and tables

3. **Configure the project connection string**:  
   - Open the project in Visual Studio (`MDST/` folder)  
   - Locate the connection string in your C# code   

```csharp
SqlConnection con = new SqlConnection(@"Server=YOUR_SERVER_NAME;Database=MedicalStoreDB;Trusted_Connection=True;");


