﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalDC
{
    public partial class DialogBoxModificar : Form
    {
        public DialogBoxModificar()
        {
            InitializeComponent();
        }
        public string fecha
        {
            get { return (textBox1.Text); }
        }
        private void DialogBoxModificar_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
