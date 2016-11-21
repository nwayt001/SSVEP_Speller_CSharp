using OxyPlot;
using System;
using System.Collections;
using System.Threading;

namespace SSVEP_Speller_CSharp.LabStreamingLayer.Visualizer
{
    class Vis_WorkerThread
    {
        public Vis_Data sharedData;

        public Queue queue;

        private int counter;

        private int channelCount;

        public Vis_WorkerThread(Vis_Data sharedData, int channelCount)
        {
            this.sharedData = sharedData;
            this.channelCount = channelCount;
            this.counter = 0;
            this.queue = Queue.Synchronized(new Queue());
        }

        public void Run()
        {
            while (true)
            {
                if (this.queue.Count > 0)
                {
                    if (this.counter == this.sharedData.GTEC_SAMPLE_BUFFER_SIZE - 1)
                    {
                        this.counter = -1;
                    }
                    this.counter++;
                    float[] array = (float[])this.queue.Dequeue();
                    for (int i = 0; i < channelCount; i++)
                    {
                        this.sharedData.visMainSeries[i].Points[this.counter] = new DataPoint((double)this.counter, (double)array[i]);
                    }
                    this.sharedData.GtecMainPlot.InvalidatePlot(true);
                    Thread.Sleep(50);
                }
                
            }
        }
    }
}
