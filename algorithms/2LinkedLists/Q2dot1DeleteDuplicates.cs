using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms._2LinkedLists
{
    public class Node<T>
    {
        public Node<T> next { get; set; }
        public T data { get; }
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = next;
        }

        public void Display()
        {
            Console.WriteLine("{0}", data);
            var n = this.next;
            while (n != null)
            {
                Console.WriteLine("{0}", n.data);
                n = n.next;
            }
        }
    }

    class Q2dot1Duplicates
    {
        public void DeleteDuplicatesWithList<T>(Node<T> head)
        {
            var datalist = new List<T>();
            if (head != null)
            {
                datalist.Add(head.data);
            }
            while (head.next != null)
            {
                if (!datalist.Contains(head.next.data))
                {
                    datalist.Add(head.next.data);
                    head = head.next;
                }
                else
                {
                    Node<T> search = head.next.next;
                    while (search != null)
                    {
                        if (datalist.Contains(search.data))
                        {
                            search = search.next;
                        }
                        else
                        {
                            break;
                        }
                    }
                    head.next = search;
                }
            }
        }

        public Node<int> CreateLinkedList() => new Node<int>(2,
    new Node<int>(4,
        new Node<int>(8,
            new Node<int>(4,
                new Node<int>(2)))));

        [TestCase()]
        public void TestDeleteDuplicate()
        {
            var head = CreateLinkedList();
            DeleteDuplicatesWithList(head);
            head.Display();
            Assert.IsNull(head.next.next.next);
        }
    }
}
