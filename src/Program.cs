using DesignPatterns._01___Creational._1._1___Abstract_Factory.Example_1;
using DesignPatterns._01___Creational._1._2___Factory_Method.Example_1;
using DesignPatterns._01___Creational._1._3___Singleton.Example_1;

class Program
{
    private static void Main()
    {
        Console.WriteLine("Choose Operation:");
        Console.WriteLine("------------------------");
        Console.WriteLine("Creational Patterns");
        Console.WriteLine("------------------------");
        Console.WriteLine("1 - Abstract Factory");
        Console.WriteLine("2 - Method Factory");
        Console.WriteLine("3 - Singleton");
        Console.WriteLine("------------------------");



        var opcao = Console.ReadKey();

        Console.WriteLine("");
        Console.WriteLine("------------------------");
        Console.WriteLine("");

        switch (opcao.KeyChar)
        {
            case '1':
                InitAbstractFactory.Execute();
                break;
            case '2':
                InitFactoryMethod.Executar();
                break;
            case '3':
                InitSingleton.Executar();
                break;

        }

        Console.ReadKey();
        Console.Clear();
        Main();
    }
}