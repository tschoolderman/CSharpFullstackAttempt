using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Train
    {
        public int Id { get; set; }
        public string? Conductor { get; set; }  // question mark means nullable value
        public int Speed { get; set; }
        public string? HomeStation { get; set; }

    }
}
