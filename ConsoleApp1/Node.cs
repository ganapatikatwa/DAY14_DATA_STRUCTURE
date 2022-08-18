using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Node
    {
        public int data;
        public Node Next;
        public Node(int data)
        {
            this.data = data;
            Next = null;
        }
    }
}
