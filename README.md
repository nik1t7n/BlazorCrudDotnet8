# BlazorCrudDotnet8 Game Service

## Overview
BlazorCrudDotnet8 Game Service is a project that showcases a CRUD (Create, Read, Update, Delete) functionality for managing game data in a Blazor application using .NET Core 8. This project utilizes modern technologies, follows a structured architecture, and provides essential functionalities for interacting with game data.

## Technologies Used
- **Blazor:** A web framework for building interactive web UIs using C# and .NET.
- **.NET Core 8:** A cross-platform, open-source framework for building modern, cloud-based, and internet-connected applications.
- **Entity Framework Core:** An ORM (Object-Relational Mapping) framework for .NET that simplifies data access and management.
- **HttpClient:** Used for making HTTP requests to interact with the server-side API.
- **Razor Components:** Enables building interactive web UIs using C# and HTML.

## Architecture
The project follows a structured architecture to ensure maintainability, scalability, and separation of concerns:
- **Controllers:** Handle incoming HTTP requests and interact with the services.
- **Services:** Implement business logic and interact with the database using Entity Framework Core.
- **Data:** Contains the DataContext class for database connection and entity models.
- **Shared:** Contains shared entities, services, and interfaces used across the application.
- **Pages:** Contains Blazor components for rendering UI and interacting with the services.

## Design
The design of the project focuses on providing a user-friendly interface for managing game data:
- **CRUD Functionality:** Users can Create, Read, Update, and Delete game records.
- **Interactive UI:** Utilizes Blazor components for rendering dynamic and interactive web UIs.
- **RESTful API:** Implements API endpoints for handling CRUD operations on game data.
- **Client-Server Communication:** Uses HttpClient to communicate with the server-side API for data manipulation.

## Functionality
The project offers the following key functionalities:
- **GetAllGames:** Retrieve a list of all games from the database.
- **GetGameById:** Retrieve a specific game by its ID.
- **AddGame:** Add a new game to the database.
- **EditGame:** Update an existing game in the database.
- **DeleteGame:** Delete a game record from the database.

## Encapsulation and Abstractions
- **Interface-Based Design:** The project utilizes interfaces such as `IGameService` and `IGameRepository` to define contracts for services and repositories. This interface-based design promotes encapsulation by hiding the implementation details behind well-defined interfaces.

- **Dependency Inversion Principle:** By depending on abstractions (interfaces) rather than concrete implementations, the project adheres to the Dependency Inversion Principle. This principle states that high-level modules should not depend on low-level modules but should depend on abstractions.

- **Flexibility and Extensibility:** Encapsulation through abstractions allows for easy extension and modification of the codebase. New implementations of services or repositories can be introduced by adhering to the existing interfaces, enabling flexibility in the system.


## Conclusion
BlazorCrudDotnet8 Game Service is a demonstration of building a CRUD application using Blazor, .NET Core 8, and Entity Framework Core. The project showcases modern technologies, a structured architecture, interactive design, and essential functionalities for managing game data effectively.
