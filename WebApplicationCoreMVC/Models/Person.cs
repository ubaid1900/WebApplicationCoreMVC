using Microsoft.EntityFrameworkCore;

namespace WebApplicationCoreMVC.Models
{
    [Index("Email", IsUnique = true)]
    public class Person
    {
        //public Person(string lastName)
        //{
        //    Lastname = lastName;
        //}

        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public string? Email { get; set; }

        public bool IsResident { get; set; }

        public Nullable<long> Phonenumber { get; set; }

        public int? AddressId { get; set; }

        public Address? Address { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? Landmark { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PinCode { get; set; }
    }
}
