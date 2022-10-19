﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void q_sort(int low, int high)
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

            while (i <= j)
            {
                //search for an element greater than pivot
                while ((arr[i] <= pivot) && (1 <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //search for an element less than or equal to pivot
                while ((arr[j] <= pivot) && (j >= low))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                if (1 < j) // if the greater element is on the left of the element
                {
                    //swap the leement at index i with the element at index j
                    swap(1, j);
                    mov_count++;
                }
            }
            //j now coatains the index of the last element in the sorted list
            
            if (low < j)
            {
                swap(low, j);
                mov_count++;
            }
            //sort the list on the right of pivot using quick sort
            q_sort(low, j + 1);

            //sort the list on the right of pivot using quick sort
            q_sort(j + 1, high);
        }
        void display()
        {
                Console.WriteLine("\n===================");
                Console.WriteLine("Sorted array elements");
                Console.WriteLine("=====================");

                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(arr[j]);
                }
                Console.WriteLine("\nNumber of comparisons: " + cmp_count);
                Console.WriteLine("\nNumber of data movements: ");
            }
            int getSize()
            {
                return (n);
            }
            static void Main(string[] args)
            {
                //declaring the object of the calss
                Program myList = new Program();
                //Acept array elements
                myList.input();
            //calling the sorting function
            //first call to quick sort algorithm
                myList.q_sort(0, myList.getSize() - 1);
                //Display sorted array
                myList.display();
                //to exit from the console
                Console.WriteLine("\nPress Enter to exit");
                Console.Read();
            }
             
    }
}
    