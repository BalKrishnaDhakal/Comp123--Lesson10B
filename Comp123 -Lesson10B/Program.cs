using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 13, 2017
 * Description: Lab 24
 * Version: 0.3 - Added a power to the SuperHuman Object 
 *              - Also displayed all the powers in the powers List
 *  Git Link: https://github.com/BalKrishnaDhakal/Comp123-S2017-Lab24
 */
namespace Comp123_S2017_Lab24
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.AddPower("Spider Climbing", 50);
            superHuman.AddPower("Webcasting", 40);
            superHuman.DisplayPowers();
            Console.WriteLine(superHuman.ToString());

            SuperHero superHero = new SuperHero("SuperHero Dude", 20);

            superHero.Powers.Add(new Power("Teleportation", 50));

            superHero.Powers.Add(new Power("Phasing", 40));

            superHero.Powers.Add(new Power("Invisibility", 30));

            Console.WriteLine(superHero.ToString());

            Console.WriteLine("Karma: " + superHero.Karma);

            SuperVillian superVillian = new SuperVillian("SuperVillian Dude", 20);

            superVillian.Powers.Add(new Power("Macktus", 50));

            superVillian.Powers.Add(new Power("Ravan", 40));

            superVillian.Powers.Add(new Power("Gurrilla", 30));

            Console.WriteLine(superVillian.ToString());
            Console.WriteLine("Malice: " + superVillian.Malice);

            //if(superHero is SuperHuman)
            //{
            //    Console.WriteLine("Super hero is super human");
            //}
            //if(superHero is Human)
            //{
            //    Console.WriteLine("Super hero is a human");
            //}

            //   Console.WriteLine(superVillian._getPowerIndex("Macktus"));
            if (superVillian.GetPower("Macktus") >
                        superVillian.GetPower("Ravan"))
            {
                Console.WriteLine("Macktus is powerful than Ravan");
            }






        }
    }
}
