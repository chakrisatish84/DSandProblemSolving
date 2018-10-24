using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandProblemSolving.ListNodes
{
    class DoublyLinkedList
    {
        DoublyListNode Head;

        public DoublyLinkedList()
        {
            Head = null;
        }

        public void create(int[] arr)
        {
            int arrLength = arr.Length;

            if (arrLength < 1)
            {
                Head = null;
                return;
            }

            int k = 0;
            Head = new DoublyListNode();
            Head.read(arr[k]);
            DoublyListNode temp = Head;
            for (k = 1; k < arrLength; k++)
            {
                temp.right = new DoublyListNode();
                temp.right.left = temp;
                temp.right.read(arr[k]);
                temp = temp.right;
            }
        }

        internal void traverseDoublyLinkedListFromStart()
        {
            DoublyListNode temp = Head;
            while (temp != null)
            {
                temp.print();
                temp = temp.right;
            }
        }

        internal void traverseDoublyLinkedListFromEnd()
        {
            DoublyListNode temp = Head;
            while (temp.right != null)
            {
                temp = temp.right;
            }
            while(temp != null)
            {
                temp.print();
                temp = temp.left;
            }
        }
        internal void insertAtStart(int num)
        {
            DoublyListNode newNode = new DoublyListNode();
            newNode.read(num);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            DoublyListNode temp = Head;

            temp.left = newNode;
            newNode.right = temp;
            Head = newNode;
        }

        internal void insertAtEnd(int num)
        {
            DoublyListNode newNode = new DoublyListNode();
            newNode.read(num);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            DoublyListNode temp = Head;

            while (temp.right != null)
            {
                temp = temp.right;
            }

            temp.right = newNode;
            newNode.left = temp;
        }

        internal void insertAtPosotion(int num, int position)
        {
            DoublyListNode newNode = new DoublyListNode();
            newNode.read(num);

            DoublyListNode q = null;

            if (position == 1)
            {
                insertAtStart(num);
                return;
            }

            DoublyListNode temp = Head;
            int currentPositionValue = 1;
            while (currentPositionValue < position - 1)
            {
                temp = temp.right;
                currentPositionValue++;
            }

            if (temp.right == null) // last node
            {
                insertAtEnd(num);
                return;
            }

            q = temp.right;

            newNode.left = temp;
            temp.right = newNode;
            newNode.right = q;

        }       

        internal void insertAtmiddle(int num)
        {
            DoublyListNode newNode = new DoublyListNode();
            newNode.read(num);

            DoublyListNode p = Head;
            DoublyListNode q = Head;
            DoublyListNode ptr = null;

            if (Head == null)
            {
                Head = newNode;
            }

            while (q.right != null && q.right.right != null)
            {
                ptr = p;
                p = p.right;
                q = q.right.right;
            }

            if (q.right != null)
            {
                ptr = p.right;
                p.right = newNode;
                newNode.left = p;
                newNode.right = ptr;
            }
            else
            {
                ptr.right = newNode;
                newNode.left = ptr;
                newNode.right = p;
            }
        }

        internal void reverseList()
        {
            DoublyListNode temp = Head;
            DoublyListNode temp1 = null;

            while(temp != null)
            {
                temp1 = temp.right;
                temp.right = temp.left;
                temp.left = temp1;
                if(temp.left == null)
                {
                    Head = temp;
                }
                temp = temp.left;
            }
        }

        internal void deleteAtStart()
        {
            if(Head == null)
            {
                Console.WriteLine("Nothing exists in this list to delete");
                return;
            }
            if(Head.right == null)
            {
                Head = null;
                return;
            }

            DoublyListNode temp = Head;
            temp = temp.right;
            temp.left = null;
            Head = temp;
        }
        internal void deleteAtEnd()
        {
            if (Head == null)
            {
                Console.WriteLine("Nothing exists in this list to delete");
                return;
            }
            if (Head.right == null)
            {
                Head = null;
                return;
            }

            DoublyListNode temp = Head;
            DoublyListNode temp1 = null; ;

            while(temp.right != null){
                temp1 = temp;
                temp = temp.right;
            }
            temp1.right = null;

        }

        internal void deleteAtPosition(int position)
        {
            if (Head == null)
            {
                Console.WriteLine("Nothing exists in this list to delete");
                return;
            }
            if(Head.right == null && position == 1)
            {
                Head = null;
                return;
            }

            if(position == 1)
            {
                deleteAtStart();
                return;
            }


            DoublyListNode p = Head;
            DoublyListNode q = null;
            DoublyListNode x = null;

            int currentPosition = 1;

            while(currentPosition < position)
            {
                q = p;
                p = p.right;
                currentPosition++;
            }
            x = p.right;
            q.right = x;
            x.left = q;
        }
        
        internal void deleteAtMiddle()
        {
            if (Head == null)
            {
                Console.WriteLine("Nothing exists in this list to delete");
                return;
            }
            if (Head.right == null)
            {
                Head = null;
                return;
            }

            DoublyListNode p = Head;
            DoublyListNode q = Head;
            DoublyListNode x = null;
            DoublyListNode temp = null;

            while(q.right != null && q.right.right !=null)
            {
                x = p;
                p = p.right;
                q = q.right.right;
            }

            if(q.right != null)
            {
                x = p.right;
                temp = x.right;
                p.right = temp;
                temp.left = p;
            }
            else
            {
                temp = p.right;
                x.right = temp;
                temp.left = x;
            }
        }

     
    }
}
