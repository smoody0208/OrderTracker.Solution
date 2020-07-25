# Vendors Page

#### Latest version date 2020/07/24

#### By Spencer Moody

## Description
This application will allow the user to submit a list of vendors which each containing a sub list of orders. The orders list will contain details about that order.

## Specifications

1. **Behavior:** The user is welcomed with a splash page and given the option to add a new vendor.
    * **Input Example:** "Add a new vendor"
    * **Output Example:** /vendors/new

2. **Behavior:** The program will allow the user to add a new vendors name/address.
    * **Input Example:** "Add vendors"
    * **Output Example:** /vendors

3. **Behavior:** The program will allow the user to view orders for that vendor.
* **Input Example:** "Click on vendor name"
* **Output Example:** /vendors/{vendorid}

4. **Behavior:** The program will allow the user to add an order for that Vendor.
* **Input Example:** "Add a new order"
* **Output Example:** /vendors/{vendorid}/orders/new

5. **Behavior:** The user will enter in details about the order.
* **Input Example:** "Add order for 'vendor'"
* **Output Example:** /vendors/{vendorid}/orders

6. **Behavior:** The program will allow the user view details about an order.
    * **Input Example:** "Click on order name"
    * **Output Example:** /vendors/{vendorid}/orders/{orderid}

7. **Behavior:** The program will allow the user to delete existing vendors.
    * **Input Example:** "Clear Vendors"
    * **Output Example:** /vendors/delete

## Setup and Installation

Software Requirements
1. .NET framework
2. A code editor (Visual Studio Code, Atom, etc.)

Acquire The Repo:
1. Click the 'Clone or Download Button
2. Alternately, Clone via Bash/GitBash: `git clone {repo}`

Editting the Code Base:
1. Open the project in your code editor; with Bash, this is done by navigating to the project directory, then `code .`
2. If you wish to run testing, you'll need the testing packages: navigate into the .Tests folder, and run `dotnet restore`

Running the program:
1. To run the program, you'll need to compile the code: `dotnet build`. This will create a compiled application in the bin/ folder.
2. Alternately, you can run the program directly with `dotnet run`.

## Bugs

No bugs

## Tech used

* C#
* .NET

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) 2020 Spencer Moody
