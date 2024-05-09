# Multi-level-archtecture in .Net

This project demonstrates how having a muli level architecture in project helps in distributing area of concerns and also segegrating the code so as to reduce tight coupling between different layers.

## Table of Contents
- [Architecture Overview](#architecture-overview)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Architecture Overview

This project demonstrates a multi-level architecture, supporting the separation of concerns across different layers. Here's a high-level overview of each layer:

- **Data Access Layer (DAL)**: This layer is responsible for all interactions with the data sources (e.g., databases, file systems). It provides data to the business logic layer and handles CRUD operations.

- **Business Logic Layer (BLL)**: This layer contains the core logic and algorithms. It communicates with the data access layer to retrieve and manipulate data, applying business rules and validations.

- **Presentation Layer (PL)**: This is the user-facing layer, responsible for displaying data and handling user input. It can be a web interface, a desktop application, or a mobile app.

Each layer has its own responsibility and doesn't directly interact with layers other than the ones immediately adjacent to it. This structure promotes scalability, maintainability, and testability.

## Installation

Instructions to set up and run the project.

1. **Clone the Repository**
   ```bash
   https://github.com/Shivanidubey23/Multi-level-architecture.git

