using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Tests;

[TestFixture]
public class ArrayTasksTests
{
    [TestCase(new[] { 1, 7, 3, 6, 5, 6 }, 3)]
    [TestCase(new[] { 1, 2, 3 }, -1)]
    [TestCase(new[] { 2, 1, -1 }, 0)]
    public void PivotIndex_Tests(int[] nums, int result)
    {
        ArrayTasks.PivotIndex(nums).Should().Be(result);
    }

    [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, 3, 2)]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, 5, 4)]
    [TestCase(new[] { 1, 2, 3 }, -1, null)]
    public void BinarySearch_Tests(int[] nums, int item, int? result)
    {
        ArrayTasks.BinarySearch(nums, item).Should().Be(result);
    }

    [TestCase(new[] { 3, 7, 2, 9, 14, 1 }, new[] { 1, 2, 3, 7, 9, 14 })]
    public void SelectionSort_Tests(int[] nums, int[] result)
    {
        ArrayTasks.SelectionSort(nums).Should().Equal(result);
    }
}