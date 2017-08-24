using System;
using System.Collections.Generic;
using System.Text;

namespace Showroom
{
    public class Register
    {
        public List<RegisterEntry> SoldList { get; }
        public List<RegisterEntry> RentedList { get; }
        public List<RegisterEntry> MaintainenceList { get; }

        public Register()
        {
            SoldList = new List<RegisterEntry>();
            RentedList = new List<RegisterEntry>();
            MaintainenceList = new List<RegisterEntry>();
        }
    }
}
