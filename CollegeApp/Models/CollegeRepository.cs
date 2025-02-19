using System;
namespace CollegeApp.Models
{
	public static class CollegeRepository
	{
        public static List<Student> Students { get; set; } = new List<Student>()
        {
            new Student
            {
                Id = 1,
                StudentName = "Anil",
                Email = "studentemail@gmail.com",
                Address = "Hyd, INDIA"
            },
            new Student
            {
                Id = 2,
                StudentName = "Venkat",
                Email = "student2email@gmail.com",
                Address = "Kochi, INDIA"
            }
        };
		
	}
}

