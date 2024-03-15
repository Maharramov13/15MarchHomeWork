using System.Runtime.CompilerServices;

internal class Program
{
    public static void Main(string[] args)
    {   
        int []array={1,2,3,4,5};
        NewNum(array,13);
     }

     static void NewNum(int[]numbers,int deyer){
         int[]newNumbers=new int[numbers.Length+1];

         for(int i=0;i<numbers.Length;i++)
         {
             newNumbers[i]=numbers[i];
         }

         newNumbers[numbers.Length]=deyer;

        for (int i = 0; i < newNumbers.Length; i++)
        {
            Console.WriteLine(newNumbers[i]+ "");
        }
    }
   
    
}