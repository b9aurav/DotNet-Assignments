using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Practical.Models {
    public class Teacher {
        [Key] 
        public int Id {
            get;
            set;
        }

        [Required] 
        public string Name {
            get;
            set;
        }

        public DateTime joinDate {
            get;
            set;
        }

        public DateTime birthDate {
            get;
            set;
        }
    }
}