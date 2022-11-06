using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Managment_Studio.Models
{
    public enum MajorIndexType
    {
        DowJones,
        Nasdaq,
        SP500
    }
    public class MajorIndex
    {
        public double Price { get; set; }
        public double Changes { get; set; }
        public MajorIndexType Type { get; set; }
    }
}
