﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lectura()
        { 
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            StreamReader lector;

            lector = File.OpenText("MovieSales.txt");
            

            while (!lector.EndOfStream)
            {
                lbDatos.Items.Add(lector.ReadLine());
            }            


        }
    }
}
