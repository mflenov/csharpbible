using PersonClass;

namespace PersonClass
{
    class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Work()
        {

        }

        public System.Type GetType()
        {
            return typeof(Person);
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    class Driver : Person
    {
        public Driver(string firstName, string lastName)
            : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override void Work()
        {
            // здесь код метода
        }
    }

}

