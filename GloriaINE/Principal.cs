using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GloriaINE
{
    public partial class Principal : Form
    {
        public int childFormNumber = 0;
        
        public Principal()
        {
            InitializeComponent();
        }
        
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nameEspace,himno;

            nameEspace = "GloriaINE";
            himno = "HIMNO_"+txtBusqueda.Text;

            System.Reflection.Assembly asm = System.Reflection.Assembly.GetEntryAssembly();
            Type formtype = asm.GetType(string.Format("{0}.{1}", nameEspace, himno));

            try
            {
                   Form f = (Form)Activator.CreateInstance(formtype);
                    f.MdiParent = this;
                   
                    f.Show();
                    f.Size = new Size(548, 323);
                    f.Location = new Point(311, 88);
                    txtBusqueda.Clear();
                   
                
                                               
            }
            catch
            {
                //MessageBox.Show("HIMNO NO ENCONTRADO", "CELEBREMOS SU GLORIA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MENSAJE msj = new MENSAJE();
                msj.Show();
                msj.Location = new Point(410, 180);
                txtBusqueda.Clear();
            }
           
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter) 
            {
                String nameEspace, himno;

                nameEspace = "GloriaINE";
                himno = "HIMNO_" + txtBusqueda.Text;

                System.Reflection.Assembly asm = System.Reflection.Assembly.GetEntryAssembly();
                Type formtype = asm.GetType(string.Format("{0}.{1}", nameEspace, himno));

                try
                {
                   
                        Form f = (Form)Activator.CreateInstance(formtype);
                        f.MdiParent = this;
                        f.Show();
                        f.Size = new Size(548, 323);
                        f.Location = new Point(311, 88);
                        txtBusqueda.Clear();
                        
                    
                }
                catch
                {
                    //MessageBox.Show("HIMNO NO ENCONTRADO", "CELEBREMOS SU GLORIA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MENSAJE msj = new MENSAJE();
                    msj.Show();
                    msj.Location = new Point(410, 180);
                    txtBusqueda.Clear();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           String himno= Interaction.InputBox("Ingrese el himno", "Celebremos su Gloria", "", -1, -1);
            int HIMNO;
            if (himno !="")
            {
                String Nombre;
                Nombre = "HIMNO_" + himno;
                HIMNO =Convert.ToInt32(himno);
                if(HIMNO<2 || HIMNO>700)
                {
                    Mensaje2 msj = new Mensaje2();
                    msj.Show();
                    msj.Location = new Point(410, 180);
                }else
                {
                    Lista.Items.Add(Nombre);
                    
                }
            }else
            {
                Mensaje2 msj = new Mensaje2();
                msj.Show();
                msj.Location = new Point(410, 180);
            }

        }


        private void Lista_DoubleClick(object sender, EventArgs e)
        {
            int n = Lista.Items.Count - 1;
            if (n < 0)
            {

            }
            else
            {
                String nameEspace, Himno;

                Himno = Lista.SelectedItem.ToString();
                nameEspace = "GloriaINE";


                System.Reflection.Assembly asm = System.Reflection.Assembly.GetEntryAssembly();
                Type formtype = asm.GetType(string.Format("{0}.{1}", nameEspace, Himno));

                try
                {
                    
                        Form f = (Form)Activator.CreateInstance(formtype);

                        f.MdiParent = this;
                        f.Show();
                        f.Size = new Size(548, 323);
                        f.Location = new Point(311, 88);



                }
                catch
                {
                    //MessageBox.Show("HIMNO NO ENCONTRADO", "CELEBREMOS SU GLORIA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MENSAJE msj = new MENSAJE();
                    msj.Show();
                    msj.Location = new Point(410, 180);
                }
            }
        }

        private void Lista_Click(object sender, EventArgs e)
        {
            int n = Lista.Items.Count - 1;
            if (n < 0)
            {

            }else
            {
                txtEliminar.Text = Lista.SelectedItem.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int n = Lista.Items.Count - 1; n >= 0; --n)
            {
                if (txtEliminar.Text != "")
                {
                    string removelistitem = txtEliminar.Text;
                    if (Lista.Items[n].ToString().Contains(removelistitem))
                    {
                        Lista.Items.RemoveAt(n);
                        txtEliminar.Clear();
                    }
                }
    
            }

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            txtBusqueda.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}