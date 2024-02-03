using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProject
{
    interface IPurse
    {
        int Sum
        {
            get;
            set;
        }

        void AddMoney(int sum);
        public int DecMoney(int sum);
    }
}
