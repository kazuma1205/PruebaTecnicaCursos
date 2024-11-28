using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaCursosModels.Shared.Models
{
    public class Rol
    {
        [Key]
        public int RolID { get; set; }
        public string Nombre { get; set; }

        public ICollection<UsuarioRoles> UsuarioRoles { get; set; }
    }
}
