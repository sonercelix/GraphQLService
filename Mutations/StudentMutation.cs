using GraphQLService.Models;

namespace GraphQLService.Mutations
{
    public class StudentMutation
    {
        public Student AddStudent(string name, string surname, int age)
        {
            // Veritabanına eklemek yerine basit bir örnek veri döndürelim.
            return new Student { Id = 4, Name = name, SurName = surname, Age = age };
        }
    }
}