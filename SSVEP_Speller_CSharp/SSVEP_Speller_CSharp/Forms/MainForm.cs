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
        bool config_initialized = false;
        public bool KillApplication = false;
        #endregion Fields


        public MainForm()
        {
            InitializeComponent();
        }

        //Callback for quit button
        private void quitBtn_Click(object sender, EventArgs e)
        {
            KillApplication = true;
            Application.Exit(); // Close out application
            
        }

        //Callback for configuration button
        private void configBtn_Click(object sender, EventArgs e)
        {
            config_initialized = true;
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
            if(config_initialized)
                this.Close();
            else
            {
                MessageBox.Show("Configuration not set! Please press 'Config' Button.");
            }
        }
    }
}
