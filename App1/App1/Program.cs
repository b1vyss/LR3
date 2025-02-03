using System.Linq.Expressions;

class Program
{
    static double A, B;
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Ввод A");
            Console.WriteLine("2. Ввод Б");
            Console.WriteLine("3. Сложить");
            Console.WriteLine("4. Вычесть");

            string operations = Console.ReadLine();

            switch (operations) {
                case "1":
                    {
                        A = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                case "2": 
                    {
                        B = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
            }
        }
    }
}