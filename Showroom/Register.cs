using System;
using System.Collections.Generic;
using System.Text;

namespace Showroom
{
    public class Register
    {
        public List<Invoice> SoldList { get; }
        public List<Invoice> RentedList { get; }
        public List<Invoice> MaintainenceList { get; }

        public Register()
        {
            SoldList = new List<Invoice>();
            RentedList = new List<Invoice>();
            MaintainenceList = new List<Invoice>();
        }
    }
}
