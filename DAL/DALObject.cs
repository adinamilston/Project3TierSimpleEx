using DO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class DALObject : IDAL
    {
        public Student GetStudent()
        {
            return new Student { ID = 111, Name = "Adina" };
        }
    }
}
