using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDgtData
{
    public class ClaseMat
    {
        [Key]
        [MaxLength(1)]
        public string Id { get; set; }

        [MaxLength(250)]
        public string  Descripcion { get; set; }
    }

    public class ProcedenciaItv
    {
        [Key]
        [MaxLength(1)]
        public string Id { get; set; }

        [MaxLength(250)]
        public string Descripcion { get; set; }
    }

    public class OldServicio
    {
        [Key]
        [MaxLength(1)]
        public string Id { get; set; }

        [MaxLength(250)]
        public string Descripcion { get; set; }
    }

    public class Tipo
    {
        [Key]
        [MaxLength(2)]
        public string Id { get; set; }

        [MaxLength(250)]
        public string Descripcion { get; set; }
    }

    public class Tramite
    {
        [Key]
        [MaxLength(1)]
        public string Id { get; set; }

        [MaxLength(250)]
        public string Descripcion { get; set; }
    }

}
