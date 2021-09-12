using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Modelos.Models.ViewModels
{
    public class PersonaViewModel
    {
        [Display (Name = "Monto")]
        
        [Required(ErrorMessage ="Debe rellenar los campos")]
        public int Monto { get; set; }
        

        [Display(Name = "Nombre")]

        [Required(ErrorMessage = "Debe rellenar los campos")]
        public string Nombre { get; set; }
    }
}