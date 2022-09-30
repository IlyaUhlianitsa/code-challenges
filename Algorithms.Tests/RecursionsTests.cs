using FluentAssertions;
using NUnit.Framework;

namespace Algorithms.Tests;

[TestFixture]
public class RecursionsTests
{
    [TestCase(new[] { 1, 7, 3, 6, 5, 6 }, 28)]
    [TestCase(new[] { 1, 2, 3 }, 6)]
    [TestCase(new[] { 2, 1, -1 }, 2)]
    public void Sum_Tests(int[] nums, int result)
    {
        Recursions.Sum(nums).Should().Be(result);
    }
    
    [TestCase(new[] { 1, 7, 3, 6, 5, 6 }, 7)]
    [TestCase(new[] { 1, 2, 3 }, 3)]
    [TestCase(new[] { 2, 1, -1 }, 2)]
    public void Max_Tests(int[] nums, int result)
    {
        Recursions.Max(nums).Should().Be(result);
    }
    
    [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, 3, 2)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, 5, 4)]
    [TestCase(new[] { 1, 2, 3 }, -1, null)]
    public void BinarySearch_Tests(int[] nums, int item, int? result)
    {
        Recursions.BinarySearch(nums, item).Should().Be(result);
    }
    
    [TestCase(new[] { 3, 7, 2, 9, 14, 1 }, new[] { 1, 2, 3, 7, 9, 14 })]
    public void QuickSort_Tests(int[] nums, int[] result)
    {
        Recursions.QuickSort(nums).Should().Equal(result);
    }
}