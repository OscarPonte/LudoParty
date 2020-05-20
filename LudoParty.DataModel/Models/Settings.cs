using System.ComponentModel.DataAnnotations;
using LudoParty.DataModel.Enums;

namespace LudoParty.DataModel.Models
{
    public class Settings
    {
        [Required]
        [Key]
        public SettingCategory Id { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public SettingType Type { get; set; }
    
}
}
