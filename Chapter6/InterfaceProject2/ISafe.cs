using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProject
{
    interface ISafe: IPurse
    {
        bool Locked
        {
            get;
        }

        void Lock();
        void Unlock();
    }
}
