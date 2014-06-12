using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DesignPatterns.Models
{
    [Table("Users")]
    public partial class UserTable
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}
