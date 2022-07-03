using System;
using System.Collections;
using System.IO;

namespace Task_02
{
    class LinkedList
    {
        public Node head;
        public Node tail;


        public void InsertAtLast(double cargo)
        {
            Node newnode = new Node();
            newnode.Cargo = cargo;

            if (head == null)           //The list is empty
            {
                head = newnode;
                tail = newnode;
            }
            else
            {
                tail.next = newnode;
                tail = newnode;
            }
        }

        public bool checkWeight(Node curhead, Node temp)
        {
            if (curhead.Cargo == temp.Cargo)
                return true;
            if (temp.Cargo > curhead.Cargo)
                return (temp.Cargo - curhead.Cargo < 2.5);
            else
                return (curhead.Cargo - temp.Cargo < 2.5);
        }

        public int NrDaysHelper()
        {
            Node temp = head;
            return NrDays(head, temp);
        }

        public int NrDays(Node curhead,Node temp)
        {
            int numDays = 1;
            int count = 0;
            while (temp != null)
            {
                if(checkWeight(curhead, temp) == true)
                {
                    count++;
                    if (count > numDays)
                        numDays = count;
                    temp = temp.next;
                }
                else
                {
                    count = 0;
                    curhead = temp;
                    if (count > numDays)
                        numDays = count;
                    temp = temp.next;
                }
            }

            return numDays;
        }
        
        
        public void DisplayAll()
        {
            Console.WriteLine("Displaying List");
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Cargo);
                temp = temp.next;
            }
        } 
    }
}
