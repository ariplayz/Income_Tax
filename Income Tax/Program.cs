namespace Income_Tax;

class Program
{
    static void Main(string[] args)
    {
        int income;
        int charity;
        
        Console.WriteLine("How much income did you make?");
        income = int.Parse(Console.ReadLine());
        Console.WriteLine("How much did you donate to charity?");
        charity = int.Parse(Console.ReadLine());
        
    }
}