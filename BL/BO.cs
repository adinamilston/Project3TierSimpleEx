using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{
    class BOStudent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        List<int> courses = new List<int>();
    }
}
