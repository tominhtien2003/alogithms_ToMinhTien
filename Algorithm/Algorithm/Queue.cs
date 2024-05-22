using System;

namespace Algorithm.Algorithm
{
    public class Queuee<T>
    {
        private int capacity;

        private T[] data;

        private int front;

        private int rear;

        private int count;
        public Queuee()
        {
            capacity = 1;

            data = new T[capacity];

            front = -1;

            rear = 0;

            count = 0;
        }

        /// <summary>
        /// Queue is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return count == 0;
        }
        /// <summary>
        /// Queue is full
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return count == capacity;
        }
        /// <summary>
        /// Push obj within queue
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            if (count == capacity) UpdateCapacity();

            data[(++front) % capacity] = item;

            ++count;
        }
        /// <summary>
        /// Delete obj in queue
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public void Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            rear = (++rear) % capacity;

            --count;
        }
        /// <summary>
        /// Update capacity of queue
        /// </summary>
        private void UpdateCapacity()
        {
            capacity = capacity * 2 + 1;

            T[] newData = new T[capacity];

            for (int i = rear; i <= front; i++)
            {
                newData[i - rear] = data[i];
            }
            rear = 0;

            front = front - rear;

            data = newData;
        }

        /// <summary>
        /// Take size of queue
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return count;
        }
        /// <summary>
        /// Take obj of queue
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public T Front()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return data[rear];
        }
    }
}
