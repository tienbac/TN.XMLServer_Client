﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TN.XMLServer_Client.Code;

namespace TN.XMLServer_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Worker worker = new Worker();
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(worker.Connect);
            thread.Start();

            
        }
    }
}
