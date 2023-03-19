namespace Day1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }


        public static List<Course> Cources = new()
        {


            new Course() {Id = 1 , Name ="C" , Duration= 60 , Description ="intro to .net and c# Basics" },
            new Course() {Id = 2 , Name ="SQL" , Duration=50 , Description ="Structure Query Language" },
            new Course() {Id = 3 , Name ="Asp.net" , Duration= 36 , Description ="Server Side Programming" },
            new Course() {Id = 4 , Name ="MVC" , Duration= 30 , Description ="Server Side Programming" },
        };

    }
}
