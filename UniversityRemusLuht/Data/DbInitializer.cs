using UniversityRemusLuht.Models;

namespace UniversityRemusLuht.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }
            var students = new Student[]
            {
                new Student(){FirstName="Kaarel-Martin",LastName="Noole",EnrollmentDate=DateTime.Now},
                new Student(){FirstName="Palmi",LastName="Lahe",EnrollmentDate=DateTime.Parse("2021-09-01")},
                new Student(){FirstName="Karl Umberto",LastName="Kats",EnrollmentDate=DateTime.Parse("2021-09-01")},
                new Student(){FirstName="Kristjan Georg",LastName="Kessel",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student(){FirstName="Kenneth-Marcus",LastName="Aljas",EnrollmentDate=DateTime.Parse("2021-09-05")},
                new Student(){FirstName="Henri",LastName="Jervson",EnrollmentDate=DateTime.Parse("2021-09-03")}
            };
            foreach (Student s in students) 
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course() {CourseID=1050,Title="Programmeerimine", Credits=160 },
                new Course() {CourseID=6900,Title="Keemia", Credits=160 },
                new Course() {CourseID=1420,Title="Matemaatika", Credits=160 },
                new Course() {CourseID=6666,Title="Testimine", Credits=160 },
                new Course() {CourseID=1234,Title="Riigikaitse", Credits=160 }
            };
            foreach(Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1, CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1, CourseID=6900,Grade=Grade.B},
                new Enrollment{StudentID=2, CourseID=1420,Grade=Grade.B},
                new Enrollment{StudentID=2, CourseID=6666,Grade=Grade.C},
                new Enrollment{StudentID=3, CourseID=6666,Grade=Grade.C},
                new Enrollment{StudentID=3, CourseID=1234,Grade=Grade.A},
                new Enrollment{StudentID=4, CourseID=6666,Grade=Grade.F},
                new Enrollment{StudentID=4, CourseID=6900,Grade=Grade.A},
                new Enrollment{StudentID=5, CourseID=1050,Grade=Grade.F},
                new Enrollment{StudentID=5, CourseID=6666,Grade=Grade.C}
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
