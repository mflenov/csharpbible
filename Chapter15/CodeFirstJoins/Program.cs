// See https://aka.ms/new-console-template for more information
using System.Linq;
using CodeFirst.Data;
using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

using (var dbcontext = new MyStoreContext())
{
    // add user
    if (!dbcontext.Customers.Any(m => m.Email == "with@orders.com"))
    {
        dbcontext.Customers.Add(
            new Customer()
            {
                Email = "with@orders.com",
                FirstName = "With",
                LastName = "Orders",
                Phone = "123",
                Orders = new List<Order> {
                new Order() { Created = DateTime.Now.AddMinutes(10), Modified = DateTime.Now },
                new Order() { Created = DateTime.Now.AddMinutes(25), Modified = DateTime.Now },
                }
            });
        dbcontext.SaveChanges();
    }

    /*
    // Show one user
    Customer? customer = dbcontext.Customers
        .Where(m => m.Email == "with@orders.com")
        .AsSplitQuery()
        .Include(m => m.Orders.Where(m => m.Created > new DateTime(2022,12, 19, 12, 0, 0)))
        .FirstOrDefault();

    foreach(var o in customer?.Orders)
    {
        Console.WriteLine($"{o.Id}");
    }

    //bad manual mapping
    List<Customer> customers = dbcontext.Customers.ToList();
    List<Order> orders = dbcontext.Orders.ToList();
    foreach (Customer c in customers)
        c.Orders = orders.Where(m => m.CustomerId == c.Id).ToList();

    //good manual mapping
    var ordersLookup = orders.ToLookup(m => m.CustomerId);
    foreach (Customer c in customers)
        c.Orders = ordersLookup[c.Id].ToList();
    */
}


using (var dbcontext = new MyStoreContext())
{
    // Явная загрузка
    Customer? customer2 = dbcontext.Customers
        .Where(m => m.Email == "with@orders.com")
        .FirstOrDefault();

    dbcontext.Entry(customer2).Collection(m => m.Orders).Load();
    foreach (var o in customer2?.Orders)
    {
        Console.WriteLine($"{o.Id}");
    }
}
