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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnRemove1_Click(object sender, EventArgs e)
        {
            int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while (posicao >=0 )
            {

                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                    txtPalavra2.Text.Substring(txtPalavra1.Text.Length +
                    posicao, txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);


                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text.Length);




            }



        }

        private void BtnRemove2_Click(object sender, EventArgs e)
        {

            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");


        }

        private void BtnInverte_Click(object sender, EventArgs e)
        {

            char[] meuarray = txtPalavra1.Text.ToCharArray();


            Array.Reverse(meuarray);


            foreach (var c in meuarray)
                txtPalavra2.Text += c;


            MessageBox.Show(txtPalavra2.Text);




        }

        private void TxtPalavra2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
