namespace LinqExercise
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

    public class LinqExercise
    {
        public static void Main()
        {
            const string FilePath = @"../../Students-data.txt";

            List<Student> students = new List<Student>();

            using (var reader = new StreamReader(FilePath))
            {
                int lineCount = 0;
                string data = reader.ReadLine();
                while (data != null)
                {
                    if (lineCount > 1)
                    {
                        string[] tokens = data.Split();
                        int id = int.Parse(tokens[0]);
                        string firstName = tokens[1];
                        string lastName = tokens[2];
                        string email = tokens[3];
                        string gender = tokens[4];
                        string studentType = tokens[5];
                        int examResult = int.Parse(tokens[6]);
                        int homeworksSent = int.Parse(tokens[7]);
                        int homeworksEvaluated = int.Parse(tokens[8]);
                        double teamworkScore = double.Parse(tokens[9]);
                        int attendancesCount = int.Parse(tokens[10]);
                        double bonus = double.Parse(tokens[11]);

                        students.Add(new Student(
                            id,
                            firstName,
                            lastName,
                            email,
                            gender,
                            studentType,
                            examResult,
                            homeworksSent,
                            homeworksEvaluated,
                            teamworkScore,
                            attendancesCount,
                            bonus));
                    }

                    lineCount++;
                    data = reader.ReadLine();
                }
            }

            var maleStudents = students.Where(st => st.Gender == "Male");
            foreach (var student in maleStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} - {student.Gender}");
            }

            /////////////////////////////////////////
            var studentA = students.Where(st => st.FirstName.StartsWith("A"));
            foreach (var student in studentA)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            /////////////////////////////////////////
            var onlineStudent = students.Where(st => st.StudentType == "Online" && st.ExamResult > 350)
                .OrderByDescending(st => st.ExamResult);
            foreach (var student in onlineStudent)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} ({student.StudentType}) - {student.ExamResult}");
            }

            ////////////////////////////////////////
            var studentWithoutHomework =
                students.Where(st => st.HomeworksSent < 1)
                .OrderBy(st => st.FirstName)
                .ThenBy(st => st.LastName);

            foreach (var student in studentWithoutHomework)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} ({student.HomeworksSent} homeworks sent)");
            }

            ////////////////////////////////////////
            var studentEmail = students.Where(st => st.StudentType == "Onsite")
                .Select(st => st.Email);

            foreach (var email in studentEmail)
            {
                Console.WriteLine(email);
            }

            /////////////////////////////////////////
            var attendancesLessFive = students
                .Where(st => st.AttendancesCount < 5);

            foreach (var student in attendancesLessFive)
            {
                Console.WriteLine($"Result: {student.ExamResult}, attendances: {student.AttendancesCount}");
            }

            /////////////////////////////////////////////
            var studentWithBonus = students.Where(st => st.Bonus >= 4);

            foreach (var student in studentWithBonus)
            {
                Console.WriteLine(student.Id);
            }

            //////////////////////////////////////////
            var averageExamResultOnSite = students
                .Where(st => st.StudentType == "Onsite")
                .Average(st => st.ExamResult);

            var averageExamResultOnLine = students
                .Where(st => st.StudentType == "Online")
                .Average(st => st.ExamResult);

            Console.WriteLine(averageExamResultOnSite);
            Console.WriteLine(averageExamResultOnLine);

            /////////////////////////////////////////////////////////
            var maxTeamWorkScore = students.Select(st => st.TeamworkScore);
            var idWithMax = maxTeamWorkScore.Max();
            var studentWithMax = students.Where(st => st.TeamworkScore == idWithMax)
                .Select(st => st.Id);

            foreach (var st in studentWithMax)
            {
                Console.WriteLine(st);
            }

            /////////////////////////////////////////////////////////
            var groupStudents = students
                .GroupBy(st => st.FirstName[0])
                .OrderBy(st => st.Key);

            foreach (var st in groupStudents)
            {
                Console.WriteLine(st.Key);
                foreach (var student in st)
                {
                    Console.WriteLine(student.FirstName);
                }
            }

            ///////////////////////////////////////////////////////
            var groupForType = students
            .GroupBy(st => st.StudentType);

            foreach (var type in groupForType)
            {
                Console.WriteLine(type.Key);
                foreach (var student in type.OrderByDescending(st => st.ExamResult))
                {
                    Console.WriteLine($"{student.FirstName} {student.ExamResult} - {student.StudentType}");
                }
            }
        }
    }
}

