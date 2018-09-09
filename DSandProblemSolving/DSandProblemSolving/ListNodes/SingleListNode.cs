using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandProblemSolving.ListNodes
{
    class SingleListNode
    {
        public int data { get; set; }
        public SingleListNode next { get; set; }
        public SingleListNode()
        {
            data = 0;
            next = null;

        }

        public void read(int number)
        {
            this.data = number;
        }

        public void print()
        {
            Console.WriteLine("\t" + this.data + "--->");
        }
    }
  
}
