namespace Interviews;

public class Stenn : IChallenge
{
    public void Execute()
    {
        // Task1();
        // Task2();
        // Task3();
        // Task4();
        // Task5();
    }

    public void Task1()
    {
        var a = 5;
        object o = a;
        var x = (long)o;
        Console.Write(x.GetType().Name);
        // Invalid Cast Exception
        Console.ReadLine();
    }

    public void Task2()
    {
        var str = "123";
        var newStr = str;
        Console.WriteLine(ReferenceEquals(str, newStr));
        str = newStr + "345";
        Console.Write(newStr);
        // 123, because str links to the new object in heap
        Console.WriteLine();
    }

    public void Task3()
    {
        var count = 0;
        Enumerable.Repeat(1, 100)
            .Where(_ => count < 50)
            .Select(x => count++);

        Console.Write(count);
        // 0, because there is no materialization
        Console.WriteLine();
    }

    public void Task4()
    {
        const int iterations = 1000000000;
        var count = 0;
        Parallel.For(0, iterations, _ => count++);
        Console.WriteLine($"{count > iterations}, {count < iterations}");
        // False, True
    }

    public void Task5()
    {
        var actions = new List<Action>();
        for (var count = 0; count < 5; count++) actions.Add(() => Console.Write(count + " "));

        foreach (var action in actions) action();
        // 5 5 5 5 5, because Closure
    }
}