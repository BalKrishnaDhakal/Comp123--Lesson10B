using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Name: Bal Krishna Dhakal
* Date: July 13, 2017
* Description: 
* Version: 0.1 - Created the SuperVillian Class
* Git Link: https://github.com/BalKrishnaDhakal/Comp123-S2017-Lab24
*/

namespace Comp123_S2017_Lab24
{
    public class SuperVillian : SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _malice;
        // PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;

            }
            set
            {
                this._malice = value;

            }
        }

        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor 
        /// It takes one argument - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperVillian(string name, int malice)
            : base(name)
        {
            this.Malice = malice;

        }
        // PRIVATE METHODS
        // PUBLIC METHODS
    }
}