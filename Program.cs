using System;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace ClassesCSharp
{
    // too many assignments coming up for all the classes, couldnt spend any longer working on this
    //------------------------------------------------- Task 1
    
    class Program
    {
        static void Main(string[] args)
        {
            Cookie c1 = new Cookie();
            c1.Weight = 5;
            

            Cookie c2 = new Cookie("Square", 7);

            Console.WriteLine(c1.Weight);
            Console.WriteLine(c2.Shape);
        }
    }
    class Cookie
    {
        //attributes
        public string Shape;
        public int Weight;

        //constructors
        public Cookie()
        {
            this.Shape = "";
            this.Weight = 0;
            red = 0;
            Colour.green = 0;
            Colour.blue = 0;
        }

        public Cookie(string shape, int weight)
        {
            this.Shape = shape;
            this.Weight = weight;
        }
        class Colour
        {
            //attributes
            public int red;
            public int green;
            public int blue;

            //operations
            public Colour()
            {
                this.red = 0;
                this.green = 0;
                this.blue = 0;
            }

            public Colour(int red, int green, int blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
            }
        }
    }
    
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.FirstName = "Dominic";
            p1.Surname = "Hudson";
            p1.DOB = 1993;
            p1.Height = 185;
            

            Person p2 = new Person();
            p2.FirstName = "Tom";
            p2.Surname = "Mottram";
            p2.DOB = 1990;
            p2.Height = 189;


            Person p3 = new Person();
            p3.FirstName = "Charlotte";
            p3.Surname = "Mardling";
            p3.DOB = 1992;
            p3.Height = 165;

            Console.WriteLine(GetFullName(p1.FirstName, p1.Surname));
            Console.WriteLine(GetHeightDifference(p1.Height, p2.Height, p1.GetFullName, p2.GetFullName));
            Console.WriteLine(GetHeightDifference(p1.Height, p3.Height, p1.GetFullName, p3.GetFullName));

            Console.WriteLine(GetFullName(p2.FirstName, p2.Surname));
            Console.WriteLine(GetHeightDifference(p2.Height, p1.Height, p2.GetFullName, p1.GetFullName));
            Console.WriteLine(GetHeightDifference(p2.Height, p3.Height, p2.GetFullName, p3.GetFullName));

            Console.WriteLine(GetFullName(p2.FirstName, p2.Surname));
            Console.WriteLine(GetHeightDifference(p3.Height, p1.Height, p3.GetFullName, p1.GetFullName));
            Console.WriteLine(GetHeightDifference(p3.Height, p2.Height, p3.GetFullName, p2.GetFullName));
        }
    };

    class Person
    {
        //attributes
        public string FirstName;
        public string Surname;
        public int DOB;
        public int Height;

        //constructors
        public Person()
        {
            string FirstName = "";
            string Surname = "";
            // tried using DateTime but couldnt get it to work, settled for int as just the year instead
            int DOB = 0000;
            int Height = 0;
        }

        public void GetFullName(string FirstName, string Surname)
        {
            string FullName = FirstName + " " + Surname;
            Console.WriteLine(FullName);
        }

        public int GetHeightDifference()
        {
            int[] heightArray = { };

            heightArray[0] = p1.Height;
            heightArray[1] = p2.Height;
            heightArray[2] = p3.Height;
            return        
        }
    }
    */
}
