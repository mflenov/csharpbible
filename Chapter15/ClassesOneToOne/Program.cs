// See https://aka.ms/new-console-template for more information
using ClassesManyToMany.Data;
using ClassesManyToMany.Models;


using (var context = new SchoolContext())
{
    context.Add(new Student()
    {
        FirstName = "Ivan",
        LastName = "Lastname",
    });
    context.SaveChanges();

    context.Add(new StudentData()
    {
        Id = context.Students.First().Id,
        Address = "Street",
        CityName = "Toronto"
    });
    context.SaveChanges();
}

Console.WriteLine("Hello, World!");
