using dotnet_api.Models.UserModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_api.Models.ClientModels
{
    [Table("Clients")]
    public class ClientModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("Id")]
        public int Id { get; set; } = 0;

        [Required]
        [MaxLength(100)]
        [Column("Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Column("CreatedBy")]
        public UserModel? CreatedBy { get; set; } = null;
    }
}