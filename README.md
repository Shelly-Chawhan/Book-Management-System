# Hi-Tech Order Management System

## Project Description
The Hi-Tech Order Management System is a Windows Forms application developed for Hi-Tech Distribution Inc., which supplies computer science books to colleges and universities . This application is designed to streamline the order processing and inventory management.

## Features
- **User Management**
  - Add, update, and delete user information.
  - Authentication via username and password.

- **Inventory Management**
  - Manage book records (ISBN, title, unit price, publication year, and quantity on hand).
  - Support for multiple authors per book.
  - Each book is associated with a single publisher.

- **Customer Management**
  - Maintain customer information (name, contact details, credit limit).
  
- **Order Processing**
  - Order placement via phone, fax, or email.
  - Direct withdrawal payment processing.

- **Data Validation**
  - Ensures all entered data is valid and correctly formatted.

## Project Design

### Database Design
- **Consistent Naming Conventions**: Standard naming for tables and fields.
- **No Data Redundancy**: Designed to minimize data duplication.
- **Relationships**: Proper relationships among tables to ensure data integrity.

### Class Design
- **Application Domain Classes**: Represents key entities such as books, authors, customers, and orders.
- **GUI Classes**: Designed for easy navigation and user interaction.
- **Data Access Classes**: Implements data access methods using ADO.NET and Entity Framework.

### Class Diagram
- A visual representation of relationships between classes is included in the documentation.

## Project Implementation
- Developed using a **three-tier architecture**:
  - Presentation Layer
  - Business Logic Layer
  - Data Access Layer

## Project Testing
- Comprehensive testing to ensure:
  - Functionality of features.
  - Data integrity validation.
  - Various scenarios for adding, updating, and deleting records.



## Conclusion
The Hi-Tech Order Management System provides a comprehensive solution for managing book orders and inventory for Hi-Tech Distribution Inc. The project showcases a solid understanding of multi-tier application development, database design, and effective user interface design.

---

### Future Development Notes
- Consider adding features for report generation (sales, inventory analysis).
- Explore options for web-based deployment to enhance accessibility.
