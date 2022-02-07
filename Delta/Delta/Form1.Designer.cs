namespace Delta
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.radioButton33 = new System.Windows.Forms.RadioButton();
            this.radioButton34 = new System.Windows.Forms.RadioButton();
            this.radioButton35 = new System.Windows.Forms.RadioButton();
            this.radioButton40 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(612, 19);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(949, 314);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(32, 54);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(80, 21);
            this.radioButton6.TabIndex = 7;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "January";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(32, 81);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(86, 21);
            this.radioButton7.TabIndex = 8;
            this.radioButton7.Text = "February";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(32, 106);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(63, 21);
            this.radioButton8.TabIndex = 9;
            this.radioButton8.Text = "Mach";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(32, 160);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(55, 21);
            this.radioButton9.TabIndex = 10;
            this.radioButton9.Text = "May";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(32, 133);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(57, 21);
            this.radioButton10.TabIndex = 11;
            this.radioButton10.Text = "April";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(32, 187);
            this.radioButton11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(60, 21);
            this.radioButton11.TabIndex = 12;
            this.radioButton11.Text = "June";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(32, 214);
            this.radioButton12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(54, 21);
            this.radioButton12.TabIndex = 13;
            this.radioButton12.Text = "July";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(32, 241);
            this.radioButton13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(73, 21);
            this.radioButton13.TabIndex = 14;
            this.radioButton13.Text = "August";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(32, 268);
            this.radioButton14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(98, 21);
            this.radioButton14.TabIndex = 15;
            this.radioButton14.Text = "September";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton14_CheckedChanged);
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(32, 377);
            this.radioButton15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(78, 21);
            this.radioButton15.TabIndex = 16;
            this.radioButton15.Text = "All Year";
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.radioButton15_CheckedChanged);
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(32, 350);
            this.radioButton16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(94, 21);
            this.radioButton16.TabIndex = 17;
            this.radioButton16.Text = "December";
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.CheckedChanged += new System.EventHandler(this.radioButton16_CheckedChanged);
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(32, 322);
            this.radioButton17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(94, 21);
            this.radioButton17.TabIndex = 18;
            this.radioButton17.Text = "November";
            this.radioButton17.UseVisualStyleBackColor = true;
            this.radioButton17.CheckedChanged += new System.EventHandler(this.radioButton17_CheckedChanged);
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(32, 295);
            this.radioButton18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(80, 21);
            this.radioButton18.TabIndex = 19;
            this.radioButton18.Text = "October";
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton18.CheckedChanged += new System.EventHandler(this.radioButton18_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton18);
            this.groupBox2.Controls.Add(this.radioButton17);
            this.groupBox2.Controls.Add(this.radioButton16);
            this.groupBox2.Controls.Add(this.radioButton15);
            this.groupBox2.Controls.Add(this.radioButton14);
            this.groupBox2.Controls.Add(this.radioButton13);
            this.groupBox2.Controls.Add(this.radioButton12);
            this.groupBox2.Controls.Add(this.radioButton11);
            this.groupBox2.Controls.Add(this.radioButton10);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(24, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(157, 406);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Months";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(376, 234);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 22);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(180, 260);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(379, 56);
            this.trackBar1.TabIndex = 22;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 427);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "degradation (year)";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(197, 79);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(255, 56);
            this.trackBar2.TabIndex = 30;
            this.trackBar2.Value = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(203, 19);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(255, 56);
            this.trackBar3.TabIndex = 31;
            this.trackBar3.Value = 2;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "quality 0 [%]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "price 100 [%]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "efficiency 0 [%]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "temp. 100 [%]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(619, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "panel";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(338, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "Calculation results:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(612, 364);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(936, 174);
            this.dataGridView2.TabIndex = 38;
            // 
            // radioButton31
            // 
            this.radioButton31.AutoSize = true;
            this.radioButton31.Checked = true;
            this.radioButton31.Location = new System.Drawing.Point(27, 21);
            this.radioButton31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.Size = new System.Drawing.Size(148, 21);
            this.radioButton31.TabIndex = 44;
            this.radioButton31.TabStop = true;
            this.radioButton31.Text = "roof jednospadowy";
            this.radioButton31.UseVisualStyleBackColor = true;
            this.radioButton31.CheckedChanged += new System.EventHandler(this.radioButton31_CheckedChanged);
            // 
            // radioButton32
            // 
            this.radioButton32.AutoSize = true;
            this.radioButton32.Location = new System.Drawing.Point(27, 44);
            this.radioButton32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.Size = new System.Drawing.Size(125, 21);
            this.radioButton32.TabIndex = 45;
            this.radioButton32.Text = "roof 2 spadowy";
            this.radioButton32.UseVisualStyleBackColor = true;
            this.radioButton32.CheckedChanged += new System.EventHandler(this.radioButton32_CheckedChanged);
            // 
            // radioButton33
            // 
            this.radioButton33.AutoSize = true;
            this.radioButton33.Location = new System.Drawing.Point(27, 70);
            this.radioButton33.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton33.Name = "radioButton33";
            this.radioButton33.Size = new System.Drawing.Size(156, 21);
            this.radioButton33.TabIndex = 46;
            this.radioButton33.Text = "roof  czterospadowy";
            this.radioButton33.UseVisualStyleBackColor = true;
            this.radioButton33.CheckedChanged += new System.EventHandler(this.radioButton33_CheckedChanged);
            // 
            // radioButton34
            // 
            this.radioButton34.AutoSize = true;
            this.radioButton34.Location = new System.Drawing.Point(213, 19);
            this.radioButton34.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton34.Name = "radioButton34";
            this.radioButton34.Size = new System.Drawing.Size(126, 21);
            this.radioButton34.TabIndex = 47;
            this.radioButton34.Text = "roof  kopertowy";
            this.radioButton34.UseVisualStyleBackColor = true;
            this.radioButton34.CheckedChanged += new System.EventHandler(this.radioButton34_CheckedChanged);
            // 
            // radioButton35
            // 
            this.radioButton35.AutoSize = true;
            this.radioButton35.Location = new System.Drawing.Point(213, 44);
            this.radioButton35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton35.Name = "radioButton35";
            this.radioButton35.Size = new System.Drawing.Size(136, 21);
            this.radioButton35.TabIndex = 48;
            this.radioButton35.Text = "roof  Naczółkowy";
            this.radioButton35.UseVisualStyleBackColor = true;
            this.radioButton35.CheckedChanged += new System.EventHandler(this.radioButton35_CheckedChanged);
            // 
            // radioButton40
            // 
            this.radioButton40.AutoSize = true;
            this.radioButton40.Location = new System.Drawing.Point(213, 70);
            this.radioButton40.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton40.Name = "radioButton40";
            this.radioButton40.Size = new System.Drawing.Size(145, 21);
            this.radioButton40.TabIndex = 49;
            this.radioButton40.Text = "roof  Półszczytowy";
            this.radioButton40.UseVisualStyleBackColor = true;
            this.radioButton40.CheckedChanged += new System.EventHandler(this.radioButton40_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton40);
            this.groupBox4.Controls.Add(this.radioButton35);
            this.groupBox4.Controls.Add(this.radioButton34);
            this.groupBox4.Controls.Add(this.radioButton33);
            this.groupBox4.Controls.Add(this.radioButton32);
            this.groupBox4.Controls.Add(this.radioButton31);
            this.groupBox4.Location = new System.Drawing.Point(197, 123);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(388, 107);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Choose";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(328, 542);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1220, 218);
            this.dataGridView3.TabIndex = 66;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // chart2
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisY.IsMarginVisible = false;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(24, 521);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(283, 239);
            this.chart2.TabIndex = 67;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // trackBar5
            // 
            this.trackBar5.LargeChange = 1;
            this.trackBar5.Location = new System.Drawing.Point(-8, 452);
            this.trackBar5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar5.Maximum = 360;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(388, 56);
            this.trackBar5.TabIndex = 68;
            this.trackBar5.Value = 3;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 69;
            this.label8.Text = "roof slope 0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aquamarine;
            this.button2.Location = new System.Drawing.Point(386, 452);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 36);
            this.button2.TabIndex = 70;
            this.button2.Text = "OBLICZ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aquamarine;
            this.button3.Location = new System.Drawing.Point(386, 394);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 39);
            this.button3.TabIndex = 73;
            this.button3.Text = "production per year";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 761);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton radioButton31;
        private System.Windows.Forms.RadioButton radioButton32;
        private System.Windows.Forms.RadioButton radioButton33;
        private System.Windows.Forms.RadioButton radioButton34;
        private System.Windows.Forms.RadioButton radioButton35;
        private System.Windows.Forms.RadioButton radioButton40;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

