Hi-Tech Order Management System
Project Description
The Hi-Tech Order Management System is a Windows Forms application developed to streamline the order processing for Hi-Tech Distribution Inc., a company specializing in supplying computer science books to colleges and universities . The application is designed using C# and Microsoft SQL Server, focusing on managing book inventories, customer orders, and user information efficiently.

Features
User Management: Users can be added, updated, or deleted. Each user must authenticate using a valid username and password.
Inventory Management: Users can manage book records, including details such as ISBN, title, unit price, publication year, and quantity on hand (QOH). The application supports multiple authors per book and associates each book with a single publisher.
Customer Management: The system maintains customer information, including contact details and credit limits.
Order Processing: Order clerks can take and manage customer orders, which can be placed via phone, fax, or email. Payments are processed through direct withdrawals.
Data Validation: The application ensures that all data entered into the system is valid and formatted correctly.
Project Design
Database Design
Consistent Naming Conventions: All tables and fields follow a standard naming convention for clarity.
No Data Redundancy: The database is designed to minimize duplication of data.
Relationships: Proper relationships among tables ensure data integrity.
Class Design
Application Domain Classes: Classes representing key entities such as books, authors, customers, and orders.
GUI Classes: Design of user interface components for easy navigation and user interaction.
Data Access Classes: Implementation of data access methods using ADO.NET and the Entity Framework to handle database operations.
Class Diagram
A visual representation of the relationships between the application's classes will be included in the documentation.

Project Implementation
The application has been developed following a three-tier architecture, separating the presentation layer, business logic, and data access layers. This structure enhances maintainability and scalability.

Project Testing
Extensive testing has been conducted to ensure functionality and validate data integrity. Various scenarios have been tested, including adding, updating, and deleting records, to ensure the application behaves as expected.

Conclusion
The Hi-Tech Order Management System serves as a comprehensive solution for managing book orders and inventory for Hi-Tech Distribution Inc. The project demonstrates a solid understanding of multi-tier application development, database design, and effective user interface design.
