using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1_ClassStudent
{
    public class MainStudent
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Sara", "Mills", 23, "898765446678", "0878/678543", "smills0@marketwatch.com",
                new List<int>() { 4, 5, 6 }, 2));
            students.Add(new Student("Daniel", "Carter", 33, "8989987446678", "0897/693563", "dcarter1@buzzfeed.com",
                new List<int>() {6, 5, 6}, 3));
            students.Add(new Student("Aaron", "Gibson", 18, "678765446678", "0843/178543", "agibson2@house.gov",
                new List<int>() {2, 5, 3}, 2));
            students.Add(new Student("William", "Alexander", 21, "238765446678", "0888/123456", "walexander3@hexun.com",
                new List<int>() {5, 5, 5}, 1));
            students.Add(new Student("Cheryl", "Gray", 41, "768965446678", "0877/653546", "cgray6@yahoo.com",
                new List<int>() {4, 5, 6}, 2));
            students.Add(new Student("Richard", "Edwards", 28, "098765446678", "0898567432", "redwardsb@uiuc.edu",
                new List<int>() {6, 6, 6}, 3));


            //Problem 1.Students by Group
            var subset = students
                .Where(student => student.GroupNumber == 2)
                .OrderBy(student => student.FirstName);

            foreach (Student student in subset)
            {
                Console.WriteLine(student);
            }

        

        }
    }
}
