using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaCursosModels.Shared.Models
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionID { get; set; }
        public Usuarios UsuarioID { get; set; }

        public Cursos CursoID { get; set; }

        public DateTime FechaInscripcion { get; set; }
    }
}
