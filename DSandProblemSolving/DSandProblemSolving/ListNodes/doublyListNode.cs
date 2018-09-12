using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandProblemSolving.ListNodes
{
    class DoublyListNode
    {
        public int data { get; set; }
        public DoublyListNode left { get; set; }
        public DoublyListNode right { get; set; }

        public DoublyListNode()
        {
            data = 0;
            left = null;
            right = null;
        }

        public void read(int num)
        {
            this.data = num;
        }

        public void print()
        {
            Console.WriteLine("\t" + this.data + "--->");
        }
    }
}
