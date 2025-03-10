

            namespace StackAssignment
    {
        class Program
        {
            static void Main()
            {
                var stack = new Stack();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);

                Console.WriteLine(stack.Pop()); // 3
                Console.WriteLine(stack.Pop()); // 2
                Console.WriteLine(stack.Pop()); // 1


                //Console.WriteLine(stack.Pop()); This stimulates an exception.




            }
        }
    }





