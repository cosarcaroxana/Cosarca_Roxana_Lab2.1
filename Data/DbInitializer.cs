﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosarca_Roxana_Lab2.Models;

namespace Cosarca_Roxana_Lab2.Data
{
    public class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();
            if (context.Books.Any())
            {
                return; // BD a fost creata anterior
            }
            var books = new Book[]
            {
                new Book{Title="Baltagul",Author="Mihail Sadoveanu",Price=Decimal.Parse("22")},
                new Book{Title="Enigma Otiliei",Author="George Calinescu",Price=Decimal.Parse("18")},
                new Book{Title="Maytrei",Author="Mircea Eliade"}
            };
            foreach (Book s in books)
            {
                context.Books.Add(s);
            }
            context.SaveChanges();
            var customers = new Customer[]
            {

                new Customer{CustomerID=1050,Name="Popescu Marcela",BirthDate=DateTime.Parse("1979-09-01")},
                new Customer{CustomerID=1045,Name="Mihailescu Cornel",BirthDate=DateTime.Parse("1969-07-08")},

 };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();
            var orders = new Order[]
            {
                   new Order{BookID=1,CustomerID=1050, OrderDate=DateTime.Parse("2020-07-08")},
                   new Order{BookID=3,CustomerID=1045, OrderDate=DateTime.Parse("2020-06-18")},
                   new Order{BookID=1,CustomerID=1045, OrderDate=DateTime.Parse("2020-09-10")},
                   new Order{BookID=2,CustomerID=1050, OrderDate=DateTime.Parse("2020-10-06")},
            };
            foreach (Order e in orders)
            {
                context.Orders.Add(e);
            }
            context.SaveChanges();
        }
    }
}
