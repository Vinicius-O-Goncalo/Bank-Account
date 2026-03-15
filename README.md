Bank Account Register – Windows Forms Application

# Overview

This project is a simple desktop application developed using C# and Windows Forms to simulate a basic bank account transaction register.

The application allows users to record account information such as name, date, description, debit, and credit values. The data is written to a text file using file streams, enabling simple transaction logging and persistence.

The system also performs basic financial calculations by validating debit and credit inputs and computing the resulting balance.

This project demonstrates practical knowledge of desktop application development, file handling, user input validation, and financial calculations using C#.


# Features

Open a text file to store transaction records

Save account transaction data

Record name, date, description, debit, and credit values

Validate numeric input for debit and credit fields

Calculate and display the resulting balance

Display system status messages to the user

Close the file safely after operations

# Technologies Used

C#

.NET Framework

Windows Forms

StreamWriter (File Handling)

Basic Financial Calculations

# Project Structure

Bank_Account
│
├── Form1.cs
│
├── Form1.Designer.cs
│
└── Program.cs


# Application Logic

The application is based on a simple event-driven workflow.

Users first open a file where transaction data will be stored. Once the file is open, the system allows the user to enter transaction information such as account name, date, description, debit, and credit.

When the user saves the transaction, the application writes the information to a text file using StreamWriter. The system then validates the debit and credit values and calculates the balance.

Finally, the file can be safely closed by the user, updating the interface status.


# File Storage

The application writes transaction records to a text file located (create your own) at:

C:\Users\Aluno\VisualStudioGoncalo\bankaccount.txt

Each record is stored in a simple structured format separated by semicolons.

Example structure:

Name;Date;Description;

# How to Run

Open the project in Visual Studio

Build the solution

Run the application

Click "Open File" to start writing transactions

Enter the transaction information

Click "Save" to register the transaction

Click "Close File" when finished

Input Validation

The system validates the debit and credit values before performing calculations. If invalid values are entered, the application will notify the user and request correct numeric inputs.

The balance is calculated using the formula:

Saldo = Crédito − Débito

# Learning Objectives

This project was created to practice:

Windows Forms application development

File handling using StreamWriter

Event-driven programming in C#

User input validation

Basic financial calculations

MessageBox interaction with users

# Possible Improvements

Future enhancements may include:

Saving debit and credit values to the file

Implementing a full transaction history viewer

Adding account balance accumulation

Implementing a graphical transaction table (DataGridView)

Exporting transactions to CSV or Excel

Improving user interface design

# Author

Vinícius Gonçalo
