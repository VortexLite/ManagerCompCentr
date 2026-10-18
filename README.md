# ManagerCompCentr 🏢

## Badges

[![Stars](https://img.shields.io/github/stars/VortexLite/ManagerCompCentr.svg?style=social)](https://github.com/VortexLite/ManagerCompCentr/stargazers)
[![Forks](https://img.shields.io/github/forks/VortexLite/ManagerCompCentr.svg?style=social)](https://github.com/VortexLite/ManagerCompCentr/network/members)
[![License](https://img.shields.io/github/license/VortexLite/ManagerCompCentr.svg)](https://github.com/VortexLite/ManagerCompCentr/blob/main/LICENSE)

## Description 📝

ManagerCompCentr appears to be a C# Windows Forms application designed for managing company-related data. Based on the file structure and names, it likely handles operations such as managing customers, employees, products, suppliers, and orders. The project also includes functionality for reporting and utilizes SQL Server for data storage, indicated by the `Microsoft.SqlServer.Types` package and `ConnectionDB.cs` file.

## Table of Contents 📜

- [Features](#features-🌟)
- [Tech Stack](#tech-stack-💻)
- [Installation](#installation-🚀)
- [Usage](#usage-💡)
- [Project Structure](#project-structure-📂)
- [Contributing](#contributing-🤝)
- [License](#license-⚖️)
- [Footer](#footer-❤️)

## Features 🌟

- **Customer Management:** Add, delete, and manage customer information.
- **Employee Management:** Add, delete, and manage employee details.
- **Product Management:** Add, delete, and manage product information.
- **Supplier Management:** Add, delete, and manage supplier details.
- **Order Processing:** Add and delete customer orders.
- **Reporting:** Generate reports related to customer orders and supplier products.
- **Database Connectivity:** Connects to and manages data using SQL Server.
- **Spatial Data Type Support:** Includes support for SQL Server spatial data types via the `Microsoft.SqlServer.Types` package.

## Tech Stack 💻

- **Language:** C#
- **Framework:** .NET Framework (inferred from project files and dependencies)
- **Database:** SQL Server
- **UI:** Windows Forms
- **Reporting:** RDLC Reports, Report Viewer Control
- **Dependencies:**
  - `Microsoft.SqlServer.Types`
  - `Microsoft.Report.Viewer` (potentially an older version)
  - `Microsoft.ReportingServices.ReportViewerControl.Winforms`

## Installation 🚀

To set up and run this project, follow these steps:

1.  **Prerequisites:**
    *   Visual Studio (2017 or later recommended)
    *   .NET Framework installed
    *   SQL Server instance

2.  **Clone the Repository:**
    ```bash
    git clone https://github.com/VortexLite/ManagerCompCentr.git
    cd ManagerCompCentr
    ```

3.  **Restore NuGet Packages:**
    The project uses NuGet for package management. Ensure you restore the packages. This typically happens automatically in Visual Studio, but you can also restore using the Package Manager Console:
    ```powershell
    Update-Package -reinstall
    ```
    Alternatively, you can use the .NET CLI:
    ```bash
    dotnet restore
    ```

4.  **Configure Database Connection:**
    *   Locate the `ConnectionDB.cs` file.
    *   Update the connection string within this file to point to your SQL Server instance and database.
    *   Ensure the database schema is set up correctly. The `Computershop.bacpac` file might be a database backup that needs to be restored.

5.  **Load Native Assemblies for SQL Server Types:**
    The `SqlServerTypes` package requires specific code to load its native assemblies. Depending on your application type:
    
    *   **Desktop Applications:** Add the following line to your application's startup code (e.g., in `Program.cs` or `Form1.cs` constructor before any spatial operations): 
        ```csharp
        SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
        ```
    *   **ASP.NET Web Applications:** Add this to the `Application_Start` method in `Global.asax.cs`:
        ```csharp
        SqlServerTypes.Utilities.LoadNativeAssemblies(Server.MapPath("~/bin"));
        ```
    *   **ASP.NET Web Sites:** Add this to the code-behind of the relevant Web Form:
        ```csharp
        SqlServerTypes.Utilities.LoadNativeAssemblies(Server.MapPath("~"));
        ```
    The `SqlServerTypes/readme.htm` file and `packages/Microsoft.SqlServer.Types.14.0.314.76/content/SqlServerTypes/readme.htm` provide detailed instructions on this.

6.  **Build and Run:**
    *   Open the solution file `ManagerCompCentr.sln` in Visual Studio.
    *   Build the project (Build > Build Solution).
    *   Run the application (Debug > Start Debugging or Start Without Debugging).

## Usage 💡

This application is designed as a desktop management tool for a computer shop. Users can interact with different modules to manage various aspects of the business:

- **Main Interface (`Form1.cs`, `Form2.cs`):** Likely serves as the primary dashboard or navigation point, allowing users to access different management sections (Customers, Employees, Products, etc.).
- **Adding Records:** Utilize forms like `AddCustomer.cs`, `AddEmoloyee.cs`, `AddProduct.cs`, `AddReview.cs`, and `AddSupplier.cs` to input new data into the system.
- **Deleting Records:** Forms like `DellCustomer.cs`, `DellEmployee.cs`, `DellProduct.cs`, `DellReview.cs`, and `DellSupplier.cs` are available for removing existing records.
- **Order Management:** The `OrderAdd.cs` and `OrderDell.cs` forms are used for creating and removing customer orders.
- **Reporting:** Access reports for `ReportCustomerOrder.rdlc` and `ReportSupplierProduct.rdlc` to gain insights into sales and supplier relationships.

**Example Use Case: Adding a New Product**

1.  Navigate to the Product Management section from the main form.
2.  Click the 'Add Product' button.
3.  Fill in the details on the `AddProduct` form (e.g., Product Name, Price, Stock Quantity).
4.  Click 'Save' or 'Add' to record the new product in the database.

**Example Use Case: Viewing Customer Orders Report**

1.  From the main interface, select the 'Reports' option.
2.  Choose the 'Customer Order Report'.
3.  The `ReportViewerControl` will display a list of customer orders, potentially filterable by customer or date range (depending on implementation).

## Project Structure 📂

The project follows a typical .NET Windows Forms application structure:

```
ManagerCompCentr/
├── Forms/
│   ├── AddCustomer.cs
│   ├── AddEmoloyee.cs
│   ├── AddProduct.cs
│   ├── AddReview.cs
│   ├── AddSupplier.cs
│   ├── DellCustomer.cs
│   ├── DellEmployee.cs
│   ├── DellProduct.cs
│   ├── DellReview.cs
│   ├── DellSupplier.cs
│   ├── OrderAdd.cs
│   └── OrderDell.cs
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.Designer.cs
│   ├── Resources.resx
│   ├── Settings.Designer.cs
│   └── Settings.settings
├── Report/
│   ├── DataSet1.Designer.cs
│   ├── DataSet1.xsc
│   ├── DataSet1.xsd
│   ├── DataSet1.xss
│   ├── DataSet2.Designer.cs
│   ├── DataSet2.xsc
│   ├── DataSet2.xsd
│   ├── DataSet2.xss
│   ├── Report1.rdlc
│   ├── Report2.rdlc
│   ├── ReportCustomerOrder.Designer.cs
│   ├── ReportCustomerOrder.cs
│   ├── ReportCustomerOrder.resx
│   ├── ReportSupplierProduct.Designer.cs
│   ├── ReportSupplierProduct.cs
│   └── ReportSupplierProduct.resx
├── SqlServerTypes/
│   ├── Loader.cs
│   └── readme.htm
├── App.config
├── ConnectionDB.cs
├── Form1.Designer.cs
├── Form1.cs
├── Form1.resx
├── Form2.Designer.cs
├── Form2.cs
├── Form2.resx
├── ManagerCompCentr.csproj
├── Program.cs
└── README.md
└── SqlServerTypes/x86/
└── SqlServerTypes/x64/

packages/
├── Microsoft.Report.Viewer.11.0.0.0/
├── Microsoft.ReportingServices.ReportViewerControl.Winforms.150.1586.0/
└── Microsoft.SqlServer.Types.14.0.314.76/
```

## Contributing 🤝

Contributions are welcome! If you'd like to contribute to this project, please follow these guidelines:

1.  **Fork the repository.**
2.  **Create a new branch** for your feature or bug fix (`git checkout -b feature/AmazingFeature`).
3.  **Make your changes** and commit them (`git commit -m 'Add some AmazingFeature'`).
4.  **Push to the branch** (`git push origin feature/AmazingFeature`).
5.  **Open a Pull Request.**

## License ⚖️

This project is currently under **No license**. Please refer to the repository for any specific terms or conditions.

## Footer ❤️

This project is maintained by VortexLite.

- **Repository:** [ManagerCompCentr](https://github.com/VortexLite/ManagerCompCentr)
- **Author:** VortexLite
- **Contact:** [Your Contact Information Here]

Feel free to **Fork**, **Like**, open **Issues**, or contribute to this project!


---
**<p align="center">Generated by [ReadmeCodeGen](https://www.readmecodegen.com/)</p>**