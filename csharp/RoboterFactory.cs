using System;
using System.Linq;

public sealed class RoboterFactory
{
    public long CalculateScrap(int[] scraps, int numberOfRobots)
    {
        double totalWeight = numberOfRobots * 50;

        foreach (int scrap in scraps)
        {
            // for the scrap
            double d = (100 - scrap) / 100.0;
            totalWeight /= d;
        }

        // ceiling
        return (long)Math.Ceiling(totalWeight);
    }
}

