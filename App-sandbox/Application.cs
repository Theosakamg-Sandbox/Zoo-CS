using Console_test.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_test
{
    //                         Extends | Implements...
    public class Application : Object, IDisposable, ICloneable, IApiWs
    {

        #region Fileds
        /// <summary>ftjfyugyug</summary>
        private String lastname = "";
        public String Firstname { get; set; }
        #endregion


        #region Functions
        /// <summary>
        /// Constructor
        /// </summary>
        public Application()
        {
            this.Firstname = "";

            this.Lastname = "";
            Console.Out.WriteLine(this.Lastname);
        }

        /// <summary>
        /// Destructor
        /// </summary>
        public void Dispose()
        {
            
        }

        ~Application()
        {

        }

        public object Clone()
        {
            return null;
        }

        public String Lastname
        {
            get
            {
                return this.lastname;
            }
            set
            {
                this.lastname = value;
            }
        }

        /// <summary>
        /// My function description
        /// </summary>
        /// <param name="titi">My first parameter</param>
        /// <param name="tutu">My second parameter</param>
        /// <returns>Return always 1 !!</returns>
        public int Toto(String titi, Object tutu = null)
        {
            return 1;
        }
        #endregion

        public void Toto()
        {
            String t = this.Lastname + this.Firstname;
        }
    }
}
