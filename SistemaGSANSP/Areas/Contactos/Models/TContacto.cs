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

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public string nombres { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "El campo apellidos es obligatorio.")]        
        public string apellidos { get; set; }

        [Display(Name = "Sexo")]
        public string sexo { get; set; }

        [Display(Name = "DUI")]
        [Required(ErrorMessage = "El campo dui es obligatorio.")]        
        public string dui { get; set; }

        [Display(Name = "NIT")]
        [Required(ErrorMessage = "El campo nit es obligatorio.")]
        public string nit { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "El campo fecha nacimiento es obligatorio.")]
        public DateTime? fecha_nac { get; set; }

        [Display(Name = "Lugar de nacimiento")]
        [Required(ErrorMessage = "El campo lugar nacimiento es obligatorio.")]
        public string lugar_nac { get; set; }

        [Display(Name = "Nombre del padre")]
        public string nomb_padre { get; set; }

        [Display(Name = "Nombre de la madre")]
        public string nomb_madre { get; set; }

        [Display(Name = "Estado civil")]
        public string estado_civil { get; set; }

        [Display(Name = "Nombre del conyuge")]
        public string nombre_conyuge { get; set; }

        [Display(Name = "Direccion actual")]
        public string direcc_actual { get; set; }

        [Display(Name = "No. de Teléfono celular")]
        public string tel_celular { get; set; }

        [Display(Name = "Teléfono de casa")]
        public string tel_casa { get; set; }

        [Display(Name = "Profesión u oficio")]
        public string profes_oficio { get; set; }

        [Display(Name = "Empresa donde trabaja")]
        public string empresa_trabaja { get; set; }

        [Display(Name = "¿Sin empleo?")]
        public Boolean trabaja { get; set; } = false;

        [Display(Name = "¿Se inscribe por su cuenta?")]
        public Boolean por_su_cuenta { get; set; } = false;

        [Display(Name = "Estudios realizados")]
        public string estudios_rea { get; set; }
        public int UserId { get; set; }
        public Boolean estado { get; set; } = false;
        public string usuario { get; set; }
        public DateTime? creado { get; set; }
        public string usuamodif { get; set; }
        public DateTime? modificado { get; set; }
    }
}
