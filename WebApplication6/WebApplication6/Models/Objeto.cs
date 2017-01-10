using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Objeto {

    [Key]
        public int IDObjeto { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Primeiro nome não pode passar de 50 caracteres")]
        [Column("NomeObjeto")]
        [Display(Name = "Nome do Objeto")]
        public string Nome { get; set; }

        public virtual List<Medida> Medidas { get; set; }
            }
     }
