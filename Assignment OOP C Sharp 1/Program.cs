namespace OOP1
{
    #region 01 Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WeekDays Members:");
            foreach (var day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
        }
    }
    #endregion


    #region 02 Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons (spring March to May, summer June to August, autumn September to November, winter December to February).
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    class Program02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();
            Season season;
            if (Enum.TryParse(input, true, out season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season entered.");
            }
        }
    }
    #endregion


    #region 03 Assign the following Permissions (Read, Write, Delete, Execute) in a form of Enum. Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable.
    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    class Program03
    {
        static void Main(string[] args)
        {
            Permissions myPermissions = Permissions.Read | Permissions.Write;

            Console.WriteLine("Initial Permissions: " + myPermissions);

            // Add Delete Permission
            myPermissions |= Permissions.Delete;
            Console.WriteLine("After adding Delete: " + myPermissions);

            // Remove Write Permission
            myPermissions &= ~Permissions.Write;
            Console.WriteLine("After removing Write: " + myPermissions);

            // Check if Execute Permission is assigned
            bool hasExecute = (myPermissions & Permissions.Execute) == Permissions.Execute;
            Console.WriteLine("Has Execute Permission: " + hasExecute);
        }
    }
    #endregion


    #region 04 Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
    enum Colors
    {
        Red,
        Green,
        Blue
    }

    class Program04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a color:");
            string input = Console.ReadLine();
            Colors color;
            if (Enum.TryParse(input, true, out color))
            {
                switch (color)
                {
                    case Colors.Red:
                    case Colors.Green:
                    case Colors.Blue:
                        Console.WriteLine(input + " is a primary color.");
                        break;
                    default:
                        Console.WriteLine(input + " is not a primary color.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid color entered.");
            }
        }
    }
    #endregion



    #region 05 Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        // Constructor to initialize point coordinates
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Method to calculate the distance to another point
        public double DistanceTo(Point OtherPoint)
        {
            double dx = X - OtherPoint.X;
            double dy = Y - OtherPoint.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }

    class Program05
    {
        static void Main(string[] args)
        {
            // Input coordinates for the first point
            Console.WriteLine("Enter the coordinates of the first point (x y):");
            string[] point1Input = Console.ReadLine().Split();
            Point point1 = new Point(double.Parse(point1Input[0]), double.Parse(point1Input[1]));

            // Input coordinates for the second point
            Console.WriteLine("Enter the coordinates of the second point (x y):");
            string[] point2Input = Console.ReadLine().Split();
            Point point2 = new Point(double.Parse(point2Input[0]), double.Parse(point2Input[1]));

            // Calculate and display the distance between the two points
            double distance = point1.DistanceTo(point2);
            Console.WriteLine("Distance between the points: " + distance);
        }
    }
    #endregion














}