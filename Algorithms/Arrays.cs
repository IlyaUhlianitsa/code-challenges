namespace Algorithms;

public static class Arrays
{
    // https://leetcode.com/problems/find-pivot-index/?envType=study-plan&id=level-1
    public static int PivotIndex(int[] nums)
    {
        var sum = 0;
        foreach (var n in nums)
            sum += n;

        var leftsum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (sum - nums[i] - leftsum == leftsum)
                return i;

            leftsum += nums[i];
        }

        return -1;
    }

    /// <summary>
    ///     Looking for an index of item in an array
    /// </summary>
    /// <param name="nums">array of items</param>
    /// <param name="item">search item</param>
    public static int? BinarySearch(int[] nums, int item)
    {
        var low = 0;
        var high = nums.Length - 1;
        while (low < high)
        {
            var middle = (high + low) / 2;
            var guess = nums[middle];
            if (guess == item)
                return middle;
            if (guess < item)
                low = middle + 1;
            if (guess > item)
                high = middle - 1;
        }

        return null;
    }

    /// <summary>
    ///     Sort an array with Selection Sort. O(n^2)
    /// </summary>
    /// <param name="nums">array of items</param>
    public static int[] SelectionSort(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var smallestIndex = i;
            for (var j = i + 1; j < nums.Length; j++)
                if (nums[j] < nums[smallestIndex])
                    smallestIndex = j;

            (nums[i], nums[smallestIndex]) = (nums[smallestIndex], nums[i]);
        }

        return nums;
    }
    
    /// <summary>
    /// Реализовать функцию FilterLast которая возвращает все элементы исходной последовательности без последних N элементов.
    /// Исходную последовательность нельзя перечислять более одного раза и хранить целиком в памяти.
    /// Обратите внимание, что длина входящей последовательности заранее не известна
    /// (т.е. обращение source.Count() вызывает перечисление элементов последовательности)
    /// Реализуйте поточный однопроходный алгоритм
    /// Число n сильно меньше длины последовательности
    /// Можно использовать дополнительная память для хранения небольшого числа элементов
    /// </summary>
    public static IEnumerable<T> FilterLast<T>(IEnumerable<T> source, int n)
    {
        var queue = new Queue<T>(n);
        var enumerator = source.GetEnumerator();
        while (enumerator.MoveNext())
        {
            queue.Enqueue(enumerator.Current);

            if (queue.Count == n + 1)
                yield return queue.Dequeue();
        }
    }
}