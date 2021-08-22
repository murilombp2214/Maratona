using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace URI
{
    class Program
    {
        const string FACE = "FACE";
        const int COUNT_INPUT = 4;
        static void Main(string[] args)
        {

            var stack = new Stack<char>(FACE);
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            while (n-- > 0)
            {

                string[] array = Console.ReadLine().Split(' ');
                if(array.Count() == 1)
                    array = Console.ReadLine().Split(' ');
                stack.Push(array[0][0]);
                stack.Push(array[1][0]);
                stack.Push(array[2][0]);
                stack.Push(array[3][0]);

                if (IsReverseWord(ref stack))
                    result++;

                if (stack.Count == 0)
                    AddFace(stack);
            }


            Console.WriteLine(result);
        }

        private static bool IsReverseWord(ref Stack<char> stack)
        {
            var stackComper = new Stack<char>();
            var stackAux = new Stack<char>(stack.Reverse());

            stackComper.Push(stack.Pop());
            stackComper.Push(stack.Pop());
            stackComper.Push(stack.Pop());
            stackComper.Push(stack.Pop());
            

            bool isEqual = true;
            int max = COUNT_INPUT;
            while (max-- > 0 && (isEqual = stackComper.Pop() == stack.Pop())) 
            ;

            if (!isEqual)
                stack = stackAux;

            return isEqual;

        }

        private static void AddFace(Stack<char> stack)
        {
            stack.Push(FACE[0]);
            stack.Push(FACE[1]);
            stack.Push(FACE[2]);
            stack.Push(FACE[3]);
        }
    }
}
