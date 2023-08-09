// See https://aka.ms/new-console-template for more information
using UtilityLibraries;
public class Program
{
   public static void Main(string[] args)
   {
       int[] arr = { 3, 6, 8, 10, 1, 2, 1 };
       QuickSortArray(arr, 0, arr.Length - 1);
       Console.WriteLine("Sorted array:");
       PrintArray(arr);
       int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input: {input}");
            Console.WriteLine("Begins with uppercase? " +
                 $"{(input.StartsWithUpper() ? "Yes" : "No")}");
            Console.WriteLine();
            row += 4;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
            row = 3;
        }
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

   
}