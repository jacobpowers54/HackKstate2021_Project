/* UserInterface.cs
 * Author: Jacob Powers
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ksu.Cis300.NameLookup;

namespace HackKstate2021_Project
{
    public partial class UserInterface : Form
    {
        //On Start
        public UserInterface()
        {
            InitializeComponent();
            uxTextBox.Text = "Welcome to my Hack! In this game you will read a story that is effected by your decisions. To begin, simply go down the first path.";
            uxPathTwo.Enabled = false;
            uxPathThree.Enabled = false;
        }

        /// <summary>
        /// A string[] that stores the collected gear (strings) by the player
        /// </summary>
        private string[] _gear = new string[10];

        /// <summary>
        /// An int to keep track of gear
        /// </summary>
        private int _gearCount = 0;

        /// <summary>
        /// An array that holds the contents of the file that was read
        /// 0: The Text for the TextBox
        /// 1-3: The String that contains the filename for the path
        /// 4-6: Sets the enabled property for the Path Buttons
        /// 7: Checks to see if the player won
        /// 8: An item
        /// 9:Wheither a choice requires an item or not
        /// 10: Wheither this path is a checkpoint or not
        /// </summary>
        private string[] _elements = new string[11];

        /// <summary>
        /// The current path the player is on
        /// </summary>
        public string currPath = "GameStart.txt";

        /// <summary>
        /// A string the contains the file name if path one is chosen
        /// </summary>
        public string path1 = "Level_0.txt";

        /// <summary>
        /// A string the contains the file name if path two is chosen
        /// </summary>
        public string path2;

        /// <summary>
        /// A string the contains the file name if path two is chosen
        /// </summary>
        public string path3;

        /// <summary>
        /// Saves current information at the checkpoint
        /// </summary>
        public CheckPoint checkPoint;


        /// <summary>
        /// Updates the TextBox with the choice the player made.
        /// </summary>
        /// <param name="choice">An int telling what path the player choose</param>
        public void UpdateText()
        {
            uxTextBox.Text = _elements[0];
            uxGearTB.Clear();
            for (int i = 0; i < _gear.Length; i++)
            {
                if (_gear[i] != null)
                {
                    uxGearTB.Text += _gear[i] + ", ";
                }
            }
        }

        /// <summary>
        /// Updates the Path Buttons Enabled Property
        /// </summary>
        public void UpdateEnabled()
        {
            if (_elements[4] == "true")
            {
                uxPathOne.Enabled = true;
            }
            else
            {
                uxPathOne.Enabled = false;
            }
            if (_elements[5] == "true")
            {
                uxPathTwo.Enabled = true;
            }
            else
            {
                uxPathTwo.Enabled = false;
            }
            if (_elements[6] == "true")
            {
                uxPathThree.Enabled = true;
            }
            else
            {
                uxPathThree.Enabled = false;
            }
            if (_elements[9] != "none")
            {
                for (int i = 0; i < _gear.Length; i++)
                {
                    if (_elements[9] == _gear[i])
                    {
                        uxPathThree.Enabled = true;
                    }
                }
            }
        }

        /// <summary>
        /// Updates the Array that stores all of the information
        /// Updates private path fields
        /// </summary>
        /// <param name="fileName"></param>
        public void UpdateArr(string fileName)
        {
            using (StreamReader input = new StreamReader(fileName))
            {
                int count = 0;
                while (!input.EndOfStream)
                {
                    string line = input.ReadLine();
                    _elements[count] = line;
                    count++;
                }
            }
            path1 = _elements[1];
            path2 = _elements[2];
            path3 = _elements[3];
            if (_elements[8] != "none")
            {
                _gear[_gearCount] = _elements[8];
                _gearCount++;
            }
        }

        /// <summary>
        /// Checks to see if the player has won the game
        /// </summary>
        public void CheckWin()
        {
            if (_elements[7] == "true")
            {
                MessageBox.Show("You Win! Thanks for playing this Hack!");
                UpdateArr("GameStart.txt");
                UpdateText();
                UpdateEnabled();
                uxGearTB.Clear();
            }
            else if (_elements[7] == "lose")
            {
                uxGearTB.Clear();
                MessageBox.Show("You Lose! Thanks for playing this Hack! If you would like to continue, hit OK");
                currPath = checkPoint.path;
                UpdateArr(currPath);
                checkPoint.checkGear.CopyTo(_gear, 0);
                _gearCount = checkPoint.checkGearCount;
                UpdateText();
                UpdateEnabled();
            }
        }

        /// <summary>
        /// Checks if the path is a check point
        /// </summary>
        public void CheckCheckPoint()
        {
            if (_elements[10] == "yes")
            {
                checkPoint = new CheckPoint(currPath, _gear, _gearCount);
            }
        }

        /// <summary>
        /// Handles an event when "Path One..." is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPathOne_Click(object sender, EventArgs e)
        {
            currPath = path1;
            UpdateArr(path1);
            UpdateText();
            UpdateEnabled();
            CheckCheckPoint();
            CheckWin();
        }

        /// <summary>
        /// Handles an event when "Path Two..." is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPathTwo_Click(object sender, EventArgs e)
        {
            currPath = path2;
            UpdateArr(path2);
            UpdateText();
            UpdateEnabled();
            CheckCheckPoint();
            CheckWin();
        }

        /// <summary>
        /// Handles an event when "Path Three..." is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPathThree_Click(object sender, EventArgs e)
        {
            currPath = path3;
            UpdateArr(path3);
            UpdateText();
            UpdateEnabled();
            CheckCheckPoint();
            CheckWin();
        }
    }
}
