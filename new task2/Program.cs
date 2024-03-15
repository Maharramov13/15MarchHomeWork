internal class Program
{
    private static void Main(string[] args)
    {
           // string sentence="   Garage  Academy    ";
            System.Console.WriteLine(Word("    Garage Academy    "));
            

    }
    static string Word(string a){

    
    
    int left=0;
    int right=0;

    string result="";

    for(int i=0;i<a.Length;i++)
    {
        if(a[i]==' '){
            left++;

            if(a[i+1]!=' '){
                break;
            }
        }
    }
    for (int i = a.Length-1; i >=0; i--)
    {
        if (a[i]==' ')
        {
            right++;
            if(a[i-1]!=' ')
            {
                break;
            }
            
        }
    }
    for (int i = left; i <a.Length-right; i++)
    {
        result+=a[i];
    }

    return result;
}
}