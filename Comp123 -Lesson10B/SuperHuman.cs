using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 13, 2017
 * Description: This is the Super Human Class that extends the Human abstract class 
 * Version: 0.5 - Added GetPower method to the SuperHuman class
 */

namespace Comp123_S2017_Lab24
{/// <summary>
 /// This is the SupeHuman Class
 /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE INSTANCE VARIABLES
        private List<Power> _powers;
        // PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._powers; // this reference

            }
        }

        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the superHuman Class.
        /// It takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();
        }

        // PRIVATE METHODS
        /// <summary>
        /// This method initialize and assign default values to class Fields
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();// create a empty list
        }
        private int _getPowerIndex(string name)
        {
            int index = 0;
            foreach (Power power in this.Powers)
            {
                if (name.Equals(power.Name))
                {
                    break;
                }
                index++;
                if (this.Powers.Count == index)
                {
                    index = -1;// This means that we didn not find the power in the list
                }
            }
            return index;
        }

        // PUBLIC METHODS
        /// <summary>
        /// This method adds a power to the Power List
        /// It takes two parameter - name(string) - rank(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        /// <summary>
        /// This method dispayes each of the powers stored in the Powers List
        /// </summary>
        public void DisplayPowers()
        {
            foreach (var power in this.Powers)
            {
                Console.WriteLine("Name: " + power.Name + " Rank:" + power.Rank);
            }
        }
        // PUBLIC OVERRIDDEN METHODS
        /// <summary>
        /// Overridden the build in ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "================================================\n";
            outputString += " SuperHuman Name:" + this.Name + "\n";
            outputString += "================================================\n";

            foreach (Power power in this.Powers)
            {
                outputString += "Power:" + power.Name + " Rank:" + power.Rank + "\n";

            }
            outputString += "================================================\n";

            return outputString;
        }
        /// <summary>
        /// This is the DisplaySkills Method
        /// Need to be Implemented
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented!");
        }
        /// <summary>
        /// This method returns the power object
        /// If the power is not found it returns an anonymous 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Power GetPower(string name)
        {
            int index = this._getPowerIndex(name);
            if (index != -1)
            {
                return this.Powers[index];
            }
            return new Power("Power not found", 0);
        }

    }
}

