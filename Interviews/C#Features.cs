namespace Interviews;

public class CSharpFeatures : IChallenge
{
    public void Execute()
    {
        var p1 = new Person(56, "Adam");
        var p2 = new Person(56, "Adam");
        Console.WriteLine(p1 == p2);
        var p3 = p1 with { Age = 56 };
        Console.WriteLine(p1 == p3);
        var (age, name) = p3;
        Console.WriteLine(Person.Type);
        Console.WriteLine(age);
        Console.WriteLine(p3);
        Console.WriteLine(Day.Sunday);

        var s = p3 switch
        {
            { Age: var ages } => $"{ages}"
        };

        var result = (age, name) switch
        {
            (> 50, _) => "Hello"
        };

        var ag = Type.Age;
        var type = new Type();

        Console.WriteLine(s);
        Console.ReadLine();
    }

    private enum Day
    {
        Monday = 5,
        Tuesday,
        Wednesday,
        Thursday = 14,
        Friday = Tuesday,
        Saturday,
        Sunday
    }

    public record Person(int Age, string Name)
    {
        public const int Type = 5;
    }

    private class Type
    {
        public static readonly int Age = 55;

        static Type()
        {
        }
    }
}