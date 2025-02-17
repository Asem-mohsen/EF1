using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [ForeignKey("instructor")]
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }

        public Instructor Instructor { get; set; }

        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
    }

}
