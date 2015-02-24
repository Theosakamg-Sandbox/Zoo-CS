using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Animal.Base;

namespace Model.Animal
{
    public class Turtle : AnimalBase, ITerestrial, IAquatic
    {
        public Turtle(String name) : base(name) { }
    }
}
