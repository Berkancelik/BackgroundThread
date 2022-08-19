﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "")
            {
                int i = int.Parse(txtValue.Text);
                backgroundWorker1.RunWorkerAsync(i);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int j = int.Parse(e.Argument.ToString());
            for (int i = 0; i <= j; i++)
            {
                backgroundWorker1.ReportProgress(i / 10);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Bitti");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 1000; i++)
            {
                progressBar1.Value = i / 10;
                System.Threading.Thread.Sleep(100);

            }
        }
    }
}
