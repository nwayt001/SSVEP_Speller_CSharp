using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Drawing;
using System.Windows.Forms;
namespace SSVEP_Speller_CSharp.LabStreamingLayer.Visualizer
{
    partial class LSL_Visualizer
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
            this.visMainPlot = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // visMainPlot
            // 
            this.visMainPlot.Location = new System.Drawing.Point(0, 0);
            this.visMainPlot.Name = "visMainPlot";
            this.visMainPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.visMainPlot.Size = new System.Drawing.Size(900, 900);
            this.visMainPlot.TabIndex = 0;
            this.visMainPlot.Text = "mainPlotView";
            this.visMainPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.visMainPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.visMainPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // LSL_Visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 900);
            this.Controls.Add(this.visMainPlot);
            this.Name = "LSL_Visualizer";
            this.Text = "LSL_Visualizer";
            this.Load += new System.EventHandler(this.LSL_Visualizer_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}