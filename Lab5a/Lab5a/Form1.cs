/*
 * Author: Justin Baja
 * Student Number: 000356032
 * File Date: Friday December 7, 2018
 * Programs Purpose: Creates a program that displays an animation of water filling a
 * bucket while the track bar is turned on.
 * Statement of Authorship: I, Justin Baja, 000356032 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement.
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

/// <summary>
/// Able to share code through out the project
/// </summary>
namespace Lab5a
{
    /// <summary>
    /// This class creates shapes which represent a Bucket and water, which make use
    /// of the trackbar that controls the flow of which the water fills the bucket. It
    /// also contains a feature which allows the user to change the color of water.
    /// </summary>
    public partial class Form1 : Form
    {
        // Encapsulates a GDI & acts as a drawing surface
        private Graphics g;

        // Pen is used to draw objects for water
        private Pen water;

        // Pen used to color bucket
        private Pen bucketColor;

        // used to fill in the bucket with water
        private SolidBrush waterFilling;

        // Used to fill in faucet water
        private SolidBrush black; 

        // Represents the water color, initially set to blue
        private Color waterColor = Color.LightBlue;

        // Used to represent the background color black
        private Color backgroundColor = Color.Black;

        // Represents the x axis of the bucket
        private int x = 101;

        // Represents the y axis of the bucket
        private int y = 355;

        // Represents the amount of water in the bucket
        private int amount = 5;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(form_Paint);
        }

        /// <summary>
        /// Closes the application when button is clicked
        /// </summary>
        /// <param name="sender">reference to the control/object that raised the event</param>
        /// <param name="e">contains the event data</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// When clicked, allows user to see their previous colour and change it to a 
        /// new colour of water
        /// </summary>
        /// <param name="sender">reference to the control/object that raised the event</param>
        /// <param name="e">contains the event data</param>
        private void colourButton_Click(object sender, EventArgs e)
        {
            // Display with the previous colour already choisen
            colorDialog.Color = waterColor;
            // Display the actual dialog box
            colorDialog.ShowDialog();
            // Save the colour the user choose
            waterColor = colorDialog.Color;

        }

        /// <summary>
        /// Creates Pens for bucket and water color, and also creates the bucket
        /// </summary>
        /// <param name="sender">reference to the control/object that raised the event</param>
        /// <param name="e">contains the event data</param>
        private void form_Paint(object sender, PaintEventArgs e)
        {
            // Get the Graphics object from the PaintEventArgs
            g = e.Graphics;
            // Create a new Pen using the current colour chosen
            water = new Pen(waterColor);
            // Create a new Pen to colour the bucket
            bucketColor = new Pen(Color.White, 2);
            // Create a new brush using the current colour
            waterFilling = new SolidBrush(waterColor);
            // Create a new brush of color black
            black = new SolidBrush(backgroundColor);

            // Draws the bucket
            g.DrawLine(bucketColor, 250, 360, 100, 360);
            g.DrawLine(bucketColor, 250, 200, 250, 360);
            g.DrawLine(bucketColor, 100, 200, 100, 360);

        }

        /// <summary>
        /// Controls the speed of which the water flows at
        /// </summary>
        /// <param name="sender">reference to the control/object that raised the event</param>
        /// <param name="e">contains the event data</param>
        private void waterControl_Scroll(object sender, EventArgs e)
        {
            waterTimer.Enabled = true;
            waterTimer.Interval = 1100 - waterControlTrackBar.Value * 100;

            if( amount > 150 )
            {
                // Clears the water from the bucket
                this.Invalidate();
                // Reset the starting position of the water
                y = 355;
                amount = 5;

            }
        }

        /// <summary>
        /// Creates the animation of water filling the bucket while the
        /// tap is on.Once full the water shuts off and waits for the user
        /// to reset the water by bringing the track bar to 0
        /// </summary>
        /// <param name="sender">reference to the control/object that raised the event</param>
        /// <param name="e">contains the event data</param>
        private void waterTimer_Tick(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            // Draws the water starting from the bottom of the bucket
            g.FillRectangle(waterFilling, x, y, 148, amount);
            // Draws the water coming from the faucet
            g.FillRectangle(waterFilling, 121, 160, 20, 200);
            // Increase the speed of which the water flows
            amount += waterControlTrackBar.Value;
            y -= waterControlTrackBar.Value;

            if (amount >= 150)
            {
                amount = 155;
                y = 205;
                // Reset the track bar
                waterControlTrackBar.Value = 0;
                // Turn off the timer
                waterTimer.Enabled = false;
                // Hides the water coming from the faucet
                g.FillRectangle(black, 121, y-45, 20, 55);
            }
            if (waterControlTrackBar.Value == 0)
            {
                // Hides the water coming from the faucet
                g.FillRectangle(black, 121, 160 - amount, 20, 200);
            }
        }
    }
}
