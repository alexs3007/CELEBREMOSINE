﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GloriaINE
{
    public partial class HIMNO_112 : Form
    {
        public HIMNO_112()
        {
            InitializeComponent();
        }

        private void HIMNO_112_Load(object sender, EventArgs e)
        {
            int value = 100;
            axWindowsMediaPlayer1.settings.volume = value;
            axWindowsMediaPlayer1.Size = new Size(535, 285);
            axWindowsMediaPlayer1.Location = new Point(0, 0);
            this.Icon = GloriaINE.Properties.Resources.icono;
        }
    }
}
