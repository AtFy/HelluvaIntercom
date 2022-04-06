using System.Diagnostics;
using System.Threading;


namespace HelluvaIntercom.Extensions
{
    static class Extensions
    {
        public static void Sleep(this Stopwatch stopwatch, int delay)
        {
            stopwatch = Stopwatch.StartNew();
            while (true)
            {
                if (stopwatch.ElapsedMilliseconds >= delay)
                {
                    break;
                }
                Thread.Sleep(1);
            }
        }
    }
}
