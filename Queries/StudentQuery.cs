using GraphQLService.Models;

namespace GraphQLService.Queries
{
    public class StudentQuery
    {
        public List<Student> GetBooks()
        {
            // Örnek veri
            return new List<Student>
            {
                new Student { Id = 1, Name = "Soner", SurName = "ÇELİK", Age = 20 },
                new Student { Id = 2, Name = "Kudret", SurName = "ASLAN", Age = 21 },
                new Student { Id = 3, Name = "Burak", SurName = "KOÇ", Age = 22 },
            };
        }
    }
}