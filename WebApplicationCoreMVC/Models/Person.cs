namespace WebApplicationCoreMVC.Models
{
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
    }
}
