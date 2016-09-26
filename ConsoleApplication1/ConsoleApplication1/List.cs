using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class List<T>
    {
        private Element<T> head;

        internal Element<T> Head
        {
            get { return head; }
            set { head = value; }
        }

    }
}
