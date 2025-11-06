# User Management Console App

A simple console application for managing users.  
This project demonstrates a clean architecture approach in C#, suitable for learning and extending to a full-stack application.

---

## Features

- Register new users (FullName, Email, Password)
- User login with Email and Password
- Search users by Email or Id
- Display all users in the system

---

## Architecture

- **Model:** `User` – Defines the structure of user data
- **Service Layer:** `UserService` – Handles user operations (Add, Get, Login)
- **Controller:** `UserController` – Handles interaction between UI and service
- **UI (Console):** `Program.cs` – Provides a menu for user interaction

This separation of concerns makes the code maintainable and easily extendable for future Web API or database integration.

---

## How to Run

1. Clone the repository:

```bash
git clone https://github.com/username/repo.git
