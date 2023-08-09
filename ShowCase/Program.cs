// See https://aka.ms/new-console-template for more information
using UtilityLibraries;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace show {
public class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }

public class Program
{
    
   public static void Main(string[] args)
   {
       int[] arr = { 3, 6, 8, 10, 1, 2, 1 };
       QuickSortArray(arr, 0, arr.Length - 1);
       Console.WriteLine("Sorted array:");
       PrintArray(arr);

       Account account = new Account
            {
                Name = "John Doe",
                Email = "john@nuget.org",
                DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
            };

            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(json);
      
   }

   public static void QuickSortArray(int[] arr, int low, int high)
   {
       if (low < high)
       {
           int pivotIndex = Partition(arr, low, high);
           QuickSortArray(arr, low, pivotIndex - 1);
           QuickSortArray(arr, pivotIndex + 1, high);
       }
   }

   private static int Partition(int[] arr, int low, int high)
   {
       int pivot = arr[high];
       int i = low - 1;
       for (int j = low; j <= high - 1; j++)
       {
           if (arr[j] <= pivot)
           {
               i++;
               Swap(ref arr[i], ref arr[j]);
           }
       }
       Swap(ref arr[i + 1], ref arr[high]);
       return i + 1;
   }

   private static void Swap(ref int a, ref int b)
   {
       int temp = a;
       a = b;
       b = temp;
   }

   private static void PrintArray(int[] arr)
   {
       foreach (int num in arr)
       {
           Console.Write(num + " ");
       }
       Console.WriteLine();
   }

   
}}