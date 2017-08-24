using Showroom.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Showroom
{
    public class RegisterEntry
    {
        public DateTime Date { get; }
        public IVehicle Vehicle { get; }

        public RegisterEntry(IVehicle vehicle)
        {
            Vehicle = vehicle;
            Date = DateTime.Now;
        }
    }
}
