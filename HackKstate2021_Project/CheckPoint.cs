/* CheckPoint.cs
 * Author: Jacob Powers
 */
using Ksu.Cis300.NameLookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackKstate2021_Project
{
    public class CheckPoint
    {
        /// <summary>
        /// Gear at the checkpoint
        /// </summary>
        public string[] checkGear = new string[10];

        /// <summary>
        /// Gear Count at the checkpoint
        /// </summary>
        public int checkGearCount;

        /// <summary>
        /// The Path of the checkpoint
        /// </summary>
        public string path;

        /// <summary>
        /// Constructs a new CheckPoint
        /// </summary>
        /// <param name="pathName"></param>
        /// <param name="gear"></param>
        /// <param name="gearCount"></param>
        public CheckPoint(string pathName, string[] gear, int gearCount)
        {
            path = pathName;
            gear.CopyTo(checkGear, 0);
            checkGearCount = gearCount;
        }
    }
}
