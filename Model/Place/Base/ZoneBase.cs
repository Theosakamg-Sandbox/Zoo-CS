using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Animal.Base;

namespace Model.Place.Base
{
    public abstract class ZoneBase<T> : IZone where T : IAnimal
    {

        protected List<T> content = new List<T>();
        protected String Name { get; set; }
        protected int Capacity { get; private set; }

        public ZoneBase(String name, int maxi)
        {
            this.Name = name;
            this.Capacity = maxi;
        }

        public void Add(T value)
        {

            // Check availability.
            if (this.content.Count == this.Capacity)
            {
                throw new Exception("To many animals !!");
            }

            // Check Duplicate.
            if (value.Zone != null)
            {
                throw new Exception("In other Zone...");
            }

            // Check if no armagedon...
            if (this.content.Count > 0 && this.Content[0].GetType() != value.GetType())
            {
                throw new Exception("Outch Animal is dead...");
            }

            // Add Bidirectional relation
            this.content.Add(value);
            value.Zone = this;
        }

        public void Remove(T value)
        {
            this.content.Remove(value);
        }

        public List<T> Content { get { return this.content; } }
    }
}
