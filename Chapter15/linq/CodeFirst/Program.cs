// See https://aka.ms/new-console-template for more information
using CodeFirst.Data;
using CodeFirst.Models;

using (var dbcontext = new MyStoreContext())
{
    dbcontext.Customers.Add(
        new Customer()
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "John@Doe.com"
        }
        );

    dbcontext.Customers.Add(
    new Customer()
    {
        FirstName = "Anna",
        LastName = "",
        Email = "John@Doe.com"
    }
    );

    dbcontext.SaveChanges();

    foreach (Customer c in dbcontext.Customers)
    {
        Console.WriteLine("First Name " + c.FirstName);
        Console.WriteLine("Last Name " + c.LastName);
        Console.WriteLine("-------------------");
    }
}