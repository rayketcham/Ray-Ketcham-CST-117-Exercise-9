using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!

//Name: Ray Ketcham
//Class: CST-117
//Date: 07/29/2018
//Instructor: Dr. Smithers
//Corrected by: Ray Ketcham

namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {

            bool ifContainsElement = false;

            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    ifContainsElement = true;

                //return true;
                //else
                //return false;
            }

            return ifContainsElement;
            //This would always return a false
            //return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);
            }
            return rhs;
        }
    }
}
