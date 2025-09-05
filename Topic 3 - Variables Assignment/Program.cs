namespace Topic_3___Variables_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomNumber, graduationYear, cicleRadius;
            double coursePrice, pi;
            string courseName, firstName, lastName;

            roomNumber = 29;
            coursePrice = 2.99;
            courseName = "Computer Science";
            firstName = "Alex";
            lastName = "Ronan";
            graduationYear = 2027;
            cicleRadius = 15; //cm
            pi = 3.14159;

            //This diplays the course information
            Console.WriteLine("This is room #" + roomNumber);
            Console.WriteLine("The price is " + coursePrice.ToString("C"));
            Console.WriteLine("I'm learning a bit of " + courseName);

            //This displays the student information
            Console.WriteLine("My name is " + firstName + " " + lastName + ", and I'll graduate in " + graduationYear);

            //This finds the area of a circle
            Console.WriteLine("The area of your circle is: " + (pi * Math.Pow(cicleRadius, 2)) .ToString("0.0"));

            //Do pythagorean theorem or something
        }
    }
}
