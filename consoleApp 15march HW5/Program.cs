internal class Program
{
    private static void Main(string[] args)
    {
       //Fibonacci ardicilligi:
       int a=0;
       int b=1;
       int c;
       for(int i=0;i<10;i++){
        c=a+b;
        a=b;
        b=c;
       
        System.Console.WriteLine(c);
       }
    }
}