namespace Algorithms;

public static class Recursions
{
    public static int Sum(int[] arr)
    {
        if (arr.Length == 1)
            return arr[0];
        
        return arr[0] + Sum(arr[1..]);
    }
    
    public static int Max(int[] arr)
    {
        var first = arr[0];
        if (arr.Length == 2)
            return first > arr[1] ? first : arr[1];

        var subMax = Max(arr[1..]);

        return first > subMax ? first : subMax;
    }
}