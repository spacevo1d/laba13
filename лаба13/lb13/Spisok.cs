using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lb13
{
    internal class Spisok
    {
        public Node head;
        public Node tail;
        public int count = 0;
        public Spisok() {
        }
        public void AddFirst(Node node)
        {
            var temp = head;
            node.next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.prev = node;
            count++;
        }
        public void Add(Node node)
        {
            if (head == null) { head = node; }
            else
            {
                tail.next = node;
                node.prev = tail;

            }
            tail = node;
            while(head.prev != null) { head=head.prev; count++; }
            while(tail.next != null) { tail = tail.next; count++; }
            count++;
        }
        public void DelFirst()
        {
            if (count == 0)
            {
                throw new Exception("Пустой список");
            }
            else if (count == 1)
            {
                var temp=new Node();
                head = tail = temp;
                count--;
            }
            else
            {
                var temp=head.next;
                head=new Node(head.next.data);
                head.next = temp.next;
                count--;
            }
        }
        public void Del()
        {
            if (count == 0)
            {
                throw new Exception("Пустой список");
            }
            else if (count == 1)
            {
                var temp = new Node();
                head = tail = temp;
                count--;
            }
            else
            {
                var temp = tail.prev;
                tail=new Node(tail.prev.data);
                tail.prev = temp.prev;
                count--;
            }
        }
        public Node First()
        {
            return head;
        }
        public Node Last()
        {
            return tail;
        }
        public int Count()
        {
            return count;
        }
        public void print()
        {
            Node node = head;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; ++i)
            {
                if (node != null)
                {
                    sb.Append(node.data.ToString() + " ");
                    node = node.next;
                }
            }
            Console.WriteLine("Список: " + sb.ToString());
        }
    }
}
