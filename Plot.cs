using ScottPlot;
using ScottPlot.WinForms;
using System.Globalization;
namespace ControllerGUI
{
    public class Plot
    {
         public (double[], double[]) ValueList(List<double> ValueList, List<string> dateTimeList)
        {
            double[] dataY = new double[ValueList.Count];
            string[] dataX = new string[dateTimeList.Count];
            string DateTimeFormat = "M/d/yyyy h:mm:ss tt";

            int i = 0;
            foreach (var datapoint in dateTimeList)
            {
                dataX[i] = datapoint;
                i++;
            }
            i = 0;
            foreach (var datapoint in ValueList)
            {
                dataY[i] = datapoint;
                i++;
            }
            DateTime[] dateTimes = Array.ConvertAll(dataX, dateStr => DateTime.ParseExact(dateStr, DateTimeFormat, CultureInfo.InvariantCulture));
            double[] datesAsOle = Array.ConvertAll(dateTimes, date => date.ToOADate());

            return (datesAsOle, dataY);
        }
        public void CreateChart(FormsPlot formsPlot, double[] timeStamp, double[] dataY, string Ylabel, string XLabel, string Title)
        {
            formsPlot.Plot.Clear();
            formsPlot.Plot.XLabel(XLabel);
            formsPlot.Plot.YLabel(Ylabel);
            formsPlot.Plot.Title(Title);

            formsPlot.Plot.Add.Scatter(timeStamp, dataY, color: Colors.Blue);
            formsPlot.Plot.Axes.DateTimeTicksBottom();
            formsPlot.Plot.Axes.AutoScale();
            formsPlot.Refresh();
        }
        public void InitializeChart(FormsPlot formsPlot, string Ylabel, string XLabel , string Title)
        {
            formsPlot.Plot.XLabel(XLabel);
            formsPlot.Plot.YLabel(Ylabel);
            formsPlot.Plot.Title(Title);
            formsPlot.Refresh();
        }
    }
}