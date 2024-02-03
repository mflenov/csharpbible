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

        public void AddMoney(int sum)
        {
            Sum += sum;
        }

        public int DecMoney(int sum)
        {
            Sum -= sum;
            return Sum;
        }
    }
}
