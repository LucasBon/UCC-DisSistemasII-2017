using SistemaTurnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace SistemaTurnosWeb.Models
{
    public class StartWithUpperCase : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string letra = value.ToString();

                if (!char.IsLetter(letra[0]) || char.IsLower(letra[0]))
                {
                    return new ValidationResult("Debe comenzar con una letra mayuscula...");
                }

                return ValidationResult.Success;
            }
            return new ValidationResult("Se debe especificar la letra que identifica el motivo de atención");
        }
    }

    public class IsDayOfWeek : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string diaSemana = value.ToString();

                switch (diaSemana.ToUpper())
                {
                    case "LUNES":
                    case "MARTES":
                    case "MIERCOLES":
                    case "JUEVES":
                    case "VIERNES":
                    case "SABADO":
                    case "DOMINGO":
                        return ValidationResult.Success;
                    default:
                        return new ValidationResult("Debe ingresar un día de semana.");

                }
            }
            return new ValidationResult("Se debe especificar un día de la semana.");
        }
    }

    public class MotivoAtencionViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se debe especificar la letra que identifica el motivo de atención")]
        [Display(Name = "Letra descriptiva", Description = "Letra que se usa en el turno para identificar el motivo de atención")]
        [MaxLength(2, ErrorMessage = "No puede ser mas de 2 carateres.")]
        [StartWithUpperCase]
        public string LetraDescriptiva { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se debe especificar el nombre del motivo de atención")]
        public string Nombre { get; set; }

        public MotivoAtencionViewModel() { }

        public MotivoAtencionViewModel(MotivoAtencion ma)
        {
            this.Id = ma.Id;
            this.Nombre = ma.Nombre;
            this.LetraDescriptiva = ma.LetraDescriptiva;
        }

    }

    public class DisponibilidadViewModel : IValidatableObject
    {

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese el día de la semana")]
        [Display(Name = "Día de la semana", Description = "Día de la semana")]
        [IsDayOfWeek]
        public string DiaSemana { get; set; }

        public TimeSpan Desde { get; set; }

        public TimeSpan Hasta { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int IdMotivoAtencion { get; set; }

        public DisponibilidadViewModel() { }

        public DisponibilidadViewModel(DayOfWeek dia, RangoHora rango)
        {
            this.DiaSemana = dia.ToString();
            this.Desde = rango.Inicio;
            this.Hasta = rango.Fin;
        }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (this.Desde >= this.Hasta)
            {
                yield return new ValidationResult("La hora de inicio debe ser anterior a la hora de fin.");
            }
        }
    }

   


}