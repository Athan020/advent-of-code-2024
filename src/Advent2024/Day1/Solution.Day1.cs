
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Advent2024.Day1;

public partial class Solution
{


    public static int SolveDay1Part1(string FilePath)
    {

        using var fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);

        using var sr = new StreamReader(fs);

        string? currentLine = string.Empty;

        List<int> left = new(), right = new();


        while ((currentLine = sr.ReadLine()) != null)
        {
            string[] nums = Regex.Split(currentLine, "\\s+");

            left.Add(int.Parse(nums[0]));
            right.Add(int.Parse(nums[1]));
        }

        left.Sort();
        right.Sort();

        var totalDistance = Enumerable.Zip(left, right, (l, r) => Math.Abs(l - r))
                            .Sum();

        return totalDistance;
    }

    public static int SolveDay1Part2(string FilePath)
    {

        using var fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);

        using var sr = new StreamReader(fs);

        string? currentLine = string.Empty;

        List<int> left = new(), right = new();


        while ((currentLine = sr.ReadLine()) != null)
        {
            string[] nums = Regex.Split(currentLine, "\\s+");

            left.Add(int.Parse(nums[0]));
            right.Add(int.Parse(nums[1]));
        }

        Dictionary<int, int> rightCounter = new();

        for (int i = 0; i < right.Count; i++)
        {
            if (!rightCounter.ContainsKey(right[i]))
            {
                rightCounter[right[i]] = 1;
            }
            else
            {
                rightCounter[right[i]]++;
            }
        }

        // var similarity = Enumerable.Zip(left, right,
        //                    (l, r) => l * (rightCounter.TryGetValue(l, out var count) ? count : 0))
        //                    .Sum();


        var totalSimilarity = left
        .Select(l => l * (rightCounter.TryGetValue(l, out int count) ? count : 0))
        .Sum();


        return totalSimilarity;
    }

}