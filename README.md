# Student Management System (WinForms)

A desktop application built with .NET Windows Forms for managing student records. The application allows for full CRUD (Create, Read, Update, Delete) operations on student data, course enrollment management, and connects to a MySQL database for data persistence.

## Features

- **View and Search Students**: Display a list of all students and search for specific students by first or last name.
- **Add, Update, and Delete Students**: Perform full CRUD operations on student records.
- **View Student Profiles**: See a detailed profile for each student, including their personal information and a list of enrolled courses.
- **Course Enrollment**: Enroll students in available courses and unenroll them.
- **Data Persistence**: All student and course data is stored and managed in a MySQL database.

## Technologies Used

- **Framework**: .NET 8
- **UI**: Windows Forms (WinForms)
- **Language**: C#
- **Database**: MySQL
- **ORM**: Dapper
- **Database Connector**: MySql.Data

## Screenshots

![alt text](https://github.com/EyEyron64/Student-Management-System-Winforms/blob/main/Screenshots/StudentManagementPage.png)
![alt text](https://github.com/EyEyron64/Student-Management-System-Winforms/blob/main/Screenshots/AddUpdateStudentPage.png)
![alt text](https://github.com/EyEyron64/Student-Management-System-Winforms/blob/main/Screenshots/StudentEnrollmentPage.png)
![alt text](https://github.com/EyEyron64/Student-Management-System-Winforms/blob/main/Screenshots/StudentProfilePage.png)

## Getting Started

Follow these instructions to set up and run the project on your local machine.

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/)

### 1. Database Setup

1.  Ensure your MySQL server is running.
2.  Use a MySQL client (like MySQL Workbench, DBeaver, or the command line) to run the `setup.sql` script located in the root of this repository. This script will:
    - Create the `student_management_db` database.
    - Create the necessary `students`, `courses`, and `enrolled_courses` tables.
    - Populate the tables with sample data.

### 2. Application Configuration

1.  Navigate to the `StudentManagementSystem/` directory.
2.  Rename the `App.config.sample` file to `App.config`.
3.  Open the newly renamed `App.config` file and modify the `connectionString` with your MySQL server details:

    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <configuration>
        <connectionStrings>
            <add name="Default"
                 connectionString="Server=localhost;Port=3306;Database=student_management_db;User ID=your_user;Password=your_password"
                 providerName="MySql.Data.MySqlClient" />
        </connectionStrings>
    </configuration>
    ```

    Replace `your_user` and `your_password` with your actual MySQL credentials.

### 3. Build and Run

1.  Open the `StudentManagementSystem.sln` file in Visual Studio.
2.  Visual Studio will automatically restore the required NuGet packages (Dapper, MySql.Data).
3.  Press `F5` or click the "Start" button to build and run the application.
4.  The main student management window should appear, populated with the sample data from the database.

## Project Structure

-   `StudentManagementSystem.sln`: The main solution file for Visual Studio.
-   `setup.sql`: SQL script for database and table creation.
-   `/StudentManagementSystem`: The main project directory.
    -   `/DataAccess`: Contains `SqlClient.cs`, which handles all database communication using Dapper.
    -   `/Models`: Contains the `Student.cs` and `Course.cs` classes that represent the data models.
    -   `/Views`: Contains the Windows Forms for the application's user interface.
        -   `StudentManagementPage.cs`: The main form displaying the list of students.
        -   `AddUpdateStudentPage.cs`: The form for adding or updating a student's details.
        -   `StudentProfilePage.cs`: The form for viewing a single student's profile and their enrolled courses.
        -   `StudentEnrollmentPage.cs`: The form for enrolling or unenrolling a student from courses.
    -   `App.config`: Configuration file for database connection strings.
    -   `Program.cs`: The main entry point for the application.
