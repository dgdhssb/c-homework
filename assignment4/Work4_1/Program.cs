using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。
//通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。

namespace Work4_1
{
    public class Node<T>
    {
        public Node<T> Next{ set; get; }
        public T Data { set; get; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get=> head;
        }
        public void Add(T t)
        {
            Node<T> n=new Node<T>(t);
            if (tail == null)
            {
                head=tail = n;
            }else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> current = head;
            while (current != null)
            {
                action(current.Data);
                current = current.Next;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> genericList = new GenericList<int>();
            genericList.Add(1);
            genericList.Add(2);
            genericList.Add(3);
            genericList.Add(4);
            genericList.ForEach(x=>Console.WriteLine(x));
            int sum = 0;
            genericList.ForEach(x=>sum+=x);
            int max = genericList.Head.Data;
            genericList.ForEach(x => max = (x > max) ? x:max) ;
            int min = genericList.Head.Data;
            genericList.ForEach(x => min = (x < min) ? x:min) ;
            Console.WriteLine($"总和是{sum} 最大值是{max} 最小值是{min}");
            Console.ReadLine();
        }
    }
}
