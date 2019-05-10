using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] arr = new int[1000];
            int[] arr2 = new int[1000];

            arr = Populate(arr);
            StandardBubbleSort(arr);
            ImprovedBubbleSort(arr);
            Display(arr);

            Console.ReadLine();

        }

        static int[] Populate(int[] arr)
        {
            Random randNum = new Random();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write((arr[i] = randNum.Next(0, 1000)) + " ");
            }

            return arr;
        }

        static void Display<T>(T[] arr)
        {
            foreach (T x in arr)
            {
                Console.Write(x + " ");
            }
        }


        static int[] StandardBubbleSort(int[] arr)

            
        {
            /*External loop makes sure we check all of array*/
            for (int i = 0; i < arr.Length - 1; i++)
            {
                /*Internal loop goes through the elements and checks each one*/
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    /*If the current element is larger than the next element, swap them*/
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        
      

    static int[] ImprovedBubbleSort(int[] arr)
        {
            /*External loop makes sure we check all of array*/
            for (int i = 0; i < arr.Length - 1; i++)
            {
                /*Internal loop goes through the elements and checks each one*/
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    /*If the current element is larger than the next element, swap them*/
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

      


    }
}
