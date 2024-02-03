using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Иван", "Иванов");
            MyPoint point = (MyPoint)person;
        }
    }
}
