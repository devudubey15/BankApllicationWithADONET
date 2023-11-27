# Bank Application with ADO.NET

## Overview
Welcome to the Bank Application with ADO.NET repository! This C# application showcases object-oriented programming concepts, exception handling, and a publisher-subscriber design pattern. It allows users to create savings and current accounts, perform transactions, and receive SMS and email notifications.

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Usage](#usage)
- [Implementation Details](#implementation-details)
- [Note](#note)

## Overview
This repository contains a simple Bank Application implemented in C# with ADO.NET for data storage. The application includes abstract classes, inheritance, exception handling, and a publisher-subscriber design pattern for sending SMS and email notifications.

## Features
- **Abstract Class `Account`**
  - **Id:** Automatically generated and readonly.
  - **Name:** Getter-setter with length validation (2 to 15 characters).
  - **Balance:** Getter-setter with restrictions on modification outside the class.
  - **Methods:** `withdraw` and `Deposit`.
  
- **Child Classes: `SavingAccount` and `CurrentAccount`**
  - `CurrentAccount` allows negative balance.
  - `SavingAccount` enforces a minimum balance of 1000.

- **Transaction Handling**
  - SMS and email notifications on withdrawal (publisher-subscriber pattern).
  - `Payinterest` method in `SavingAccount` for interest calculation.
  - User-defined exception for insufficient balance in `SavingAccount`.
  - Limiting the creation of only 5 account objects.
  - Exception handling for various scenarios.
    
## Implementation Details

- **ADO.NET is used for data storage.**
- **The Transaction class logs user transactions, and insufficient balance exceptions are logged in a file.**
- **The publisher-subscriber pattern is implemented for sending notifications.**

## Note

Ensure you have the necessary dependencies installed and configured to run the application successfully.

Feel free to explore and enhance the application as needed. Happy coding!

## Usage
 **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/Bank_application_with_ADO.git
