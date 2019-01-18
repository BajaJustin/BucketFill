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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Able to share code through out the project
/// </summary>
namespace Lab5a
{
    /// <summary>
    /// The main entry for the application
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
