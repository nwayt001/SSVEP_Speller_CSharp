using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SSVEP_Speller_CSharp.LabStreamingLayer.Visualizer;

namespace SSVEP_Speller_CSharp.Forms
{
    public partial class MainForm : Form
    {
        #region Fields
        // ui forms
        public ConfigUI config;
        public LSL_Visualizer visualizer;
        #endregion Fields


        public MainForm()
        {
            InitializeComponent();
        }

        //Callback for quit button
        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close out application
            
        }

        //Callback for configuration button
        private void configBtn_Click(object sender, EventArgs e)
        {
            config = new ConfigUI();
            config.Show();
            
        }

        //Callback for the visualizer button
        private void visualizeBtn_Click(object sender, EventArgs e)
        {
            visualizer = new LSL_Visualizer();
            visualizer.Show();
        }

        //Callback for the start button
        private void startBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
