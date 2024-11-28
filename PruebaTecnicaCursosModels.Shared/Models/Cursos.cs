using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaCursosModels.Shared.Models
{ 
    public class Cursos
    {
        [Key]
        public int CursoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public ICollection<Inscripciones> Inscripciones { get; set; }
        public ICollection<Evaluaciones> Evaluaciones { get; set; }

    }
}
