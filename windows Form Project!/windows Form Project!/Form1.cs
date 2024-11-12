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
using System.Diagnostics;

namespace windows_Form_Project_
{    
    public partial class Form1 : Form
    {      
        string[] theStory;
        int pointer = 1;        

        Button TrainStrength;
        Button TrainIntellegence;
        Button HuntForFood;
        Button GatherHerbs;

        Random r = new Random();
        public Form1()
        {
            InitializeComponent();

            theStory = File.ReadAllLines("Story.txt");

            label1.Text = theStory[0];


            


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(pointer<theStory.Length)
            {
                label1.Text = theStory[pointer];
                pointer++;
            }
            if (pointer == 29)
            {
                TrainStrength = new Button();
                TrainStrength.Size = new Size(50, 50);
                TrainStrength.Location = new Point(450, 450);
                TrainStrength.Text = "Train Your Strength";
                this.Controls.Add(TrainStrength);
                TrainStrength.Click += Strength;

                int strength = r.Next(1, 6);

                TrainIntellegence = new Button();
                TrainIntellegence.Size = new Size(50, 50);
                TrainIntellegence.Location = new Point(450, 510);
                TrainIntellegence.Text = "Read a Book";
                this.Controls.Add(TrainIntellegence);
                TrainIntellegence.Click += Intellegence;

                int intellegence = r.Next(1, 6);

                HuntForFood = new Button();
                HuntForFood.Size = new Size(50, 50);
                HuntForFood.Location = new Point(450, 570);
                HuntForFood.Text = "Hunt for food";
                this.Controls.Add(HuntForFood);
                HuntForFood.Click += Hunt;

                GatherHerbs = new Button();
                GatherHerbs.Size = new Size(50, 50);
                GatherHerbs.Location = new Point(450, 630);
                GatherHerbs.Text = "Gather herbs";
                this.Controls.Add(GatherHerbs);
                GatherHerbs.Click += GatherHerb;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (pointer <= theStory.Length)
            {
                pointer--;
                label1.Text = theStory[pointer];

            }
        }

        void Strength(object sender, EventArgs e)
        {

        }
        void Intellegence(object sender, EventArgs e)
        {

        }
        void Hunt(object sender, EventArgs e)
        {

        }
        void GatherHerb(object sender, EventArgs e)
        {

        }
    }
}
