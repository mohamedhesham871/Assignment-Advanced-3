﻿namespace C__Advanced_3
{
    internal class Program
    {
        #region Method of Point One
        static public void ReverseQueue( Queue<int> ts)
        {
            Stack<int> Temp = new Stack<int>();
            while (ts.Count > 0)
            {
                Temp.Push(ts.Dequeue());
            }
            while(Temp.Count > 0)
            {
                ts.Enqueue(Temp.Pop());
            }

        }
        #endregion
        static void Main(string[] args)
        {
            #region First Point
            Queue<int> numbers=new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);
            numbers.Enqueue(5);
            numbers.Enqueue(6);

            Console.WriteLine("number in Queue Befor Reverse");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }//1 2 3 4 5 6 ...
            //********
            ReverseQueue( numbers);
            //********
            Console.WriteLine("number in Queue After Reverse");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
