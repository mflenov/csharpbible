// See https://aka.ms/new-console-template for more information
using CodeFirst.Data;
using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

using (var dbcontext = new MyStoreContext())
{
    var customers = dbcontext.Customers.AsNoTracking().ToList();
    for (int i = 0; i < customers.Count(); i++)
    {
        customers[i].FirstName = "User " + i.ToString();
        dbcontext.Update(customers[i]);
    }
    dbcontext.SaveChanges();

}

using (var dbcontext = new MyStoreContextReadOnly()) { 
    var customer = await dbcontext.Customers
        .Where(m => m.LastName == "Doe")
        .FirstOrDefaultAsync();

    if (customer != null)
    {
        customer.FirstName = "Updated";
        dbcontext.SaveChanges();
    }

    var customers = dbcontext.Customers.ToList();
    for (int i = 0; i < customers.Count(); i++)
        Console.WriteLine("Имя = " + customers[i].FirstName);
}
