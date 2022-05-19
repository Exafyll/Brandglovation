using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public class Country : BoardTile
    {
        /// <summary>
        /// The Name of the Tile
        /// </summary>
        private readonly string name;
        public string Name { get { return name; } }

        /// <summary>
        /// The path to the Country Flag
        /// </summary>
        private readonly string flagSource;
        public string FlagSource { get { return flagSource; } }

        //TODO: Add Investment List

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="flagSource"></param>
        public Country(string name, string flagSource) : base()
        {
            this.name = name;
            this.flagSource = flagSource;
        }
    }
}
