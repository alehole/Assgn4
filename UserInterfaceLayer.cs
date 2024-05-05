using System.Configuration;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ScottPlot;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Collections;
using ScottPlot.TickGenerators.TimeUnits;
using System.Globalization;
using Avalonia.Controls;
using System.Threading;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using ControllerGUI.Data;
using ScottPlot.WinForms;

namespace ControllerGUI
{
    public partial class UserInterfaceLayer : Form
    {
        BusinessLayer BL = new BusinessLayer();
        Plot PL = new Plot();

        public UserInterfaceLayer() => InitializeComponent();

        private void timer_Udp_Tick(object sender, EventArgs e)
        {
            BL.CheckCon();
            if (BL.ConOK)
            {
                lblConnectionOK.Text = "Connection OK";
                BL.SendDatPackage();
            }
            else
            {
                lblConnectionOK.Text = "Connection Not OK";
            }
        }

        private void timer_db_Tick(object sender, EventArgs e)
        {
            txtBx_PV.Text = BL.Get_PV();
            txtBx_CV.Text = BL.Get_CV();
            txtBx_SP.Text = BL.Get_SP();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_Udp.Enabled = true;
            timer_Udp.Start();
            timer_db.Enabled = true;
            timer_db.Start();
            PL.InitializeChart(formsPlot1, "PV", "Time[s]", "PV plot");
            PL.InitializeChart(formsPlot2, "SP", "Time[s]", "SP plot");
            PL.InitializeChart(formsPlot3, "CV", "Time[s]", "CV plot");
        }

        private void num_Kp_ValueChanged(object sender, EventArgs e) => BL.Kp = num_Kp.Value;

        private void num_Ti_ValueChanged(object sender, EventArgs e) => BL.Ti = num_Ti.Value;

        private void num_Td_ValueChanged(object sender, EventArgs e) => BL.Td = num_Td.Value;

        private void num_MaxSP_ValueChanged(object sender, EventArgs e) => BL.Max_Sp = num_MaxSP.Value;

        private void num_HH_ValueChanged(object sender, EventArgs e) => BL.HH = num_HH.Value;

        private void num_H_ValueChanged(object sender, EventArgs e) => BL.H = num_H.Value;

        private void num_L_ValueChanged(object sender, EventArgs e) => BL.L = num_L.Value;

        private void num_LL_ValueChanged(object sender, EventArgs e) => BL.LL = num_LL.Value;

        private void num_SP_ValueChanged(object sender, EventArgs e) => BL.Sp = num_SP.Value;

        private void num_ManCV_ValueChanged(object sender, EventArgs e) => BL.Man_CV = num_ManCV.Value;


        private void btnPlotPV_Click(object sender, EventArgs e)
        {
            var (sensorDataList, dateTimeList) = BL.GetDataList((int)numSamplesPlotPV.Value, "TT01");
            var (oleDates, sensorValues) = PL.ValueList(sensorDataList, dateTimeList);
            PL.CreateChart(formsPlot1, oleDates, sensorValues, "PV", "Time[s]", "PV plot");
        }

        private void btnPlotSP_Click(object sender, EventArgs e)
        {
            var (sensorDataList, dateTimeList) = BL.GetDataList((int)numSamplesPlotSP.Value, "PID1_SP");
            var (oleDates, sensorValues) = PL.ValueList(sensorDataList, dateTimeList);
            PL.CreateChart(formsPlot2, oleDates, sensorValues, "SP", "Time[s]", "SP plot");
        }

        private void btnPlotCV_Click(object sender, EventArgs e)
        {
            var (sensorDataList, dateTimeList) = BL.GetDataList((int)numSamplesPlotCV.Value, "PID1_CV");
            var (oleDates, sensorValues) = PL.ValueList(sensorDataList, dateTimeList);
            PL.CreateChart(formsPlot3, oleDates, sensorValues, "CV", "Time[s]", "CV plot");
        }
    }
}
