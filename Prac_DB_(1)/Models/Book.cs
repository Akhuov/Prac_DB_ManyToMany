using Microsoft.EntityFrameworkCore.Metadata;

namespace Prac_DB__1_.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
