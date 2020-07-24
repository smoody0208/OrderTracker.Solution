# Vendors Page

#### Latest version date 2020/07/24

#### By Spencer Moody

## Description
This application will allow the user to submit a list of vendors which each containing a sub list of orders. The orders list will contain details about that order.

## Specifications

1. **Behavior:** The user is welcomed with a splash page and given the option to add a new vendor.
    * **Input Example:** "Add a new vendor"
    * **Output Example:** "/vendors/new"

2. **Behavior:** The program will allow the user to view the created vendor/all vendors.
    * **Input Example:** "View vendors"
    * **Output Example:** /vendors/show

2. **Behavior:** The program will ask the user to add an order/details to the selected vendor.
    * **Input Example:** "Add order to this vendor"
    * **Output Example:** /vendors/{order}

3. **Behavior:** The program will allow the user to delete existing orders.
    * **Input Example:** "Delete orders"
    * **Output Example:** /orders/delete

3. **Behavior:** The program will allow the user to delete existing vendors.
    * **Input Example:** "Delete vendors"
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
