// See https://aka.ms/new-console-template for more information
using CodeFirst.Data;
using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

using (var dbcontext = new MyStoreContext())
{
    Customer? johnCustomer = dbcontext.Customers.TagWith("Getting all customners").Where(m => m.Email == "John@Doe.com").Include(m => m.Orders).FirstOrDefault();
    if (johnCustomer == null)
    {
        johnCustomer = new Customer()
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "John@Doe.com"
        };

        dbcontext.Customers.Add(johnCustomer);
    }

    Customer? annaCustomer = dbcontext.Customers.Where(m => m.Email == "Anna@Doe.com").Include(m => m.Orders).FirstOrDefault();
    if (annaCustomer == null)
    {
        annaCustomer = new Customer()
        {
            FirstName = "Anna",
            LastName = "Doe",
            Email = "Anna@Doe.com"
        };

        dbcontext.Customers.Add(annaCustomer);
    }

    dbcontext.SaveChanges();

    if (!johnCustomer.Orders.Any())
        dbcontext.Orders.Add(
            new Order()
            {
                CustomerId = johnCustomer.Id,
                Created = DateTime.Now,
                Modified = DateTime.Now
            }
        );

    if (!annaCustomer.Orders.Any())
        dbcontext.Orders.Add(
            new Order()
            {
                CustomerId = annaCustomer.Id,
                Created = DateTime.Now,
                Modified = DateTime.Now
            }
        );

    dbcontext.SaveChanges();

    Console.WriteLine("All Orders -----------------");

    foreach (Order order in dbcontext.Orders)
    {
        Console.WriteLine("First Name " + order.Customer.FirstName);
        Console.WriteLine("Last Name " + order.Customer.LastName);
        Console.WriteLine("Order Id " + order.Id);
        Console.WriteLine("Order Date " + order.Created.ToString());
    }

    Console.WriteLine("Find Orders -----------------");

    foreach (Order order in dbcontext.Orders.Where(o => o.CustomerId == johnCustomer.Id)) {
        Console.WriteLine("First Name " + order.Customer.FirstName);
        Console.WriteLine("Last Name " + order.Customer.LastName);
        Console.WriteLine("Order Id " + order.Id);
        Console.WriteLine("Order Date " + order.Created.ToString());
    }

    Console.WriteLine("Customer Orders -----------------");

    foreach (Order order in johnCustomer.Orders)
    {
        Console.WriteLine("First Name " + order.Customer.FirstName);
        Console.WriteLine("Last Name " + order.Customer.LastName);
        Console.WriteLine("Order Id " + order.Id);
        Console.WriteLine("Order Date " + order.Created.ToString());
    }
}
