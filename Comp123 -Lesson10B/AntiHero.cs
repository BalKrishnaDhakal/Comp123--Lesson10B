using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp123_S2017_Lab24
{
    public class AntiHero: SuperHuman,IHasKarma,IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _karma;
        private int _malice;
        //PUBLIC PROPERTIES
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
        public int Malice
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
        public AntiHero( string name, int karma, int malice)
            :base(name)
        {
            this.Karma = karma;
            this.Malice = malice;

        }
    }
}