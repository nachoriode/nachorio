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
    public class estudios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public String Categoria { get; set; }
        public String Titulo { get; set; }
        public String Escuela { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public ICollection<actitudes> actitudes { get; set; }
    }
}