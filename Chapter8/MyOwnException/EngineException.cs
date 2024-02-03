using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOwnException
{
    public class EngineException: ApplicationException
    {
        CarEngine engine;

        public EngineException(CarEngine engine, string message):base(message)
        {            
            this.engine = engine;
        }

        public CarEngine Engine
        {
            get { return engine; }
        }
    }
}
