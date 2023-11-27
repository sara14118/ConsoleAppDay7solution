using System.Runtime.CompilerServices;

namespace ConsoleAppDay7
{
    internal class Program

    {
        //static int Sumarr(params int[] arr)
        //{
        //    int sum = 0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}







        //static void Main(string[] args)
        //{
        //    int[] Numbers = { 1, 2, 3, 4, 5 };
        //    Console.WriteLine(Sumarr(1, 2, 3, 4, 5));

        //}














        //static int SumArray(int x, int y, out int multiplication, out int sum , params int[] sumarray)


        //{

        //    multiplication = x * y;
        //    sum = 0 ;

        //    for (int i = 0; i < sumarray.Length; i++)
        //    {
        //        sum += sumarray[i];
        //    }
        //    return 0;

        //}


        //static void Main(string[] args)
        //{
        //    int[] Numbers = { 1, 2, 3, 4, 5 };
        //    Console.WriteLine(SumArray(1,2,out int multiplication,out int sum ,3,4,5));
        //    Console.WriteLine($"sum :{sum} , multi :{multiplication}");

        //}









        static void DoSomthing()
        {
            Console.WriteLine("please enter a number :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enternumber :");
            int y = int.Parse(Console.ReadLine());

            int z = x / y;

            int arr[] = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr[4]);
        }




























    }
}