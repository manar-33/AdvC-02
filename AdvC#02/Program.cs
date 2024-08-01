using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdvC_02
{
    internal class Program
    {
        //public static int ReverseArrayList(ArrayList arrayList)
        //{
        //    int[] reverse = new int[arrayList.Count];
        //    int j = arrayList.Count - 1;
        //    for (int i = 0; i < arrayList.Count; i++)
        //    {

        //        reverse[i] = (int)arrayList[j];
        //        Console.WriteLine(reverse[i]);
        //        j--;
        //    }
        //    return 0;
        //}
        static void Main(string[] args)
        {
            #region Part01
            #region Non Generic
            //Structure:
            //ArrayList:
            // Dynamically resizable array of objects.
            // array is resized as needed 
            // Stack:
            // LIFO(Last In, First Out) data structure.
            //Often implemented using an array or linked list.
            //Queue:
            //FIFO(First In, First Out) data structure.
            //Typically implemented using an array or linked list.
            //Time Complexity:
            //Collection Operation   Average Case    Worst Case
            //ArrayList Access          O(1)            O(1)
            //ArrayList Search          O(n)            O(n)
            //ArrayList Insertion       O(n)            O(n)
            //ArrayList Deletion        O(n)            O(n)
            //Stack Push                O(1)            O(1)
            //Stack Pop                 O(1)            O(1)
            //Stack Peek                O(1)            O(1)
            // Queue Enqueue            O(1)            O(1)
            //Queue Dequeue             O(1)            O(1)
            //Queue Peek                O(1)            O(1) 
            #endregion
            #region Generic
            //List<T>: Represents a strongly typed list of objects.Internally, it uses an array to store elements.
            //Stack<T>: Represents a generic stack(LIFO).   
            //Queue<T>: Represents a generic queue(FIFO).   
            //Collection Operation   Average Case    Worst Case
            //List<T> Access              O(1)          O(1)
            //List<T> Search              O(n)          O(n)
            //List<T> Insertion           O(1)          O(n)
            //List<T> Deletion            O(1)          O(n)
            //Stack<T> Push               O(1)          O(1)
            //Stack<T> Pop                O(1)          O(1)
            //Stack<T> Peek               O(1)          O(1)
            //Queue<T> Enqueue            O(1)          O(1)
            //Queue<T> Dequeue            O(1)          O(1)
            //Queue<T> Peek               O(1)          O(1)

            #endregion

            #endregion
            #region Part02 Question01

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);
            //arrayList.Add(5);
            //int Result = ReverseArrayList(arrayList);
            //Console.WriteLine(Result);
            //Console.WriteLine("=============");
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);

            //}
            #endregion
            #region Question02
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            //foreach (int Num in Numbers)
            //{
            //    if (Num % 2 == 0)
            //    {
            //        Console.WriteLine(Num);
            //    }
            //}
            #endregion


        }
    }
}

