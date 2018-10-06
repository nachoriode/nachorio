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
    public class experiencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public String Categoria { get; set; }
        public String Empresa { get; set; }
        public String Puesto { get; set; }
        public String Ciudad { get; set; }
        public String Pais { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public ICollection<taks> taks { get; set; }
    }
}