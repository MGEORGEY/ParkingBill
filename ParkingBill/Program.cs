namespace ParkingBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Solution("10:00", "13:21"));
            Console.WriteLine(Solution("09:42", "11:42"));
        }

        public static int Solution(string E, string L)
        {
            var entryTime = DateTime.Parse(E);

            var exitTime = DateTime.Parse(L);

            var firstHourAssumed = entryTime.AddHours(1);

            var hourTimeDifference = exitTime - firstHourAssumed;
            if (hourTimeDifference.Minutes > 0)
                hourTimeDifference = hourTimeDifference.Add(new TimeSpan(1, 0, 0));

            var total = 2 + 3 + (hourTimeDifference.Hours * 4);

            return total;
        }
    }
}
