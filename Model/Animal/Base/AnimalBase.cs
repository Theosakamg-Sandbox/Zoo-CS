using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Place.Base;

namespace Model.Animal.Base
{
    public class AnimalBase : IAnimal
    {
        public String Name { get; set; }
        public IZone Zone { get; set; }

        public AnimalBase(String name)
        {
            this.Name = name;
        }

        override
        public String ToString()
        {
            return String.Format("%s (%s)", this.Name, this.GetType().Name);
        }
    }
}
