﻿using System.Collections.Generic;

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
        private string groupName;

        public Student(string firstName, string lastName, int age, string facultyNumber, 
            string phone, string email, IList<int> marks, int groupNumber,string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks{ get; set; }
        public int GroupNumber { get; set; }
        public string GroupName { get; set; }

        public override string ToString()
        {
            string marks = string.Join(",", this.Marks);
            return $"{this.FirstName, 7:0} {this.LastName, 8} | {this.Age,3} |{this.FacultyNumber,-3} |{this.Phone, -10} " +
                   $"|{this.Email, 7:0}| {marks, 3} |{this.GroupNumber}| {this.GroupName}";
        }
    }
    
}
