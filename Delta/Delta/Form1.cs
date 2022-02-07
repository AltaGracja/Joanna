using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;

namespace Delta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ustaw();
            degradacja();
            wybor_panela();
            d = 1;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox1.Visible = false;

            dataGridView3[1, 0].Value = 0;
            dataGridView3[1, 1].Value = 0;
            dataGridView3[1, 2].Value = 20;
            dataGridView3[1, 3].Value = 10;
            dataGridView3[3, 0].Value = 0;
            dataGridView3[3, 1].Value = 0;
            dataGridView3[3, 2].Value = 30;
            dataGridView3[3, 3].Value = 0;
        }
        double x, y, x1, y1,kata=0, katb=0;
        double[,] A = new double[7, 18];
        int k = 1, r = 1, d = 10, trak;
        double[] BB = new double[17];
        double[] C = new double[12];
        double[] B = new double[12];
        string[] napis = new string[18];
        double kat_b;
        double moc0;
        double[,] kat = new double[361, 3];
        double jakosc;
        double aa, bb, cc, dd, zz; // kąt odchylenia od południa zz - kierunek ściany frontowej
        // aa- frontowa , bb-prawa cc- lewa, dd-tylna
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void ustaw()
        {
            dataGridView1.ColumnCount = 11;
            dataGridView1.RowCount = 17;

            dataGridView2.ColumnCount = 6;
            dataGridView2.RowCount = 6;

            napis[1] = "Poli-(classic)";
            napis[2] = " Amorphics";
            napis[3] = "Poli-with links cut in half";
            napis[4] = "Poli-MWT";
            napis[5] = "Mono-(classic)";
            napis[6] = "Mono-with links cut in half";
            napis[7] = "Mono-PERC";
            napis[8] = "CdTe";
            napis[9] = "Mono-MWT";
            napis[10] = "CIGS";
            napis[11] = "Poli-Smart (Solar Edge)";
            napis[12] = "Mono-Smart (Solar Edge)";
            napis[13] = "Poli-glass-glass";
            napis[14] = "Mono-glass-glass ";
            napis[15] = "Mono-HIT";
            napis[16] = "Mono-bifacjalny";
            napis[17] = "Mono-all back contact";

            for (int i = 1; i <= 17; i++)
                dataGridView1[10, i - 1].Value = napis[i];

            for (int i = 1; i < 7; i++)
            {
                dataGridView1.Columns[i].Width = 120; // szerokość komórek tablicy A
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString(); // I  


            }
            dataGridView2.Columns[0].Width = 200;
            dataGridView2.Columns[2].Width = 150;
                dataGridView2.Columns[3].Width = 60;;
            dataGridView2.Columns[4].Width = 170;
            dataGridView2[0, 0].Value = "Panel type";
            dataGridView2[0, 1].Value = "Typical power Wp";
            dataGridView2[0, 2].Value = "Typical efficiency";
            dataGridView2[0, 3].Value = "Height a";
            dataGridView2[0, 4].Value = "Width b";
            dataGridView2[0, 5].Value = "śr.Temp. wsp. mocy";

            dataGridView2[2, 0].Value = "Front wall direction";
            dataGridView2[2, 1].Value = "The front wall";
            dataGridView2[2, 2].Value = "The right wall";
            dataGridView2[2, 3].Value = "The left wall";
            dataGridView2[2, 4].Value = "The back wall";
            dataGridView2[2, 5].Value = "maximum number of photovoltaic panels";
            dataGridView2[3, 5].Value = 0;

            dataGridView2[4, 0].Value = "the surface of one panel";
            dataGridView2[4, 1].Value = "installed power";
            dataGridView2[4, 2].Value = "Production [kW]";
            dataGridView2[4, 3].Value = "Power regained [%]";
            dataGridView2[4, 4].Value = " ";
            dataGridView2[4, 5].Value = "  ";



            dataGridView1.Columns[0].HeaderText = "Typical power Wp";
            dataGridView1.Columns[1].HeaderText = "Typical efficiency";
            dataGridView1.Columns[2].HeaderText = "Height a";
            dataGridView1.Columns[3].HeaderText = "Width b";
            dataGridView1.Columns[4].HeaderText = "śr.Temp. wsp. mocy";
            dataGridView1.Columns[5].HeaderText = "Praice netto for Wp";
            dataGridView1.Columns[6].HeaderText = "Praice";
            dataGridView1.Columns[7].HeaderText = "efficiency";
            dataGridView1.Columns[8].HeaderText = "temperature";
            dataGridView1.Columns[9].HeaderText = "solution";
            dataGridView1.Columns[10].HeaderText = "panel";

            dataGridView1[0, 0].Value = 280;
            dataGridView1[0, 1].Value = 100;
            dataGridView1[0, 2].Value = 290;
            dataGridView1[0, 3].Value = 300;
            dataGridView1[0, 4].Value = 295;
            dataGridView1[0, 5].Value = 325;
            dataGridView1[0, 6].Value = 320;
            dataGridView1[0, 7].Value = 100;
            dataGridView1[0, 8].Value = 325;
            dataGridView1[0, 9].Value = 140;
            dataGridView1[0, 10].Value = 280;
            dataGridView1[0, 11].Value = 295;
            dataGridView1[0, 12].Value = 275;
            dataGridView1[0, 13].Value = 300;
            dataGridView1[0, 14].Value = 330;
            dataGridView1[0, 15].Value = 300;
            dataGridView1[0, 16].Value = 333;



            dataGridView1[1, 0].Value = 17.2;
            dataGridView1[1, 1].Value = 8.3;
            dataGridView1[1, 2].Value = 17.6;
            dataGridView1[1, 3].Value = 18.5;
            dataGridView1[1, 4].Value = 18.2;
            dataGridView1[1, 5].Value = 19.8;
            dataGridView1[1, 6].Value = 19.7;
            dataGridView1[1, 7].Value = 13.9;
            dataGridView1[1, 8].Value = 20;
            dataGridView1[1, 9].Value = 13.4;
            dataGridView1[1, 10].Value = 17.2;
            dataGridView1[1, 11].Value = 18.2;
            dataGridView1[1, 12].Value = 16.9;
            dataGridView1[1, 13].Value = 18.5;
            dataGridView1[1, 14].Value = 20.1;
            dataGridView1[1, 15].Value = 18.3;
            dataGridView1[1, 16].Value = 20.5;

            dataGridView1[2, 0].Value = 0.99;
            dataGridView1[2, 1].Value = 1.0;
            dataGridView1[2, 2].Value = 0.99;
            dataGridView1[2, 3].Value = 0.99;
            dataGridView1[2, 4].Value = 0.99;
            dataGridView1[2, 5].Value = 0.99;
            dataGridView1[2, 6].Value = 0.99;
            dataGridView1[2, 7].Value = 0.6;
            dataGridView1[2, 8].Value = 0.99;
            dataGridView1[2, 9].Value = 1;
            dataGridView1[2, 10].Value = 0.66;
            dataGridView1[2, 11].Value = 0.99;
            dataGridView1[2, 12].Value = 0.99;
            dataGridView1[2, 13].Value = 0.99;
            dataGridView1[2, 14].Value = 1.05;
            dataGridView1[2, 15].Value = 1.0;
            dataGridView1[2, 16].Value = 1.04;

            dataGridView1[3, 0].Value = 1.64;
            dataGridView1[3, 1].Value = 1.2;
            dataGridView1[3, 2].Value = 1.66;
            dataGridView1[3, 3].Value = 1.64;
            dataGridView1[3, 4].Value = 1.64;
            dataGridView1[3, 5].Value = 1.66;
            dataGridView1[3, 6].Value = 1.64;
            dataGridView1[3, 7].Value = 1.2;
            dataGridView1[3, 8].Value = 1.64;
            dataGridView1[3, 9].Value = 1.58;
            dataGridView1[3, 10].Value = 1.64;
            dataGridView1[3, 11].Value = 1.64;
            dataGridView1[3, 12].Value = 1.64;
            dataGridView1[3, 13].Value = 1.64;
            dataGridView1[3, 14].Value = 1.59;
            dataGridView1[3, 15].Value = 1.64;
            dataGridView1[3, 16].Value = 1.56;

            dataGridView1[4, 0].Value = 0.41;
            dataGridView1[4, 1].Value = 0.25;
            dataGridView1[4, 2].Value = 0.38;
            dataGridView1[4, 3].Value = 0.36;
            dataGridView1[4, 4].Value = 0.43;
            dataGridView1[4, 5].Value = 0.37;
            dataGridView1[4, 6].Value = 0.45;
            dataGridView1[4, 7].Value = 0.34;
            dataGridView1[4, 8].Value = 0.36;
            dataGridView1[4, 9].Value = 0.38;
            dataGridView1[4, 10].Value = 0.43;
            dataGridView1[4, 11].Value = 0.44;
            dataGridView1[4, 12].Value = 0.44;
            dataGridView1[4, 13].Value = 0.45;
            dataGridView1[4, 14].Value = 0.29;
            dataGridView1[4, 15].Value = 0.38;
            dataGridView1[4, 16].Value = 0.33;


            dataGridView1[5, 0].Value = 1.5;
            dataGridView1[5, 1].Value = 1.6;
            dataGridView1[5, 2].Value = 1.6;
            dataGridView1[5, 3].Value = 1.7;
            dataGridView1[5, 4].Value = 1.8;
            dataGridView1[5, 5].Value = 1.9;
            dataGridView1[5, 6].Value = 1.9;
            dataGridView1[5, 7].Value = 0.0;
            dataGridView1[5, 8].Value = 2.1;
            dataGridView1[5, 9].Value = 2.1;
            dataGridView1[5, 10].Value = 2.1;
            dataGridView1[5, 11].Value = 2.2;
            dataGridView1[5, 12].Value = 2.2;
            dataGridView1[5, 13].Value = 2.4;
            dataGridView1[5, 14].Value = 2.8;
            dataGridView1[5, 15].Value = 3.2;
            dataGridView1[5, 16].Value = 3.3;

            // cena
            dataGridView1[6, 0].Value = 12;
            dataGridView1[6, 1].Value = 11;
            dataGridView1[6, 2].Value = 11;
            dataGridView1[6, 3].Value = 10;
            dataGridView1[6, 4].Value = 9;
            dataGridView1[6, 5].Value = 8;
            dataGridView1[6, 6].Value = 8;
            dataGridView1[6, 7].Value = 7;
            dataGridView1[6, 8].Value = 6;
            dataGridView1[6, 9].Value = 6;
            dataGridView1[6, 10].Value = 6;
            dataGridView1[6, 11].Value = 5;
            dataGridView1[6, 12].Value = 5;
            dataGridView1[6, 13].Value = 4;
            dataGridView1[6, 14].Value = 3;
            dataGridView1[6, 15].Value = 2;
            dataGridView1[6, 16].Value = 1;
            // sprawność

            dataGridView1[7, 0].Value = 5;
            dataGridView1[7, 1].Value = 1;
            dataGridView1[7, 2].Value = 6;
            dataGridView1[7, 3].Value = 9;
            dataGridView1[7, 4].Value = 7;
            dataGridView1[7, 5].Value = 11;
            dataGridView1[7, 6].Value = 10;
            dataGridView1[7, 7].Value = 3;
            dataGridView1[7, 8].Value = 12;
            dataGridView1[7, 9].Value = 2;
            dataGridView1[7, 10].Value = 5;
            dataGridView1[7, 11].Value = 7;
            dataGridView1[7, 12].Value = 4;
            dataGridView1[7, 13].Value = 9;
            dataGridView1[7, 14].Value = 13;
            dataGridView1[7, 15].Value = 8;
            dataGridView1[7, 16].Value = 14;
            // temperatura

            dataGridView1[8, 0].Value = 4;
            dataGridView1[8, 1].Value = 11;
            dataGridView1[8, 2].Value = 5;
            dataGridView1[8, 3].Value = 7;
            dataGridView1[8, 4].Value = 3;
            dataGridView1[8, 5].Value = 6;
            dataGridView1[8, 6].Value = 1;
            dataGridView1[8, 7].Value = 8;
            dataGridView1[8, 8].Value = 7;
            dataGridView1[8, 9].Value = 5;
            dataGridView1[8, 10].Value = 3;
            dataGridView1[8, 11].Value = 2;
            dataGridView1[8, 12].Value = 2;
            dataGridView1[8, 13].Value = 1;
            dataGridView1[8, 14].Value = 10;
            dataGridView1[8, 15].Value = 5;
            dataGridView1[8, 16].Value = 9;

            dataGridView3.RowCount = 7;
            dataGridView3.ColumnCount = 8;
            dataGridView3.Columns[0].Width = 150;
            dataGridView3.Columns[1].Width = 70;
            dataGridView3.Columns[3].Width = 70;
            dataGridView3.Columns[5].Width = 70;

            dataGridView3[0, 0].Value = "front ";
            dataGridView3[0, 1].Value = "right side zabudowy ";
            dataGridView3[0, 2].Value = "left side zabudowy"; 
            dataGridView3[0, 3].Value = "back wall";
            dataGridView3[0, 4].Value = "Powierzchnia roof ";
            dataGridView3[0, 5].Value = "max number of paneli vertically";
            dataGridView3[0, 6].Value = "max number of paneli horizonatlly";
            dataGridView3[2, 0].Value = "angle of deflection";
            dataGridView3[2, 1].Value = "angle of deflection ";
            dataGridView3[2, 2].Value = "angle of deflection ";
            dataGridView3[2, 3].Value = "angle of deflection ";
            dataGridView3[4, 2].Value = "favorable length ";
            dataGridView3[4, 3].Value = "favorable length  ";
            dataGridView3[2, 5].Value = "module horizontally ";
            dataGridView3[2, 6].Value = "module horizontally ";
            dataGridView3[6, 2].Value = "favorable height ";
            dataGridView3[6, 3].Value = "favorable height ";
            dataGridView3[4, 5].Value = "module vertically ";
            dataGridView3[4, 6].Value = "module vertically";

           
        }

    
       

        private void button1_Click(object sender, EventArgs e)
        {

            chart1.Series[0].Enabled = false;
            chart1.Series[1].Enabled = false;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            r = (int)numericUpDown1.Value;
            trackBar1.Value = r;
            degradacja();
        }

        void degradacja()
        {
            r = (int)numericUpDown1.Value;
            double[] moc = new double[18];
            double[] spr = new double[18];

            for (int i = 1; i <= 17; i++)
            {
                moc[i] = double.Parse(dataGridView1[0, i - 1].Value.ToString());
                spr[i] = double.Parse(dataGridView1[1, i - 1].Value.ToString());
            }


            if (r > 0)
            {
                double[] degrad = new double[26];


                degrad[1] = 0.8; degrad[2] = 1.6;
                degrad[3] = 2.4; degrad[4] = 3.2; degrad[5] = 4.3; degrad[6] = 4.8; degrad[7] = 5.6; degrad[8] = 6.4; degrad[9] = 7.2; degrad[10] = 8.0; degrad[11] = 8.8;
                degrad[12] = 9.6; degrad[13] = 10.4; degrad[14] = 11.2; degrad[15] = 12.0; degrad[16] = 12.8; degrad[17] = 13.6; degrad[18] = 14.4; degrad[19] = 15.2;
                degrad[20] = 16.0; degrad[21] = 16.8; degrad[22] = 17.6; degrad[23] = 18.4; degrad[24] = 19.2; degrad[25] = 20.0;


                for (int i = 1; i <= 25; i++)
                    degrad[i] /= 100.0;
                double[,] moc1 = new double[18, 26];
                double[,] spr1 = new double[18, 26];
                for (int i = 1; i <= 25; i++)
                    for (int j = 1; j <= 17; j++)
                    {
                        moc1[j, i] = moc[j] - degrad[i] * moc[j];
                        spr1[j, i] = spr[j] - degrad[i] * spr[j];

                    }

                for (int i = 1; i <= 25; i++)
                    for (int j = 1; j <= 17; j++)
                    {
                        dataGridView2[1, 0].Value = napis[k];
                        dataGridView2[1, 1].Value = moc1[k, r];
                        dataGridView2[1, 2].Value = spr1[k, r];
                    }



                double year;

                chart1.Series[0].Enabled = true;
                chart1.Series[1].Enabled = true;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                year = moc1[k, r];
                chart1.Series[0].Points.AddXY(r, year);

                for (int i = 1; i <= 25; i++)
                {
                    chart1.Series[1].Points.AddY(moc1[k, i]);

                }

            }

            else // bez degradacji:
            {


                chart1.Series[0].Points.AddXY(0, moc[k]);
                for (int j = 1; j <= 17; j++)
                {

                    dataGridView2[1, 1].Value = moc[k];
                    dataGridView2[1, 2].Value = spr[k];
                }
            

            }


            chart1.Series[0].LegendText = "kW";
            //  chart1.Series[1].LegendText = "[10* C]";
            chart1.ChartAreas[0].AxisX.Maximum = 25;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Title = "degradation";


        }
        void naslonecznienie()
        {
            chart1.Series[0].Enabled = true;
            chart1.Series[1].Enabled = true;
            B[0] = 25; B[1] = 37; B[2] = 77; B[3] = 129; B[4] = 158; B[5] = 160;
            B[6] = 161; B[7] = 132; B[8] = 98; B[9] = 53; B[10] = 26; B[11] = 17;
            C[0] = -1; C[1] = 1; C[2] = 4; C[3] = 10; C[4] = 15; C[5] = 17;
            C[6] = 20; C[7] = 19; C[8] = 14; C[9] = 10; C[10] = 5; C[11] = 0;
          
            chart1.Series[0].LegendText = "kWh/m2";
            chart1.Series[1].LegendText = "[10* C]";
            chart1.ChartAreas[0].AxisX.Maximum = 13;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Title = "Miesiące";
        }

        void zachmurzenie()
        {
            chart1.Series[0].Enabled = true;
            chart1.Series[1].Enabled = true;
            B[0] = 25; B[1] = 37; B[2] = 77; B[3] = 129; B[4] = 158; B[5] = 160;
            B[6] = 161; B[7] = 132; B[8] = 98; B[9] = 53; B[10] = 26; B[11] = 17;
            C[0] = -1; C[1] = 1; C[2] = 4; C[3] = 10; C[4] = 15; C[5] = 17;
            C[6] = 20; C[7] = 19; C[8] = 14; C[9] = 10; C[10] = 5; C[11] = 0;

            chart1.Series[0].LegendText = "kWh/m2";
            chart1.Series[1].LegendText = "[10* C]";
            chart1.ChartAreas[0].AxisX.Maximum = 13;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Title = "Miesiące";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            r = trackBar1.Value;
            numericUpDown1.Value = r;
            degradacja();



        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                for (int i = 0; i < 12; i++)
                {
                    chart1.Series[0].Points.AddY(B[i]);
                    chart1.Series[1].Points.AddY(10 * C[i]);
                }
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }


        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                r = 11;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(r + 1, B[r]);
                chart1.Series[1].Points.AddXY(r + 1, 10 * C[r]);
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                r = 10;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(r + 1, B[r]);
                chart1.Series[1].Points.AddXY(r + 1, 10 * C[r]);
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                r = 9;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(r + 1, B[r]);
                chart1.Series[1].Points.AddXY(r + 1, 10 * C[r]);
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                r = 8;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(r + 1, B[r]);
                chart1.Series[1].Points.AddXY(r + 1, 10 * C[r]);
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                r = 7;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(r + 1, B[r]);
                chart1.Series[1].Points.AddXY(r + 1, 10 * C[r]);
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                r = 6;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(r + 1, B[r]);
                chart1.Series[1].Points.AddXY(r + 1, 10 * C[r]);
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                r = 5;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(r + 1, B[r]);
                chart1.Series[1].Points.AddXY(r + 1, 10 * C[r]);
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                r = 4;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(r + 1, B[r]);
                chart1.Series[1].Points.AddXY(r + 1, 10 * C[r]);
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                r = 3;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(r + 1, B[r]);
                chart1.Series[1].Points.AddXY(r + 1, 10 * C[r]);
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                r = 2;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(r + 1, B[r]);
                chart1.Series[1].Points.AddXY(r + 1, 10 * C[r]);
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                r = 1;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(r + 1, B[r]);
                chart1.Series[1].Points.AddXY(r + 1, 10 * C[r]);
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }


        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                naslonecznienie();
                r = 0;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(r + 1, B[r]);
                chart1.Series[1].Points.AddXY(r + 1, 10 * C[r]);
            }
            else
            {
                chart1.Series[0].Enabled = false;
                chart1.Series[1].Enabled = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            trak = (int)trackBar3.Value;
            label2.Text = "quality" + "  " + trak.ToString() + " [%]";
            trak = 100 - trak;
            label3.Text = "price" + "  " + trak.ToString() + " [%]";
            wybor_panela();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trak = (int)trackBar2.Value;
            label4.Text = "efficiency  " + trak.ToString() + " [%]";
            trak = 100 - trak;
            label5.Text = "temp." + "  " + trak.ToString() + " [%]";
            wybor_panela();
        }

        void wybor_panela()
        {
          
            double[,] tab = new double[18, 4];
            double[] WS = new double[18];

            int jako = (int)trackBar3.Value;
            int cena = 100 - jako;
            int sprawn = (int)trackBar2.Value;
            int temper = 100 - sprawn;

            for (int i = 1; i < 18; i++) // wiersz
                for (int j = 1; j < 4; j++) // kolumna
                    tab[i, j] = double.Parse(dataGridView1[j + 5, i - 1].Value.ToString());


            for (int i = 1; i < 18; i++) // wiersz     
            {
                WS[i] = (tab[i, 1] * cena / 120 + (tab[i, 2] * sprawn / 140 + tab[i, 3] * temper / 110) * jako / 100) / 10;
                dataGridView1[9, i - 1].Value = WS[i].ToString("0.000");
            }

            double max = WS[1];
            string nap = "Poli-(klasyczny)";
            dataGridView2[1, 0].Value = nap;
            int numer = 1;
            for (int i = 2; i < 18; i++)
                if (WS[i] > max) { max = WS[i]; numer = i; nap = napis[i - 2]; }
            for (int i = 1; i < 6; i++)
                dataGridView2[1, i].Value = dataGridView1[i - 1, numer - 1].Value;
            dataGridView2[1, 0].Value = dataGridView1[10, numer - 1].Value;
            

            moc0 = double.Parse(dataGridView1[0, 0].Value.ToString());
            label6.Text = "a panel is selected: " + dataGridView2[1, 0].Value;

        }
     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        

        void oblicz_dach()
        {
            double max, max1, max3, max4;

            double wysa, wysb, jeden, moc_inst;
            // dataGridView2[2, 5].Value = "maksymalna ilość paneli";
            wysa = double.Parse(dataGridView2[1, 3].Value.ToString());
            wysb = double.Parse(dataGridView2[1, 4].Value.ToString());
            jeden = wysa * wysb;


            if (d == 1)
            {
                dataGridView3[1, 0].Value = 0;
                dataGridView3[1, 1].Value = 0;
                x = double.Parse(dataGridView3[1, 2].Value.ToString());
                y = double.Parse(dataGridView3[1, 3].Value.ToString());
                kata = double.Parse(dataGridView3[3, 2].Value.ToString());
                katb = double.Parse(dataGridView3[3, 3].Value.ToString());
                kata *= 3.14 / 180.0;
                katb *= 3.14 / 180.0;
                x1 = x / Math.Cos(katb);
                y1 = y / Math.Cos(kata);

            }
            else if (d == 2)
            {

                dataGridView3[1, 2].Value = double.Parse(dataGridView3[1, 1].Value.ToString());
                dataGridView3[1, 3].Value = double.Parse(dataGridView3[1, 0].Value.ToString());
                dataGridView3[3, 2].Value = double.Parse(dataGridView3[3, 1].Value.ToString());
                dataGridView3[3, 3].Value = double.Parse(dataGridView3[3, 0].Value.ToString());

                x = double.Parse(dataGridView3[1, 0].Value.ToString());
                y = double.Parse(dataGridView3[1, 1].Value.ToString());

                kata = double.Parse(dataGridView3[3, 0].Value.ToString());
                katb = double.Parse(dataGridView3[3, 1].Value.ToString());
                kata *= 3.14 / 180.0;
                katb *= 3.14 / 180.0;
                x1 = 0.5 * x / Math.Cos(katb);
                y1 = 0.5 * y / Math.Cos(kata);


            }
            else if (d == 5)
            {

                dataGridView3[1, 2].Value = double.Parse(dataGridView3[1, 1].Value.ToString());
                dataGridView3[1, 3].Value = double.Parse(dataGridView3[1, 0].Value.ToString());
                dataGridView3[3, 2].Value = double.Parse(dataGridView3[3, 1].Value.ToString());
                dataGridView3[3, 3].Value = double.Parse(dataGridView3[3, 0].Value.ToString());

                x = double.Parse(dataGridView3[1, 0].Value.ToString());
                y = double.Parse(dataGridView3[1, 1].Value.ToString());

                kata = double.Parse(dataGridView3[3, 0].Value.ToString());
                katb = double.Parse(dataGridView3[3, 1].Value.ToString());
                kata *= 3.14 / 180.0;
                katb *= 3.14 / 180.0;
                x1 = 0.4 * x / Math.Cos(katb);
                y1 = 0.4 * y / Math.Cos(kata);


            }

            if (d == 1 || d == 2 || d==5 || d==6)
            {
                dataGridView3[1, 4].Value = (x1 * y1).ToString("0.00");
                dataGridView3[5, 2].Value = (x - 2.0 * 0.2).ToString("0.00");
                dataGridView3[5, 3].Value = (y - 2.0 * 0.2).ToString("0.00");
                dataGridView3[7, 2].Value = (y1 - 2.0 * 0.35).ToString("0.00");
                dataGridView3[7, 3].Value = (x1 - 2.0 * 0.35).ToString("0.000");
                double wpisz;

                wpisz = (int)((x - 2 * 0.2) / (wysb + 0.01));
                dataGridView3[3, 5].Value = wpisz.ToString();
                wpisz = (int)((y - 2 * 0.2) / (wysb + 0.01));
                dataGridView3[3, 6].Value = wpisz.ToString();
                //------------------------------------------------------------------------
                wpisz = (int)((y1 - 2 * 0.35) / (wysa + 0.01));
                dataGridView3[5, 5].Value = wpisz.ToString();
                wpisz = (int)((x1 - 2 * 0.35) / (wysa + 0.01));
                dataGridView3[5, 6].Value = wpisz.ToString();

                dataGridView3[1, 6].Value = double.Parse(dataGridView3[3, 6].Value.ToString()) * double.Parse(dataGridView3[5, 6].Value.ToString());
                dataGridView3[1, 5].Value = double.Parse(dataGridView3[3, 5].Value.ToString()) * double.Parse(dataGridView3[5, 5].Value.ToString());

                max = double.Parse(dataGridView2[3, 1].Value.ToString());
                max1 = double.Parse(dataGridView2[3, 2].Value.ToString());
                max3 = double.Parse(dataGridView2[3, 3].Value.ToString());
                max4 = double.Parse(dataGridView2[3, 4].Value.ToString());
                if (max <= 90 && kata > 0) dataGridView2[3, 5].Value = dataGridView3[1, 5].Value;
                else if (max1 <= 90 && katb > 0) dataGridView2[3, 5].Value = dataGridView3[1, 6].Value;
                else if (max3 <= 90 && katb > 0) dataGridView2[3, 5].Value = dataGridView3[1, 6].Value;
                else if (max4 <= 90 && kata > 0) dataGridView2[3, 5].Value = dataGridView3[1, 5].Value;
                else dataGridView2[3, 5].Value = 0;

                moc_inst = moc0 * double.Parse(dataGridView2[3, 5].Value.ToString());

                dataGridView2[5, 0].Value = jeden;
                dataGridView2[5, 1].Value = moc_inst;
            }
            else if (d == 3)
            {

                dataGridView3[1, 2].Value = double.Parse(dataGridView3[1, 1].Value.ToString());
                dataGridView3[1, 3].Value = double.Parse(dataGridView3[1, 0].Value.ToString());
                double poch;
                poch = double.Parse(dataGridView3[3, 0].Value.ToString());
                if (poch > 90) poch = 90;
                dataGridView3[3, 0].Value = poch;
                dataGridView3[3, 2].Value = poch;
                dataGridView3[3, 3].Value = poch;
                dataGridView3[3, 1].Value = poch;
                x = double.Parse(dataGridView3[1, 0].Value.ToString());
                y = double.Parse(dataGridView3[1, 1].Value.ToString());
                double maks = 0, min = 0, d_a, d_b, d_c, d_d, d_e, poziomy;
                if (x > y) { maks = x; min = y; }
                else { maks = y; min = x; }
                d_a = maks - min; // kalenica
                d_b = min / 2.0; // naroże

                kata = double.Parse(dataGridView3[3, 0].Value.ToString());

                kata *= 3.14 / 180.0;

                d_c = d_b * Math.Tan(kata); // wysokość poddasza
                d_d = Math.Sqrt(d_b * d_b + d_c * d_c); // wysokość dachu
                d_e = Math.Sqrt(d_b * d_b + d_d * d_d); // długość krawędzi dachu
                poziomy = (int)(d_d / (wysa + 0.01) - 2.0 * 0.35);
                double[,] tabela = new double[26, 9];

                for (int i = 1; i < 26; i++)
                    tabela[i, 1] = i;
                for (int i = 1; i < 26; i++)
                    if (tabela[i, 1] <= poziomy) tabela[i, 2] = 1;
                for (int i = 1; i < 26; i++)
                    tabela[i, 3] = d_d - 0.35 - tabela[i, 1] * (wysa + 0.01) - 2.0 * 0.2;
                for (int i = 1; i < 26; i++)
                    tabela[i, 4] = (int)(tabela[i, 3] / (wysb + 0.01));
                for (int i = 1; i < 26; i++)
                    tabela[i, 5] = tabela[i, 4] * tabela[i, 2];
                for (int i = 1; i < 26; i++)
                    tabela[i, 6] = tabela[i, 3] + d_a;
                for (int i = 1; i < 26; i++)
                    tabela[i, 7] = (int)(tabela[i, 6] / wysb + 0.01);
                for (int i = 1; i < 26; i++)
                    tabela[i, 8] = tabela[i, 7] * tabela[i, 2];

                double suma = 0, suma1 = 0;
                for (int i = 1; i < 26; i++)
                    suma += tabela[i, 5];
                for (int i = 1; i < 26; i++)
                    suma1 += tabela[i, 8];
                dataGridView2[3, 5].Value = suma + suma1;
                dataGridView3[1, 5].Value = suma;
                dataGridView3[1, 6].Value = suma1;
                dataGridView3[1, 4].Value = " ";
                dataGridView3[3, 5].Value = " ";
                dataGridView3[3, 6].Value = " ";
                dataGridView3[5, 5].Value = " ";
                dataGridView3[5, 6].Value = " ";
                dataGridView3[5, 2].Value = " ";
                dataGridView3[5, 3].Value = " ";
                dataGridView3[7, 2].Value = " ";
                dataGridView3[7, 3].Value = " ";
                moc_inst = moc0 * double.Parse(dataGridView2[3, 5].Value.ToString());

                dataGridView2[5, 0].Value = jeden;
                dataGridView2[5, 1].Value = moc_inst;

            }

            else if (d == 4)
            {

                dataGridView3[1, 1].Value = double.Parse(dataGridView3[1, 0].Value.ToString());
                dataGridView3[1, 2].Value = double.Parse(dataGridView3[1, 0].Value.ToString());
                dataGridView3[1, 3].Value = double.Parse(dataGridView3[1, 0].Value.ToString());
                double poch;
                poch = double.Parse(dataGridView3[3, 0].Value.ToString());
                if (poch > 90) poch = 90;
                dataGridView3[3, 0].Value = poch;
                dataGridView3[3, 2].Value = poch;
                dataGridView3[3, 3].Value = poch;
                dataGridView3[3, 1].Value = poch;

                x = double.Parse(dataGridView3[1, 0].Value.ToString());
                y = double.Parse(dataGridView3[1, 1].Value.ToString());
                double maks = 0, min = 0, d_a, d_b, d_c, d_d, d_e, poziomy;
                if (x > y) { maks = x; min = y; }
                else { maks = y; min = x; }
                d_a = maks - min; // kalenica
                d_b = min / 2.0; // naroże

                kata = double.Parse(dataGridView3[3, 0].Value.ToString());

                kata *= 3.14 / 180.0;

                d_c = d_b * Math.Tan(kata); // wysokość poddasza
                d_d = Math.Sqrt(d_b * d_b + d_c * d_c); // wysokość dachu
                d_e = Math.Sqrt(d_b * d_b + d_d * d_d); // długość krawędzi dachu
                poziomy = (int)(d_d / (wysa + 0.01) - 2.0 * 0.35);
                double[,] tabela = new double[26, 9];

                for (int i = 1; i < 26; i++)
                    tabela[i, 1] = i;
                for (int i = 1; i < 26; i++)
                    if (tabela[i, 1] <= poziomy) tabela[i, 2] = 1;
                for (int i = 1; i < 26; i++)
                    tabela[i, 3] = d_d - 0.35 - tabela[i, 1] * (wysa + 0.01) - 2.0 * 0.2;
                for (int i = 1; i < 26; i++)
                    tabela[i, 4] = (int)(tabela[i, 3] / (wysb + 0.01));
                for (int i = 1; i < 26; i++)
                    tabela[i, 5] = tabela[i, 4] * tabela[i, 2];
                for (int i = 1; i < 26; i++)
                    tabela[i, 6] = tabela[i, 3] + d_a;
                for (int i = 1; i < 26; i++)
                    tabela[i, 7] = (int)(tabela[i, 6] / wysb + 0.01);
                for (int i = 1; i < 26; i++)
                    tabela[i, 8] = tabela[i, 7] * tabela[i, 2];

                double suma = 0, suma1 = 0;
                for (int i = 1; i < 26; i++)
                    suma += tabela[i, 5];
                for (int i = 1; i < 26; i++)
                    suma1 += tabela[i, 8];
                dataGridView2[3, 5].Value = suma + suma1;
                dataGridView3[1, 5].Value = suma;
                dataGridView3[1, 6].Value = suma1;
                dataGridView3[1, 4].Value = " ";
                dataGridView3[3, 5].Value = " ";
                dataGridView3[3, 6].Value = " ";
                dataGridView3[5, 5].Value = " ";
                dataGridView3[5, 6].Value = " ";
                dataGridView3[5, 2].Value = " ";
                dataGridView3[5, 3].Value = " ";
                dataGridView3[7, 2].Value = " ";
                dataGridView3[7, 3].Value = " ";
                moc_inst = moc0 * double.Parse(dataGridView2[3, 5].Value.ToString());

                dataGridView2[5, 0].Value = jeden;
                dataGridView2[5, 1].Value = moc_inst;
            }

        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            d = 10;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
          

        }

       
             private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            d = 6;
            pictureBox7.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox1.Visible = false;
            dataGridView3[1, 0].Value = 15;
            dataGridView3[1, 1].Value = 8;
            dataGridView3[1, 2].Value = 8;
            dataGridView3[1, 3].Value = 20;

            dataGridView3[3, 0].Value = 20;
            dataGridView3[3, 1].Value = 0;
            dataGridView3[3, 2].Value = 0;
            dataGridView3[3, 3].Value = 20;
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            d = 5;
            pictureBox6.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
           pictureBox1.Visible = false;
            pictureBox7.Visible = false;         

            dataGridView3[1, 0].Value = 20;
            dataGridView3[1, 1].Value = 10;
            dataGridView3[1, 2].Value = 10;
            dataGridView3[1, 3].Value = 20;

            dataGridView3[3, 0].Value = 30;
            dataGridView3[3, 1].Value = 0;
            dataGridView3[3, 2].Value = 0;
            dataGridView3[3, 3].Value = 30;
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            d = 4;
            pictureBox5.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox1.Visible = false;

             dataGridView3[1, 0].Value = 20;
            dataGridView3[1, 1].Value = 20;
            dataGridView3[1, 2].Value = 20;
            dataGridView3[1, 3].Value = 20;

       

            dataGridView3[3, 0].Value = 30;
            dataGridView3[3, 1].Value = 30;
            dataGridView3[3, 2].Value = 30;
            dataGridView3[3, 3].Value = 30;
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            d = 3;
            pictureBox4.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox1.Visible = false;

            dataGridView3[1, 0].Value = 20;
            dataGridView3[1, 1].Value = 10;
            dataGridView3[1, 2].Value = 10;
            dataGridView3[1, 3].Value = 20;

       

            dataGridView3[3, 0].Value = 30;
            dataGridView3[3, 1].Value = 30;
            dataGridView3[3, 2].Value = 30;
            dataGridView3[3, 3].Value = 30;
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            d = 2;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox1.Visible = false;

            dataGridView3[1, 0].Value = 20;
            dataGridView3[1, 1].Value = 10;
            dataGridView3[1, 2].Value = 10;
            dataGridView3[1, 3].Value = 20;
            
            dataGridView3[3, 0].Value = 30;
            dataGridView3[3, 1].Value = 0;
            dataGridView3[3, 2].Value = 0;
            dataGridView3[3, 3].Value = 30;
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            d = 1;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox1.Visible = false;

            dataGridView3[1, 0].Value = 0;
            dataGridView3[1, 1].Value = 0;
            dataGridView3[1, 2].Value = 20;
            dataGridView3[1, 3].Value = 10;
            dataGridView3[3, 0].Value = 0;
            dataGridView3[3, 1].Value = 0;
            dataGridView3[3, 2].Value = 30;
            dataGridView3[3, 3].Value = 0;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            kompas();
           
            double b1;
            // b - kąt nachylenia dachu
            b1 = (kat_b * Math.PI) / 180.0;

            Complex rys = new Complex(4 * Math.Cos(b1), 4 * Math.Sin(b1));
            label8.Text = "roof slope: " + kat_b.ToString();

            chart2.Series[0].Points.Clear();
            double t, dt, punkt;
            punkt = rys.Imaginary / rys.Real;
            int n = 500;
            dt = 6.0 / n;
            chart2.ChartAreas[0].AxisX.Minimum = -4;
            chart2.ChartAreas[0].AxisX.Maximum = 4;
            chart2.ChartAreas[0].AxisY.Minimum = -4;
            chart2.ChartAreas[0].AxisY.Maximum = 4;
            chart2.ChartAreas[0].AxisY.Interval = 1;
            chart2.ChartAreas[0].AxisX.Interval = 1;
            //for (int i = -5; i < 5; i++)
            //    chart2.Series[0].Points.AddXY(rys.Real, rys.Imaginary);

            if ((kat_b >= 0 && kat_b < 90) ||(kat_b > 270 && kat_b <= 360))
            {
                for (int i = 0; i < n; i++)
                {
                    t = i * dt;
                    chart2.Series[0].Points.AddXY(t, punkt * t);

                }
            }
            else if (kat_b > 90 && kat_b <= 270)
            {
                for (int i = -n; i < 0; i++)
                {
                    t = i * dt;
                    chart2.Series[0].Points.AddXY(t, punkt * t);

                }
            }

            oblicz_dach();
        }


        void kompas()
        {
            kat_b = (int)trackBar5.Value;
            zz = kat_b;
                       if (zz >= 0 && zz <= 180) aa = zz;
            else aa = 360 - zz;
            if ((zz > 180 && aa - 90 >= 0) || (zz <= 180 && aa + 90 >= 0))
            {
                if (aa > 180) bb = aa - 90;
                else bb = aa + 90;
            }
            if ((zz > 180 && aa - 90 < 0) || (zz <= 180 && aa + 90 < 0))
            {
                if (aa > 180) bb = -1.0 * (aa - 90);
                else bb = -1 * (aa + 90);
            }
            if ((zz > 180 && aa + 90 >= 0) || (zz <= 180 && aa - 90 >= 0))
            {
                if (aa > 180) cc = aa + 90;
                else cc = aa - 90;
            }
            if ((zz > 180 && aa + 90 < 0) || (zz <= 180 && aa - 90 < 0))
            {
                if (aa > 180) cc = -1.0 * (aa + 90);
                else cc = -1.0 * (aa - 90);
            }
            dd = 180 - aa;

            dataGridView2[3, 0].Value = zz;
            dataGridView2[3, 1].Value = Math.Abs(aa);
            dataGridView2[3, 2].Value = Math.Abs(cc);
            dataGridView2[3, 3].Value = Math.Abs(bb);
            dataGridView2[3, 4].Value = Math.Abs(dd);
            dataGridView2[3, 5].Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (d != 10)
            {
                kompas();
                oblicz_dach();
                tabela_naslonecznienie();
            }
        }

       

        void tabela_naslonecznienie()
        {
            double[,] NAS = new double[13, 25];
            double[,] KOR_IL = new double[13, 25];
            double[,] KOR_TEMP = new double[13, 25];
            double[,] KOR_TYP_SPR=new double[13,25];
            double[,] KOR_SYS_SPR = new double[13, 25];
            double[,] FRONT = new double[13, 25];
            double[,] PRAWA = new double[13, 25];
            double[,] LEWA = new double[13, 25];
            double[,] TYLNA = new double[13, 25];
            double cz_zachm, duze_zachm;
            double spr_systemu;
            double[] wektro_FRONT = new double[13];
            double[] wektro_PRAWY = new double[13];
            double[] wektro_LEWY = new double[13];
            double[] wektro_TYL = new double[13];
            double[] wektor_korekt_temp = new double[13];
            double[] wektro_korekt = new double[13];
            double[,] wspolczynnik = new double[13, 4];
            double[,] wspolczynnik1 = new double[13, 10];
            double[,] wspolczynnik2 = new double[13, 10];
            double sr_temp_wsp_mocy = double.Parse(dataGridView2[1, 5].Value.ToString());
            double typowa_spr = double.Parse(dataGridView2[1, 2].Value.ToString());
            double ilosc_paneli = double.Parse(dataGridView2[3, 5].Value.ToString());
            double powierzchnia_panela = double.Parse(dataGridView2[5, 0].Value.ToString());
            double produkcja_ogolem;
            double sprawnosc_sys;
            // -------------------------------------------------------------------------------------------
            NAS[1, 10] = 141; NAS[1, 11] = 165; NAS[1, 12] = 165; NAS[1, 13] = 139;
            NAS[2, 9] = 170; NAS[2, 10] = 225; NAS[2, 11] = 266; NAS[2, 12] = 257; NAS[2, 13] = 230; NAS[2, 14] = 178; NAS[2, 15] = 108;
            NAS[3, 7] = 110; NAS[3, 8] = 199; NAS[3, 9] = 277; NAS[3, 10] = 335; NAS[3, 11] = 335; NAS[3, 12] = 334; NAS[3, 13] = 333; NAS[3, 14] = 274; NAS[3, 15] = 194; NAS[3, 16] = 105;
            NAS[4, 7] = 123; NAS[4, 8] = 220; NAS[4, 9] = 313; NAS[4, 10] = 391; NAS[4, 11] = 446; NAS[4, 12] = 472; NAS[4, 13] = 736; NAS[4, 14] = 430; NAS[4, 15] = 336; NAS[4, 16] = 282; NAS[4, 17] = 186;
            NAS[5, 6] = 104; NAS[5, 7] = 197; NAS[5, 8] = 294; NAS[5, 9] = 385; NAS[5, 10] = 460; NAS[5, 11] = 511; NAS[5, 12] = 534; NAS[5, 13] = 527; NAS[5, 14] = 490; NAS[5, 15] = 427; NAS[5, 16] = 344; NAS[5, 17] = 249; NAS[5, 18] = 152;
            NAS[6, 6] = 129; NAS[6, 7] = 222; NAS[6, 8] = 317; NAS[6, 9] = 406; NAS[6, 10] = 480; NAS[6, 11] = 531; NAS[6, 12] = 556; NAS[6, 13] = 551; NAS[6, 14] = 517; NAS[6, 15] = 458; NAS[6, 16] = 378; NAS[6, 17] = 286; NAS[6, 18] = 190; NAS[6, 19] = 100;
            NAS[7, 6] = 108; NAS[7, 7] = 199; NAS[7, 8] = 295; NAS[7, 9] = 385; NAS[7, 10] = 461; NAS[7, 11] = 515; NAS[7, 12] = 542; NAS[7, 13] = 540; NAS[7, 14] = 508; NAS[7, 15] = 451; NAS[7, 16] = 372; NAS[7, 17] = 280; NAS[7, 18] = 183;
            NAS[8, 7] = 145; NAS[8, 8] = 242; NAS[8, 9] = 333; NAS[8, 10] = 411; NAS[8, 11] = 466; NAS[8, 12] = 493; NAS[8, 13] = 490; NAS[8, 14] = 457; NAS[8, 15] = 396; NAS[8, 16] = 315; NAS[8, 17] = 221; NAS[8, 18] = 124;
            NAS[9, 8] = 169; NAS[9, 9] = 258; NAS[9, 10] = 332; NAS[9, 11] = 383; NAS[9, 12] = 406; NAS[9, 13] = 398; NAS[9, 14] = 360; NAS[9, 15] = 295; NAS[9, 16] = 212; NAS[9, 17] = 120;
            NAS[10, 9] = 168; NAS[10, 10] = 235; NAS[10, 11] = 279; NAS[10, 12] = 297; NAS[10, 13] = 284; NAS[10, 14] = 243; NAS[10, 15] = 197; NAS[10, 16] = 102;
            NAS[11, 9] = 139; NAS[11, 10] = 178; NAS[11, 11] = 193; NAS[11, 12] = 181; NAS[11, 13] = 145;
            NAS[12, 10] = 126; NAS[12, 11] = 144; NAS[12, 12] = 137; NAS[12, 13] = 107;
            // -------------------------------------------------------------------------------------------
          
            wspolczynnik[1, 1] = 3.2; wspolczynnik[2, 1] = 2.4; wspolczynnik[3, 1] = 4.0; wspolczynnik[4, 1] = 6.4; wspolczynnik[5, 1] = 6.8; wspolczynnik[6, 1] = 5.4;
            wspolczynnik[7, 1] = 8.4; wspolczynnik[8, 1] = 8.8; wspolczynnik[9, 1] = 7.6; wspolczynnik[10, 1] = 7.9; wspolczynnik[11, 1] = 4.8; wspolczynnik[12, 1] = 3.3;
            jakosc = trak = (int)trackBar3.Value;
            wspolczynnik[1, 2] = 10.3; wspolczynnik[2, 2] = 10.7; wspolczynnik[3, 2] = 14.5; wspolczynnik[4, 2] = 15.1; wspolczynnik[5, 2] = 16.7; wspolczynnik[6, 2] = 17.9;
            wspolczynnik[7, 2] = 17.5; wspolczynnik[8, 2] = 16.5; wspolczynnik[9, 2] = 13.9; wspolczynnik[10, 2] = 13.7; wspolczynnik[11, 2] = 11.6; wspolczynnik[12, 2] = 10.6;

            wspolczynnik[1, 3] = 17.5; wspolczynnik[2, 3] = 15.2; wspolczynnik[3, 3] = 12.5; wspolczynnik[4, 3] = 8.5; wspolczynnik[5, 3] = 7.5; wspolczynnik[6, 3] = 6.7;
            wspolczynnik[7, 3] = 5.1; wspolczynnik[8, 3] = 5.6; wspolczynnik[9, 3] = 8.5; wspolczynnik[10, 3] = 9.4; wspolczynnik[11, 3] = 13.5; wspolczynnik[12, 3] = 17.0;
            cz_zachm = 5.0 + (20.0 * ((100.0 - jakosc) / 100.0));
            duze_zachm = 100 * (0.2 + 0.8 * ((100 - jakosc) / 100));
            for (int i = 1; i < 13; i++)
                wspolczynnik[i, 2] = wspolczynnik[i, 2] - ((wspolczynnik[i, 2] * cz_zachm) / 100.0);
            for (int i = 1; i < 13; i++)
                wspolczynnik[i, 3] = wspolczynnik[i, 3] - wspolczynnik[i, 3] * duze_zachm / 100.0;

            double suma = 0;
           
            for (int i = 1; i < 13; i++) // i - wiersz
            {   suma = 0;
                for (int j = 1; j < 4; j++) // j -kolumna
                {
                    suma+=wspolczynnik[i, j];
                  
                }
                wektro_korekt[i] = suma;
            }
            // -------------------------------------------------------------------------------------------
            for (int i = 1; i < 13; i++)
                for (int j = 0; j < 25; j++)
                    KOR_IL[i, j] = (int)(NAS[i, j] * wektro_korekt[i]);
            //--------------------------------------------------------------------------------------
             wspolczynnik1[1,1]=0;  wspolczynnik1[1,2]=0;  wspolczynnik1[1,3]=0;  wspolczynnik1[1,4]=0;  wspolczynnik1[1,5]=1.2;  wspolczynnik1[1,6]=7.1;
             wspolczynnik1[1, 7] = 12.8; wspolczynnik1[1, 8] = 7.8; wspolczynnik1[1, 9] = 1.8;
            wspolczynnik1[2, 1] = 0; wspolczynnik1[2, 2] = 0; wspolczynnik1[2, 3] = 0; wspolczynnik1[2, 4] = 0.2; wspolczynnik1[2, 5] = 2.8; wspolczynnik1[2, 6] = 7.7;
             wspolczynnik1[2, 7] = 10.3; wspolczynnik1[2, 8] = 5.8; wspolczynnik1[2, 9] = 1.2; 
            wspolczynnik1[3, 1] = 0; wspolczynnik1[3, 2] = 0; wspolczynnik1[3, 3] = 0.2; wspolczynnik1[3, 4] = 2.9; wspolczynnik1[3, 5] = 8.6; wspolczynnik1[3, 6] = 10.7;
             wspolczynnik1[3, 7] = 6.5; wspolczynnik1[3, 8] = 2.0; wspolczynnik1[3, 9] = 0.1; 
            wspolczynnik1[4, 1] = 0; wspolczynnik1[4, 2] = 0.5; wspolczynnik1[4, 3] = 4.1; wspolczynnik1[4, 4] = 10.2; wspolczynnik1[4, 5] = 9.7; wspolczynnik1[4, 6] = 4.5;
             wspolczynnik1[4, 7] = 1.0; wspolczynnik1[4, 8] = 0; wspolczynnik1[4, 9] = 0; 
            wspolczynnik1[5, 1] = 0.1; wspolczynnik1[5, 2] = 3.7; wspolczynnik1[5, 3] = 10.5; wspolczynnik1[5, 4] = 11.6; wspolczynnik1[5, 5] = 4.7; wspolczynnik1[5, 6] = 0.4;
            wspolczynnik1[5, 7] = 0; wspolczynnik1[5, 8] = 0; wspolczynnik1[5, 9] = 0; 
            wspolczynnik1[6, 1] = 1.3; wspolczynnik1[6, 2] = 6.4; wspolczynnik1[6, 3] = 12.1; wspolczynnik1[6, 4] = 8.7; wspolczynnik1[6, 5] = 1.5; wspolczynnik1[6, 6] = 0;
             wspolczynnik1[6, 7] = 0; wspolczynnik1[6, 8] = 0; wspolczynnik1[6, 9] = 0; 
            wspolczynnik1[7, 1] = 3.5; wspolczynnik1[7, 2] = 10.7; wspolczynnik1[7, 3] = 11.2; wspolczynnik1[7, 4] = 5.2; wspolczynnik1[7, 5] = 0.1; wspolczynnik1[7, 6] = 0;
             wspolczynnik1[7, 7] = 0; wspolczynnik1[7, 8] = 0; wspolczynnik1[7, 9] = 0;
             wspolczynnik1[8, 1] = 3.7; wspolczynnik1[8, 2] = 10.9; wspolczynnik1[8, 3] = 11.5; wspolczynnik1[8, 4] = 4.3; wspolczynnik1[8, 5] = 0.3; wspolczynnik1[8, 6] = 0;
             wspolczynnik1[8, 7] = 0; wspolczynnik1[8, 8] = 0; wspolczynnik1[8, 9] = 0; 
            wspolczynnik1[9, 1] = 0.1; wspolczynnik1[9, 2] = 4.5; wspolczynnik1[9, 3] = 9.8; wspolczynnik1[9, 4] = 11.1; wspolczynnik1[9, 5] = 4.2; wspolczynnik1[9, 6] = 0.3;
             wspolczynnik1[9, 7] = 0.4; wspolczynnik1[9, 8] = 0; wspolczynnik1[9, 9] = 0; 
            wspolczynnik1[10, 1] = 0; wspolczynnik1[10, 2] = 0.6; wspolczynnik1[10, 3] = 5.7; wspolczynnik1[10, 4] = 9.2; wspolczynnik1[10, 5] = 10.6; wspolczynnik1[10, 6] = 4.6;
             wspolczynnik1[10, 7] = 12.8; wspolczynnik1[10, 8] = 7.8; wspolczynnik1[10, 9] = 1.8;
           wspolczynnik1[11, 1] = 0; wspolczynnik1[11, 2] = 0; wspolczynnik1[11, 3] = 0.1; wspolczynnik1[11, 4] = 2.3; wspolczynnik1[11, 5] = 8.5; wspolczynnik1[11, 6] = 11.2;
             wspolczynnik1[11, 7] = 6.9; wspolczynnik1[11, 8] = 0.9; wspolczynnik1[11, 9] = 0.1; 
            wspolczynnik1[12, 1] = 0; wspolczynnik1[12, 2] = 0; wspolczynnik1[12, 3] = 0; wspolczynnik1[12, 4] = 0; wspolczynnik1[12, 5] = 1.4; wspolczynnik1[12, 6] = 8.8;
             wspolczynnik1[12, 7] = 14.4; wspolczynnik1[12, 8] = 5.6; wspolczynnik1[12, 9] = 0.7;  
          //--------------------------------------------------------------------------------------------------------------
             for (int i = 1; i < 13; i++)
                 wspolczynnik2[i, 1] = (25 - 33) * sr_temp_wsp_mocy * wspolczynnik1[i, 1];
             for (int i = 1; i < 13; i++)
                 wspolczynnik2[i, 2] = (25 - 27.5) * sr_temp_wsp_mocy * wspolczynnik1[i, 2];
             for (int i = 1; i < 13; i++)
                 wspolczynnik2[i, 3] = (25 - 22.5) * sr_temp_wsp_mocy * wspolczynnik1[i, 3];
             for (int i = 1; i < 13; i++)
                 wspolczynnik2[i, 4] = (25 - 17.5) * sr_temp_wsp_mocy * wspolczynnik1[i, 4];
             for (int i = 1; i < 13; i++)
                 wspolczynnik2[i, 5] = (25 - 12.5) * sr_temp_wsp_mocy * wspolczynnik1[i, 5];
             for (int i = 1; i < 13; i++)
                 wspolczynnik2[i, 6] = (25 - 7.5) * sr_temp_wsp_mocy * wspolczynnik1[i, 6];
             for (int i = 1; i < 13; i++)
                 wspolczynnik2[i, 7] = (25 - 2.5) * sr_temp_wsp_mocy * wspolczynnik1[i, 7];
             for (int i = 1; i < 13; i++)
                 wspolczynnik2[i, 8] = (25 + 2.5) * sr_temp_wsp_mocy * wspolczynnik1[i, 8];
             for (int i = 1; i < 13; i++)
                 wspolczynnik2[i, 9] = (25 + 7.5) * sr_temp_wsp_mocy * wspolczynnik1[i, 9];
           

            for (int i = 1; i < 13; i++) // i - wiersz
            {
                suma = 0;
                for (int j = 1; j < 10; j++) // j -kolumna
                {
                    suma += wspolczynnik2[i, j];

                }
                wektor_korekt_temp[i] = suma/9.0;
            }
         // -------------------------------------------------------------------------------------------
            for (int i = 1; i < 13; i++)
                for (int j = 0; j < 25; j++)                 
                    KOR_TEMP[i, j] = (int)(KOR_IL[i,j]*(wektor_korekt_temp[i] / 100 + 1));
         //---------------------------------------------------------------------------------------
            for (int i = 1; i < 13; i++)
                for (int j = 0; j < 25; j++)
                    KOR_TYP_SPR[i, j] = (KOR_TEMP[i, j] * typowa_spr  / 100);
        // -------------------------------------------------------------------------------------------

            //---------------------------------------------------------------------------------------
            spr_systemu = 1 - 0.1 - 0.2 * ((100 - jakosc) / 100);
            for (int i = 1; i < 13; i++)
                for (int j = 0; j < 25; j++)
                    KOR_SYS_SPR[i, j] = (KOR_TYP_SPR[i, j] * spr_systemu);
            // -------------------------------------------------------------------------------------------
           //LEWA Ściana:
            for (int i = 1; i < 13; i++)
                for (int j = 0; j < 25; j++)
                    LEWA[i, j] = (KOR_SYS_SPR[i, j] * ilosc_paneli*powierzchnia_panela);
            //-----------------------------------------------------------------------------------
            suma = 0;
            for (int i = 1; i < 13; i++)
            {
                suma = 0;
                for (int j = 0; j < 25; j++)
                    suma += LEWA[i, j];
                wektro_LEWY[i] = suma/1000;
            }
           
            suma=0;
            for (int i = 1; i < 13; i++)
                suma += wektro_LEWY[i];
                produkcja_ogolem = suma;


               dataGridView2[5, 2].Value = produkcja_ogolem.ToString("0.000");
            sprawnosc_sys=  (produkcja_ogolem / double.Parse(dataGridView2[5, 1].Value.ToString())) * 100.0;
            dataGridView2[5, 3].Value =sprawnosc_sys.ToString("0.0") ;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

    }
}
