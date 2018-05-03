using System;
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
    public partial class HIMNO_2 : Form
    {
        public HIMNO_2()
        {
            InitializeComponent();
        }

        private void HIMNO_2_Load(object sender, EventArgs e)
        {
            int value = 100;
            axWindowsMediaPlayer1.settings.volume = value;
            axWindowsMediaPlayer1.Size = new Size(535, 285);
            this.Icon = GloriaINE.Properties.Resources.icono;
        }

       

        private void HIMNO_2_FormClosing(object sender, FormClosingEventArgs e)
        {      
            
        }
    }
}
