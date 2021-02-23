/// created by : 
/// date       : 
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;  

        // random number generator

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                else if (scene == 0) { }
                else if (scene == 1) { }
                else if (scene == 2) { }
                else if (scene == 3) { }
                else if (scene == 4) { }
                else if (scene == 5) { }
                else if (scene == 6) { }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                else if (scene == 0) { }
                else if (scene == 1) { }
                else if (scene == 2) { }
                else if (scene == 3) { }
                else if (scene == 4) { }
                else if (scene == 5) { }
                else if (scene == 6) { }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    break;
                case 1:   
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                default:
                    break;
            }
        }
    }
}
