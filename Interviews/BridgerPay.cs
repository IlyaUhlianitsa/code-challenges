namespace Interviews;

public class BridgerPay : IChallenge
{
    public void Execute()
    {
        Task6();
        // Task7();
        // Task8();
        // Task9();
        // Task10();
    }

    private void Task6()
    {
        Console.WriteLine(Math.Round(1.5));
        Console.WriteLine(Math.Round(2.5));

        Console.WriteLine(Math.Round(3.5));
        Console.WriteLine(Math.Round(4.5));
        // 2 and 2, because default behaviour is "round to even"
    }

    private void Task7()
    {
        string s = null;
        Console.WriteLine(s is string);
        // False
    }

    private void Task8()
    {
        var f = Sum(0.1f, 0.2f);
        var g = Sum(0.1f, 0.2f);

        Console.WriteLine(f == g);

        float Sum(float f1, float f2)
        {
            return f1 + f2;
        }
        // true or false. Because float numbers not strict
    }

    private void Task9()
    {
        var price = 4.99F;
        var quantity = 17;
        Console.WriteLine(price * quantity);
        // 84.829994
    }

    private void Task10()
    {
        var b1 = new b();
        var b2 = new b();
        Console.WriteLine();
    }

    public class a
    {
        public a()
        {
            Console.WriteLine("Constructor A");
        }
    }

    public class b : a
    {
        public b()
        {
            Console.WriteLine("Constructor B");
        }
    }
}