using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alluvion_Moon_Base_Alpha
{
    public partial class FormMain : Form
    {
        // Objects created from classes Labeled for each room
        // 
        ClassArea LivingQuarters = new ClassArea();
        ClassArea Research_Area = new ClassArea();
        ClassArea ObservationDeck = new ClassArea();
        ClassArea CafeteriaArea = new ClassArea();
        ClassArea MedArea = new ClassArea();
        ClassArea LQ = new ClassArea();
        public object ResearchArea { get; private set; }

        public FormMain()

        {
            InitializeComponent();
            /// <summary>
            /// Below is the associated objects for each created class. These instances changed the text within area name
            /// and description of the specified area.
            /// </summary>
            LivingQuarters.AreaName = "Living Quarters";
            LivingQuarters.AreaDescription = "Welcome astronaut! My name is Shanisa Labrida," +
                " I will be your base trainer to help you onboard at Alluvion." +
                " This is Captain Chris Dorranbarn, he leads the missions on Alluvion." +
                " Beyond the Kuiper Belt, the search for habitable planets is underway!" +
                " Alluvion Moonbase Alpha provides a safe enviornment for the top astrologists and scientist to find water" +
                " bearing planets beyond the Solar System. I will take you on a self-guided tour as you explore what we have" +
                " to offer at Alluvion MoonBase. I know you were briefed before you arrived, but nothing beats the real tour!" +
                " Alluvion is our hope for new Goldie Lox planets to expand the human race!" +
                " When you are ready, utilize the navigation to begin the base tour.";

            Research_Area.AreaName = "Research Area";
            Research_Area.AreaDescription = "The Research Area is a scientist dream! With the drone data collected" +
                " we are able to analyze solar systems and the planets within to identify ideal planets" +
                " for future expeditions. We utilize holographic technology to mitigate the need for extensive" +
                " montior repaclement. We are able to splice the planets data to identify planetary composition" +
                " down to the core. We can identify molecular structure to an overall percentage based on difficulty" +
                " to obtain and the ecosystem qualities needed for human survival. Have a look around, continue the" +
                " tour when you are ready.";

            ObservationDeck.AreaName = "Observation Deck";
            ObservationDeck.AreaDescription = "The Observation deck was installed to provide a picture perfect view of" +
                " Lola Snow, the first planet located by Capt. Dorranbarn. As you know there are now 2 billion people" +
                " habitating Lola snow, in fact you are the first crew member joining us from that very planet! This marks" +
                " a huge milestone for our team on Alluvion! The glass is re-enforced and has UV protection so we do not" +
                " require any eye protection. Enjoy the views, contiune the tour when you are ready!";

            CafeteriaArea.AreaName = "Cafeteria Area";
            CafeteriaArea.AreaDescription = "The Cafeteria provides you with Three meals a day. Each meal has" +
                " specifically identified nutrients each astronaut requires, based on the data submitted to mission control." +
                " You were prepared for this diet a year in advance to ensure no adverse reactions occured when you made" +
                " the move to Alluvion. Your watch will assign the ideal time for each meal to be consumed for maximum" +
                " energy production. Our consumption regulation system means we all live longer and preserve more" +
                " resources in the process. When you are ready, continue the tour.";

            MedArea.AreaName = "Medical Area";
            MedArea.AreaDescription = "Our base Medical Area has all the supplies you need in case of an" +
                " emergency situation. You were provided with extensive medical training to assist when the time" +
                " arises. Everyone on Alluvion is capable of performing basic surgical procedures that will allow the flight" +
                " crew time to prepare for transportation to Lola Snow for severe circumstances. Your training will include" +
                " simulations to ensure you are capable of executing the emergency protocols aligned with your training" +
                "on Lola Snow.";

            LQ.AreaName = "Living Quarters";
            LQ.AreaDescription = "Welcome back to the Living Quarters!" +
                " Don't forget to maintain cleanliness after utilizing a sleeping pod," +
                " as this is shared space amongst the Alluvion crew." +
                " You can relax or continue the tour from the Alluvion Navigation Menu.";



            /// Area name is refenced to create object and class
            TextBoxAreaName.Text = LivingQuarters.AreaName;
            /// <summary>
            /// Area name is refenced to create object and class
            /// The names are anagrams of Sirisha Bandla and Richard Branson, who are used in the picture.
            /// </summary>
            TextBox_Area_Description.Text = LivingQuarters.AreaDescription;
            /// change the image in Area Information groupbox
            PictureBoxMain.Image = Properties.Resources.mainIntro;

        }
        /// This code handles the event of the user navigating North
        private void ButtonNorth_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// When North Nav button is pressed 
            /// Area name is refenced to create object and class
            /// </summary>
            TextBoxAreaName.Text = Research_Area.AreaName;
            /// <summary>
            /// Area description is refenced to create object and class
            ///</summary>
            TextBox_Area_Description.Text = Research_Area.AreaDescription;
            /// <summary>
            /// Change the area background
            /// </summary>
            this.BackgroundImage = Properties.Resources.Research_area;
            /// <summary>
            /// change the image in Area Information groupbox
            /// </summary>
            PictureBoxMain.Image = Properties.Resources.siren_research;
        }
        private void ButtonLQ_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// When North Nav button is pressed 
            /// Area name is refenced to create object and class
            /// </summary>
            TextBoxAreaName.Text = LQ.AreaName;
            /// <summary>
            /// Area description is refenced to create object and class
            ///</summary>
            TextBox_Area_Description.Text = LQ.AreaDescription;
            ///<summary>
            /// Change the area background
            /// </summary>
            this.BackgroundImage = Properties.Resources.living_quarters;
            PictureBoxMain.Image = Properties.Resources.siren_living_quarters;
        }

        private void ButtonEast_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// When North Nav button is pressed 
            /// Area name is refenced to create object and class
            /// </summary>
            TextBoxAreaName.Text = CafeteriaArea.AreaName;
            /// <summary>
            /// Area description is refenced to create object and class
            ///</summary>
            TextBox_Area_Description.Text = CafeteriaArea.AreaDescription;
            ///<summary>
            /// Change the area background
            /// </summary>
            this.BackgroundImage = Properties.Resources.Cafeteria;
            /// change the image in Area Information groupbox
            /// </summary>
            PictureBoxMain.Image = Properties.Resources.siren_cafeteria;

        }
        private void ButtonSouth_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// When North Nav button is pressed 
            /// Area name is refenced to create object and class
            /// </summary>
            TextBoxAreaName.Text = ObservationDeck.AreaName;
            /// <summary>
            /// Changes the area Description. Area description is refenced to create object and class. Planet name is Richard Branson's first daughter's name.
            ///</summary>
            TextBox_Area_Description.Text = ObservationDeck.AreaDescription;
            ///<summary>
            /// Change the area background
            /// </summary>
            this.BackgroundImage = Properties.Resources.Observation_area;
            /// change the image in Area Information groupbox
            /// </summary>
            PictureBoxMain.Image = Properties.Resources.Siren_launch;
        }
        private void ButtonWest_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// When North Nav button is pressed 
            /// Area name is refenced to create object and class
            /// </summary>
            TextBoxAreaName.Text = MedArea.AreaName;
            /// <summary>
            /// Area description is refenced to create object and class
            ///</summary>
            TextBox_Area_Description.Text = MedArea.AreaDescription;
            ///<summary>
            /// Change the area background
            /// </summary>
            this.BackgroundImage = Properties.Resources.Med_area;
            /// change the image in Area Information groupbox
            /// </summary>
            PictureBoxMain.Image = Properties.Resources.siren_med;
        }

        private void radioButtonTaskComplete_CheckedChanged(object sender, EventArgs e)
        {

            /// Radio button created when tasks are completed the if statement returns a message Tasks are Complete!
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                MessageBox.Show("Tasks are Complete!");
                return;
            }
        }
    }
}