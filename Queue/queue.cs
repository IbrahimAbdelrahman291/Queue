using System;


namespace Queue
{
    public class queue
    {
        int size;
        int front;
        int rear;
        int[] q;
        public queue() 
        {
            size = 10;
            front = -1;
            rear = -1;
            q = new int[size];
        }
        public bool IsFull() 
        {
            return (rear == size-1) ? true : false;
        }
        public bool IsEmpty() 
        {
            return (front == -1 && rear == -1) ? true : false;
        }
        public int LengthOfQueue() 
        {
            return rear + 1;
        }
        public int peek() 
        {
            return (IsEmpty()) ? 0 : q[front];
        }
        public void Enqueue(int value) 
        {
            if (IsFull())
            {
                Console.WriteLine("Already full");
            }
            else if (IsEmpty()) 
            {
                front++;
                rear++;
                q[rear] = value;
                Console.WriteLine("Item added successfully");
            }
            else
            {
                rear++;
                q[rear] = value;
                Console.WriteLine("Item added successfully");
            }
        }
        public void Dequeue() 
        {
            if (IsEmpty())
            {
                Console.WriteLine("Already empty");
            }
            else if(front == rear)
            {
                q[front] = 0;
                front--;
                rear--;
            }
            else
            {
                q[front] = 0;
                
                for (int i = 0; i < rear; i++)
                {
                    q[i] = q[i + 1];
                }
                Console.WriteLine("Dequeue successfully");
            }
        }
        public void Display() 
        {
            if (IsEmpty())
            {
                Console.WriteLine("There are not elements to display it");
            }
            else 
            {
                for (int i = 0; i <= rear; i++)
                {
                    Console.Write($"{q[i]} <-");
                }
                Console.WriteLine();
            }
        }
    }
}