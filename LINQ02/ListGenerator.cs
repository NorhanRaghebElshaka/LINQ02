﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinQ02
{
    class CompareProductBasedOnUnitInstock : IComparer<Productslist>
    {
        public int Compare(Productslist? x, Productslist? y)
        {
            return x.UnitsInStock.CompareTo(y.UnitsInStock);
        }

    }

    class Productslist : IComparable<Productslist>
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public int CompareTo(Productslist? other)
            => this.UnitPrice.CompareTo(other?.UnitPrice);


        public override string ToString()
            => $"ProductID:{ProductID},ProductName:{ProductName},Category{Category},UnitPrice:{UnitPrice},UnitsInStock:{UnitsInStock}";

    }
    class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Order[] Orders { get; set; }
        public Customer(string customerID, string customerName)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            Orders = new Order[10];
        }
        public Customer()
        {

        }
        public override string ToString()
            => $"{CustomerID}, {CustomerName}, {Address}, {City}, {Region}, {PostalCode}, {Country}, {Phone}, {Fax}";
    }
    class Order
    {

        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }

        public Order(int orderID, DateTime orderDate, decimal total)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            Total = total;
        }
        public Order()
        {

        }

        public override string ToString()
            => $"Order Id: {OrderID}, Date: {OrderDate.ToShortDateString()}, Total: {Total}";
    }
    internal static class ListGenerator
    {
        public static List<Productslist> ProductsList { get; set; }
        public static List<Customer> CustomersList { get; set; }

        static ListGenerator()
        {
            ProductsList = new List<Productslist>()
            {

                        new Productslist() {ProductID = 1, ProductName = "Chai", Category = "Beverages",
                            UnitPrice = 18.00M, UnitsInStock = 100},
                        new Productslist{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
                        UnitPrice = 19.0000M, UnitsInStock = 17 },
                      new Productslist{ ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments",
                        UnitPrice = 10.0000M, UnitsInStock = 13 },
                      new Productslist{ ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
                        UnitPrice = 22.0000M, UnitsInStock = 53 },
                      new Productslist{ ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
                        UnitPrice = 21.3500M, UnitsInStock = 0 },
                      new Productslist{ ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments",
                        UnitPrice = 25.0000M, UnitsInStock = 120 },
                      new Productslist{ ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce",
                        UnitPrice = 30.0000M, UnitsInStock = 15 },
                      new Productslist{ ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments",
                        UnitPrice = 40.0000M, UnitsInStock = 6 },
                      new Productslist{ ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry",
                        UnitPrice = 97.0000M, UnitsInStock = 29 },
                      new Productslist{ ProductID = 10, ProductName = "Ikura", Category = "Seafood",
                        UnitPrice = 31.0000M, UnitsInStock = 31 },
                      new Productslist{ ProductID = 11, ProductName = "Queso Cabrales", Category = "Dairy Products",
                        UnitPrice = 21.0000M, UnitsInStock = 22 },
                      new Productslist{ ProductID = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products",
                        UnitPrice = 38.0000M, UnitsInStock = 86 },
                      new Productslist() { ProductID = 13, ProductName = "Konbu", Category = "Seafood",
                        UnitPrice = 6.0000M, UnitsInStock = 24 },
                      new Productslist() { ProductID = 14, ProductName = "Tofu", Category = "Produce",
                        UnitPrice = 23.2500M, UnitsInStock = 35 },
                      new Productslist() { ProductID = 15, ProductName = "Genen Shouyu", Category = "Condiments",
                        UnitPrice = 15.5000M, UnitsInStock = 39 },
                      new Productslist() { ProductID = 16, ProductName = "Pavlova", Category = "Confections",
                        UnitPrice = 17.4500M, UnitsInStock = 29 },
                      new Productslist() { ProductID = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry",
                        UnitPrice = 39.0000M, UnitsInStock = 0 },
                      new Productslist() { ProductID = 18, ProductName = "Carnarvon Tigers", Category = "Seafood",
                        UnitPrice = 62.5000M, UnitsInStock = 42 },
                      new Productslist() { ProductID = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections",
                        UnitPrice = 9.2000M, UnitsInStock = 25 },
                      new Productslist() { ProductID = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections",
                        UnitPrice = 81.0000M, UnitsInStock = 40 },
                      new Productslist() { ProductID = 21, ProductName = "Sir Rodney's Scones", Category = "Confections",
                        UnitPrice = 10.0000M, UnitsInStock = 3 },
                      new Productslist() { ProductID = 22, ProductName = "Gustaf's Knäckebröd", Category = "Grains/Cereals",
                        UnitPrice = 21.0000M, UnitsInStock = 104 },
                      new Productslist() { ProductID = 23, ProductName = "Tunnbröd", Category = "Grains/Cereals",
                        UnitPrice = 9.0000M, UnitsInStock = 61 },
                      new Productslist() { ProductID = 24, ProductName = "Guaraná Fantástica", Category = "Beverages",
                        UnitPrice = 4.5000M, UnitsInStock = 20 },
                      new Productslist() { ProductID = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", Category = "Confections",
                        UnitPrice = 14.0000M, UnitsInStock = 76 },
                      new Productslist() { ProductID = 26, ProductName = "Gumbär Gummibärchen", Category = "Confections",
                        UnitPrice = 31.2300M, UnitsInStock = 15 },
                      new Productslist() { ProductID = 27, ProductName = "Schoggi Schokolade", Category = "Confections",
                        UnitPrice = 43.9000M, UnitsInStock = 49 },
                      new Productslist() { ProductID = 28, ProductName = "Rössle Sauerkraut", Category = "Produce",
                        UnitPrice = 45.6000M, UnitsInStock = 26 },
                      new Productslist() { ProductID = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry",
                        UnitPrice = 123.7900M, UnitsInStock = 0 },
                      new Productslist() { ProductID = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood",
                        UnitPrice = 25.8900M, UnitsInStock = 10 },
                      new Productslist() { ProductID = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products",
                        UnitPrice = 12.5000M, UnitsInStock = 0 },
                      new Productslist() { ProductID = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products",
                        UnitPrice = 32.0000M, UnitsInStock = 9 },
                      new Productslist() { ProductID = 33, ProductName = "Geitost", Category = "Dairy Products",
                        UnitPrice = 2.5000M, UnitsInStock = 112 },
                      new Productslist() { ProductID = 34, ProductName = "Sasquatch Ale", Category = "Beverages",
                        UnitPrice = 14.0000M, UnitsInStock = 111 },
                      new Productslist() { ProductID = 35, ProductName = "Steeleye Stout", Category = "Beverages",
                        UnitPrice = 18.0000M, UnitsInStock = 20 },
                      new Productslist() { ProductID = 36, ProductName = "Inlagd Sill", Category = "Seafood",
                        UnitPrice = 19.0000M, UnitsInStock = 112 },
                      new Productslist() { ProductID = 37, ProductName = "Gravad lax", Category = "Seafood",
                        UnitPrice = 26.0000M, UnitsInStock = 11 },
                      new Productslist() { ProductID = 38, ProductName = "Côte de Blaye", Category = "Beverages",
                        UnitPrice = 263.5000M, UnitsInStock = 17 },
                      new Productslist() { ProductID = 39, ProductName = "Chartreuse verte", Category = "Beverages",
                        UnitPrice = 18.0000M, UnitsInStock = 69 },
                      new Productslist() { ProductID = 40, ProductName = "Boston Crab Meat", Category = "Seafood",
                        UnitPrice = 18.4000M, UnitsInStock = 123 },
                      new Productslist() { ProductID = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood",
                        UnitPrice = 9.6500M, UnitsInStock = 85 },
                      new Productslist() { ProductID = 42, ProductName = "Singaporean Hokkien Fried Mee", Category = "Grains/Cereals",
                        UnitPrice = 14.0000M, UnitsInStock = 26 },
                      new Productslist() { ProductID = 43, ProductName = "Ipoh Coffee", Category = "Beverages",
                        UnitPrice = 46.0000M, UnitsInStock = 17 },
                      new Productslist() { ProductID = 44, ProductName = "Gula Malacca", Category = "Condiments",
                        UnitPrice = 19.4500M, UnitsInStock = 27 },
                      new Productslist() { ProductID = 45, ProductName = "Rogede sild", Category = "Seafood",
                        UnitPrice = 9.5000M, UnitsInStock = 5 },
                      new Productslist() { ProductID = 46, ProductName = "Spegesild", Category = "Seafood",
                        UnitPrice = 12.0000M, UnitsInStock = 95 },
                      new Productslist() { ProductID = 47, ProductName = "Zaanse koeken", Category = "Confections",
                        UnitPrice = 9.5000M, UnitsInStock = 36 },
                      new Productslist() { ProductID = 48, ProductName = "Chocolade", Category = "Confections",
                        UnitPrice = 12.7500M, UnitsInStock = 15 },
                      new Productslist() { ProductID = 49, ProductName = "Maxilaku", Category = "Confections",
                        UnitPrice = 20.0000M, UnitsInStock = 10 },
                      new Productslist() { ProductID = 50, ProductName = "Valkoinen suklaa", Category = "Confections",
                        UnitPrice = 16.2500M, UnitsInStock = 65 },
                      new Productslist() { ProductID = 51, ProductName = "Manjimup Dried Apples", Category = "Produce",
                        UnitPrice = 53.0000M, UnitsInStock = 20 },
                      new Productslist() { ProductID = 52, ProductName = "Filo Mix", Category = "Grains/Cereals",
                        UnitPrice = 7.0000M, UnitsInStock = 38 },
                      new Productslist() { ProductID = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry",
                        UnitPrice = 32.8000M, UnitsInStock = 0 },
                      new Productslist() { ProductID = 54, ProductName = "Tourtière", Category = "Meat/Poultry",
                        UnitPrice = 7.4500M, UnitsInStock = 21 },
                      new Productslist() { ProductID = 55, ProductName = "Pâté chinois", Category = "Meat/Poultry",
                        UnitPrice = 24.0000M, UnitsInStock = 115 },
                      new Productslist() { ProductID = 56, ProductName = "Gnocchi di nonna Alice", Category = "Grains/Cereals",
                        UnitPrice = 38.0000M, UnitsInStock = 21 },
                      new Productslist() { ProductID = 57, ProductName = "Ravioli Angelo", Category = "Grains/Cereals",
                        UnitPrice = 19.5000M, UnitsInStock = 36 },
                      new Productslist() { ProductID = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood",
                        UnitPrice = 13.2500M, UnitsInStock = 62 },
                      new Productslist() { ProductID = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products",
                        UnitPrice = 55.0000M, UnitsInStock = 79 },
                      new Productslist() { ProductID = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products",
                        UnitPrice = 34.0000M, UnitsInStock = 19 },
                      new Productslist() { ProductID = 61, ProductName = "Sirop d'érable", Category = "Condiments",
                        UnitPrice = 28.5000M, UnitsInStock = 113 },
                      new Productslist() { ProductID = 62, ProductName = "Tarte au sucre", Category = "Confections",
                        UnitPrice = 49.3000M, UnitsInStock = 17 },
                      new Productslist() { ProductID = 63, ProductName = "Vegie-spread", Category = "Condiments",
                        UnitPrice = 43.9000M, UnitsInStock = 24 },
                      new Productslist() { ProductID = 64, ProductName = "Wimmers gute Semmelknödel", Category = "Grains/Cereals",
                        UnitPrice = 33.2500M, UnitsInStock = 22 },
                      new Productslist() { ProductID = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments",
                        UnitPrice = 21.0500M, UnitsInStock = 76 },
                      new Productslist() { ProductID = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments",
                        UnitPrice = 17.0000M, UnitsInStock = 4 },
                      new Productslist() { ProductID = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages",
                        UnitPrice = 14.0000M, UnitsInStock = 52 },
                      new Productslist() { ProductID = 68, ProductName = "Scottish Longbreads", Category = "Confections",
                        UnitPrice = 12.5000M, UnitsInStock = 6 },
                      new Productslist() { ProductID = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products",
                        UnitPrice = 36.0000M, UnitsInStock = 26 },
                      new Productslist() { ProductID = 70, ProductName = "Outback Lager", Category = "Beverages",
                        UnitPrice = 15.0000M, UnitsInStock = 15 },
                      new Productslist() { ProductID = 71, ProductName = "Flotemysost", Category = "Dairy Products",
                        UnitPrice = 21.5000M, UnitsInStock = 26 },
                      new Productslist() { ProductID = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products",
                        UnitPrice = 34.8000M, UnitsInStock = 14 },
                      new Productslist() { ProductID = 73, ProductName = "Röd Kaviar", Category = "Seafood",
                        UnitPrice = 15.0000M, UnitsInStock = 101 },
                      new Productslist() { ProductID = 74, ProductName = "Longlife Tofu", Category = "Produce",
                        UnitPrice = 10.0000M, UnitsInStock = 4 },
                      new Productslist() { ProductID = 75, ProductName = "Rhönbräu Klosterbier", Category = "Beverages",
                        UnitPrice = 7.7500M, UnitsInStock = 125 },
                      new Productslist() { ProductID = 76, ProductName = "Lakkalikööri", Category = "Beverages",
                        UnitPrice = 18.0000M, UnitsInStock = 57 },
                      new Productslist() { ProductID = 77, ProductName = "Original Frankfurter grüne Soße", Category = "Condiments",
                        UnitPrice = 13.0000M, UnitsInStock = 32 }
            };

            CustomersList = (from e in XDocument.Load("Customers.xml").Root.Elements("customer")
                             select new Customer()
                             {
                                 CustomerID = (string)e.Element("id"),
                                 CustomerName = (string)e.Element("name"),
                                 Address = (string)e.Element("address"),
                                 City = (string)e.Element("city"),
                                 Region = (string)e.Element("region"),
                                 PostalCode = (string)e.Element("postalcode"),
                                 Country = (string)e.Element("country"),
                                 Phone = (string)e.Element("phone"),
                                 Fax = (string)e.Element("fax"),
                                 Orders = (
                                      from o in e.Elements("orders").Elements("order")
                                      select new Order
                                      {
                                          OrderID = (int)o.Element("id"),
                                          OrderDate = (DateTime)o.Element("orderdate"),
                                          Total = (decimal)o.Element("total")
                                      }).ToArray()
                             }).ToList();
        }
    }
}