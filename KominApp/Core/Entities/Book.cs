namespace KominApp.Core.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Furnace { get; set; }
        public bool State { get; set; }
        public int PhoneNumber { get; set; }
        public string LastName { get; set; }
        public string? Note { get; set; }
    }
}
