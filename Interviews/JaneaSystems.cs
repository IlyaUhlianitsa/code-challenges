namespace Interviews;

public class JaneaSystems : IChallenge
{
    public void Execute()
    {
        cosine_similarity(new List<int> { 736565921, 2014363605 },
            new List<double> { 871.250834721723, 693.657922881496 },
            new List<int> { 736565921, 2014363605 }, new List<double> { 160.05272192883, 758.489622156364 });
    }

    // task
    private double cosine_similarity(List<int> a_keys, List<double> a_values, List<int> b_keys, List<double> b_values)
    {
        var keys = a_keys.Union(b_keys);
        var dot = 0d;
        var mag1 = 0d;
        var mag2 = 0d;

        foreach (var i in keys)
        {
            var a = get_value_by_index(i, a_keys, a_values);
            var b = get_value_by_index(i, b_keys, b_values);

            dot += a * b;
            mag1 += Math.Pow(a, 2);
            mag2 += Math.Pow(b, 2);
        }

        return dot / (Math.Sqrt(mag1) * Math.Sqrt(mag2));
    }

    private double get_value_by_index(int i, List<int> keys, List<double> values)
    {
        var index = keys.IndexOf(i);
        return index < 0 ? 0 : values[index];
    }
}