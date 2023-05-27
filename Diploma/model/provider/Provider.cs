using Diploma.model.user;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.model.provider
{
    [Table(name: "Providers")]
    public class Provider : User
    {
        [Required, MaxLength(16), Phone] public string PhoneNumber { get; set; } = string.Empty;
        [Required, MaxLength(256)] public string Address { get; set; } = string.Empty;
        public override string Role => "ProviderUser";
    }
}
