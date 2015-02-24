using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Place.Base;

namespace Model.Animal.Base
{
    public interface IAnimal
    {
        IZone Zone { get; set; }
    }
}
