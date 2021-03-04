﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool G_IsUsingLimint = false;
        public Form1()
        {
            InitializeComponent();
            changeLimitsTBEnable();
        }
        void changeLimitsTBEnable()
        {
            TB_X1_MAX.Enabled = G_IsUsingLimint;
            TB_X2_MAX.Enabled = G_IsUsingLimint;
            TB_INTERVAL_X1.Enabled = G_IsUsingLimint;
            TB_INTERVAL_X2.Enabled = G_IsUsingLimint;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            G_IsUsingLimint = IsUsingLimits.Checked;
            changeLimitsTBEnable();
        }

        private void B_CalculateY_Click(object sender, EventArgs e)
        {
            double Accuracy = 0.1;
            List<CalculatedPoint> points = new List<CalculatedPoint>();
            LB_Results.Items.Clear();

            double cb_X1 = convertTextToDouble(ref TB_X1);
            double cb_X2 = convertTextToDouble(ref TB_X2);

            if (G_IsUsingLimint && (cb_X1 != 0 || cb_X2 != 0))
            {
                TB_INTERVAL_X1.Text = TB_INTERVAL_X1.Text.Replace('.', ',');
                TB_INTERVAL_X2.Text = TB_INTERVAL_X2.Text.Replace('.', ',');

                double cb_INTERVAL_X1 = convertTextToDouble(ref TB_INTERVAL_X1);
                double cb_INTERVAL_X2 = convertTextToDouble(ref TB_INTERVAL_X2);
                double cb_X1_MAX = convertTextToDouble(ref TB_X1_MAX);
                double cb_X2_MAX = convertTextToDouble(ref TB_X2_MAX);

                int CriticalCounter = 0;
                int LimitCounterX1 = (int)((Math.Max(cb_X1_MAX, cb_X1) - Math.Min(cb_X1_MAX, cb_X1)) / Accuracy);
                int LimitCounterX2 = (int)((Math.Max(cb_X2_MAX, cb_X2) - Math.Min(cb_X2_MAX, cb_X2)) / Accuracy);

                for (double i_x1 = cb_X1, i_x2 = cb_X2;
                    (i_x1 < cb_X1_MAX || i_x2 < cb_X2_MAX);// && (CriticalCounter < LimitCounterX1 || CriticalCounter < LimitCounterX2);
                    i_x1 += cb_INTERVAL_X1, i_x2 += cb_INTERVAL_X2)
                {
                    points.Add(new CalculatedPoint(i_x1, i_x2));
                    CriticalCounter++;
                }
            }
            else
            {
                points.Add(new CalculatedPoint(cb_X1, cb_X2));
            }

            foreach(CalculatedPoint point in points)
            {
                LB_Results.Items.Add(point);
            }
        }
        private double convertTextToDouble(ref TextBox TB)
        {
            double output = 0;

            try
            {
                output = Convert.ToDouble(TB.Text);
            }
            catch
            {
                MessageBox.Show("Can`t convert " + TB.Name + ".Text to double.\n0 is result.");
            }

            return output;
        }
    }
}
