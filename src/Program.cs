using DesignPatterns._01___Creational._1._1___Abstract_Factory.Example_1;

class Program
{
    private static void Main()
    {
        Console.WriteLine("Choose Operation:");
        Console.WriteLine("------------------------");
        Console.WriteLine("Creational Patterns");
        Console.WriteLine("------------------------");
        Console.WriteLine("1 - Abstract Factory");
    

        var opcao = Console.ReadKey();

        Console.WriteLine("");
        Console.WriteLine("------------------------");
        Console.WriteLine("");

        switch (opcao.KeyChar)
        {
            case '1':
                ExecuteAbstractFactory.Execute();
                break;
           
        }

        Console.ReadKey();
        Console.Clear();
        Main();
    }
}