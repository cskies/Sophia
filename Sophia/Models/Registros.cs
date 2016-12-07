using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Sophia.Models
{
    [Table("Registro")]
    public class Registro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Instuicao deve ser preenchdo")]
        public string Instituicao { get; set; }

        [Required(ErrorMessage = "Nome do contato nao pode ficar em branco")]
        public string NomeContato { get; set; }

        [Required(ErrorMessage = "Obrigatorio digitar telefone")]
        public int Telefone { get; set; }

    }
}