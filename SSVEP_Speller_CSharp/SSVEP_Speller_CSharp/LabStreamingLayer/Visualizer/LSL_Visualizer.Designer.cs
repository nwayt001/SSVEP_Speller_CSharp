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
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            Text = "LSL_Visualizer";

            visMainPlot = new PlotView();
            visMainPlot.Location = new Point(0, 0);
            visMainPlot.Name = "gtecMainPlot";
            visMainPlot.PanCursor = Cursors.Hand;
            visMainPlot.Size = new Size(900, 900);
            visMainPlot.TabIndex = 0;
            visMainPlot.Text = "mainPlotView";
            visMainPlot.ZoomHorizontalCursor = Cursors.SizeWE;
            visMainPlot.ZoomRectangleCursor = Cursors.SizeNWSE;
            visMainPlot.ZoomVerticalCursor = Cursors.SizeNS;
            AutoScaleDimensions = new SizeF(6f, 13f);
            ClientSize = new Size(900, 900);
            Controls.Add(this.visMainPlot);
            ResumeLayout(false);
        }

        #endregion
    }
}