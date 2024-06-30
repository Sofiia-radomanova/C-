using System; 
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the notebook price: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the pen price: ");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of notebooks: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of pens: ");
        int m = int.Parse(Console.ReadLine());

        double overall = x*n + y*m;

        Console.WriteLine("The total price of {0} notebooks and {1} pens is {2}", n, m, overall);


    }
}