using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace nachorio.Models
{
    [DataContract(IsReference = true)]
    public class actitudes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public String Tipo { get; set; }
        public String Nivel { get; set; }
        public virtual estudios estudios {get;set;}
    }
}