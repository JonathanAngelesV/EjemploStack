using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Angeles Valadez Jonathan

namespace EjemploStack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> s = new Stack<int>(4);
            s.Push(5);
            s.Push(4);
            s.Push(3);
           Console.WriteLine( s.Pop());
           Console.ReadKey();

        }
        public class Stack<T>
        {
            readonly int m_Size;
            int m_StackPointer = 0;
            T[] m_Items;

            public Stack()
                : this(100)
            {

            }


            public Stack(int size)
            {
                m_Size = size;
                m_Items = new T[m_Size];

            }
            public void Push(T item)
            {
                if (m_StackPointer >= m_Size)
                    throw new StackOverflowException();
                m_Items[m_StackPointer] = item;
                m_StackPointer++;
            }
            public T Pop()
            {
                m_StackPointer--;
                if (m_StackPointer >= 0)
                {
                    return m_Items[m_StackPointer];
                }
                else
                {
                    m_StackPointer = 0;
                    throw new InvalidOperationException("Cannot pop an empty stack");
                }
            }
        }
    }
}
