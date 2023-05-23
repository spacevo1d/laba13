using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lb13
{
    internal class SpisokC<T>
    {
        public Node1<T> head;
        public Node1<T> tail;
        public int count = 0;
        public SpisokC()
        {
        }
        public void Add(Node1<T> a)
        {
            if (head == null) { head = a;}
            else
            {
                tail.next = a;
                a.prev = tail;
            }
            tail = a;
            tail.next = head;head.prev = tail;
            count++;
        }
        public SpisokC(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Add(new Node1<T>(arr[i]));
            }
        }
        public T[] Arr()
        {
            var a= new T[count];
            var temp = head;
            for(int i = 0; i < count; i++)
            {
                a[i] = temp.data; temp = temp.next;
            }
            return a;
        }
        public T[] Arr(T b)
        {   if (!Exist(b)) { throw new Exception("Не существующий элемент!"); }
            int cnt = count;
            var tp = head;
            while (!tp.data.Equals(b))
            {
                tp=tp.next;
                cnt--;
            }
            var a = new T[cnt];
            for (int i = 0; i < cnt; i++)
            {
                a[i] = tp.data; tp = tp.next;
            }
            return a;
        }
        public bool Exist(T a)
        {
            var temp = head;
            for (int i = 0; i < count; i++)
            {
                if (temp.data.Equals(a))
                {
                    return true;
                }
                else { temp = temp.next; }
            }
            return false;
        }
        public void AddAfter(Node1<T> a, T b)
        {
            if (head == null) { throw new Exception("Пустой список!"); }
            else if (!Exist(b))
            {
                throw new Exception("Не существующий элемент!");
            }
            else
            {
                var temp= head;
                while (!temp.data.Equals(b))
                {
                    temp= temp.next;
                }
                var temp1= temp.next;
                temp.next = a;
                a.prev=temp; 
                a.next=temp1;
                temp1.prev = a;
                count++;
            }
        }
        public void AddAfter(T b,SpisokC<T> c,T d)
        {
            if (head == null||c.head == null) { throw new Exception("Пустой список!"); }
            else if (!Exist(b)||!c.Exist(d))
            {
                throw new Exception("Не существующий элемент!");
            }
            var temp = head;
            while (!temp.data.Equals(b))
            {
                temp = temp.next;
            }
            var temp1 = temp.next;
            var e=new SpisokC<T>(c.Arr(d));
            var tp1 = e.head;
            for(int i = 0; i < e.count; i++)
            {
                var tp2 = new Node1<T>(tp1.data);
                temp.next = tp2;
                tp2.prev = temp;
                temp=temp.next;
                tp1 = tp1.next;
                count++;
            }
            temp1.prev = temp;
            temp.next=temp1;
        }
        public void AddBefore(Node1<T> a, T b)
        {
            if (head == null) { throw new Exception("Пустой список!"); }
            else if (!Exist(b))
            {
                throw new Exception("Не существующий элемент!");
            }
            else
            {
                var temp = head;
                while (!temp.data.Equals(b))
                {
                    temp = temp.next;
                }
                var temp1 = temp.prev;
                temp.prev = a;
                a.prev = temp1;
                a.next = temp;
                temp1.next = a;
                count++;
            }
        }
        public Node1<T> First()
        {
            return head;
        }
        public int Count()
        {
            return count;
        }
        public void Del(T a)
        {
            if (head == null) { throw new Exception("Пустой список!"); }
            else if (!Exist(a))
            {
                throw new Exception("Не существующий элемент!");
            }
            else
            {
                var temp = head;
                while (!temp.data.Equals(a))
                {
                    temp = temp.next;
                }
                temp=temp.prev;
                var temp1 = temp.next.next;
                temp.next = temp1;
                temp1.prev=temp;
                count--;
            }
        }
        public override string ToString()
        {
            var a=new StringBuilder();
            var temp = head;
            for(int i = 0; i < count; i++)
            {
                a.Append(temp.data+"\n");
                temp= temp.next;
            }
            return a.ToString();
        }
    }
}
