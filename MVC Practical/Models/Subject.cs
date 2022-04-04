using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Practical.Models {
    public class Subject {
        [Key]
        public int ID {
            get;
            set;
        }

        public string Subject_Name {
            get;
            set;
        }

        public string syllabus {
            get;
            set;
        }

        [Range(1,5)]
        public int credits {
            get;
            set;
        }
    }
}