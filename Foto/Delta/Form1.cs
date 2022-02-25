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
            //degradacja();
            wybor_panela();
            d = 1;
          

            dataGridView3[1, 0].Value = 0;
            dataGridView3[1, 1].Value = 0;
            dataGridView3[1, 2].Value = 20;
            dataGridView3[1, 3].Value = 10;
            dataGridView3[3, 0].Value = 0;
            dataGridView3[3, 1].Value = 0;
            dataGridView3[3, 2].Value = 30;
            dataGridView3[3, 3].Value = 0;
            dataGridView1[1, 0].Value = 0;
            dataGridView1[1, 1].Value = 0;
            dataGridView1[1, 2].Value = 20;
            dataGridView1[1, 3].Value = 10;
            dataGridView1[3, 0].Value = 0;
            dataGridView1[3, 1].Value = 0;
            dataGridView1[3, 2].Value = 30;
            dataGridView1[3, 3].Value = 0;
            solution();
        }
        double x, y, x1, y1,kata=0, katb=0; double kata1=0, katb1=0;
        double[,] A = new double[7, 18];
        int k = 1, r = 1, d = 10, trak;
        double[,] data = new double[11,18];
        double[] BB = new double[17];
        double[] C = new double[12];
        double[] B = new double[12];
        double[] Mounth = new double[12];
        double[] degrad=new double[26];
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

           
            dataGridView2[0, 0].Value = "Panel type";
            dataGridView2[0, 1].Value = "Typical power Wp";
            dataGridView2[0, 2].Value = "Typical efficiency";
            dataGridView2[0, 3].Value = "Width a";
            dataGridView2[0, 4].Value = "Height b";
            dataGridView2[0, 5].Value = "average temperature power factor";

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


            
            data[0, 0] = 280;
            data[0,1] = 100;
            data[0,2] = 290;
            data[0,3] = 300;
            data[0,4] = 295;
            data[0,5] = 325;
            data[0,6] = 320;
            data[0,7] = 100;
            data[0,8] = 325;
            data[0,9] = 140;
            data[0,10] = 280;
            data[0,11] = 295;
            data[0,12] = 275;
            data[0,13] = 300;
            data[0,14]= 330;
            data[0,15] = 300;
            data[0,16] = 333;


            data[1, 0] = 17.2;
            data[1, 1] = 8.3;
            data[1, 2] = 17.6;
            data[1, 3] = 18.5;
            data[1, 4] = 18.2;
            data[1, 5] = 19.8;
            data[1, 6] = 19.7;
            data[1, 7] = 13.9;
            data[1, 8] = 20;
            data[1, 9] = 13.4;
            data[1, 10] = 17.2;
            data[1, 11] = 18.2;
            data[1, 12]= 16.9;
            data[1, 13] = 18.5;
            data[1, 14] = 20.1;
            data[1, 15] = 18.3;
            data[1, 16] = 20.5;

            data[2, 0] = 0.99;
            data[2, 1] = 1.0;
            data[2, 2] = 0.99;
            data[2, 3] = 0.99;
            data[2, 4] = 0.99;
            data[2, 5] = 0.99;
            data[2, 6] = 0.99;
            data[2, 7] = 0.6;
            data[2, 8] = 0.99;
            data[2, 9] = 1;
            data[2, 10] = 0.66;
            data[2, 11] = 0.99;
            data[2, 12] = 0.99;
            data[2, 13] = 0.99;
            data[2, 14] = 1.05;
            data[2, 15] = 1.0;
            data[2, 16] = 1.04;

            data[3, 0] = 1.64;
            data[3, 1] = 1.2;
            data[3, 2] = 1.66;
            data[3, 3] = 1.64;
            data[3, 4]= 1.64;
            data[3, 5] = 1.66;
            data[3, 6] = 1.64;
            data[3, 7] = 1.2;
            data[3, 8]= 1.64;
            data[3, 9] = 1.58;
            data[3, 10] = 1.64;
            data[3, 11] = 1.64;
            data[3, 12] = 1.64;
            data[3, 13] = 1.64;
            data[3, 14] = 1.59;
            data[3, 15] = 1.64;
            data[3, 16] = 1.56;

            data[4, 0] = 0.41;
            data[4, 1] = 0.25;
            data[4, 2] = 0.38;
            data[4, 3]= 0.36;
            data[4, 4] = 0.43;
            data[4, 5] = 0.37;
            data[4, 6]= 0.45;
            data[4, 7] = 0.34;
            data[4, 8] = 0.36;
            data[4, 9] = 0.38;
            data[4, 10] = 0.43;
            data[4, 11] = 0.44;
            data[4, 12] = 0.44;
            data[4, 13] = 0.45;
            data[4, 14] = 0.29;
            data[4, 15] = 0.38;
            data[4, 16] = 0.33;


            data[5, 0] = 1.5;
            data[5, 1] = 1.6;
            data[5, 2] = 1.6;
            data[5, 3]= 1.7;
            data[5, 4] = 1.8;
            data[5, 5]= 1.9;
            data[5, 6] = 1.9;
            data[5, 7]=0.0;
            data[5, 8] = 2.1;
            data[5, 9] = 2.1;
            data[5, 10] = 2.1;
            data[5, 11]= 2.2;
            data[5, 12] = 2.2;
            data[5, 13] = 2.4;
            data[5, 14]= 2.8;
            data[5, 15] = 3.2;
            data[5, 16]=3.3;
                        // cena
            data[6, 0] = 12;
            data[6, 1]= 11;
            data[6, 2] = 11;
            data[6, 3]= 10;
            data[6, 4] = 9;
            data[6, 5] = 8;
            data[6, 6] = 8;
            data[6, 7] = 7;
            data[6, 8] = 6;
            data[6, 9]= 6;
            data[6, 10] = 6;
            data[6, 11] = 5;
            data[6, 12] = 5;
            data[6, 13] = 4;
            data[6, 14]= 3;
            data[6, 15] = 2;
            data[6, 16] = 1;
            // sprawność

            data[7, 0] = 5;
            data[7, 1] = 1;
            data[7, 2] = 6;
            data[7, 3]= 9;
            data[7, 4] = 7;
            data[7, 5] = 11;
            data[7, 6] = 10;
            data[7, 7] = 3;
            data[7, 8] = 12;
            data[7, 9] = 2;
            data[7, 10] = 5;
            data[7, 11] = 7;
            data[7, 12] = 4;
            data[7, 13] = 9;
            data[7, 14] = 13;
            data[7, 15] = 8;
            data[7, 16] = 14;
            // temperatura

            data[8, 0] = 4;
            data[8, 1] = 11;
            data[8, 2]= 5;
            data[8, 3] = 7;
            data[8, 4]= 3;
            data[8, 5] = 6;
            data[8, 6] = 1;
            data[8, 7]= 8;
            data[8, 8] = 7;
            data[8, 9] = 5;
            data[8, 10] = 3;
            data[8, 11] = 2;
            data[8, 12] = 2;
            data[8, 13]= 1;
            data[8, 14] = 10;
            data[8, 15] = 5;
            data[8, 16] = 9;

            dataGridView3.RowCount = 7;
            dataGridView3.ColumnCount = 8;

            dataGridView3.Columns[0].Width = 230;
            dataGridView3.Columns[1].Width = 110;
            dataGridView3.Columns[2].Width = 160;
            dataGridView3.Columns[3].Width = 80;
            dataGridView3.Columns[4].Width = 140;
            dataGridView3.Columns[5].Width = 90;
            dataGridView3.Columns[6].Width = 170;

            dataGridView2.Columns[0].Width = 160;
            dataGridView2.Columns[1].Width = 130;
            dataGridView2.Columns[2].Width = 160;
            dataGridView2.Columns[3].Width = 80;
            dataGridView2.Columns[4].Width = 170;
            dataGridView3[0, 0].Value = "front wall";
            dataGridView3[0, 1].Value = "right wall of buildings";
            dataGridView3[0, 2].Value = "left wall of buildings"; 
            dataGridView3[0, 3].Value = "back wall";
            dataGridView3[0, 4].Value = "roof area";
            dataGridView3[0, 5].Value = "max number of panel vertically";
            dataGridView3[0, 6].Value = "max number of panel horizonatlly";
            dataGridView3[2, 0].Value = "roof inclination angle";
            dataGridView3[2, 1].Value = "roof inclination angle";
            dataGridView3[2, 2].Value = "roof inclination angle ";
            dataGridView3[2, 3].Value = "roof inclination angle";
            dataGridView3[4, 2].Value = "favorable length ";
            dataGridView3[4, 3].Value = "favorable length  ";
            dataGridView3[2, 5].Value = "module horizontally ";
            dataGridView3[2, 6].Value = "module horizontally ";
            dataGridView3[6, 2].Value = "favorable height ";
            dataGridView3[6, 3].Value = "favorable height ";
            dataGridView3[4, 5].Value = "module vertically ";
            dataGridView3[4, 6].Value = "module vertically";

            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Width = 125;
            dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[2].Width = 122;
            dataGridView1.Columns[3].Width = 30;
            dataGridView1[0, 0].Value = "front wall [m]";
            dataGridView1[0, 1].Value = "right wall of buildings [m]";
            dataGridView1[0, 2].Value = "left wall of buildings [m]";
            dataGridView1[0, 3].Value = "back wall [m]";
            dataGridView1[2, 0].Value = "roof inclination angle [o]";
            dataGridView1[2, 1].Value = "roof inclination angle [o]";
            dataGridView1[2, 2].Value = "roof inclination angle [o]";
            dataGridView1[2, 3].Value = "roof inclination angle [o]";
            //   dataGridView3[1,0].Value=double.Parse(dataGridView1[1, 0].Value.ToString());
            dataGridView4.RowCount = 6;
            dataGridView4.ColumnCount = 12;

            dataGridView4.Columns[0].Width = 135;
            dataGridView4.Columns[1].Width = 40;
            dataGridView4.Columns[2].Width = 120;
            dataGridView4.Columns[3].Width = 50;
            dataGridView4.Columns[4].Width = 115;
            dataGridView4.Columns[5].Width = 60;
            dataGridView4.Columns[6].Width = 160;
            dataGridView4.Columns[7].Width = 40;
            dataGridView4.Columns[8].Width = 150;
            dataGridView4.Columns[9].Width = 40;
            dataGridView4.Columns[10].Width = 100;
            dataGridView4.Columns[11].Width = 40;
          
            dataGridView4[0, 0].Value = "front wall [m]";
            dataGridView4[0, 1].Value = "right wall of buildings [m]";
            dataGridView4[0, 2].Value = "left wall of buildings [m]";
            dataGridView4[0, 3].Value = "back wall [m]";
            
                dataGridView4[0, 4].Value = "maximum number of panels vertically";
                dataGridView4[0, 5].Value = "maximum number of panels horizontally";
           




            dataGridView4[2, 4].Value = "panel surface [m2]";
            dataGridView4[2, 5].Value = "max number of panels ";

            dataGridView4[2, 0].Value = "favorable length [m]";
            dataGridView4[2, 1].Value = "favorable length [m]";
            dataGridView4[2, 2].Value = "favorable length [m]";
            dataGridView4[2, 3].Value = "favorable length [m]";
            dataGridView4[4, 4].Value = "installed power [kW]";
            dataGridView4[4, 5].Value = "production [kW]";

            dataGridView4[4, 0].Value = "favorable height [m]";
            dataGridView4[4, 1].Value = "favorable height [m]";
            dataGridView4[4, 2].Value = "favorable height [m]";
            dataGridView4[4, 3].Value = "favorable height [m]";
            dataGridView4[6, 5].Value = "                         efficiency [%]";
        

            dataGridView4[6, 0].Value = "number of modules horizontally";
            dataGridView4[6, 1].Value = "number of modules horizontally";
            dataGridView4[6, 2].Value = "number of modules horizontally";
            dataGridView4[6, 3].Value = "number of modules horizontally";

            dataGridView4[8, 0].Value = "number of modules vertically";
            dataGridView4[8, 1].Value = "number of modules vertically";
            dataGridView4[8, 2].Value = "number of modules vertically";
            dataGridView4[8, 3].Value = "number of modules vertically";

            dataGridView4[10, 0].Value = "deflection angle [o]";
            dataGridView4[10, 1].Value = "deflection angle [o]";
            dataGridView4[10, 2].Value = "deflection angle [o]";
            dataGridView4[10, 3].Value = "deflection angle [o]";

           


        }

    void read()
    {
          degrad[1] = 0.8; degrad[2] = 1.6;
                degrad[3] = 2.4; degrad[4] = 3.2; degrad[5] = 4.3; degrad[6] = 4.8; degrad[7] = 5.6; degrad[8] = 6.4; degrad[9] = 7.2; degrad[10] = 8.0; degrad[11] = 8.8;
                degrad[12] = 9.6; degrad[13] = 10.4; degrad[14] = 11.2; degrad[15] = 12.0; degrad[16] = 12.8; degrad[17] = 13.6; degrad[18] = 14.4; degrad[19] = 15.2;
                degrad[20] = 16.0; degrad[21] = 16.8; degrad[22] = 17.6; degrad[23] = 18.4; degrad[24] = 19.2; degrad[25] = 20.0;


                for (int i = 1; i <= 25; i++)
                    degrad[i] /= 100.0;
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
                  
         
            double moc;
           double spr;

           moc = data[0, k-1];
           spr = data[1, k-1];
           
           

        }
       

      
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            r = trackBar1.Value;
            numericUpDown1.Value = r;
            degradacja();
            tabela_naslonecznienie();
            



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
                    tab[i, j] = data[j + 5, i - 1];


            for (int i = 1; i < 18; i++) // wiersz     
            {
                WS[i] = (tab[i, 1] * cena / 120 + (tab[i, 2] * sprawn / 140 + tab[i, 3] * temper / 110) * jako / 100) / 10;
                data[9, i - 1] = WS[i];
            }

            double max = WS[1];
            string nap = "Poli-(klasyczny)";
            dataGridView2[1, 0].Value = nap;

            int numer = 1;
            for (int i = 2; i < 18; i++)
                if (WS[i] > max) { max = WS[i]; numer = i; nap = napis[i - 2]; }
            for (int i = 1; i < 6; i++)
                dataGridView2[1, i].Value = data[i - 1, numer - 1];
            label10.Text = "width: " + data[2, numer - 1].ToString();
            label11.Text = "height: " + data[3, numer - 1].ToString();
            label12.Text = "typical power Wp: " + data[0, numer - 1].ToString();
            label13.Text = "typical efficiency: " + data[1, numer - 1].ToString();
            label14.Text = "average temperature: " + data[4, numer - 1].ToString();
            label16.Text = "price per Wp: " + data[5, numer - 1].ToString();
            dataGridView2[1, 0].Value = napis[numer];
            

            label6.Text = "a panel is selected: " + napis[numer];
            k = numer;
        }
     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        

        void oblicz_dach()
        {




            double max, max1, max3, max4;
           moc0 = double.Parse(dataGridView2[1, 1].Value.ToString());
           

            double wysa, wysb, jeden, moc_inst; 
            // dataGridView2[2, 5].Value = "maksymalna ilość paneli";
            wysa = double.Parse(dataGridView2[1, 3].Value.ToString());
            wysb = double.Parse(dataGridView2[1, 4].Value.ToString());
            jeden = wysa * wysb;


            if (d == 1)
            {
               // dataGridView3[1, 0].Value = 0;
                //dataGridView3[1, 1].Value = 0;
                x = double.Parse(dataGridView3[1, 2].Value.ToString());
                y = double.Parse(dataGridView3[1, 3].Value.ToString());
                kata1 = double.Parse(dataGridView3[3, 0].Value.ToString());
                katb1 = double.Parse(dataGridView3[3, 1].Value.ToString());
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
                kata1 = double.Parse(dataGridView3[3, 0].Value.ToString());
                katb1 = double.Parse(dataGridView3[3, 1].Value.ToString());
                kata = double.Parse(dataGridView3[3, 2].Value.ToString());
                katb = double.Parse(dataGridView3[3, 3].Value.ToString());

                kata1 *= 3.14 / 180.0;
                katb1 *= 3.14 / 180.0;
                x1 = 0.5 * x / Math.Cos(katb1);
                y1 = 0.5 * y / Math.Cos(kata1);


            }
            else if (d == 5)
            {

                dataGridView3[1, 2].Value = double.Parse(dataGridView3[1, 1].Value.ToString());
                dataGridView3[1, 3].Value = double.Parse(dataGridView3[1, 0].Value.ToString());
                dataGridView3[3, 2].Value = double.Parse(dataGridView3[3, 1].Value.ToString());
                dataGridView3[3, 3].Value = double.Parse(dataGridView3[3, 0].Value.ToString());

                x = double.Parse(dataGridView3[1, 0].Value.ToString());
                y = double.Parse(dataGridView3[1, 1].Value.ToString());

                kata1 = double.Parse(dataGridView3[3, 0].Value.ToString());
                katb1 = double.Parse(dataGridView3[3, 1].Value.ToString());
                kata = double.Parse(dataGridView3[3, 2].Value.ToString());
                katb = double.Parse(dataGridView3[3, 3].Value.ToString());
                kata1 *= 3.14 / 180.0;
                katb1 *= 3.14 / 180.0;
                x1 = 0.4 * x / Math.Cos(katb1);
                y1 = 0.4 * y / Math.Cos(kata1);


            }
            else if (d == 6)
            {

                dataGridView3[1, 2].Value = double.Parse(dataGridView3[1, 1].Value.ToString());
                dataGridView3[1, 3].Value = double.Parse(dataGridView3[1, 0].Value.ToString());
                dataGridView3[3, 2].Value = double.Parse(dataGridView3[3, 1].Value.ToString());
                dataGridView3[3, 3].Value = double.Parse(dataGridView3[3, 0].Value.ToString());

                x = double.Parse(dataGridView3[1, 0].Value.ToString());
                y = double.Parse(dataGridView3[1, 1].Value.ToString());

                kata1 = double.Parse(dataGridView3[3, 0].Value.ToString());
                katb1 = double.Parse(dataGridView3[3, 1].Value.ToString());
                kata = double.Parse(dataGridView3[3, 2].Value.ToString());
                katb = double.Parse(dataGridView3[3, 3].Value.ToString());
                kata1 *= 3.14 / 180.0;
                katb1 *= 3.14 / 180.0;
                x1 = 0.3 * x / Math.Cos(katb1);
                y1 = 0.3 * y / Math.Cos(kata1);


            }

            if (d == 1 || d == 2 || d==5 || d==6)
            {
                dataGridView3[1, 4].Value = (x1 * y1).ToString("0.00");
                dataGridView3[5, 2].Value = (x - 2.0 * 0.2).ToString("0.00");
                dataGridView3[5, 3].Value = (y - 2.0 * 0.2).ToString("0.00");
                dataGridView3[7, 2].Value = (y1 - 2.0 * 0.35).ToString("0.00");
                dataGridView3[7, 3].Value = (x1 - 2.0 * 0.35).ToString("0.000");
                double wpisz;

                wpisz = (int)((x -  0.4) / (wysb + 0.01));
                dataGridView3[3, 5].Value = wpisz.ToString();
                wpisz = (int)((y - 0.4) / (wysb + 0.01));
                dataGridView3[3, 6].Value = wpisz.ToString();
                //------------------------------------------------------------------------
                wpisz = (int)((y1 - 0.7) / (wysa + 0.01));
                dataGridView3[5, 5].Value = wpisz.ToString();
                wpisz = (int)((x1 - 0.7) / (wysa + 0.01));
                dataGridView3[5, 6].Value = wpisz.ToString();

                dataGridView3[1, 6].Value = double.Parse(dataGridView3[3, 6].Value.ToString()) * double.Parse(dataGridView3[5, 6].Value.ToString());
                dataGridView3[1, 5].Value = double.Parse(dataGridView3[3, 5].Value.ToString()) * double.Parse(dataGridView3[5, 5].Value.ToString());

                max = double.Parse(dataGridView2[3, 1].Value.ToString());
                max1 = double.Parse(dataGridView2[3, 2].Value.ToString());
                max3 = double.Parse(dataGridView2[3, 3].Value.ToString());
                max4 = double.Parse(dataGridView2[3, 4].Value.ToString());
             

                  dataGridView2[3, 5].Value = 0;
                if (max <= 90 && kata1 > 0) dataGridView2[3, 5].Value = dataGridView3[1, 5].Value;

                if (max1 <= 90 && katb1 > 0) dataGridView2[3, 5].Value = dataGridView3[1, 6].Value;

                if (max3 <= 90 && kata > 0) dataGridView2[3, 5].Value = dataGridView3[1, 5].Value;

                if ((max4 <= 90) && (katb > 0)) dataGridView2[3, 5].Value = dataGridView3[1, 5].Value;

                dataGridView4[1, 4].Value = double.Parse(dataGridView3[1, 5].Value.ToString());
                dataGridView4[1, 5].Value = double.Parse(dataGridView3[1, 6].Value.ToString());

                dataGridView4[3, 5].Value = double.Parse(dataGridView2[3, 5].Value.ToString());

                moc_inst = moc0 * double.Parse(dataGridView2[3, 5].Value.ToString());

                dataGridView2[5, 0].Value = jeden;
                dataGridView2[5, 1].Value = moc_inst;
                dataGridView4[3, 4].Value = jeden;
                dataGridView4[5, 4].Value = moc_inst;


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
                dataGridView4[3, 5].Value = suma + suma1;
                dataGridView4[1, 4].Value = suma;
                dataGridView4[1, 5].Value = suma1;
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
               
                dataGridView4[3, 4].Value = jeden;
                dataGridView4[5, 4].Value = moc_inst;
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
                dataGridView4[3, 5].Value = suma + suma1;
                dataGridView4[1, 4].Value = suma;
                dataGridView4[1, 5].Value = suma1;
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
                dataGridView4[3, 4].Value = jeden;
                dataGridView4[5, 4].Value = moc_inst;
            }

        }

      

       
             private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            d = 6;

            dataGridView1[1, 0].Value = 15;
            dataGridView1[1, 1].Value = 8;
            dataGridView1[1, 2].Value = 8;
            dataGridView1[1, 3].Value = 20;

            dataGridView1[3, 0].Value = 20;
            dataGridView1[3, 1].Value = 0;
            dataGridView1[3, 2].Value = 0;
            dataGridView1[3, 3].Value = 20;
            //solution();
            label24.Text = "Enter: left and rihht wall of buildings, front and back wall and roof inclination angle";
        }//

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            d = 5;


            dataGridView1[1, 0].Value = 20;
            dataGridView1[1, 1].Value = 10;
            dataGridView1[1, 2].Value = 10;
            dataGridView1[1, 3].Value = 20;

            dataGridView1[3, 0].Value = 30;
            dataGridView1[3, 1].Value = 0;
            dataGridView1[3, 2].Value = 0;
            dataGridView1[3, 3].Value = 30;
            label24.Text = "Enter: left and rihht wall of buildings, front and back wall and roof inclination angle";
            //solution();
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            d = 4;

            dataGridView1[1, 0].Value = 20;
            dataGridView1[1, 1].Value = 20;
            dataGridView1[1, 2].Value = 20;
            dataGridView1[1, 3].Value = 20;


            
            
            dataGridView1[3, 0].Value = 30;
            dataGridView1[3, 1].Value = 30;
            dataGridView1[3, 2].Value = 30;
            dataGridView1[3, 3].Value = 30;
            //solution();
            label24.Text = "Enter: left or right wall of buildings and roof inclination angle";
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            d = 3;

            dataGridView1[1, 0].Value = 20;
            dataGridView1[1, 1].Value = 10;
            dataGridView1[1, 2].Value = 10;
            dataGridView1[1, 3].Value = 20;



            dataGridView1[3, 0].Value = 30;
            dataGridView1[3, 1].Value = 30;
            dataGridView1[3, 2].Value = 30;
            dataGridView1[3, 3].Value = 30;
            //solution();
            label24.Text = "Enter:  wall of buildings and roof inclination angle";
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            d = 2;

            dataGridView1[1, 0].Value = 20;
            dataGridView1[1, 1].Value = 10;
            dataGridView1[1, 2].Value = 10;
            dataGridView1[1, 3].Value = 20;

            dataGridView1[3, 0].Value = 30;
            dataGridView1[3, 1].Value = 0;
            dataGridView1[3, 2].Value = 0;
            dataGridView1[3, 3].Value = 30;
            //solution();
            label24.Text = "Enter: left wall of buildings, back wall and roof inclination angle";
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            d = 1;

            
            dataGridView1[1, 0].Value = 0;
            dataGridView1[1, 1].Value = 0;
            dataGridView1[1, 2].Value = 20;
            dataGridView1[1, 3].Value = 10;
            dataGridView1[3, 0].Value = 0;
            dataGridView1[3, 1].Value = 0;
            dataGridView1[3, 2].Value = 20;
            dataGridView1[3, 3].Value = 0;
            label24.Text = "Enter: left wall of buildings, back wall and roof inclination angle";
          //  solution();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[2].Enabled = false;
            label26.Text = "production ("+ double.Parse(dataGridView4[3,5].Value.ToString())+ ") panels in the first year [kW] / Months";
            label27.Visible = false;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            read();
            double[] Power = new double[13];
            double power1 = double.Parse(dataGridView2[5, 2].Value.ToString());
           

            if (d == 3 || d == 4)
            {
                chart1.Series[2].Enabled = true;
                double da = double.Parse(dataGridView4[1, 4].Value.ToString());
                double db = double.Parse(dataGridView4[1, 5].Value.ToString());

                for (int i = 0; i < 12; i++)
                {
                    chart1.Series[0].Points.AddY(Mounth[i]/(da+db)*da);
                    chart1.Series[2].Points.AddY(Mounth[i] / (da + db) * db);

                }

                label27.Visible = true;
                label27.Text = "production(" + double.Parse(dataGridView4[1, 4].Value.ToString()) + ") panels - blue and production(" + double.Parse(dataGridView4[1, 5].Value.ToString()) + ") panels - red";
            }
            else
            {
                for (int i = 0; i < 12; i++)
                    chart1.Series[0].Points.AddY(Mounth[i]);
            }

            
            chart1.ChartAreas[0].AxisX.Title = "Months";
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            kompas();
            
            double b1;
            // b - kąt nachylenia dachu
            b1 = kat_b - 90;
            b1 = ( b1* Math.PI) / 180.0;
            
            Complex rys = new Complex(4 * Math.Cos(b1), 4 * Math.Sin(b1));
           if (kat_b>=0 && kat_b<=180) label8.Text = "roof slope: " + kat_b.ToString();
           else label8.Text = "roof slope: " + (180-(kat_b-180)).ToString();
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
           

            if ((kat_b > 0 && kat_b < 180) )
            {
                for (int i = 0; i < n; i++)
                {
                    t = i * dt;
                    chart2.Series[0].Points.AddXY(t, punkt * t);

                }
            }
            else if (kat_b >= 180 && kat_b <  360)
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
            dataGridView2[3, 1].Value = Math.Abs(aa);
            dataGridView2[3, 4].Value = Math.Abs(dd);
            if (zz > 0 && zz <= 180)
            {
                dataGridView2[3, 0].Value = zz;
                dataGridView2[3, 2].Value = Math.Abs(bb);
                dataGridView2[3, 3].Value = Math.Abs(cc);
            }
            else
            {
                dataGridView2[3, 0].Value = 180 - (zz - 180);
                
                dataGridView2[3, 2].Value = Math.Abs(cc);
                dataGridView2[3, 3].Value = Math.Abs(bb);
               
            }

            dataGridView4[11, 0].Value = double.Parse(dataGridView2[3, 1].Value.ToString());
            dataGridView4[11, 1].Value = double.Parse(dataGridView2[3, 2].Value.ToString());
            dataGridView4[11, 2].Value = double.Parse(dataGridView2[3, 3].Value.ToString());
            dataGridView4[11, 3].Value = double.Parse(dataGridView2[3, 4].Value.ToString());


            dataGridView2[3, 5].Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            solution();
            
        }
        void solution()
        {
            kompas();
            oblicz_dach();
            tabela_naslonecznienie();
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
            {
                suma += wektro_LEWY[i];
                Mounth[i-1]= wektro_LEWY[i];
            }
                produkcja_ogolem = suma;

                read();

            int r = trackBar1.Value;

            if (r > 0)
            {
                produkcja_ogolem = produkcja_ogolem -produkcja_ogolem * degrad[r];
                dataGridView2[5, 2].Value = produkcja_ogolem.ToString("0.000");
                dataGridView4[5, 5].Value = produkcja_ogolem.ToString("0.00");

                sprawnosc_sys = (produkcja_ogolem / double.Parse(dataGridView2[5, 1].Value.ToString())) * 100.0;
                dataGridView2[5, 3].Value = sprawnosc_sys.ToString("0.0");
                dataGridView4[7, 5].Value = sprawnosc_sys.ToString("0.0");
            }
            else
            {
                dataGridView2[5, 2].Value = produkcja_ogolem.ToString("0.000");
                dataGridView4[5, 5].Value = produkcja_ogolem.ToString("0.00");
                sprawnosc_sys = (produkcja_ogolem / double.Parse(dataGridView2[5, 1].Value.ToString())) * 100.0;
                dataGridView2[5, 3].Value = sprawnosc_sys.ToString("0.0");
                dataGridView4[7, 5].Value = sprawnosc_sys.ToString("0.0");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        void czytaj1()
        {
            dataGridView3[1, 0].Value = double.Parse(dataGridView1[1, 0].Value.ToString());
            dataGridView3[1, 1].Value = double.Parse(dataGridView1[1, 1].Value.ToString());
            dataGridView3[1, 2].Value = double.Parse(dataGridView1[1, 2].Value.ToString());
            dataGridView3[1, 3].Value = double.Parse(dataGridView1[1, 3].Value.ToString());

            dataGridView3[3, 0].Value = double.Parse(dataGridView1[3, 0].Value.ToString());
            dataGridView3[3, 1].Value = double.Parse(dataGridView1[3, 1].Value.ToString());
            dataGridView3[3, 2].Value = double.Parse(dataGridView1[3, 2].Value.ToString());
            dataGridView3[3, 3].Value = double.Parse(dataGridView1[3, 3].Value.ToString());




        }
        private void button2_Click(object sender, EventArgs e)
        {
            czytaj1();  
            solution();

            dataGridView4[1, 0].Value = double.Parse(dataGridView1[1, 0].Value.ToString());
            dataGridView4[1, 1].Value = double.Parse(dataGridView1[1, 1].Value.ToString());
            dataGridView4[1, 2].Value = double.Parse(dataGridView1[1, 2].Value.ToString());
            dataGridView4[1, 3].Value = double.Parse(dataGridView1[1, 3].Value.ToString());
           
            if (d == 1)
            {
                dataGridView4[3, 0].Value = 0;
                dataGridView4[3, 1].Value = 0;
                dataGridView4[3, 2].Value = double.Parse(dataGridView3[5, 2].Value.ToString());
                dataGridView4[3, 3].Value = double.Parse(dataGridView3[5, 3].Value.ToString());

                dataGridView4[5, 0].Value = 0;
                dataGridView4[5, 1].Value = 0;
                dataGridView4[5, 2].Value = double.Parse(dataGridView3[7, 2].Value.ToString());
                dataGridView4[5, 3].Value = double.Parse(dataGridView3[7, 3].Value.ToString());

                dataGridView4[7, 0].Value = 0;
                dataGridView4[7, 1].Value = 0;
                dataGridView4[7, 2].Value = double.Parse(dataGridView3[3, 5].Value.ToString());
                dataGridView4[7, 3].Value = double.Parse(dataGridView3[3, 6].Value.ToString());

                dataGridView4[9, 0].Value = 0;
                dataGridView4[9, 1].Value = 0;
                dataGridView4[9, 2].Value = double.Parse(dataGridView3[5, 5].Value.ToString());
                dataGridView4[9, 3].Value = double.Parse(dataGridView3[5, 6].Value.ToString());
            }
            if (d == 2)
            {
                dataGridView4[3, 0].Value = double.Parse(dataGridView3[5, 2].Value.ToString());
                dataGridView4[3, 1].Value = double.Parse(dataGridView3[5, 3].Value.ToString());
                dataGridView4[3, 2].Value = double.Parse(dataGridView3[5, 3].Value.ToString());
                dataGridView4[3, 3].Value = double.Parse(dataGridView3[5, 2].Value.ToString());

                dataGridView4[5, 0].Value = double.Parse(dataGridView3[7, 2].Value.ToString());
                dataGridView4[5, 1].Value = double.Parse(dataGridView3[7, 3].Value.ToString());
                dataGridView4[5, 2].Value = double.Parse(dataGridView3[7, 3].Value.ToString());
                dataGridView4[5, 3].Value = double.Parse(dataGridView3[7, 2].Value.ToString());

                dataGridView4[7, 0].Value = double.Parse(dataGridView3[3, 5].Value.ToString());
                dataGridView4[7, 1].Value = double.Parse(dataGridView3[3, 6].Value.ToString());
                dataGridView4[7, 2].Value = double.Parse(dataGridView3[3, 6].Value.ToString());
                dataGridView4[7, 3].Value = double.Parse(dataGridView3[3, 5].Value.ToString());

                dataGridView4[9, 0].Value = double.Parse(dataGridView3[5, 5].Value.ToString());
                dataGridView4[9, 1].Value = double.Parse(dataGridView3[5, 6].Value.ToString());
                dataGridView4[9, 2].Value = double.Parse(dataGridView3[5, 6].Value.ToString());
                dataGridView4[9, 3].Value = double.Parse(dataGridView3[5, 5].Value.ToString());
            }

            if (d == 3 || d==4)
            {
                dataGridView4[3, 0].Value = " ";
                dataGridView4[3, 1].Value = " ";
                dataGridView4[3, 2].Value = " ";
                dataGridView4[3, 3].Value = " ";

                dataGridView4[5, 0].Value = " ";
                dataGridView4[5, 1].Value = " ";
                dataGridView4[5, 2].Value = " ";
                dataGridView4[5, 3].Value = " ";
                
                    dataGridView4[0, 4].Value = "number of panels back wall";
                    dataGridView4[0, 5].Value = "number of panels left wall";
                

            }
        }





        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series[2].Enabled = false;
            label26.Text = "production per year [kW] / Year";
            label27.Visible = true;
            label27.Text = "yellow - installed power [kW]  blue - production [kW] ";
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            read();
            double[] Power = new double[26];
            double power1 = double.Parse(dataGridView2[5, 2].Value.ToString());
            for (int i = 1; i < 25; i++)
                Power[i] = power1 - power1 * degrad[i];
            for (int i = 1; i < 25; i++)
            {
                chart1.Series[0].Points.AddY(Power[i]);
                chart1.Series[1].Points.AddY(double.Parse(dataGridView2[5, 1].Value.ToString()));
            }
            chart1.Series[0].LegendText = "power produced";
            chart1.Series[1].LegendText = "installed power";
            chart1.ChartAreas[0].AxisX.Title = "year";
        }

    }
}
