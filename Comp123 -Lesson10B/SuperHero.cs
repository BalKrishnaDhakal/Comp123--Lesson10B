using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 13, 2017
 * Description: This is an SuperHero Class which inherits from the SuperHuman Class
 * and implements the IHasKarma Interface
 * must be implemente in any class that subscribe to it
 * Version: 0.1 - Created the SuperHero Class
 * Git Link: https://github.com/BalKrishnaDhakal/Comp123-S2017-Lab24
 */

namespace Comp123_S2017_Lab24
{ /// <summary>
  /// This is the SuperHero Class
  /// </summary>
    public class SuperHero : SuperHuman, IHasKarma
    {
        // PRIVATE INSTANCE VARIABLES
        private int _karma;
        // PUBLIC PROPERTIES
        public int Karma
        {
            get
            {
                return this._karma;

            }
            set
            {
                this._karma = value;

            }
        }

        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the SuperHuman class
        /// It takes one argument - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;

        }
        // PRIVATE METHODS
        // PUBLIC METHODS

    }
}
