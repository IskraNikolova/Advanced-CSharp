using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace Problem1_ClassStudent
{
    public class MainStudent
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Sara", "Mills", 23, "898714446678", "02/678543", "smills0@marketwatch.com",
                new List<int>() { 4, 5 }, 2, "OtherGroupName"));
            students.Add(new Student("Daniel", "Carter", 33, "8989147446678", "0897/693563", "dcarter1@abv.bg",
                new List<int>() {6, 5, 6}, 3, "FirstGroupName"));
            students.Add(new Student("Aaron", "Aaren", 18, "678712446678", "+3592/178543", "agibson2@house.gov",
                new List<int>() {2, 5, 3}, 2, "SecondGroupName"));
            students.Add(new Student("William", "Gitar", 21, "238711446678", "0888/123456", "walexander3@hexun.com",
                new List<int>() {5, 5}, 1, "FirstGroupName"));
            students.Add(new Student("Cheryl", "Gray", 41, "768914446678", "0877/653546", "cgray6@abv.bg",
                new List<int>() {4, 5, 6}, 2, "SecondGroupName"));
            students.Add(new Student("Cheryl", "Abc", 41, "768910446678", "+359 2/653546", "cgray6@yahoo.com",
         new List<int>() { 4, 5, 4 }, 2, "OtherGroupName"));
            students.Add(new Student("Richard", "Edwards", 28, "098714446678", "0898567432", "redwardsb@uiuc.edu",
                new List<int>() {6, 6, 6}, 3, "OtherGroupName"));
            students.Add(new Student("Richard", "Moon", 28, "098712446678", "0898567432", "redwardsb@uiuc.edu",
             new List<int>() { 6, 6, 6 }, 3, "FirstGroupName"));

            //Problem 2.Students by Group
            Console.WriteLine();
            Console.WriteLine("Students from group number 2. .");
            Console.WriteLine("-----------------------------------------------------------------------");
            var subset = students
                .Where(student => student.GroupNumber == 2)
                .OrderBy(student => student.FirstName);

            foreach (Student student in subset)
            {
                Console.WriteLine(student);
            }

            //Problem 3.Students by Group
            Console.WriteLine();
            Console.WriteLine("Students whose first name is before their last name alphabetically.");
            Console.WriteLine("-----------------------------------------------------------------------");
            var subset2 = students
                .Where(student => student.FirstName[0] > student.LastName[0]);

            foreach (Student student in subset2)
            {
                Console.WriteLine(student);
            }

            //Problem 4.Students by Age
            Console.WriteLine();
            Console.WriteLine("Students with age between 18 and 24.");
            Console.WriteLine("-----------------------------------------------------------------------");
            var subset3 = students
                .Where(student => student.Age >= 18 && student.Age <= 24);
       
            foreach (Student student in subset3)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} - {student.Age}");
            }

            //Problem 5.Sort Students
            Console.WriteLine();
            Console.WriteLine("Sort the students by first name and last name in descending order.");
            Console.WriteLine("-----------------------------------------------------------------------");

            var subset4 = students
                .OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName);

            foreach (Student student in subset4)
            {
                Console.WriteLine(student);
            }

            //Problem 6.Filter Students by Email Domain
            Console.WriteLine();
            Console.WriteLine("Students that have email @abv.bg. ");
            Console.WriteLine("-----------------------------------------------------------------------");

            var subset5 = students
                .Where(student => student.Email.Contains("@abv.bg"));

            foreach (Student student in subset5)
            {
                Console.WriteLine(student);
            }

            //Problem 7.Filter Students by Phone
            Console.WriteLine();
            Console.WriteLine("Students with phones in Sofia (starting with 02 / +3592 / +359 2). ");
            Console.WriteLine("-----------------------------------------------------------------------");
            var subset6 = students
                 .Where(student => student.Phone.Contains("02") || student.Phone.Contains("+3592") || student.Phone.Contains("+359 2"));

            foreach (Student student in subset6)
            {
                Console.WriteLine(student);
            }

            //Problem 8.Excellent Students
            Console.WriteLine();
            Console.WriteLine("Students that have at least one mark Excellent (6) ");
            Console.WriteLine("-----------------------------------------------------------------------");
            var subset7 = students
                 .Where(student => student.Marks.Contains(6));
            
            foreach (Student student in subset7)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {string.Join(", ", student.Marks)}");
            }

            //Problem 9.Weak Students
            Console.WriteLine();
            Console.WriteLine("Students with exactly two marks \"2\" ");
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (Student student in students)
            {
                bool isTwoMarks = student.IsHasTwoMarks();
                if (isTwoMarks)
                {
                    Console.WriteLine(student);
                }
            }

            //Problem 10.Students Enrolled in 2014
            Console.WriteLine();
            Console.WriteLine("Students enrolled in 2014");
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (Student student in students)
            {
                bool isThisYear = student.IsEnrolled();
                if (isThisYear)
                {
                    Console.WriteLine("{0} {1}: {2}",student.FirstName, student.LastName, string.Join(", ", student.Marks));
                }
            }

            //Problem 11.* Students by Groups
            Console.WriteLine();
            Console.WriteLine("Students grouped by GroupName");
            Console.WriteLine("-----------------------------------------------------------------------");
            var studentGroup = from student in students
                group student by student.GroupName;
            
          

            foreach (Student stud in studentGroup)
            {
                Console.WriteLine(stud);
            }
        }
    }
}
