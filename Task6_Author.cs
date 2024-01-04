using System;

namespace Task6
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
