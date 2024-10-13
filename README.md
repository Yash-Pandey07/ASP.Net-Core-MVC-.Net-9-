# ASP.Net-Core-MVC-.Net-9
# 📚 Entity Framework Core - Full Course

## Overview
This repository contains the code and exercises from the Entity Framework Core full course provided by freeCodeCamp.org. The course covers various aspects of using Entity Framework Core, including setting up the environment, creating models, migrations, and more.

## 📺 Source
Follow along with the [full course on YouTube](https://www.youtube.com/watch?v=RWXKysImabs&t=5559s&ab_channel=freeCodeCamp.org) 

## 📝 Course Content
- **Introduction to Entity Framework Core**: Basic concepts and setup.
- **Creating Models and Migrations**: How to create models and apply migrations.
- **CRUD Operations**: Implementing Create, Read, Update, and Delete operations.
- **Relationships**: Handling one-to-many, many-to-many relationships.
- **Querying Data**: Efficient querying using LINQ.
- **Advanced Features**: Covering advanced topics and performance optimization.

## 🛠️ Prerequisites
- .NET 6.0 SDK or later
- SQL Server 2019 or later
- Visual Studio 2022 or later

## 🚀 Getting Started

### Installation

1. **Clone the repository**:
    ```sh
    git clone https://github.com/Yash-Pandey07/ASP.Net-Core-MVC-.Net-9-.git
    cd ASP.Net-Core-MVC-.Net-9
    ```

2. **Set up the database**:
   - Create a new database in SQL Server.
   - Update the `appsettings.json` with your database connection string.

    ```json
    // Example appsettings.json configuration
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_username;Password=your_password;"
      },
      ...
    }
    ```

3. **Run migrations to set up the database schema**:
    ```sh
    dotnet ef database update
    ```

4. **Run the application**:
    ```sh
    dotnet run
    ```

## 📂 Database Structure
- **Categories**: Stores information about item categories.
- **Items**: Stores information about items including price and serial numbers.
- **SerialNumbers**: Tracks serial numbers for each item.
- **Clients**: Stores client information.
- **ItemClients**: Tracks the relationship between items and clients.

## 💡 Usage

1. **Home Page**: View a dashboard overview of the application.
2. **Manage Categories**: Navigate to the Categories page to add, update, or delete categories.
3. **Manage Items**: Navigate to the Items page to add, update, or delete items.
4. **Manage Clients**: Navigate to the Clients page to manage client information.
5. **Assign Items to Clients**: Use the Item-Client relationship management feature to assign items to clients.

## 🤝 Contributing
Contributions are welcome! Please submit a pull request or open an issue to discuss your ideas.

## 📬 Contact
For any inquiries or support, feel free to reach out.

---

Happy learning with Entity Framework Core! 🚀
