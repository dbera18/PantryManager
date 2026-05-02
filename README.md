# Pantry Manager

A C# Windows Forms application designed to efficiently track and manage household pantry inventory. This project demonstrates Object-Oriented Programming (OOP) principles and persistent data storage to fulfill all functional requirements.

## Features
* **Inventory Management:** Add new items with a name, quantity, and expiration date.
* **Stock Tracking:** Select an item and click "Use" to decrease its quantity, featuring automated out-of-stock alerts.
* **Input Validation:** Prevents invalid entries by checking for empty names and zero-quantity inputs.
* **Data Persistence:** Automatically saves and loads inventory data locally using JSON serialization so no data is lost between sessions.

## Architecture
This application is built using C# and WinForms, adhering to strict OOP principles. Our data model includes core classes like `User` and `Pantry`, utilizing inheritance for `PantryItem` with specialized subclasses such as `PerishableItem` and `NonPerishableItem`. 

## How to Run Our Application
1. Clone this repository to your local machine using Git.
2. Open the `PantryManager.sln` file in Visual Studio (2022 or newer).
3. Go to the top menu and press the green **Start** button (or press F5) to launch the application.
4. Fill in the item details and click **Add Item** to populate the grid.
5. Select a row and click **Use Item** to decrement the stock.
6. **Note:** The application will automatically create a `pantry.json` file in the local build directory to securely save our inventory state.