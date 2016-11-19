using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using LSLlib;

namespace SSVEP_Speller_CSharp.LabStreamingLayer.Visualizer
{
    public partial class LSL_Visualizer : Form
    {
        private const int CHUNK_SIZE = 250;

        private System.Timers.Timer timer;

        private liblsl.StreamInlet inlet;

        private liblsl.StreamInfo[] results;

        private float[,] chunk;

        private double[] timestamps = new double[250];

        private float[] sample;

        private int channelCount;

        private Vis_Data visData;

        private Vis_WorkerThread visWorkerThread;

        private PlotView visMainPlot;

        public LSL_Visualizer()
        {
            this.results = liblsl.resolve_stream("type", "EEG", 1, 5.0);
            if (this.results.Length < 1)
            {
                MessageBox.Show("No gTec Stream Found");
                Environment.Exit(0);
            }
            this.inlet = new liblsl.StreamInlet(this.results[0]);
            this.channelCount = this.results[0].channel_count();
            this.sample = new float[this.channelCount];
            this.chunk = new float[250, this.channelCount];
            this.visData = new Vis_Data();
            this.visWorkerThread = new Vis_WorkerThread(this.visData, this.channelCount);
            this.InitializeComponent();
            this.InitializeMainForm();
            this.visData.GtecMainPlot = this.visMainPlot;
            for (int i = 0; i < this.visData.GTEC_SAMPLE_BUFFER_SIZE; i++)
            {
                LineSeries[] visMainSeries = this.visData.visMainSeries;
                for (int j = 0; j < visMainSeries.Length; j++)
                {
                    visMainSeries[j].Points.Add(DataPoint.Undefined);
                }
            }
            for (int k = 0; k < 250; k++)
            {
                for (int l = 0; l < this.channelCount; l++)
                {
                    this.chunk[k, l] = 0f;
                }
            }
            new Thread(new ThreadStart(this.visWorkerThread.Run)).Start();
            this.timer = new System.Timers.Timer(5.0);
            this.timer.Elapsed += new ElapsedEventHandler(this.UpdateMainPlot);
            this.timer.Start();
        }

        private void UpdateMainPlot(object sender, ElapsedEventArgs args)
        {
            int num = this.inlet.pull_chunk(this.chunk, this.timestamps);
            if (num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    double arg_28_0 = this.timestamps[i];
                    for (int j = 0; j < this.channelCount; j++)
                    {
                        this.sample[j] = this.chunk[i, j]+(i*10);
                    }
                    if (this.sample[0] != 0f)
                    {
                        this.visWorkerThread.queue.Enqueue(this.sample);
                    }
                }
            }
        }

        private void InitializeMainForm()
        {
            PlotModel plotModel = new PlotModel
            {
                Title = "EEG Data",
                DefaultColors = OxyPalettes.Rainbow(this.channelCount).Colors,
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.BottomLeft,
                LegendMaxWidth = 900.0,
                LegendMaxHeight = 100.0
            };
            plotModel.Axes.Add(new LinearAxis
            {
                Key = "X Axis",
                Position = AxisPosition.Bottom,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dash,
                Title = "Time",
                TextColor = OxyColors.Transparent,
                Minimum = 0.0,
                Maximum = (double)this.visData.GTEC_SAMPLE_BUFFER_SIZE,
                IsPanEnabled = false,
                IsZoomEnabled = false
            });
            var tmp = new LinearAxis();
            tmp.AbsoluteMaximum = 1000;
            plotModel.Axes.Add(new LinearAxis
            {
                Key = "Y Axis",
                Position = AxisPosition.Left,
                AbsoluteMaximum = 1000,
                AbsoluteMinimum = -1000
            });
            this.visData.visMainSeries = new LineSeries[this.channelCount];
            for (int i = 0; i < this.channelCount; i++)
            {
                this.visData.visMainSeries[i] = new LineSeries
                {
                    LineStyle = LineStyle.Solid,
                    StrokeThickness = 1.0
                };
                plotModel.Series.Add(this.visData.visMainSeries[i]);
            }
            this.visMainPlot.Model = plotModel;
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && this.components != null)
        //    {
        //        this.components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private void InitializeComponent()
        //{
        //    this.visMainPlot = new PlotView();
        //    this.visMainPlot.Location = new Point(0, 0);
        //    this.visMainPlot.Name = "gtecMainPlot";
        //    this.visMainPlot.PanCursor = Cursors.Hand;
        //    this.visMainPlot.Size = new Size(900, 900);
        //    this.visMainPlot.TabIndex = 0;
        //    this.visMainPlot.Text = "mainPlotView";
        //    this.visMainPlot.ZoomHorizontalCursor = Cursors.SizeWE;
        //    this.visMainPlot.ZoomRectangleCursor = Cursors.SizeNWSE;
        //    this.visMainPlot.ZoomVerticalCursor = Cursors.SizeNS;
        //    base.AutoScaleDimensions = new SizeF(6f, 13f);
        //    base.AutoScaleMode = AutoScaleMode.Font;
        //    base.ClientSize = new Size(900, 900);
        //    base.Controls.Add(this.visMainPlot);
        //    base.ResumeLayout(false);
        //}
    }
}
