using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
        public class Topic  
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public ICollection<Course> Course { get; set; } = new List<Course>();  
    }
    
}
