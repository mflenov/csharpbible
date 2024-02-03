using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOwnException
{
    public class CarEngine
    {
        public CarEngine(string name)
        {
            Working = false;
            Name = name;
        }

        public bool Working { get; private set; }
        public string Name { get; set; }

        public void StartEngine()
        {
            if (Working)
                throw new EngineException(this, "Двигатель уже работает");

            Working = true;
        }

        public void StopEngine()
        {
            Working = false;
        }
    }
}
