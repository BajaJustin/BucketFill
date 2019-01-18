/*
 * Author: Justin Baja
 * Student Number: 000356032
 * File Date: Friday December 7, 2018
 * Programs Purpose: This class handles the properties and form desgin
 * Statement of Authorship: I, Justin Baja, 000356032 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement.
 */

/// <summary>
/// Able to share code through out the project
/// </summary>
namespace Lab5a
{
    /// <summary>
    /// This class handles the properties / form 
    /// </summary>
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colourButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.waterTimer = new System.Windows.Forms.Timer(this.components);
            this.waterControlTrackBar = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.faucet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.waterControlTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faucet)).BeginInit();
            this.SuspendLayout();
            // 
            // colourButton
            // 
            this.colourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourButton.Location = new System.Drawing.Point(50, 12);
            this.colourButton.Name = "colourButton";
            this.colourButton.Size = new System.Drawing.Size(104, 30);
            this.colourButton.TabIndex = 0;
            this.colourButton.Text = "Colour";
            this.colourButton.UseVisualStyleBackColor = true;
            this.colourButton.Click += new System.EventHandler(this.colourButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(178, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(104, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // waterTimer
            // 
            this.waterTimer.Tick += new System.EventHandler(this.waterTimer_Tick);
            // 
            // waterControlTrackBar
            // 
            this.waterControlTrackBar.Location = new System.Drawing.Point(50, 66);
            this.waterControlTrackBar.Name = "waterControlTrackBar";
            this.waterControlTrackBar.Size = new System.Drawing.Size(158, 56);
            this.waterControlTrackBar.TabIndex = 2;
            this.waterControlTrackBar.Scroll += new System.EventHandler(this.waterControl_Scroll);
            // 
            // faucet
            // 
            this.faucet.Image = ((System.Drawing.Image)(resources.GetObject("faucet.Image")));
            this.faucet.Location = new System.Drawing.Point(50, 128);
            this.faucet.Name = "faucet";
            this.faucet.Size = new System.Drawing.Size(144, 79);
            this.faucet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.faucet.TabIndex = 3;
            this.faucet.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(460, 459);
            this.Controls.Add(this.faucet);
            this.Controls.Add(this.waterControlTrackBar);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.colourButton);
            this.Name = "Form1";
            this.Text = "A Drop in the Bucket";
            ((System.ComponentModel.ISupportInitialize)(this.waterControlTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faucet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button colourButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Timer waterTimer;
        private System.Windows.Forms.TrackBar waterControlTrackBar;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox faucet;
    }
}

