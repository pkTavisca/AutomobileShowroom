using System;
using System.Collections.Generic;
using System.Text;

namespace Showroom.Contracts
{
    public interface IVehicle : IComparable<IVehicle>
    {
        int Id { get; }
        string Name { get; }
        string Company { get; }
        decimal LeasePricePerDay { get; }
        decimal SellPrice { get; }
    }
}
