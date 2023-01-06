﻿using ScottPlot.Avalonia;

namespace srra
{
    internal class Graph
    {
        public double[] xData { get; set; }
        public double[] yData { get; set; }

        public AvaPlot avaPlot;
        public Graph(AvaPlot plot, string title) {
            avaPlot = plot;
            avaPlot.Plot.Title(title);
            xData = System.Array.Empty<double>();
            yData = System.Array.Empty<double>();
        }

        public void ShowGraph()
        {
            if (xData is null || yData is null || xData.Length == 0 || yData.Length == 0) return;
            avaPlot.Plot.Palette = ScottPlot.Palette.Frost;
            avaPlot.Plot.AddScatter(xData, yData);
            avaPlot.Plot.AxisAuto(0, 0.1);
            avaPlot.Refresh();
        }
    }
}
