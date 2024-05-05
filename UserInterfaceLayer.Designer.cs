namespace ControllerGUI
{
    partial class UserInterfaceLayer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabMain = new TabControl();
            tabPage1 = new TabPage();
            gb_Status = new GroupBox();
            lblConnectionOK = new Label();
            label10 = new Label();
            lbl_AlarmActive = new Label();
            txtBx_SP = new TextBox();
            label9 = new Label();
            txtBx_CV = new TextBox();
            label8 = new Label();
            txtBx_PV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            lbl_Sts_running = new Label();
            label5 = new Label();
            lbl_sts_auto = new Label();
            gb_Control = new GroupBox();
            btn_AckAlm = new Button();
            btn_Stop = new Button();
            btn_Start = new Button();
            btnMan = new Button();
            btn_AutoMan = new Button();
            gb_SP = new GroupBox();
            num_ManCV = new NumericUpDown();
            label12 = new Label();
            num_SP = new NumericUpDown();
            label11 = new Label();
            gb_PIDConf = new GroupBox();
            label17 = new Label();
            num_LL = new NumericUpDown();
            label16 = new Label();
            num_L = new NumericUpDown();
            label15 = new Label();
            num_H = new NumericUpDown();
            label14 = new Label();
            num_HH = new NumericUpDown();
            label13 = new Label();
            num_MaxSP = new NumericUpDown();
            num_Ti = new NumericUpDown();
            label3 = new Label();
            num_Kp = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            num_Td = new NumericUpDown();
            tabPage2 = new TabPage();
            tabControl1 = new TabControl();
            tab_PV = new TabPage();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            gb_PlotConf = new GroupBox();
            numSamplesPlotPV = new NumericUpDown();
            btnPlotPV = new Button();
            label4 = new Label();
            tab_SP = new TabPage();
            groupBox1 = new GroupBox();
            numSamplesPlotSP = new NumericUpDown();
            btnPlotSP = new Button();
            label18 = new Label();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            tab_CV = new TabPage();
            groupBox2 = new GroupBox();
            numSamplesPlotCV = new NumericUpDown();
            btnPlotCV = new Button();
            label19 = new Label();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            timer_Udp = new System.Windows.Forms.Timer(components);
            timer_db = new System.Windows.Forms.Timer(components);
            tabMain.SuspendLayout();
            tabPage1.SuspendLayout();
            gb_Status.SuspendLayout();
            gb_Control.SuspendLayout();
            gb_SP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_ManCV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_SP).BeginInit();
            gb_PIDConf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_LL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_L).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_H).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_HH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_MaxSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Ti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Kp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Td).BeginInit();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            tab_PV.SuspendLayout();
            gb_PlotConf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSamplesPlotPV).BeginInit();
            tab_SP.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSamplesPlotSP).BeginInit();
            tab_CV.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSamplesPlotCV).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPage1);
            tabMain.Controls.Add(tabPage2);
            tabMain.Location = new Point(12, 12);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(787, 474);
            tabMain.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(gb_Status);
            tabPage1.Controls.Add(gb_Control);
            tabPage1.Controls.Add(gb_SP);
            tabPage1.Controls.Add(gb_PIDConf);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(779, 446);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PID";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // gb_Status
            // 
            gb_Status.Controls.Add(lblConnectionOK);
            gb_Status.Controls.Add(label10);
            gb_Status.Controls.Add(lbl_AlarmActive);
            gb_Status.Controls.Add(txtBx_SP);
            gb_Status.Controls.Add(label9);
            gb_Status.Controls.Add(txtBx_CV);
            gb_Status.Controls.Add(label8);
            gb_Status.Controls.Add(txtBx_PV);
            gb_Status.Controls.Add(label7);
            gb_Status.Controls.Add(label6);
            gb_Status.Controls.Add(lbl_Sts_running);
            gb_Status.Controls.Add(label5);
            gb_Status.Controls.Add(lbl_sts_auto);
            gb_Status.Location = new Point(151, 6);
            gb_Status.Name = "gb_Status";
            gb_Status.Size = new Size(200, 269);
            gb_Status.TabIndex = 12;
            gb_Status.TabStop = false;
            gb_Status.Text = "Status";
            // 
            // lblConnectionOK
            // 
            lblConnectionOK.AutoSize = true;
            lblConnectionOK.Location = new Point(82, 179);
            lblConnectionOK.Name = "lblConnectionOK";
            lblConnectionOK.Size = new Size(88, 15);
            lblConnectionOK.TabIndex = 14;
            lblConnectionOK.Text = "Connection OK";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 65);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 11;
            label10.Text = "Alarm active:";
            // 
            // lbl_AlarmActive
            // 
            lbl_AlarmActive.AutoSize = true;
            lbl_AlarmActive.Location = new Point(119, 65);
            lbl_AlarmActive.Name = "lbl_AlarmActive";
            lbl_AlarmActive.Size = new Size(23, 15);
            lbl_AlarmActive.TabIndex = 10;
            lbl_AlarmActive.Text = "No";
            // 
            // txtBx_SP
            // 
            txtBx_SP.Location = new Point(70, 150);
            txtBx_SP.Name = "txtBx_SP";
            txtBx_SP.ReadOnly = true;
            txtBx_SP.Size = new Size(100, 23);
            txtBx_SP.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 153);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 8;
            label9.Text = "SP:";
            // 
            // txtBx_CV
            // 
            txtBx_CV.Location = new Point(69, 120);
            txtBx_CV.Name = "txtBx_CV";
            txtBx_CV.ReadOnly = true;
            txtBx_CV.Size = new Size(100, 23);
            txtBx_CV.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 123);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 6;
            label8.Text = "CV:";
            // 
            // txtBx_PV
            // 
            txtBx_PV.Location = new Point(70, 89);
            txtBx_PV.Name = "txtBx_PV";
            txtBx_PV.ReadOnly = true;
            txtBx_PV.Size = new Size(100, 23);
            txtBx_PV.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 92);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 4;
            label7.Text = "PV:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 46);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 3;
            label6.Text = "Running/Stopped:";
            // 
            // lbl_Sts_running
            // 
            lbl_Sts_running.AutoSize = true;
            lbl_Sts_running.Location = new Point(119, 46);
            lbl_Sts_running.Name = "lbl_Sts_running";
            lbl_Sts_running.Size = new Size(51, 15);
            lbl_Sts_running.TabIndex = 2;
            lbl_Sts_running.Text = "Stopped";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 23);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 1;
            label5.Text = "Auto/Manual:";
            // 
            // lbl_sts_auto
            // 
            lbl_sts_auto.AutoSize = true;
            lbl_sts_auto.Location = new Point(119, 23);
            lbl_sts_auto.Name = "lbl_sts_auto";
            lbl_sts_auto.Size = new Size(47, 15);
            lbl_sts_auto.TabIndex = 0;
            lbl_sts_auto.Text = "Manual";
            // 
            // gb_Control
            // 
            gb_Control.Controls.Add(btn_AckAlm);
            gb_Control.Controls.Add(btn_Stop);
            gb_Control.Controls.Add(btn_Start);
            gb_Control.Controls.Add(btnMan);
            gb_Control.Controls.Add(btn_AutoMan);
            gb_Control.Location = new Point(357, 6);
            gb_Control.Name = "gb_Control";
            gb_Control.Size = new Size(96, 180);
            gb_Control.TabIndex = 12;
            gb_Control.TabStop = false;
            gb_Control.Text = "Control";
            // 
            // btn_AckAlm
            // 
            btn_AckAlm.Location = new Point(6, 145);
            btn_AckAlm.Name = "btn_AckAlm";
            btn_AckAlm.Size = new Size(75, 23);
            btn_AckAlm.TabIndex = 14;
            btn_AckAlm.Text = "Ack alarm";
            btn_AckAlm.UseVisualStyleBackColor = true;
            // 
            // btn_Stop
            // 
            btn_Stop.Location = new Point(6, 115);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size(75, 23);
            btn_Stop.TabIndex = 13;
            btn_Stop.Text = "Stop";
            btn_Stop.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(6, 86);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(75, 23);
            btn_Start.TabIndex = 12;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            // 
            // btnMan
            // 
            btnMan.Location = new Point(6, 57);
            btnMan.Name = "btnMan";
            btnMan.Size = new Size(75, 23);
            btnMan.TabIndex = 11;
            btnMan.Text = "Manual";
            btnMan.UseVisualStyleBackColor = true;
            // 
            // btn_AutoMan
            // 
            btn_AutoMan.Location = new Point(6, 28);
            btn_AutoMan.Name = "btn_AutoMan";
            btn_AutoMan.Size = new Size(75, 23);
            btn_AutoMan.TabIndex = 10;
            btn_AutoMan.Text = "Auto";
            btn_AutoMan.UseVisualStyleBackColor = true;
            // 
            // gb_SP
            // 
            gb_SP.Controls.Add(num_ManCV);
            gb_SP.Controls.Add(label12);
            gb_SP.Controls.Add(num_SP);
            gb_SP.Controls.Add(label11);
            gb_SP.Location = new Point(459, 7);
            gb_SP.Name = "gb_SP";
            gb_SP.Size = new Size(161, 100);
            gb_SP.TabIndex = 11;
            gb_SP.TabStop = false;
            gb_SP.Text = "Setpoints";
            // 
            // num_ManCV
            // 
            num_ManCV.DecimalPlaces = 1;
            num_ManCV.Location = new Point(88, 55);
            num_ManCV.Name = "num_ManCV";
            num_ManCV.Size = new Size(55, 23);
            num_ManCV.TabIndex = 11;
            num_ManCV.ValueChanged += num_ManCV_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 61);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 12;
            label12.Text = "Man. CV";
            // 
            // num_SP
            // 
            num_SP.DecimalPlaces = 1;
            num_SP.Location = new Point(88, 21);
            num_SP.Name = "num_SP";
            num_SP.Size = new Size(55, 23);
            num_SP.TabIndex = 9;
            num_SP.ValueChanged += num_SP_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 24);
            label11.Name = "label11";
            label11.Size = new Size(23, 15);
            label11.TabIndex = 10;
            label11.Text = "SP:";
            // 
            // gb_PIDConf
            // 
            gb_PIDConf.Controls.Add(label17);
            gb_PIDConf.Controls.Add(num_LL);
            gb_PIDConf.Controls.Add(label16);
            gb_PIDConf.Controls.Add(num_L);
            gb_PIDConf.Controls.Add(label15);
            gb_PIDConf.Controls.Add(num_H);
            gb_PIDConf.Controls.Add(label14);
            gb_PIDConf.Controls.Add(num_HH);
            gb_PIDConf.Controls.Add(label13);
            gb_PIDConf.Controls.Add(num_MaxSP);
            gb_PIDConf.Controls.Add(num_Ti);
            gb_PIDConf.Controls.Add(label3);
            gb_PIDConf.Controls.Add(num_Kp);
            gb_PIDConf.Controls.Add(label2);
            gb_PIDConf.Controls.Add(label1);
            gb_PIDConf.Controls.Add(num_Td);
            gb_PIDConf.Location = new Point(6, 6);
            gb_PIDConf.Name = "gb_PIDConf";
            gb_PIDConf.Size = new Size(139, 269);
            gb_PIDConf.TabIndex = 9;
            gb_PIDConf.TabStop = false;
            gb_PIDConf.Text = "Config";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(18, 231);
            label17.Name = "label17";
            label17.Size = new Size(19, 15);
            label17.TabIndex = 18;
            label17.Text = "LL";
            // 
            // num_LL
            // 
            num_LL.DecimalPlaces = 1;
            num_LL.Location = new Point(73, 229);
            num_LL.Name = "num_LL";
            num_LL.Size = new Size(55, 23);
            num_LL.TabIndex = 17;
            num_LL.ValueChanged += num_LL_ValueChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 202);
            label16.Name = "label16";
            label16.Size = new Size(13, 15);
            label16.TabIndex = 16;
            label16.Text = "L";
            // 
            // num_L
            // 
            num_L.DecimalPlaces = 1;
            num_L.Location = new Point(73, 200);
            num_L.Name = "num_L";
            num_L.Size = new Size(55, 23);
            num_L.TabIndex = 15;
            num_L.ValueChanged += num_L_ValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(18, 173);
            label15.Name = "label15";
            label15.Size = new Size(16, 15);
            label15.TabIndex = 14;
            label15.Text = "H";
            // 
            // num_H
            // 
            num_H.DecimalPlaces = 1;
            num_H.Location = new Point(73, 171);
            num_H.Name = "num_H";
            num_H.Size = new Size(55, 23);
            num_H.TabIndex = 13;
            num_H.ValueChanged += num_H_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 144);
            label14.Name = "label14";
            label14.Size = new Size(25, 15);
            label14.TabIndex = 12;
            label14.Text = "HH";
            // 
            // num_HH
            // 
            num_HH.DecimalPlaces = 1;
            num_HH.Location = new Point(73, 142);
            num_HH.Name = "num_HH";
            num_HH.Size = new Size(55, 23);
            num_HH.TabIndex = 11;
            num_HH.ValueChanged += num_HH_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 115);
            label13.Name = "label13";
            label13.Size = new Size(49, 15);
            label13.TabIndex = 10;
            label13.Text = "Max SP:";
            // 
            // num_MaxSP
            // 
            num_MaxSP.DecimalPlaces = 1;
            num_MaxSP.Location = new Point(73, 113);
            num_MaxSP.Name = "num_MaxSP";
            num_MaxSP.Size = new Size(55, 23);
            num_MaxSP.TabIndex = 9;
            num_MaxSP.ValueChanged += num_MaxSP_ValueChanged;
            // 
            // num_Ti
            // 
            num_Ti.DecimalPlaces = 1;
            num_Ti.Location = new Point(73, 55);
            num_Ti.Name = "num_Ti";
            num_Ti.Size = new Size(55, 23);
            num_Ti.TabIndex = 4;
            num_Ti.ValueChanged += num_Ti_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 86);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 8;
            label3.Text = "Td";
            // 
            // num_Kp
            // 
            num_Kp.DecimalPlaces = 1;
            num_Kp.Location = new Point(73, 26);
            num_Kp.Name = "num_Kp";
            num_Kp.Size = new Size(55, 23);
            num_Kp.TabIndex = 3;
            num_Kp.ValueChanged += num_Kp_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 57);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 7;
            label2.Text = "Ti";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 26);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 6;
            label1.Text = "Kp";
            // 
            // num_Td
            // 
            num_Td.DecimalPlaces = 1;
            num_Td.Location = new Point(73, 84);
            num_Td.Name = "num_Td";
            num_Td.Size = new Size(55, 23);
            num_Td.TabIndex = 5;
            num_Td.ValueChanged += num_Td_ValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabControl1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(779, 446);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Plot";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_PV);
            tabControl1.Controls.Add(tab_SP);
            tabControl1.Controls.Add(tab_CV);
            tabControl1.Location = new Point(6, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(770, 435);
            tabControl1.TabIndex = 12;
            // 
            // tab_PV
            // 
            tab_PV.Controls.Add(formsPlot1);
            tab_PV.Controls.Add(gb_PlotConf);
            tab_PV.Location = new Point(4, 24);
            tab_PV.Name = "tab_PV";
            tab_PV.Padding = new Padding(3);
            tab_PV.Size = new Size(762, 407);
            tab_PV.TabIndex = 0;
            tab_PV.Text = "PV";
            tab_PV.UseVisualStyleBackColor = true;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(6, 6);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(752, 326);
            formsPlot1.TabIndex = 4;
            // 
            // gb_PlotConf
            // 
            gb_PlotConf.Controls.Add(numSamplesPlotPV);
            gb_PlotConf.Controls.Add(btnPlotPV);
            gb_PlotConf.Controls.Add(label4);
            gb_PlotConf.Location = new Point(6, 338);
            gb_PlotConf.Name = "gb_PlotConf";
            gb_PlotConf.Size = new Size(752, 63);
            gb_PlotConf.TabIndex = 11;
            gb_PlotConf.TabStop = false;
            gb_PlotConf.Text = "Plot Config";
            // 
            // numSamplesPlotPV
            // 
            numSamplesPlotPV.DecimalPlaces = 1;
            numSamplesPlotPV.Location = new Point(123, 24);
            numSamplesPlotPV.Name = "numSamplesPlotPV";
            numSamplesPlotPV.Size = new Size(55, 23);
            numSamplesPlotPV.TabIndex = 11;
            numSamplesPlotPV.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPlotPV
            // 
            btnPlotPV.Location = new Point(208, 24);
            btnPlotPV.Name = "btnPlotPV";
            btnPlotPV.Size = new Size(75, 23);
            btnPlotPV.TabIndex = 12;
            btnPlotPV.Text = "Plot";
            btnPlotPV.UseVisualStyleBackColor = true;
            btnPlotPV.Click += btnPlotPV_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 8;
            label4.Text = "Number of samples";
            // 
            // tab_SP
            // 
            tab_SP.Controls.Add(groupBox1);
            tab_SP.Controls.Add(formsPlot2);
            tab_SP.Location = new Point(4, 24);
            tab_SP.Name = "tab_SP";
            tab_SP.Padding = new Padding(3);
            tab_SP.Size = new Size(762, 407);
            tab_SP.TabIndex = 1;
            tab_SP.Text = "SP";
            tab_SP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numSamplesPlotSP);
            groupBox1.Controls.Add(btnPlotSP);
            groupBox1.Controls.Add(label18);
            groupBox1.Location = new Point(6, 338);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(752, 63);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plot Config";
            // 
            // numSamplesPlotSP
            // 
            numSamplesPlotSP.DecimalPlaces = 1;
            numSamplesPlotSP.Location = new Point(123, 24);
            numSamplesPlotSP.Name = "numSamplesPlotSP";
            numSamplesPlotSP.Size = new Size(55, 23);
            numSamplesPlotSP.TabIndex = 11;
            numSamplesPlotSP.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPlotSP
            // 
            btnPlotSP.Location = new Point(208, 24);
            btnPlotSP.Name = "btnPlotSP";
            btnPlotSP.Size = new Size(75, 23);
            btnPlotSP.TabIndex = 12;
            btnPlotSP.Text = "Plot";
            btnPlotSP.UseVisualStyleBackColor = true;
            btnPlotSP.Click += btnPlotSP_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 28);
            label18.Name = "label18";
            label18.Size = new Size(111, 15);
            label18.TabIndex = 8;
            label18.Text = "Number of samples";
            // 
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(4, 6);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(752, 326);
            formsPlot2.TabIndex = 5;
            // 
            // tab_CV
            // 
            tab_CV.Controls.Add(groupBox2);
            tab_CV.Controls.Add(formsPlot3);
            tab_CV.Location = new Point(4, 24);
            tab_CV.Name = "tab_CV";
            tab_CV.Size = new Size(762, 407);
            tab_CV.TabIndex = 2;
            tab_CV.Text = "CV";
            tab_CV.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numSamplesPlotCV);
            groupBox2.Controls.Add(btnPlotCV);
            groupBox2.Controls.Add(label19);
            groupBox2.Location = new Point(7, 335);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(752, 63);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Plot Config";
            // 
            // numSamplesPlotCV
            // 
            numSamplesPlotCV.DecimalPlaces = 1;
            numSamplesPlotCV.Location = new Point(123, 24);
            numSamplesPlotCV.Name = "numSamplesPlotCV";
            numSamplesPlotCV.Size = new Size(55, 23);
            numSamplesPlotCV.TabIndex = 11;
            numSamplesPlotCV.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPlotCV
            // 
            btnPlotCV.Location = new Point(208, 24);
            btnPlotCV.Name = "btnPlotCV";
            btnPlotCV.Size = new Size(75, 23);
            btnPlotCV.TabIndex = 12;
            btnPlotCV.Text = "Plot";
            btnPlotCV.UseVisualStyleBackColor = true;
            btnPlotCV.Click += btnPlotCV_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 28);
            label19.Name = "label19";
            label19.Size = new Size(111, 15);
            label19.TabIndex = 8;
            label19.Text = "Number of samples";
            // 
            // formsPlot3
            // 
            formsPlot3.DisplayScale = 1F;
            formsPlot3.Location = new Point(7, 3);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(752, 326);
            formsPlot3.TabIndex = 5;
            // 
            // timer_Udp
            // 
            timer_Udp.Interval = 3000;
            timer_Udp.Tick += timer_Udp_Tick;
            // 
            // timer_db
            // 
            timer_db.Interval = 1000;
            timer_db.Tick += timer_db_Tick;
            // 
            // UserInterfaceLayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 492);
            Controls.Add(tabMain);
            Name = "UserInterfaceLayer";
            Text = "PID";
            Load += Form1_Load;
            tabMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            gb_Status.ResumeLayout(false);
            gb_Status.PerformLayout();
            gb_Control.ResumeLayout(false);
            gb_SP.ResumeLayout(false);
            gb_SP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_ManCV).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_SP).EndInit();
            gb_PIDConf.ResumeLayout(false);
            gb_PIDConf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_LL).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_L).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_H).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_HH).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_MaxSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Ti).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Kp).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Td).EndInit();
            tabPage2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tab_PV.ResumeLayout(false);
            gb_PlotConf.ResumeLayout(false);
            gb_PlotConf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSamplesPlotPV).EndInit();
            tab_SP.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSamplesPlotSP).EndInit();
            tab_CV.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSamplesPlotCV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private NumericUpDown num_Td;
        private NumericUpDown num_Ti;
        private NumericUpDown num_Kp;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gb_PIDConf;
        private GroupBox gb_PlotConf;
        private Label label4;
        private GroupBox gb_Status;
        private GroupBox gb_Control;
        private Button btn_Start;
        private Button btnMan;
        private Button btn_AutoMan;
        private GroupBox gb_SP;
        private Label lbl_sts_auto;
        private Label label6;
        private Label lbl_Sts_running;
        private Label label5;
        private Button btn_Stop;
        private TextBox txtBx_CV;
        private Label label8;
        private TextBox txtBx_PV;
        private Label label7;
        private TextBox txtBx_SP;
        private Label label9;
        private Label label10;
        private Label lbl_AlarmActive;
        private Button btn_AckAlm;
        private NumericUpDown num_ManCV;
        private Label label12;
        private NumericUpDown num_SP;
        private Label label11;
        private Label label17;
        private NumericUpDown num_LL;
        private Label label16;
        private NumericUpDown num_L;
        private Label label15;
        private NumericUpDown num_H;
        private Label label14;
        private NumericUpDown num_HH;
        private Label label13;
        private NumericUpDown num_MaxSP;
        private Label lblConnectionOK;
        private System.Windows.Forms.Timer timer_Udp;
        private System.Windows.Forms.Timer timer_db;
        private TabControl tabControl1;
        private TabPage tab_PV;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private TabPage tab_SP;
        private TabPage tab_CV;
        private NumericUpDown numSamplesPlotPV;
        private Button btnPlotPV;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
        private GroupBox groupBox1;
        private NumericUpDown numSamplesPlotSP;
        private Button btnPlotSP;
        private Label label18;
        private GroupBox groupBox2;
        private NumericUpDown numSamplesPlotCV;
        private Button btnPlotCV;
        private Label label19;
    }
}
