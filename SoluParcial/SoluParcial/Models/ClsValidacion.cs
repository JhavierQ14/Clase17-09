using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoluParcial.Models
{
    public class ClsValidacion
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Error este campo es requerido")]



        public String Nombre { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "Error este campo es requerido")]

        public int Edad { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Error este campo es requerido")]
        public String Sexo { get; set; }

        [Display(Name = "tipoEstudio")]
        [Required(ErrorMessage = "Error este campo es requerido")]
        public String tipoEstudio { get; set; }



    }
}