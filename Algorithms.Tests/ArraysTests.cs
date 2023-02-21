using FluentAssertions;
using NUnit.Framework;

namespace Algorithms.Tests;

[TestFixture]
public class ArraysTests
{
    [TestCase(new[] { 1, 7, 3, 6, 5, 6 }, 3)]
    [TestCase(new[] { 1, 2, 3 }, -1)]
    [TestCase(new[] { 2, 1, -1 }, 0)]
    public void PivotIndex_Tests(int[] nums, int result)
    {
        Arrays.PivotIndex(nums).Should().Be(result);
    }

    [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, 3, 2)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, 5, 4)]
    [TestCase(new[] { 1, 2, 3 }, -1, null)]
    public void BinarySearch_Tests(int[] nums, int item, int? result)
    {
        Arrays.BinarySearch(nums, item).Should().Be(result);
    }

    [TestCase(new[] { 3, 7, 2, 9, 14, 1 }, new[] { 1, 2, 3, 7, 9, 14 })]
    public void SelectionSort_Tests(int[] nums, int[] result)
    {
        Arrays.SelectionSort(nums).Should().Equal(result);
    }
    
    [TestCase(new[] { 3, 7, 2, 9, 14, 1 }, 5, new[] { 3 })]
    [TestCase(new[] { 3, 7, 2, 9, 14, 1 }, 3, new[] { 3, 7, 2 })]
    [TestCase(new[] { 3, 7, 2, 9, 14, 1 }, 1, new[] { 3, 7, 2, 9, 14 })]
    public void FilterLast_Tests(int[] source, int n, int[] result)
    {
        Arrays.FilterLast(source, n).Should().Equal(result);
    }
}