عالی! 😄 حالا می‌توانیم این متن را **به‌صورت حرفه‌ای، منظم و قالب‌بندی مناسب برای گیت هاب** تبدیل کنیم تا خواندنش راحت باشد و Markdown درست داشته باشد. نسخه بهبود یافته:

---

# User Management Console App

A simple console application for managing users.
This project demonstrates a **clean architecture approach** in C#, suitable for learning and extending into a full-stack application.

![Console App Screenshot](./assets/console_screenshot.png)

> *Screenshot of the main menu in the console app (replace with your own screenshot).*

---

## Features

* ✅ Register new users (FullName, Email, Password)
* ✅ User login with Email and Password
* ✅ Search users by Email or Id
* ✅ Display all users in the system
* ✅ Simple validation for user input
* ✅ Easily extendable for database or API integration

---

## Architecture Overview

| Layer            | Class / File     | Responsibility                             |
| ---------------- | ---------------- | ------------------------------------------ |
| **Model**        | `User`           | Defines the structure of user data         |
| **Service**      | `UserService`    | Handles user operations (Add, Get, Login)  |
| **Controller**   | `UserController` | Handles interaction between UI and service |
| **UI (Console)** | `Program.cs`     | Provides a menu for user interaction       |

> This separation of concerns makes the code maintainable, testable, and ready for future Web API or database integration.

---
