using System.ComponentModel.DataAnnotations;

namespace FirstcoreApp.Models
{
    public class Student
    {
        [Key]

        public int id { get; set; }

        public string FirstName { get; set; }

        public string lastName { get; set; }
        public string email { get; set; }
        

    }
}
