using System;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace SSVEP_Speller_CSharp.LabStreamingLayer.Visualizer
{
    public class Vis_Data
    {
        private LineSeries[] dataMainSeries;

        public int GTEC_SAMPLE_BUFFER_SIZE = 185;

        public LineSeries[] visMainSeries
        {
            get
            {
                return this.dataMainSeries;
            }
            set
            {
                this.dataMainSeries = value;
            }
        }

        public PlotView GtecMainPlot
        {
            get;
            set;
        }
    }
}
