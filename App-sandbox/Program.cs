using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_test
{
    public class Program
    {
        

        

        static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello W");
            String t = Console.In.ReadLine();

            // Variable
            string tutu = "test";
            String titi = "test";

            // Conditional
            if (tutu != null && tutu == titi)
            {
                tutu = "tutu";
            }
            else
            {

            }

            switch (1)
            {
                case 1:
                    tutu = "toto";
                    break;
                case 2:
                case 3:
                    tutu = "titi";
                    break;
                default:

            }

            // Iteration
            for (int i = 0 ; i < 100 ; i++) {

            }

            for (int i = 100; i >= 0; i--)
            {

            }

            while (true) // HOT CPU !!!
            {

            }

            do
            {
                
            } while (true);

            List<String> collection = new List<string>();
            foreach (String item in collection)
            {
                
            }

            for (int i = 0; i < collection.Count; i++)
            {
                String item = collection[i];

            }

            // Expeption
            try
            {
                // A
                throw new DivideByZeroException();
                // B
                throw new NullReferenceException();
            }
            catch (DivideByZeroException e) 
            {
                // Interceopt A
            }
            /*catch (NullReferenceException e)
            {

            }*/
            finally
            {
                 // Always run
            }

            // XX

            Application app = new Application();
            app.Lastname = "";
            app.Firstname = "";
            app.Toto("", new Object());

            // POO
            Application app2 = new Application { Firstname = "", Lastname = "" };
            
            // Generic
            List<String> y = new List<String>();
            y.Add("Toto");

            String u = y[0];

            User user = new User();
            Product product = new Product();

            Dao<User> dao = new Dao<User>();
            dao.Create(user);

            Dao<Product> daop = new Dao<Product>();
            daop.Create(product);

        }
    }
}
