uusing System;

namespace Task3.Unique
{
    class Program
    {
        static bool IsExists(int[] a, int b)
        {
            foreach(int el in a)
            if (a==b) return true;
            return false;
        }

        static void Main(string[] args)
        {
            int[] arr=new int[10];
            Random random=new Random();
            for(int i=0;i<arr.Lenght;i++)
            arr[i]=random.Next(1,6);
            System.Console.WriteLine(string.join(", ", arr));
            int j=0;
            int[] t=new int[0];
            foreach(int el in arr)
            if (!IsExists(t, el))
            {
                Array.Resize(ref t,j+1); //Вот так не хорошо!!!
                t[j]=el;
                j++;
            }
            System.Console.WriteLine(string.Join(", ", t));
        }
    }
}