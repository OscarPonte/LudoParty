using System.ComponentModel.DataAnnotations;

namespace LudoParty.Server.Models
{
    public class SettingsModel
    {
        [Required] 
        [Key]
        public int Id { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public int Type { get; set; }
    }
}