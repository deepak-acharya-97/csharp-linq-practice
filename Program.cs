using System;
using System.Collections.Generic;
using System.Linq;

namespace play_with_simple_linq_queries
{
    class Program
    {
        static void P(dynamic msg) => Console.WriteLine(msg);
        static void Main(string[] args)
        {
            float cutOff=35.88F;
            float[] scores = new float[] {56.25F,34.99F,35.001F,98.50F}; 

            IEnumerable<float> scoreQuery=from score in scores
                                            where score.CompareTo(cutOff).Equals(1)
                                            select score;

            // foreach(var score in scoreQuery)
            // {
            //     P(score);
            // }
            List<Student> students = new List<Student> 
            {
                new Student
                {
                    RollNumber="14IT167",
                    Name="Rocky Bhai",
                    Zone=Zone.Bengaluru,
                    CGPA=8.03F,
                    Department=Department.InformationTechnology,
                    StateQuota=StateQuota.HomeState
                },
                new Student
                {
                    RollNumber="14ME272",
                    Name="Varun Naidu",
                    Zone=Zone.Bengaluru,
                    CGPA=10F,
                    Department=Department.MechanicalEngineering,
                    StateQuota=StateQuota.HomeState
                },
                new Student
                {
                    RollNumber="14IT233",
                    Name="Rajesh Karunanidhi",
                    Zone=Zone.Other,
                    CGPA=8.97F,
                    Department=Department.InformationTechnology,
                    StateQuota=StateQuota.OtherState
                },
                new Student
                {
                    RollNumber="14EC226",
                    Name="Shashidhar Boraiah",
                    Zone=Zone.Bengaluru,
                    CGPA=9F,
                    Department=Department.ElectronicsAndCommunicationEngineering,
                    StateQuota=StateQuota.HomeState
                }
            };
            var searchQuery=from student in students
                                group student by student.Department;
            
            foreach(var groupedStudents in searchQuery)
            {
                Console.WriteLine(groupedStudents.Key);
                foreach(var student in groupedStudents)
                {
                    Console.WriteLine(student.CGPA);
                }
                Console.WriteLine();
            }

            var departmentToppers = (from student in students
                                    group student by student.Department into departmentStudents
                                    let maximumCgpa=departmentStudents.Max(y=>y.CGPA)
                                    select new {
                                        DepartmentName=departmentStudents.Key,
                                        Name = departmentStudents.FirstOrDefault(x=>x.CGPA.Equals(maximumCgpa)).Name,
                                        MaximumCgpa=maximumCgpa
                                    });
            foreach(var departmentTopper in departmentToppers)
            {
                Console.WriteLine(departmentTopper.DepartmentName);
                Console.WriteLine(departmentTopper.Name);
                Console.WriteLine(departmentTopper.MaximumCgpa);
                Console.WriteLine("**************************************");
            }
        }
    }
}
