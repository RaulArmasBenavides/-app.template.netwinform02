using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUI.View
{
    public partial class MDImenu : Form
    {
        public MDImenu()
        {
            InitializeComponent();
        }

        private void productosTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void productosPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
        }

        private void productosPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDImenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoView f = new ProyectoView();
            f.MdiParent = this;
            f.Show();
        }
    }
}
