using System;

namespace MyOwnException
{
    class Program
    {
        static void Main(string[] args)
        {
            CarEngine engine = new CarEngine("Мой двигатель V6");
            try
            {
                engine.StartEngine();
            }
            catch (EngineException ee)
            {
                Console.WriteLine("Двигатель '" + ee.Engine.Name +
                    "'\nCгенерировал ошибку: '" + ee.Message + "'");
            }
        }
    }
}
