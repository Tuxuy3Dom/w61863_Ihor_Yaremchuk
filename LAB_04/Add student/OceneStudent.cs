using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_student
{
    public class OceneStudent
    {
        public float ocena { get; set; }
        public OceneStudent(float ocena)
        {
            this.ocena = ocena;
        }
        public OceneStudent() : this(0) { }
    }
}
