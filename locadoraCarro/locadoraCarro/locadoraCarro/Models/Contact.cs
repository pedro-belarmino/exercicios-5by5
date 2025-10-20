namespace locadoraCarro.Models
{
    public class Contact
    {
        public string Email { get; set; }
        public string? Phone { get; set; }

        public Contact(string e, string? p)
        {
            Email = e;
            Phone = p;
        }

        public void setPhone(string p)
        {
            this.Phone = p;
        }
        public override string ToString()
        {
            return $"{Email}, {Phone}";
        }
    }
}