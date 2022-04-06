using System;
using System.IO;


namespace Exception_Stack
{
   public  class StackException : Exception
    {
        public StackException(string message) : base(message)
        { }
    }

  public  class MyStack
    {
        int[] stack;
        int topOfStack;
        int n;

        public MyStack(int size)
        {
            this.n = size;
            this.stack = new int[n];
            this.topOfStack = -1;
        }

        public void Push(int value)
        {
            try
            {
                if (this.topOfStack == this.n - 1)
                    throw new StackException("Stack is full");
                else
                    this.stack[++this.topOfStack] = value;
            }
            catch (StackException e) {

                Console.WriteLine(e.Message);
            }
            
        }

        public void Pop()
        {

            try
            {
                if (this.topOfStack == -1)
                    throw new StackException("Stack is empty ");
                else
                {
                    Console.WriteLine("{0} popped", this.stack[this.topOfStack]);
                    this.topOfStack--;
                }
            }
            catch (StackException e)
            {

                Console.WriteLine(e.Message);
            }
           
            
        }

        public void DisplayStack()
        {
            Console.WriteLine("\nValues in Stack: ");
            if (topOfStack > -1)
            {
                for (int i = 0; i <= topOfStack; i++)
                {
                    Console.Write("{0} ", stack[i]);
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("Stack Empty");
        }

     public static void Main()
        {   
         
            Console.WriteLine("Enter the size of the stack");
            int size = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            MyStack obj = new MyStack(size);

            do
            {
                Console.WriteLine("\n1. Push\n2. Pop\n3. Display Stack\n4. Exit\n");
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("Enter a value to pushed");
                        int value = Convert.ToInt32(Console.ReadLine());
                        obj.Push(value);
                        break;
                    case 2:
                        obj.Pop();
                        break;
                    case 3:
                        obj.DisplayStack();
                        break;
                    case 4:
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (c != 4);
        }
    }
}
