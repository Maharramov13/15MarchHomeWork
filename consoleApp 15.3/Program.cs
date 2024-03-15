using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int[]Numbers={1,3,5,-8,-9,2,-53};
        foreach(int items in Numbers){
           System.Console.Write("Deyishdirilmemish hali: "+items);
        }
       ModifyArray(Numbers);

    }
    static void ModifyArray(int[] array)
    { 

        System.Console.WriteLine("Modified numbers: ");
        foreach(int num in array)
        {
            if(num<0){
                System.Console.WriteLine(-num);
            }
            else{
                System.Console.WriteLine(num);
            }
        }
    }
}