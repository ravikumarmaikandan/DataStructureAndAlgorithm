﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }
        
        public void Print()
        {
            var current = this;
            while(current != null)
            {
                Console.WriteLine(current.Value.ToString() + "->");
                current = current.Next;
            }
        }
    }
}
