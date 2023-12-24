# Stok Kayit (Inventory Management) Application

This is a simple stock registration application developed in C# using Windows Forms and SQL Server. The application allows users to perform basic CRUD (Create, Read, Update, Delete) operations on stock items.
  
## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Add Item:** Add a new stock item with details such as material code, material name, annual sales, unit price, minimum stock, and lead time.
- **Delete Item:** Remove a stock item based on its material code.
- **Update Item:** Modify the details of a stock item.
- **View Items:** Display a list of all stock items.

## Getting Started

To get started with the project, you'll need to clone the repository to your local machine and set up the database. Follow the steps below:

### Prerequisites

Before you begin, ensure you have the following installed:

- Visual Studio 2019 or any other C# IDE.
- SQL Server Management Studio (SSMS)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/BaharBerra/StokKayit.git

2. Open the project in Visual Studio.

3. Update the connection string in Form1.cs to match your SQL Server configuration:

4.Build and run the application.

## Usage

Launch the application.

Use the "EKLE" (add) button to add a new inventory item.

Select a row in the table to update or delete an existing item.

Use the "SIL" (delete) button to delete the selected item.

Use the "GUNCELLE" (update) button to update the selected item.

The table automatically updates with the latest data.

## Contributing

Contributions are welcome! If you have any suggestions, bug reports, or feature requests, please open an issue or create a pull request.

## License

This project is free and open-source, and you are welcome to use, modify, and distribute the code for any purpose without any restrictions. Feel free to incorporate it into your projects.


Happy coding!

