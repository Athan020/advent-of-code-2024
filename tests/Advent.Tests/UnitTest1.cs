namespace Advent.Tests;

using Advent2024.Day1;
using Advent2024;
using FluentAssertions;

public class UnitTest1
{
    [Fact]
    public void The_Sum_Of_The_Sample_Input_Should_Equal_11()
    {

        var totalDistance = Solution.SolveDay1Part1("../../../SampleInput.txt");

        totalDistance.Should().Be(11);
    }

    [Fact]
    public void The_Similarity_Of_The_Input_Should_Equal_31()
    {
        var similarity = Solution.SolveDay1Part2("../../../SampleInput.txt");

        similarity.Should().Be(31);
    }
}
