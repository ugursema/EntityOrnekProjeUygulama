# 📦 Entity Product Management System

A multi-form Windows Forms desktop application developed in C# utilizing **Entity Framework (Database First)** for comprehensive product, category, customer, and sales management.

---

## 🖼️ Application Screenshots

| Main Dashboard (`frmAnaForm`) | Statistics Panel (`frmIstatistikler`) |
| :---: | :---: |
| ![Anasayfa](anasayfa.PNG) | ![İstatistikler](istatistikler.PNG) |

| Category Operations (`Form1`) | Product Operations (`frmUrun`) |
| :---: | :---: |
| ![Kategori Ekle](kategori-ekle.PNG) | ![Ürün Ekle](ürün-ekle.PNG) |

---

## 📌 About the Project

EntityProductManagement is an enterprise-style desktop system built to practice ORM (Object-Relational Mapping) concepts using Entity Framework. The application features a centralized dashboard (`frmAnaForm`) that branches out into multiple dedicated management modules:
- **Category Operations (`Form1`):** Complete CRUD (Create, Read, Update, Delete) operations for managing product categories.
- **Product Operations (`frmUrun`):** Managing inventory items, prices, stocks, and category bindings using combobox mappings.
- **Statistics Dashboard (`frmIstatistikler`):** Real-time business intelligence metrics and aggregated data panels powered by advanced LINQ queries and stored procedures (e.g., total stock counts, active/passive customers, highest/lowest priced products, unique city counts, and top brands).

The project was designed to demonstrate efficient database querying, LINQ expression mapping, navigation between forms, and data binding in C# Windows Forms.

## ✨ Features

- **Entity Framework Integration:** Uses `EntityUrunEntities` context for seamless database interaction without writing raw SQL statements.
- **Category Management:** List, add, update, and remove categories dynamically.
- **Product Inventory Control:** Add new products with stock, pricing, and category selection, update records, and remove items safely using primary key lookups (`Find`).
- **Relational Dropdowns:** Binds category selection dynamically to a ComboBox (`ValueMember` / `DisplayMember`).
- **Comprehensive Statistics Panel:** Computes and displays live business metrics using LINQ aggregations (`Count`, `Sum`, `Min`, `Max`, `Distinct`) and custom stored procedures (`markagetir`).
- **Multi-Form Architecture:** Clean modular design with a central hub (`frmAnaForm`) managing navigation across different feature windows.

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET Framework (Windows Forms)
- **ORM:** Entity Framework (Database First approach)
- **Database:** Microsoft SQL Server
- **Data Querying:** LINQ (Language Integrated Query)

## 🗄️ Database & Models

The project connects to an Entity Framework data model mapped to a SQL Server database containing tables such as:
- `tbl_Kategori` (Category details)
- `tbl_Urun` (Product details, stock, price, category foreign keys)
- `tbl_Musteri` (Customer information and active status flags)
- `tbl_Satis` (Sales transactions and pricing)

**Note:** Ensure your local SQL Server instance is running, your Entity Framework connection string in `App.config` matches your environment, and the database schema (`EntityUrunEntities`) is properly configured before launching the application.

## 🚀 Getting Started

1. Clone or download this repository.
2. Open the solution file (`.sln`) in **Visual Studio**.
3. Restore NuGet packages if prompted (ensure Entity Framework is installed).
4. Update the database connection string inside `App.config` to match your local SQL Server instance.
5. Build and run the solution (`F5`).

## 🎯 Learning Objectives

This project helped practice:

- Implementing Entity Framework (Database First) in Windows Forms applications.
- Performing LINQ queries (`.Where`, `.Select`, `.Count`, `.Sum`, ordered queries, and lambdas).
- Binding complex controls like `DataGridView` and `ComboBox` to LINQ query outputs.
- Developing analytical dashboards using aggregate functions and custom database functions/stored procedures.
- Structuring multi-form enterprise applications cleanly.

## 🔮 Future Improvements

- Add user authentication and role-based permissions (Admin vs. Staff).
- Implement search, filtering, and sorting capabilities on product and category grids.
- Add input validation and error/exception handling for parsing numeric values.
- Export inventory and sales reports to Excel or PDF format.
- Enhance the UI styling with modern themes or component libraries (e.g., Guna UI, DevExpress).

---

**Developer:** [ugursema](https://github.com/ugursema)
