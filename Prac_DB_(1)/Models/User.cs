namespace Prac_DB__1_.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
