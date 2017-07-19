using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 13, 2017
 * Version: 0.2 - Added a the Constructor
 * Git Link: https://github.com/BalKrishnaDhakal/Comp123-S2017-Lab24
 */

namespace Comp123_S2017_Lab24
{
    /// <summary>
    /// This is the Power class which will be used as a Data type
    /// </summary>
    public class Power
    {
        // PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }
        // CONSTRUCTORS---------------------
        /// <summary>
        /// this is the main constructor for the power class
        /// It takes two arguments - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
        //pUBLIC OVERLADED OPERATORS
        /// <summary>
        /// This method overloads the < for use with the power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>Returns true if lhs.Rank is > rhs.Rank</returns>
        public static bool operator >(Power lhs, Power rhs)
        {
            return (lhs.Rank > rhs.Rank);

        }
        /// <summary>
        /// This method overloads the > for use with the power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static bool operator <(Power lhs, Power rhs)
        {
            return (lhs.Rank < rhs.Rank);

        }
    }
}
