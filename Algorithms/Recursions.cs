namespace Algorithms;

public static class Recursions
{
    public static int Sum(int[] arr)
    {
        if (arr.Length == 1)
            return arr[0];
        
        return arr[0] + Sum(arr[1..]);
    }
}