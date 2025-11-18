using System;

namespace ConsoleApp1
{
    internal class Student
    {
        public string FullName;
        public int StudentAge;
        public string StudentNumber;

        public static int StudentCount = 0;

        public Student(string fullName, int age, string studentNumber)
        {
            FullName = fullName;
            StudentAge = age;
            StudentNumber = studentNumber;

            StudentCount++;
        }
    }
}
