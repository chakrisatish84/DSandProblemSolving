using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandProblemSolving.ListNodes
{
    class SingleLinkedList
    {
        SingleListNode Head;

        public SingleLinkedList()
        {
            Head = null;
        }

        public void createSingleLinkedList(int[] arr)
        {
            int arrLength = arr.Length;
            if (arrLength == 0)
            {
                Console.WriteLine("No elemnents exits to create a single linked list");
                Head = null;
                return;
            }
            else
            {
                int k = 0;
                Head = new SingleListNode();
                Head.read(arr[k]);
                SingleListNode temp = Head;
                for (k = 1; k < arrLength; k++)
                {
                    temp.next = new SingleListNode();
                    temp = temp.next;
                    temp.read(arr[k]);
                }
            }
        }

        public SingleListNode createSingleLinkedListNew(int[] arr)
        {
            int arrLength = arr.Length;
            if (arrLength == 0)
            {
                Console.WriteLine("No elemnents exits to create a single linked list");
                Head = null;
                return Head; ;
            }
            else
            {
                int k = 0;
                Head = new SingleListNode();
                Head.read(arr[k]);
                SingleListNode temp = Head;
                for (k = 1; k < arrLength; k++)
                {
                    temp.next = new SingleListNode();
                    temp = temp.next;
                    temp.read(arr[k]);
                }
            }

            return Head;
        }

        public void traverseLinkedList()
        {
            if (Head == null)
                Console.WriteLine("Empty list");
            SingleListNode ptr = Head;
            while (ptr != null)
            {
                ptr.print();
                ptr = ptr.next;
            }
            Console.WriteLine();
        }

        public void traverseLinkedList(SingleListNode p)
        {
            if (p == null)
                Console.WriteLine("Empty list");
            SingleListNode ptr = p;
            while (ptr != null)
            {
                ptr.print();
                ptr = ptr.next;
            }
            Console.WriteLine();
        }



        public void insertatStart(int number)
        {
            SingleListNode ptr = new SingleListNode();
            ptr.read(number);
            if (Head == null)
            {
                Head = ptr;
            }
            else
            {
                ptr.next = Head;
                Head = ptr;
            }
        }

    
        public void insertatEnd(int number)
        {
            SingleListNode ptr = new SingleListNode();
            ptr.read(number);
            if (Head == null)
            {
                Head = ptr;
            }
            else
            {
                SingleListNode temp = Head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = ptr;
            }
        }

        public void insertatSpecificPosition(int number, int position)
        {
            SingleListNode ptr = new SingleListNode();
            ptr.read(number);

            int postionPlace = 1;
            SingleListNode temp = Head;

            SingleListNode x = null;

            while (postionPlace != position)
            {
                x = temp;
                temp = temp.next;
                postionPlace++;
            }

            x.next = ptr;
            ptr.next = temp;
        }
        public void insertatMiddle(int number)
        {
            SingleListNode ptr = new SingleListNode();
            ptr.read(number);

            if (Head == null)
            {
                Head = ptr;
                return; ;
            }

            SingleListNode temp = Head;
            SingleListNode p = temp;
            SingleListNode q = temp;
            SingleListNode x = null;

            while (q.next != null && q.next.next != null)
            {
                x = p;
                p = p.next;
                q = q.next.next;
            }
            if (q.next != null)
            {
                x = p.next;
                p.next = ptr;
                ptr.next = x;
            }
            else
            {
                x.next = ptr;
                ptr.next = p;
            }
        }

        public void deleteatStart()
        {
            if (Head == null)
            {
                Console.WriteLine("No Element exists to delete");
            }
            else if (Head.next == null)
            {
                Head = null;
                return;
            }
            else
            {
                SingleListNode temp = Head;
                Head = temp.next;
            }

        }

        public void deleteatEnd()
        {
            if (Head == null)
            {
                Console.WriteLine("No Element exists to delete");
            }
            else if (Head.next == null)
            {
                Head = null;
                return;
            }
            else
            {
                SingleListNode x = null;
                SingleListNode temp = Head;
                while (temp.next != null)
                {
                    x = temp;
                    temp = temp.next;
                }
                x.next = null;
            }

        }

        public void deleteatMid()
        {
            if (Head == null)
            {
                Console.WriteLine("No Element exists to delete");
            }
            else if (Head.next == null)
            {
                Head = null;
                return;
            }
            else
            {
                SingleListNode p = Head;
                SingleListNode q = Head;
                SingleListNode x = null;

                while (q.next != null && q.next.next != null)
                {
                    x = p;
                    p = p.next;
                    q = q.next.next;
                }
                if (q.next != null)
                {
                    x = p.next;
                    p.next = x.next;
                }
                else
                {
                    x.next = p.next;
                }
            }

        }

        public void deleteatPosition(int position)
        {

            if (Head == null)
            {
                Console.WriteLine("No Element exists to delete");
            }
            else if (Head.next == null)
            {
                Head = null;
                return;
            }
            else
            {
                int postionPlace = 1;
                SingleListNode temp = Head;
                SingleListNode x = null;

                while (position != postionPlace)
                {
                    x = temp;
                    temp = temp.next;
                    postionPlace++;
                }
                x.next = temp.next;
            }
        }

        public void reverseList()
        {

            if (Head == null)
            {
                Console.WriteLine("No Element exists to delete");
            }
            else if (Head.next == null)
            {
                return;
            }
            else
            {
                SingleListNode current = Head;
                SingleListNode pnext = null;
                SingleListNode result = null;

                while (current != null)
                {
                    pnext = current.next;
                    current.next = result;
                    result = current;
                    current = pnext;
                }

                Head = result;
            }
        }

        public void reverseListRecursive()
        {

            if (Head == null)
            {
                Console.WriteLine("No Element exists to delete");
            }
            else if (Head.next == null)
            {
                return;
            }
            else
            {
                SingleListNode temp = Head;
                reverseLinkedListRescursivly(temp);

            }
        }

        private SingleListNode reverseLinkedListRescursivly(SingleListNode p)
        {
            if (p.next == null)
            {
                Head = p;
                return Head; ;
            }
            reverseLinkedListRescursivly(p.next);

            // Recursive loop statement works now (p and q values are based on call (though we brake the link it will work on previous link)
            SingleListNode q = p.next;
            q.next = p;
            p.next = null;

            return Head;
        }

        internal void mergeTwoSortedLinkedLists(int[] arr1, int[] arr2)
        {
            SingleListNode firstLinkedList = this.createSingleLinkedListNew(arr1);

            SingleListNode SecondLinkedList = this.createSingleLinkedListNew(arr2);

            SingleListNode sortCheck = null;

            if (firstLinkedList == null && SecondLinkedList == null)
            {
                Head = null;
                return;
            }


            if (firstLinkedList == null)
            {
                Head = SecondLinkedList;
                return;
            }

            if (SecondLinkedList == null)
            {
                Head = firstLinkedList;
                return;
            }

            //First check which value is leess

            if (firstLinkedList != null && SecondLinkedList != null)
            {
                if (firstLinkedList.data < SecondLinkedList.data)
                {
                    sortCheck = firstLinkedList;
                    firstLinkedList = sortCheck.next;

                }
                else
                {
                    sortCheck = SecondLinkedList;
                    SecondLinkedList = sortCheck.next;
                }

                Head = sortCheck;

            }

            while (firstLinkedList != null && SecondLinkedList != null)
            {
                if (firstLinkedList.data < SecondLinkedList.data)
                {
                    sortCheck.next = firstLinkedList;
                    sortCheck = firstLinkedList;
                    firstLinkedList = sortCheck.next;
                }
                else
                {
                    sortCheck.next = SecondLinkedList;
                    sortCheck = SecondLinkedList;
                    SecondLinkedList = sortCheck.next;
                }
            }

            if (firstLinkedList != null)
            {
                sortCheck.next = firstLinkedList;
            }
            if (SecondLinkedList != null)
            {
                sortCheck.next = SecondLinkedList;
            }
        }

        public void checkLinkedListisPallindrome()
        {
            SingleListNode p = Head;
            SingleListNode q = Head;
            SingleListNode x = null;


            while (q.next != null && q.next.next != null)
            {
                x = p;
                p = p.next;
                q = q.next.next;
            }
            if (q.next != null)
            {
                //even
                x = p.next;
                p.next = null;
            }
            else
            {
                //Odd
                x.next = null;
                x = p.next;
                p.next = null;
            }

            //Compare two lists
            int result = CompareTwoLists(Head, x);

            if (result == 1)
            {
                Console.WriteLine("This linked list is Pallindrome");
            }
            else
            {
                Console.WriteLine("This linked list is not a Pallindrome");
            }
        }

        private int CompareTwoLists(SingleListNode firstList, SingleListNode secondList)
        {
            //reverse second linked list.
            secondList = reverseLinkedListRescursivly(secondList);

            if (firstList == null || secondList == null)
            {
                return 0;
            }
            else
            {
                while (firstList != null && secondList != null)
                {
                    if (firstList.data != secondList.data)
                    {
                        return 0;
                    }

                    firstList = firstList.next;
                    secondList = secondList.next;
                }
                if (firstList == null && secondList != null)
                {
                    return 0;
                }
                if (firstList != null && secondList == null)
                {
                    return 0;
                }
            }
            return 1;
        }


        public void removeDuplicatesunsortedList()
        {
            SingleListNode p = Head;
            SingleListNode q = null;
            SingleListNode x = p;
            int posotion = 1;
            bool duplicatefound = false;

            while (p.next != null)
            {
                duplicatefound = false;
                q = p.next;
                while (q != null)
                {
                    if (p.data != q.data)
                    {
                        q = q.next;
                    }
                    else
                    {
                        duplicatefound = true;
                        x.next = p.next;
                        p = x.next;
                        x = p;
                        if (posotion == 1)
                        {
                            Head = x;
                        }
                        break;
                    }
                }
                if (!duplicatefound)
                {
                    p = p.next;
                    x = p;
                    posotion++;
                }
            }
        }

        internal void removeDuplicatessortedList()
        {
            SingleListNode p = Head;
            SingleListNode q = null;

            while(p!= null && p.next != null)
            {
                if(p.data == p.next.data)
                {
                    q = p.next.next;
                    if(q == null)
                    {
                        p.next = null;
                        break;
                    }
                    p.next = q;
                }
                if(p.data != p.next.data)
                {
                    p = p.next;
                }
            }
        }


        public void AddtwoNumbersinLinkedList(int[] arr1, int[] arr2)
        {
            SingleListNode firstList = createSingleLinkedListNew(arr1);
            SingleListNode secondList = createSingleLinkedListNew(arr2);
            SingleListNode finalList = null;

            int FirstListLength = GetLinkedListLength(firstList);
            int SecondListLength = GetLinkedListLength(secondList);

            int diff = 0;

            //If two list are not having same length add 0 to match the length
            if (FirstListLength != SecondListLength)
            {
                if (FirstListLength < SecondListLength)
                {
                    diff = SecondListLength - FirstListLength;

                    while (diff == 0)
                    {
                        SingleListNode temp = new SingleListNode();
                        temp.read(0);

                        temp.next = firstList;
                        firstList = temp;
                        diff--;

                    }
                }
                else
                {
                    diff = FirstListLength - SecondListLength;

                    while (diff != 0)
                    {
                        SingleListNode temp = new SingleListNode();
                        temp.read(0);

                        temp.next = secondList;
                        secondList = temp;
                        diff--;

                    }
                }
            }

            firstList = reverseLinkedListRescursivly(firstList);
            secondList = reverseLinkedListRescursivly(secondList);

            int addition = 0, divedby10Value = 0, Reminder = 0, carry = 0, newnodeValue = 0;
            SingleListNode ptr = new SingleListNode();

            while (firstList != null)
            {
                //when divided by 10 is not equal to 0 then new node = remainder else newnode= additem.
                addition = firstList.data + secondList.data + carry;
                divedby10Value = addition / 10;
                Reminder = addition % 10;
                carry = divedby10Value;

                if (divedby10Value != 0)
                {
                    newnodeValue = Reminder;
                }
                else
                {
                    newnodeValue = addition;
                }

                SingleListNode temp = new SingleListNode();
                temp.read(newnodeValue);

                if (finalList == null)
                {
                    finalList = temp;
                    ptr = finalList;

                }
                else
                {
                    ptr.next = new SingleListNode();
                    ptr = ptr.next;
                    ptr = temp;
                    //Not working this logic
                }

                if (firstList == null && secondList == null)
                {
                    if (carry > 0)
                    {

                    }
                }

                firstList = firstList.next;
                secondList = secondList.next;

            }


        }

        private int GetLinkedListLength(SingleListNode firstList)
        {
            SingleListNode temp = firstList;
            int length = 0;
            while (temp != null)
            {
                length++;
                temp = temp.next;
            }

            return length;
        }

        public void swapNodesPairwise()
        {
            SingleListNode p = Head;
            SingleListNode q = null;
            SingleListNode temp = null;
            SingleListNode new_start = null;
            if (p.next == null)
            {
                return;
            }
            else
                new_start = p.next;

            while (p.next != null)
            {
                q = p.next;
                temp = q.next;
                q.next = p;

                if (temp == null || temp.next == null)
                {
                    p.next = null;
                    break;
                }

                p.next = temp.next;
                p = temp;

            }
            Head = new_start;
        }

        internal void swapNodesinLLingroupsize(int k)
        {
            SingleListNode start = Head;
            SingleListNode p = start;
            SingleListNode q = null;
            SingleListNode temp = null;
            SingleListNode new_start = null;
            int cnt = 1;
            while (cnt != k)
            {
                if (p.next == null)
                {
                    Head = start;
                    return;
                }
                p = p.next;
                cnt++;
            }

            new_start = p;
            q = new_start;

            while (p.next != null)
            {
                p = start;
                temp = q.next;
                if (temp == null)
                {
                    p = reverseLinkedListRescursivly(p);
                    Head = new_start;
                    return;
                }
                q.next = null;
                q = temp;
                start = temp;
                cnt = 1;

                while (cnt != k)
                {
                    if (temp.next == null)
                    {
                        p = reverseLinkedListRescursivly(p);
                        p.next = q;
                        Head = new_start;
                        return;
                    }
                    temp = temp.next;
                    cnt++;
                }
                p = reverseLinkedListRescursivly(p); /// This logic is not working  as p is gettting reverse and handling head postion 4 th one but out head postion should be firtst one (4th after reverse)
              
                p.next = temp;
                q = temp;
            }
            Head = new_start;
        }
    }
}
