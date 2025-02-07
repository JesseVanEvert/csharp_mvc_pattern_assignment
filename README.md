Assignment: Implementing MVC Design Pattern in a C# Console Application
Objective:

To implement the Model-View-Controller (MVC) design pattern in a simple C# console application. You will create a basic system where users can perform operations on a collection of items, such as adding, listing, and removing items. The system should follow the MVC pattern, with clear separation of logic for the Model, View, and Controller.
Problem Description:

Create a simple console-based application for managing a list of products. The system will allow users to:

    Add a new product.
    List all products.
    Remove a product.

The system should be designed using the MVC pattern.
Requirements:

    Model:

        A Product class that represents a product. The product should have the following properties:
            Id (int)
            Name (string)
            Price (decimal)

        A ProductModel class to manage the list of products. This class should provide the following functionality:
            AddProduct(Product product) - Adds a new product.
            RemoveProduct(int id) - Removes a product by its Id.
            GetAllProducts() - Returns all products.

    View:
        A ProductView class that is responsible for displaying information to the user. This class will have methods like:
            ShowMenu() - Displays the main menu of options.
            ShowProducts(List<Product> products) - Displays the list of all products.
            GetProductDetails() - Asks the user for details to create a new product (name and price).
            GetProductIdForRemoval() - Asks the user for the Id of the product to be removed.

    Controller:
        A ProductController class that acts as the intermediary between the ProductModel and ProductView. It should contain:
            AddProductToModel(Product product) - Adds a product to the model.
            RemoveProductFromModel(int id) - Removes a product from the model.
            DisplayAllProducts() - Displays all products using the view.
            ProcessUserInput(int choice) - Processes the user's input from the view and decides the action (add, remove, list).

    Program:
        A Program class that ties everything together. In the Main() method:
            Create instances of the model, view, and controller.
            Continuously show the menu and process user inputs until the user decides to exit.

Functional Requirements:

    Add Product: When the user chooses to add a product, they should be prompted to input a name and price. The controller will then add the product to the model.

    List Products: When the user chooses to list products, the controller will ask the model for all products and display them using the view.

    Remove Product: When the user chooses to remove a product, they should be prompted for a product Id. The controller will then remove the product from the model.

    Exit: The user should be able to exit the application by selecting the option from the main menu.

Example Menu:

Please choose an option:
1. Add a product
2. List all products
3. Remove a product
4. Exit

Example Product Information:

Product ID: 1
Name: Laptop
Price: $999.99

Grading Criteria:

    Correct use of MVC pattern: The application should properly implement the MVC design pattern with clear separation of concerns.
    Functionality: The add, list, and remove operations should work as expected.
    Code organization: Code should be well-organized and follow best practices for C# programming.
    Error handling: Handle potential errors, such as invalid input, in a user-friendly manner.

Bonus (Optional):

    Implement input validation to ensure that the price entered is a valid decimal.
    Allow the user to edit a product after selecting it from the list.
    Use a simple persistence mechanism (e.g., write the products to a text file) so that the list of products can be saved and loaded between sessions.

Submission Instructions:

    Submit the complete C# project (all files) that implements this assignment.
    Ensure that your code is well-commented and formatted according to C# coding standards.

Good luck with your assignment! Let me know if you need any further clarifications or if you run into any issues while implementing it.
