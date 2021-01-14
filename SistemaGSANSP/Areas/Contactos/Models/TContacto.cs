using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGSANSP.Areas.Contactos.Models
{
    public class TContacto
    {
        public int ContactoID { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public string nombres { get; set; }

        [Required(ErrorMessage = "El campo apellidos es obligatorio.")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "El campo dui es obligatorio.")]
        public string dui { get; set; }

        [Required(ErrorMessage = "El campo nit es obligatorio.")]
        public string nit { get; set; }

        [Required(ErrorMessage = "El campo fecha nacimiento es obligatorio.")]
        public DateTime? fecha_nac { get; set; }

        [Required(ErrorMessage = "El campo lugar nacimiento es obligatorio.")]
        public string lugar_nac { get; set; }


        public string nomb_padre { get; set; }
        public string nomb_madre { get; set; }
        public string estado_civil { get; set; }
        public string nombre_conyuge { get; set; }
        public string direcc_actual { get; set; }
        public string tel_celular { get; set; }
        public string tel_casa { get; set; }
        public string profes_oficio { get; set; }
        public string empresa_trabaja { get; set; }
        public Boolean trabaja { get; set; } = false;
        public string estudios_rea { get; set; }
        public int UserId { get; set; }
        public Boolean estado { get; set; } = false;
        public string usuario { get; set; }
        public DateTime? creado { get; set; }
        public string usuamodif { get; set; }
        public DateTime? modificado { get; set; }
    }
}
