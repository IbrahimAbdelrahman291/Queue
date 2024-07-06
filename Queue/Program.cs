using Queue;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        queue q = new queue();
        int choice;
        int value;
        do 
        {
            ShowOptions();
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) 
            {
                case 0:
                    Console.WriteLine("Bye");
                    break;
                case 1:
                    if (q.IsFull())
                    {
                        Console.WriteLine("queue is full");
                    }
                    else
                    {
                        Console.WriteLine("queue isn't full");
                    }
                    break;
                case 2:
                    if (q.IsEmpty())
                    {
                        Console.WriteLine("queue is empty");
                    }
                    else
                    {
                        Console.WriteLine("queue isn't empty");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter value");
                    value = Convert.ToInt32(Console.ReadLine());
                    q.Enqueue(value);
                    break;
                case 4:
                    q.Dequeue();
                    break;
                case 5:
                    if (q.peek() == 0)
                    {
                        Console.WriteLine("Already empty");
                    }
                    else
                    {
                        Console.WriteLine(q.peek());
                    }
                    break;
                case 6:
                    q.Display();
                    break;
                default:
                    Console.WriteLine("Invaild option");
                    break ;
            }
        }while (choice!=0);
    }
    public static void ShowOptions() 
    {
        Console.WriteLine("__________________________________");
        Console.WriteLine("1-IsFull");
        Console.WriteLine("2-IsEmpty");
        Console.WriteLine("3-Enqueue");
        Console.WriteLine("4-Dequeue");
        Console.WriteLine("5-peek");
        Console.WriteLine("6-Display");
        Console.WriteLine("0-Exit");
        Console.WriteLine("__________________________________");
    }
}