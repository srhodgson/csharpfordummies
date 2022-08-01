using System;

/**
 * PassObject
 * Demonstrate how to pass an object to a method
 */

namespace PassObject 
{
    public class Student 
    {
        public string name;
    }

    public class Program 
    {
        public static void Main(string[] args)
        {
            Student student = new Student();

            // Set the name by accessing it directly 
            Console.WriteLine("The first time: ");
            student.name = "Stephen";
            OutputName(student);

            // Change the name using a method 
            Console.WriteLine("After being modified: ");
            SetName(student, "Robert");
            OutputName(student);

            // Wait for user to acknowledge 
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }

        // OutputName -- Output the student's name 
        public static void OutputName(Student student)
        {
            // Output the current student's name.
            Console.WriteLine("student's name is {0}", student.name);
        }

        // SetName -- Modify the student object's name 
        public static void SetName(Student student, string name)
        {
            student.name = name;
        }
    }
}