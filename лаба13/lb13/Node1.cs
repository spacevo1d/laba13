using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb13
{
    internal class Node1<T>
    {

        public T data;
        public Node1<T> next;
        public Node1<T> prev;
        public Node1() { }
        public Node1(T data)
        {
            this.data = data;
        }
    }
}
