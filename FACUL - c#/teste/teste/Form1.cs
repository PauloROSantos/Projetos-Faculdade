﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var respostas = new arrayteste();
            respostas.respostas.Add(label1.Text);

            (respostas.respostas[4] as Label).Text = "testando";
            //label1.Text = respostas.respostas[0].ToString();
           
        }
    }
}