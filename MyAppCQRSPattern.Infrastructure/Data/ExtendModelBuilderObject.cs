using Microsoft.EntityFrameworkCore;
using MyAppCQRSPattern.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MyAppCQRSPattern.Infrastructure.Data
{
    public static class ExtendModelBuilderObject
    {
        public static ModelBuilder SeedDb(this ModelBuilder incomingBuilder)
        {
            incomingBuilder.Entity<Student>()
                            .HasData(GetListOfMyStudentObj);
            incomingBuilder.Entity<Course>()
                            .HasData(GetListOfMyCourseObj);

            incomingBuilder.Entity<Gender>()
                            .HasData(GetListOfMyGenderObj);
            incomingBuilder.Entity<MainMenuItem>()
                            .HasData(GetListOfMyMainMenuItemObj);

            return incomingBuilder;
        }
        private static List<Student> GetListOfMyStudentObj
        {
            get
            {
                return new()
                {
                    new()
                    {
                        StudentId = 1,
                        FirstName = "iamtuse",
                        LastName = "theProgrammer",
                        Email = "iamtuse@iamtuse.com",
                        GenderId = 1,
                        DateEnrolled = DateTime.UtcNow,
                    },
                    new()
                    {
                        StudentId = 2,
                        FirstName = "Precious",
                        LastName = "Wonkulah",
                        Email = "wonkulahp@iamtuse.com",
                        GenderId = 2,
                        DateEnrolled = DateTime.UtcNow,
                    },
                    new()
                    {
                        StudentId = 3,
                        FirstName = "Dad",
                        LastName = "Wonkulah Sr",
                        Email = "dadwonkulahsr@iamtuse.com",
                        GenderId = 1,
                        DateEnrolled = DateTime.UtcNow,
                    },
                    new()
                    {
                        StudentId = 4,
                        FirstName = "Leo",
                        LastName = "Maxwell",
                        Email = "leo@iamtuse.com",
                        GenderId = 1,
                        DateEnrolled = DateTime.UtcNow,
                    },
                    new()
                    {
                        StudentId = 5,
                        FirstName = "Test",
                        LastName = "User",
                        Email = "testuser@iamtuse.com",
                        GenderId = 3,
                        DateEnrolled = DateTime.UtcNow,
                    },
                    new()
                    {
                        StudentId = 6,
                        FirstName = "Test1",
                        LastName = "User1",
                        Email = "testuser1@iamtuse.com",
                        GenderId = 2,
                        DateEnrolled = DateTime.UtcNow,
                    }
                };

            }
        }
        private static List<Course> GetListOfMyCourseObj
        {
            get
            {
                return new()
                {
                    new()
                    {
                        CourseId = 1,
                        CourseName = "Software Development",
                        CourseNumber = 300,
                        CreditHour = 8,
                    },
                    new()
                    {
                        CourseId = 2,
                        CourseName = "Razor Pages",
                        CourseNumber = 204,
                        CreditHour = 6,
                    },
                    new()
                    {
                        CourseId = 3,
                        CourseName = "MVC",
                        CourseNumber = 204,
                        CreditHour = 10,
                    },
                    new()
                    {
                        CourseId = 4,
                        CourseName = "Advanced Database Management",
                        CourseNumber = 400,
                        CreditHour = 10,
                    }

                };
            }
        }
        private static List<Gender> GetListOfMyGenderObj
        {
            get
            {
                return new()
                {
                    new() { GenderId = 1, Name = "Male" },
                    new() { GenderId = 2, Name = "Female" },
                    new() { GenderId = 3, Name = "Unknown" },
                };
            }
        }
        private static List<MainMenuItem> GetListOfMyMainMenuItemObj
        {
            get
            {
                return new()
                {
                    new() { MainMenuId = 1, StudentId = 1, CourseId = 2, CourseDescripion = "This is an introductory course to aspnet core razor pages!", GenderDescription = "Gender of a male", StudentDescription = "This is our first student in the institution." },
                    new() { MainMenuId = 2, StudentId = 4, CourseId = 1, CourseDescripion = "This is an introductory course to software development fundamentals!", GenderDescription = "Gender of a male", StudentDescription = "This is our second student in the institution." },
                    new() { MainMenuId = 3, StudentId = 2, CourseId = 3, CourseDescripion = "This is an introductory course to aspnet core model views and controllers!", GenderDescription = "Gender of a male", StudentDescription = "This is our first student in the institution." },
                    new() { MainMenuId = 4, StudentId = 3, CourseId = 4, CourseDescripion = "This is an introductory course toa advanced database managemntn!", GenderDescription = "Gender of a male", StudentDescription = "This is our first student in the institution." }
                };
            }
        }
    }
}
