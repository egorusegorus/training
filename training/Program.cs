
using System.Diagnostics.CodeAnalysis;

namespace training
{
    internal class Program
    {
        static void Main(string[] args)
        { int[] arr = { 3, 5, 8, 7, 4 };
            sum(arr);
            avg(arr);
            min(arr);
            max(arr);
            sort(arr);
            Console.ReadLine();
        }
      static  void sum(int[] arr) {
            int a=0;
            for (int i = 0; i < arr.Length; i++) { 
            a += arr[i];
            }
            Console.WriteLine("Summe von arr= " + a);
        }
        static void avg(int[] arr)
        {
            double a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                a += arr[i];
                
            }
            a = a / arr.Length;
            Console.WriteLine("Mittelwert von arr= " + a);
        }
        static void min(int[] arr)
        {
            int a = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (a > arr[i]) 
                    { a = arr[i]; }


            }
            
            Console.WriteLine("Minwert von arr= " + a);
        }
        static void max(int[] arr)
        {
            double a = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (a <= arr[i])  a = arr[i]; 

            }

            Console.WriteLine("Maxwert von arr= " + a);
        }

        static void sort(int[] arr)
        {
            Console.WriteLine(arr[0] + ", " + arr[1] + ", " + arr[2] + ", " + arr[3] + ", " + arr[4]);
            
            try { 
            for (int i = 0; i < arr.Length; i++) {
                    for (int j = 0; j < arr.Length-1; j++) {
                        if (arr[j] > arr[j + 1])
                        {
                            
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }
            catch (Exception ex) { }


                Console.WriteLine(arr[0]+", "+ arr[1] + ", " + arr[2] + ", " + arr[3] + ", " + arr[4]);

            
        }
    }
}
