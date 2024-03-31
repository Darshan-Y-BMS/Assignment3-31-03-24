using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SiemensProject1
{

//Exercise 1:  Interface and Implementation
//Create an interface called Shape with the following methods:
//double getArea(); double getPerimeter();
//Now, implement the Shape interface with two classes: Circle and Rectangle.
//Ensure that both classes provide the necessary implementations for the
//methods in the Shape interface.

//Exercise 3: Interface Inheritance
//Create an interface called Drawable with a method draw(). Now, modify the Shape interface
//from Exercise 1 to extend the Drawable interface. Ensure that the implementing classes(Circle and Rectangle)
//provide implementations for both interfaces.

//Exercise 2: Abstract Class and Inheritance
//Create an abstract class called Vehicle with the following properties and methods:
//Now, create two classes Car and Motorcycle that extend the Vehicle abstract class.
//Provide the necessary implementations for the abstract methods start() and stop() in both classes.

//Exercise 4: Abstract Class with Interface
//Extend the Vehicle abstract class from Exercise 2 to implement the Drawable interface from Exercise 3.
//Provide an implementation for the draw() method in the Car and Motorcycle classes.

//Exercise 5: Use Cases
//Create a program that demonstrates the use of the classes and interfaces you've created.
//Instantiate objects of Circle, Rectangle, Car, and Motorcycle, and invoke various methods
//to display information, calculate area, perimeter, and draw the objects.

    internal class Program
    {
        C:\Users\Darshan\source\repos\SiemensProject1\SiemensProject1\SiemensProject1.csproj
        public void Exercise1()
        {
            IShape c = new Circle(3);
            Rectangle r = new Rectangle(3, 4);

            Console.WriteLine("\nCircle");
            c.getDetails();
            Console.WriteLine("Area of the circle is             : " + c.getArea().ToString("f2") + " squnits");
            Console.WriteLine("Perimeter of the circle is        : " + c.getPerimeter().ToString("f2") + " squnits");

            Console.WriteLine("\n\nRactangle");
            r.getDetails();
            Console.WriteLine("Area of the ractangle is          : " + r.getArea().ToString("f2") + " squnits");
            Console.WriteLine("Perimeter of the reactangle is    : " + r.getPerimeter().ToString("f2") + " squnits");
        }
        public void Exercise2()
        {
            MotorCycle m = new MotorCycle("Nexus", "2023");
            Car c = new Car("TATA", "2003");
            Console.WriteLine("\nMotor Cycle");
            m.start();
            m.stop();
            Console.WriteLine("\n\nCar");
            c.start();
            c.stop();
            Console.WriteLine();
        }
        public void Exercise3()
        {
            Circle c = new Circle(3);

            Rectangle r = new Rectangle(3, 4);

            Console.WriteLine("\nCircle");
            c.getDetails();
            Console.WriteLine("Area of the circle is             : " + c.getArea().ToString("f2") + " squnits");
            Console.WriteLine("Perimeter of the circle is        : " + c.getPerimeter().ToString("f2") + " squnits");
            c.draw();
            Console.WriteLine();
            Console.WriteLine("\n\nRactangle");
            r.getDetails();
            Console.WriteLine("Area of the ractangle is          : " + r.getArea().ToString("f2") + " squnits");
            Console.WriteLine("Perimeter of the reactangle is    : " + r.getPerimeter().ToString("f2") + " squnits");
            r.draw();
        }

        //Exercise 6: Sum and Average
        //Write a C# program to calculate the sum and average of elements in an integer array.
        public int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public float Average(int[] arr)
        {
            float a = Sum(arr);
            return (a / arr.Length);
        }
        //Write a C# program to find the maximum and minimum values in an array of integers.
        public int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            return max;
        }
        public int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            return min;
        }
        //Exercise 8: Reverse an Array
        //Write a C# function to reverse the elements of an array in-place.
        //Do this both with and without using additional space.
        void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        int[] ReverseWithoutSpace(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = temp;
            }
            return arr;
        }
        int[] ReverseWithSpace(int[] arr)
        {
            int[] rev = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                rev[i] = arr[arr.Length - 1 - i];
            }
            return rev;
        }

        //Exercise 9: Remove Duplicates
        //Write a C# function to remove duplicate elements from an array.
        int[] RemoveDuplicates(int[] arr)
        {
            int[] temp = new int[arr.Length];
            int ptr = 1;
            int flag = 0;
            temp[0] = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                flag = 0;

                for (int j = 0; j < ptr; j++)
                {
                    if (arr[i] == temp[j])
                    {
                        flag = 1; break;
                    }
                }
                if (flag == 0)
                {
                    temp[ptr++] = arr[i];
                }
            }

            int[] temp2 = new int[ptr];
            for (int i = 0; i < ptr; i++)
            {
                temp2[i] = temp[i];
            }

            return temp2;
        }


        static void Main(string[] args)
        {
            int[] array = { 7, 8, 2, 9, 0, 8, 7, 5 }; // array for testing 
            Program p = new Program();

            // HOW TO RUN  !! 
            //uncomment the part of code to run the exercise 1 , 2 , 3...

            // p.Exercise1();

            //p.Exercise2();

            //p.Exercise3();

            //Console.WriteLine("The sum of the array is          : "+p.Sum(array));
            //Console.WriteLine("The Average of array is          : " + p.Average(array));
            //Console.WriteLine("The Maximum value of array is    : " + p.Max(array));
            //Console.WriteLine("The Minimum value of array is    : " + p.Min(array));
            //Console.Write("The elements of array before reverse  : ");
            //p.PrintArray(array);


            //array = p.ReverseWithoutSpace(array);
            
            //array = p.ReverseWithSpace(array)

            //Console.Write("The elements of array after reverse   : ");
            //p.PrintArray (array);
            //array = p.RemoveDuplicates(array);
            //p.PrintArray(array);    
        }
    }
}

