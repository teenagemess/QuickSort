using System;
using System.Security.Cryptography.X509Certificates;

namespace QuickSort
{
    class Program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; //number of comparasion
        private int mov_count = 0; //number of data movements

        //number of elements in array
        private int n;

        void input()
        {
            while (true)
            {
                while (true)
                {
                    Console.Write("Enter the number of elements in the array :");
                    string s = Console.ReadLine();
                    n = Int32.Parse(s);
                    if (n <= 20)
                        break;
                    else
                        Console.WriteLine("\n Array can have maximum 20 elements \n");
                }
                Console.WriteLine("\n==================");
                Console.WriteLine("Enter Array Elements");
                Console.WriteLine("\n==================");

                //get array elements
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("<" + (i = 1) + ">");
                    string s1 = Console.ReadLine();
                    arr[i] = Int32.Parse(s1);
                }
            }
            //swaps the element at index x with the element at index v
            void swap(int x, int y)
            {
                int temp;
                temp = arr[x];
                arr[x] = arr[y];
                arr[y] = temp;
            }
        }
            public void g_sort(int low, int high)
            {
                int pivot, i, j;
                if (low > high)
                    return;

                //particion the list into two parts:
                //one countaining elements less that or equal to pivot
                //outher containing elements greather than pivot

                i = low + 1;
                j = high;

            pivot = arr[i];

            while( i <= j)
            {
                //search for an element greater than pivot
                while ((arr[i] <= pivot) && (1 <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count = 0;

               
            }
            }
    }
}