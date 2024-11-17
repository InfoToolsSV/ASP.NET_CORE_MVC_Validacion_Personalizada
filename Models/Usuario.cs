using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ValidacionPersonalizada.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        [Remote("ValidarEmail", "Usuarios", ErrorMessage = "Este correo electrónico ya está registrado.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*]).*$", ErrorMessage = "La contraseña debe contener al menos una letra mayúscula, un número y un carácter especial.")]
        public string Password { get; set; } = null!;
    }
}