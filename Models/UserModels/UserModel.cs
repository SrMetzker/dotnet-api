using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_api.Models.UserModels
{
    [Table ("Users")]
    public class UserModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; } = 0;

        [Required]
        [Column("Name")]
        public string Name { get; set; }      = string.Empty;

        [Column("Email")]
        public string Email { get; set; }     = string.Empty;

        [Required]
        [Column("Password")]
        public string Password { get; set; }  = string.Empty;
    }
}
