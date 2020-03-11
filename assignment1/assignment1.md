# Assignment A1

## Objective
The objective of this assignment is to allow students to become familiar with architectural patterns.

## Application Description
Use JAVA/C# API to design and implement an application for the front desk employees of a bank. The application should have two types of users (a regular user represented by the front desk employee and an administrator user) which have to provide a username and a password in order to use the application.

The regular user can perform the following operations:
- Add/update/view client information (name, identity card number, personal numerical code, address, etc.).
- Create/update/delete/view client account (account information: identification number, type, amount of money, date of creation).
- money between accounts.
- Process utilities bills.

The administrator user can perform the following operations:
- CRUD on employees’ information.
- Generate reports for a particular period containing the activities performed by an employee.

## Application Constraints
- The data will be stored in a database. Use the Layers architectural pattern to organize your application. Use a domain logic pattern (transaction script or domain model or table module) and a data source pure pattern (table data gateway, row data gateway, data mapper or active record) most suitable for the application.
- do not use an Object Relational Mapper framework. Write the queries against the database in SQL.
- SQL script for creating and populating the database with initial values.
- the inputs of the application will be validated against invalid data before submitting the data and saving it in the database.

## Deliverables
- Analysis and design document
- Implementation & documentation files committed & pushed on GitHub

## References
- [Martin Fowler et. al, Patterns of Enterprise Application Architecture, Addison Wesley, 2003](http://training.hasintech.com/download/attachments/1802696/Patterns%20of%20Enterprise%20Application%20Architecture%20-%20Martin%20Fowler.pdf?version=1&modificationDate=1464702352696&api=v2)
- [Java Swing UI](https://docs.oracle.com/javase/tutorial/uiswing/)
- [JavaFx](https://docs.oracle.com/javase/8/javafx/get-started-tutorial/index.html)
- [.NET apps](https://docs.microsoft.com/en-us/dotnet/framework/develop-client-apps)
