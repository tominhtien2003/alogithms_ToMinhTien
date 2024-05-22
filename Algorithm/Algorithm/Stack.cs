using System;

namespace Algorithm.Algorithm
{
    public class Stack<T>
    {
        private T[] data;

        private int capacity;

        private int top;
        public Stack()
        {
            capacity = 1;

            data = new T[capacity];

            top = -1;
        }

        /// <summary>
        /// Stack is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return top == -1;
        }
        /// <summary>
        /// Delete obj in stack
        /// </summary>
        public void Pop()
        {
            if (top == -1) return;
            --top;
        }
        /// <summary>
        /// stack is full
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return top == capacity - 1;
        }
        /// <summary>
        /// Add obj within stack
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            if (IsFull()) UpdateCapacity();

            data[++top] = item;
        }
        /// <summary>
        /// Take size of stack
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return top + 1;
        }
        /// <summary>
        /// Delete obj in stack
        /// </summary>
        /// <returns></returns>
        public T Top()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");

                return default(T);
            }
            return data[top];
        }
        /// <summary>
        /// Update capacity of stack
        /// </summary>
        private void UpdateCapacity()
        {
            capacity = capacity * 2 + 1;

            T[] newData = new T[capacity];

            for (int i = 0; i <= top; i++)
            {
                newData[i] = data[i];
            }
            data = newData;
        }
    }
}
