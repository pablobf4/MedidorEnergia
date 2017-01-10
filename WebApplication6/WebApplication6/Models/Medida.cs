using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Medida
    {
        [Key]
        public int IDMedida { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime Horario { get; set; }

        [Display(Name = "Potencia")]
        public float Potencia { get; set; }

        [Display(Name = "Corrente")]
        public float Corrente { get; set; }

        

        public virtual ApplicationUser Usuario { get; set; }
        public virtual Objeto Objeto { get; set; }

        // construtor para api
        public Medida(float irms, float potencia)
        {
            
            var horario = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            this.Potencia = potencia;
            this.Corrente = irms;
 
            
        }

        public Medida(string usuario)
        {   

            this.Usuario.Nome = usuario;

        }

       
        
    }
}