using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySB.Entidades
{
    [Table("login")]
    public class LoginEnt
    {
        [Key]
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
