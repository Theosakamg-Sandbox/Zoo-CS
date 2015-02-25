using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Place;
using Model.Animal;

namespace UI_concole
{
    class Program
    {
        static void Main(string[] args)
        {
            Cage cage = new Cage("1", 2);
            Pool pool = new Pool("2", 3);

            // Base system
            Monkey monkey = new Monkey("Donkey Kong");
            cage.Add(monkey);

            // PolyMorphic system
            Turtle turtleL = new Turtle("Leonardo");
            Turtle turtleR = new Turtle("Raphael");
            Turtle turtleD = new Turtle("Donatello");
            Turtle turtleM = new Turtle("Michelangelo");
            pool.Add(turtleL);
            pool.Add(turtleR);
            pool.Add(turtleD);

            // Test Zone capacity limit
            try
            {
                pool.Add(turtleM);
            }
            catch (Exception ex) { Console.Out.WriteLine(ex.Message); }

            // No duplicate animal in many zone
            try
            {
                cage.Add(turtleL);
            }
            catch (Exception ex) { Console.Out.WriteLine(ex.Message); }

            // Test if mixed animal
            Lion lion = new Lion("Simba");
            try
            {
                cage.Add(lion);
            }
            catch (Exception ex) { Console.Out.WriteLine(ex.Message); }

            cage.Remove(monkey);
            cage.Add(lion);

            int i = +1;
        }
    }
}
