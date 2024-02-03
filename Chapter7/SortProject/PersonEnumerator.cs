using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ArrayListProject
{
    public class PersonEnumerator: IEnumerator
    {
        int currIndex = -1;
        PersonClass.Person person;

        public PersonEnumerator(PersonClass.Person person)
        {
            this.person = person;
        }

        #region IEnumerator Members

        public object Current
        {
            get { return person[currIndex]; }
        }

        public bool MoveNext()
        {
            currIndex++;
            if (currIndex >= person.GetChildrenNumber())
                return false;
            else
                return true;
        }

        public void Reset()
        {
            currIndex = -1;
        }

        #endregion
    }
}
