using System.Linq;

namespace apbd-cw1-git-s29039
{
    public class StatisticsHelper
    {
        public static double CalculateAverage(int[] values)
        {
            if (values == null || values.Length == 0) return 0.0;
            return values.Average();
        }

    }
}