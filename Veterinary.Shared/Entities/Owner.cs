using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El documento es requerido")]
        public string Document { get; set; } = null;

        [Required(ErrorMessage = "El primer nombre es requerido")]
        public string FirstName { get; set; } = null;

        [Required(ErrorMessage = "El apellido es requerido")]
        public string LastName { get; set; } = null;

        public string FixedPhone { get; set; } = null;

        [Required(ErrorMessage = "El numero de celular es requerido")]
        public string CellPhone { get; set; } = null;

        [Required(ErrorMessage = "La direccion es requerida")]
        public string Addres { get; set; } = null;

        public string FullName => $"{FirstName} {LastName}";


    }
}
