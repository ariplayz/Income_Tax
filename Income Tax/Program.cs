namespace Income_Tax;

class Program
{
    static void Main(string[] args)
    {
        double income;
        double charity;
        double ti;
        
        Console.WriteLine("How much income did you make?");
        income = double.Parse(Console.ReadLine());
        Console.WriteLine("How much did you donate to charity?");
        charity = double.Parse(Console.ReadLine());
        ti = income - charity;
        Console.WriteLine("Your taxable income is " + ti);
        
        double tax = CalculateTax(ti);
        Console.WriteLine("Your tax is " + tax);
    }
    static double CalculateTax(double ti)
    {
        double tax = 0;

        if (ti > 341200)
        {
            tax += (ti - 341200) * 0.35;
            ti = 341200;
        }
        if (ti > 170600)
        {
            tax += (ti - 170600) * 0.30;
            ti = 170600;
        }
        if (ti > 85300)
        {
            tax += (ti - 85300) * 0.25;
            ti = 85300;
        }
        if (ti > 37650)
        {
            tax += (ti - 37650) * 0.20;
            ti = 37650;
        }
        if (ti > 9275)
        {
            tax += (ti - 9275) * 0.15;
            ti = 9275;
        }
        tax += ti * 0.10;

        return tax;
    }  
}