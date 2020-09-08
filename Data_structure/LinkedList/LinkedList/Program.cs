using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> cacbaihoc = new LinkedList<string>();
            cacbaihoc.AddFirst("Bai hoc 3");//thêm vào đầu danh sách
            cacbaihoc.AddLast("Bai hoc 4");//thêm vào cuối danh sách
            cacbaihoc.AddFirst("Bai hoc 2");
            cacbaihoc.AddFirst("Bai hoc 1");
            //lấy phần tử đầu tiên,sau đó duyệt đến cuối
            Console.WriteLine("---------node dau tien den node cuoi");
            LinkedListNode<string> node = cacbaihoc.First;
            int i = 1;
            while (node != null)
            {
                Console.WriteLine("node " + i + ":" + node.Value);
                i++;
                node = node.Next;
            }
            Console.WriteLine("---------node cuoi den node dau tien");
             i = cacbaihoc.Count;
            node = cacbaihoc.Last;
            while (node != null)
            {
                Console.WriteLine("node " + i + ":" + node.Value);
                i--;
                node = node.Previous;
            }

            Console.ReadLine();
        }
    }
}
