// See https://aka.ms/new-console-template for more information
using CodeFirst.Data;
using CodeFirst.Models;

using (var dbcontext = new MyStoreContext())
{
    Customer customer = dbcontext.Customers.Where(m => m.Email == "John@Doe.com").FirstOrDefault();
    if (customer == null)
    {
        customer = new Customer()
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "John@Doe.com"
        };

        dbcontext.Customers.Add(customer);
    }
    dbcontext.SaveChanges();

    dbcontext.Orders.Add(
        new Order()
        {
            CustomerId = customer.Id,
            Created = DateTime.Now,
            Modified = DateTime.Now
        }
        );

    dbcontext.SaveChanges();

    foreach (Order order in dbcontext.Orders)
    {
        Console.WriteLine("First Name " + order.Customer.FirstName);
        Console.WriteLine("Last Name " + order.Customer.LastName);
        Console.WriteLine("Order Id " + order.Id);
        Console.WriteLine("Order Date " + order.Created.ToString());
    }
}
    