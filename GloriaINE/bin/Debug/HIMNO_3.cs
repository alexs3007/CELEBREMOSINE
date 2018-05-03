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
    public partial class HIMNO_3 : Form
    {
        public HIMNO_3()
        {
            InitializeComponent();
        }

        private void HIMNO_3_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            
        }

        private void HIMNO_3_Load(object sender, EventArgs e)
        {
            int value = 100;
            axWindowsMediaPlayer1.settings.volume = value;
            axWindowsMediaPlayer1.Size = new Size(535, 285);
        }
    }
}
