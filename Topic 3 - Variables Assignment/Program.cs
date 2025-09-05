namespace Topic_3___Variables_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomNumber;
            double coursePrice;
            string courseName;

            roomNumber = 29;
            coursePrice = 2.99;
            courseName = "Computer Science";

            Console.WriteLine("This is room #" + roomNumber);
            Console.WriteLine("The price is " + coursePrice .ToString("C"));
            Console.WriteLine("I'm learning a bit of " + courseName);
        }
    }
}
