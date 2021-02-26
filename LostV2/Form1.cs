/// created by : Jacob Boyd
/// date       : Feb 6
/// teacher    : Mr Theodropolis 
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
using System.Media;
using System.Threading;


namespace LostV2
{
    public partial class Form1 : Form
    {
        int scene = 0;
        Random randGen = new Random();
        SoundPlayer scratching = new SoundPlayer(Properties.Resources.scratching);
        SoundPlayer loudScratching = new SoundPlayer(Properties.Resources.louderScratchingShort);
        SoundPlayer windowBreak = new SoundPlayer(Properties.Resources.windowBreak);
        SoundPlayer brakes = new SoundPlayer(Properties.Resources.brakes);
        SoundPlayer deathNoise = new SoundPlayer(Properties.Resources.death_noise);
        SoundPlayer jailCell = new SoundPlayer(Properties.Resources.jailCell);
        SoundPlayer ratSqueak = new SoundPlayer(Properties.Resources.ratSqueak);
        SoundPlayer arrival = new SoundPlayer(Properties.Resources.arrival_noise);
        SoundPlayer metal = new SoundPlayer(Properties.Resources.metal);
        SoundPlayer horn = new SoundPlayer(Properties.Resources.horn)
       public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.A)       //Option A
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 4; }
                else if (scene == 2) { scene = 5; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 4) { scene = 0; }
                else if (scene == 5) { scene = 7; }
                else if (scene == 6) { scene = 0; }
                else if (scene == 7) { scene = 0; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 9) { scene = 11; }

                else if (scene == 10)
                {
                    int chance = randGen.Next(1, 11);
                    if (chance == 10) { scene = 16; }
                    else { scene = 13; }
                }

                else if (scene == 11) { scene = 0; }

                else if (scene == 12)
                {
                    {
                        int chance = randGen.Next(1, 11);
                        if (chance == 10) { scene = 16; }
                        else { scene = 13; }
                    }
                }

                else if (scene == 13) { scene = 0; }
                else if (scene == 14) { scene = 0; }
                else if (scene == 15) { scene = 17; }
                else if (scene == 16) { scene = 20; }
                else if (scene == 17) { scene = 20; }
                else if (scene == 18) { scene = 19; }
                else if (scene == 19) { scene = 0; }
                else if (scene == 20) { scene = 0; }
                else if (scene == 21) { scene = 0; }
                else if (scene == 22) { scene = 0; }
            }

            else if (e.KeyCode == Keys.D)  //Option B
            {
                if (scene == 0) { scene = 2; }
                else if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 3) { scene = 6; }
                else if (scene == 4) { this.Close(); }
                else if (scene == 5) { scene = 8; }
                else if (scene == 6) { this.Close(); }
                else if (scene == 7) { this.Close(); }
                else if (scene == 8) { scene = 10; }
                else if (scene == 9) { scene = 12; }

                else if (scene == 10)
                {
                    int chance = randGen.Next(1, 11);
                    if (chance == 1) { scene = 14; }
                    else { scene = 15; }
                }

                else if (scene == 11) { this.Close(); }

                else if (scene == 12)
                {
                    {
                        int chance = randGen.Next(1, 11);
                        if (chance == 1) { scene = 14; }
                        else { scene = 15; }
                    }
                }

                else if (scene == 13) { this.Close(); }
                else if (scene == 14) { this.Close(); }
                else if (scene == 15) { scene = 18; }
                else if (scene == 16) { scene = 22;  }
                else if (scene == 17) { scene = 22; }
                else if (scene == 18) { scene = 19; }
                else if (scene == 19) { this.Close(); }
                else if (scene == 20) { this.Close(); }
                else if (scene == 21) { this.Close(); }
                else if (scene == 22) { this.Close(); }
            }
            else if (e.KeyCode == Keys.S)
            {
                if (scene == 16) { scene = 21; }
                else if (scene == 17) { scene = 21; }
            }

                /// Display text and game options to screen based on the current scene
                switch (scene)
            {
                case 0:
                    outputLabel.Text = $"You are riding the subway by yourself, on your way home from work when a rat jumps up on the seat next to yours.\n\nDo you move seats or shoo the rat away?";
                    option1Label.Text = "Move seats";
                    option2Label.Text = "Shoo away the rat";
                    this.BackgroundImage = Properties.Resources.scene_0_2_3_9;
                    Refresh();
                    break;
                case 1:
                    outputLabel.Text = $"The rat scampers around and you eye it carefully from across the aisle. A second joins the first on the seat across from you, but it's eyes seem to be fixated on you.\n\nDo you ignore the rats or shoo them away?";
                    option1Label.Text = "Ignore the rats";
                    option2Label.Text = "Shoo them away";
                    this.BackgroundImage = Properties.Resources.scene_1;
                    
                    Refresh();
                    break;
                case 2:
                    scratching.Play();
                    outputLabel.Text = $"The rat runs off down the subway car and disappears. Shortly after you hear a scratching noise coming from behind your head.\n\nDo you inspect the panel behind your seat or continue to do nothing?";
                    option1Label.Text = "Inspect the pannel";
                    option2Label.Text = "Do nothing";
                    this.BackgroundImage = Properties.Resources.scene_0_2_3_9;

                    Refresh();
                    break;
                case 3:
                    loudScratching.Play();
                    outputLabel.Text = $"The noise get so loud that it sounds like the panel is going to burst. Do you inspect the panel behind your seat or continue to do nothing?";
                    option1Label.Text = "Inspect the pannel";
                    option2Label.Text = "Do nothing";
                    this.BackgroundImage = Properties.Resources.scene_0_2_3_9;
                    Refresh();
                    break;
                case 4:
                    outputLabel.Text = $"You and the rats sit in peace for the rest of the subway ride and you arrive at your destination.\n\nGame Over\n\nPlay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    Refresh();
                    break;
                case 5:
                    outputLabel.Text = $"You pull the panel off the side of the subway car. There's nothing but wires and electronics, the car is now dead silent.\n\nDo you put the pannel back on the wall or leave it off and sit back down?";
                    option1Label.Text = "Put the pannel back on the wall";
                    option2Label.Text = "Leave the pannel off and sit back down";
                    this.BackgroundImage = Properties.Resources.scene_5;
                    Refresh();
                    break;
                case 6:
                    metal.Play();
                    outputLabel.Text = $"By some unknown force the panel flies off the wall into the back of your head, rendering you unconscious.\n\nGame Over\n\nPlay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    this.BackgroundImage = Properties.Resources.scene_0_2_3_9;
                    Refresh();
                    break;
                case 7:
                    deathNoise.Play();
                    outputLabel.Text = $"After putting the panel back you turn around and face a horde of rats standing stock still. They cover the entire subway car and when you move to get away they pounce. Killing you with no witnesses.\n\nGame Over\n\nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    this.BackgroundImage = Properties.Resources.scene_7_8;
                    Refresh();
                    break;
                case 8:
                    ratSqueak.Play();
                    outputLabel.Text = $"You turn around and face a horde of rats standing stock still. Your instincts tell you to grab hold of the metal panel.\n\nDo you hold up the pannel in defense or throw it at the rats?";
                    option1Label.Text = "Defend with the pannel";
                    option2Label.Text = "Throw it at the rats";
                    this.BackgroundImage = Properties.Resources.scene_7_8;
                    Refresh();
                    break;
                case 9:
                    ratSqueak.Play();
                    outputLabel.Text = $"You manage to block the first swarm of rats buying you some time but more quickly latch on your ankles.\n\nDo you attempt to kill the remaining rats or look for a way out?";
                    option1Label.Text = "Try to kill the rats";
                    option2Label.Text = "Look for a way out";
                    this.BackgroundImage = Properties.Resources.scene_0_2_3_9;
                    Refresh();
                    break;
                case 10:
                    ratSqueak.Play();
                    outputLabel.Text = $"The horde backs off, almost absorbing your feeble attempt, but it buys you some time.\n\nYou scan the cramped subway car for an escape. You have 2 options, break the window and jump out of a moving subway car or attempt to run to the next car in search of other people.\n\nWhich do you pick?";
                    option1Label.Text = "Break Window";
                    option2Label.Text = "Run to the next car";
                    this.BackgroundImage = Properties.Resources.scene_0_2_3_9;
                    Refresh();
                    break;
                case 11:
                    deathNoise.Play();
                    outputLabel.Text = $"You try to kill the remaining rats but they overpower you, eating at your flesh while you suffocate from their sheer volume.\n\nGame Over\n\n Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    this.BackgroundImage = Properties.Resources.scene_7_8;
                    Refresh();
                    break;
                case 12:
                    outputLabel.Text = $"You scan the cramped subway car for an escape. You have 2 options, break the window and jump out of a moving subway car, attempt to run to the next car in search of other people.\n\nWhich do you pick?";
                    option1Label.Text = "Break Window";
                    option2Label.Text = "Run to the next car";
                    this.BackgroundImage = Properties.Resources.scene_0_2_3_9;
                    Refresh();
                    break;
                case 13:
                    windowBreak.Play();
                    outputLabel.Text = $"You jump out the window and crack your skull open on the tracks.\n\n Game Over \n\n Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    this.BackgroundImage = Properties.Resources.scene_13;
                    Refresh();
                    break;
                case 14:
                    deathNoise.Play();
                    outputLabel.Text = $"You trip and fall, the rats overpower you eating at your flesh while you suffocate from their sheer volume.\n\nGame Over\n\n Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    this.BackgroundImage = Properties.Resources.scene_7_8;
                    Refresh();
                    break;
                case 15:
                    outputLabel.Text = $"You make it to the next car and slam the door behind you. You're safe from the rats for now. You look to the floor and realize that the other passengers have been killed and are covered in bite marks. The rats have almost broke through the door.\n\nDo you hide with the bodies or go to the driver's compartment to stop the train";
                    option1Label.Text = "Go into the driver's conpartment";
                    option2Label.Text = "Hide with the bodies";
                    this.BackgroundImage = Properties.Resources.scene_15__18;
                    Refresh();
                    break;
                case 16:
                    windowBreak.Play();
                    outputLabel.Text = $"Miraculously you escape. You run as fast as you can and come to a 3 way crossroad.\n\nWhich direction do you pick?";
                    option1Label.Text = "Left";
                    option2Label.Text = "Straight";
                    option3Label.Visible = true;
                    label3.Visible = true;
                    option3Label.Text = "Right";
                    this.BackgroundImage = Properties.Resources.scene_16_22;
                    Refresh();
                    break;
                case 17:
                    brakes.Play();
                    outputLabel.Text = $"You enter the drivers compartment and pull the emergency break lever. You leave the train and run as fast as you can. You quickly come across a 3 way crossroad.\n\nWhich direction do you pick?";
                    option1Label.Text = "Left";
                    option2Label.Text = "Straight";
                    option3Label.Visible = true;
                    label3.Visible = true;
                    option3Label.Text = "Right";
                    this.BackgroundImage = Properties.Resources.scene_16_22;
                    Refresh();
                    break;
                case 18:
                    outputLabel.Text = $"You close your eyes and lay unmoving, waiting for the swarm to wash over you, but they never do.\n\nDo you continue to lay there or get up?";
                    option1Label.Text = "Get up";
                    option2Label.Text = "Lay there";
                    this.BackgroundImage = Properties.Resources.scene_15__18;
                    Refresh();
                    break;
                case 19:
                    arrival.Play();
                    Thread.Sleep(1000);
                    jailCell.Play();
                    outputLabel.Text = $"You hear a ding and the doors open. You've made the next stop. You get out of the train and pass out on the platform.\n\nYou wake up in handcuffs and a man in a uniform tells you you're being tried for the murder of 12 people. The court deems you mentally insane and images of rats traumatize you in your jail cell.\n\nGame Over \n\nPlay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    this.BackgroundImage = Properties.Resources.scene_19;
                    Refresh();
                    break;
                case 20:
                    outputLabel.Text = $"You turn left and follow the tunnel for what feels like hours. Eventually light hits your eyes and you come across a subway platform. A passerby helps you off the tracks and calls an ambulance. At the hospital no one believes your story but they fix you up.After a few days you're released and back to normal. Though you vow never to take the subway again.\n\nGame Over\n\nPlay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    label3.Visible = false;
                    this.BackgroundImage = Properties.Resources.scene_20;
                    Refresh();
                    break;
                case 21:
                    horn.Play();
                    outputLabel.Text = $"You continue straight. Light begins to creep around the corner of the tunnel, a subway platform? Nope. The cold hard steel of a subway train smashes you into a million pieces.\n\nGame Over\n\nPlay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    label3.Visible = false;
                    this.BackgroundImage = Properties.Resources.scene_21;
                    Refresh();
                    break;
                case 22:
                    outputLabel.Text = $"You turn right and follow the tunnel. After hours of exhaustion you break your ankle on an unknown object shrouded in darkness. Unable to continue you breakdown and wait for the unavoidable death by subway train that comes for you.\n\nGame Over\n\nPlay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Visible = false;
                    label3.Visible = false;
                    this.BackgroundImage = Properties.Resources.scene_16_22;
                    Refresh();
                    break;
                default:
                    break;
            }
        }
    }
}
