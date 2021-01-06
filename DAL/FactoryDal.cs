using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class FactoryDal
    {
        public static IDAL getDAL()
        {
            return new DALObject();
        }
    }
}
