internal class Program
{
    private static void Main(string[] args)
    {
        // Verilen ededin faktorialini tap.
        int number;
        Console.WriteLine("Ededi daxil edin");
        number=Convert.ToInt32(Console.ReadLine());
        int faktorial=1;
        for(int i=1;i<=number;i++){
            faktorial*=i;
           // i++;
        }      
        System.Console.WriteLine("Girilen ededin faktorial: "+faktorial);
}
}