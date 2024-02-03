using System;

namespace InterfaceDefault
{
    interface DefaultInterface
    {
        public void Display()
        {
            Console.WriteLine("Test");
            PrivateMethod();
        }
        private void PrivateMethod() {
            Console.WriteLine("Приветный");
        }
    }

    class DefaultInterfaceImplementation: DefaultInterface
    {
        /*
        public void Display()
        {
            Console.WriteLine("New version");
        }
        */
    }

    class Program
    {
        static void Main(string[] args)
        {
            //DefaultInterface interfaceTest = new DefaultInterface();
            DefaultInterface test = new DefaultInterfaceImplementation();
            test.Display();

            Console.WriteLine("Hello World!");
        }
    }
}
