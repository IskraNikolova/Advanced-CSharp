using System.Collections.Generic;

namespace Problem1_ClassStudent
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, int age, string facultyNumber, 
            string phone, string email, IList<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks{ get; set; }
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            string marks = string.Join(",", this.Marks);
            return $"{this.FirstName, 7:0} {this.LastName, 8} | {this.Age} |{this.FacultyNumber} |{this.Phone} " +
                   $"|{this.email} {marks} |{this.GroupNumber}";
        }
    }
    
}
