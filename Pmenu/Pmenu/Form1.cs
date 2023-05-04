using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExercícioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecionou ctrl+C");
        }

        private void ColarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecionou ctrl+V");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio2 objFrm2 = new FrmExercicio2();
            objFrm2.MdiParent = this;
            objFrm2.WindowState = FormWindowState.Maximized;
            objFrm2.Show();

        }

        private void Exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio3 objFrm3 = new FrmExercicio3();
            objFrm3.MdiParent = this;
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();

        }
        
        private void Exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio4 objFrm4 = new FrmExercicio4();
            objFrm4.MdiParent = this;
            objFrm4.WindowState = FormWindowState.Maximized;
            objFrm4.Show();
        }

        private void Exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio5 objFrm5 = new FrmExercicio5();
            objFrm5.MdiParent = this;
            objFrm5.WindowState = FormWindowState.Maximized;
            objFrm5.Show();
        }
    }
}
