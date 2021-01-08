namespace TodoApp.Domain.Entites
{
    public class Todo : EntityBase
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
