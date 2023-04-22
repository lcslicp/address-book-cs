namespace address_book.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Phone { get; set; }
        public string? Email { get; set; }
        public string? ContactAddress { get; set; }

        public Contact()
        {
            
        }
    }
}
