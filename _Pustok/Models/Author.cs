using System.ComponentModel.DataAnnotations;

namespace _Pustok.Models
{
    public class Author
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Fullname { get; set; }
    }
}
