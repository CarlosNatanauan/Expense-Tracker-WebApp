![image](https://github.com/user-attachments/assets/5f154ed5-adc9-4ae2-be2b-a4b8cfff8939)
# Expense Tracker Web Application

This is a simple Expense Tracker web application developed using ASP.NET Core MVC. The application allows users to view, create, edit, and delete their expenses. It also provides a total expense summary for easy financial management.

## Features
- View all expenses with details like ID, value, and description.
- Create new expenses.
- Edit or delete existing expenses.
- Displays the total amount of expenses.

## Screenshots

### Home Page
![image](https://github.com/user-attachments/assets/365fd9b2-4571-4d09-900a-8df3da001a87)

The home page provides navigation options for viewing all expenses and creating a new expense.

### Expenses Overview
![image](https://github.com/user-attachments/assets/22ac2467-d39d-4f7f-a6e2-f9762019713d)

This page displays all the user's expenses with options to edit or delete any entry.

### Create/Edit Expense
![image](https://github.com/user-attachments/assets/2e36e5f9-24b8-48c7-b515-ce5e326e0d50)

Allows users to create a new expense or edit an existing one by entering values and descriptions.

## Project Structure
The project is built using ASP.NET Core MVC. Here is an overview of the structure:

- **Controllers**
  - `HomeController.cs`: Handles requests for viewing and managing expenses.
  
- **Models**
  - `Expense.cs`: The model representing an expense with fields like `Id`, `Value`, and `Description`.

- **Views**
  - `Home/Index.cshtml`: The main homepage view.
  - `Home/Expenses.cshtml`: The view for displaying a list of expenses.
  - `Home/CreateEditExpense.cshtml`: The view for creating or editing an expense.

## Usage
1. Clone the repository:
   ```bash
   git clone https://github.com/CarlosNatanauan/Expense-Tracker-WebApp.git
