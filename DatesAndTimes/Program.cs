//Console.WriteLine("Hello, OS");

namespace WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            /*
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.Day);
            Console.WriteLine(myValue.Hour);
            Console.WriteLine(myValue.DayOfWeek);
            Console.WriteLine(myValue.DayOfYear);
            Console.WriteLine(myValue.Month);
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());
            */

            //Console.WriteLine(myValue.AddDays(4).ToString());
            //Console.WriteLine(myValue.AddHours(4).ToString());
            //Console.WriteLine(myValue.AddDays(-4).ToString());

            DateTime myBirthday = DateTime.Parse("28/3/1994");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine("years: " + myAge.Days/365);
            Console.WriteLine("Days: " + myAge.TotalDays);
            Console.WriteLine("Days: " + myAge.Days);
            Console.WriteLine("Hours: " + myAge.Hours);
            Console.WriteLine("Minutes: " + myAge.Minutes);
            Console.WriteLine("Seconds: " + myAge.Seconds);
        }
    }
}