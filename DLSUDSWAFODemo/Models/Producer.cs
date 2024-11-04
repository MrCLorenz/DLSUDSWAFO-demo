using System.ComponentModel.DataAnnotations;

namespace DLSUDSWAFODemo.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public int ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
