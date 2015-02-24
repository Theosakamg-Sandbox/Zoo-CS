using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Animal.Base;

namespace Model.Animal
{
    public class Monkey : AnimalBase, ITerestrial
    {
        public Monkey(String name) : base(name) { }
    }
}
