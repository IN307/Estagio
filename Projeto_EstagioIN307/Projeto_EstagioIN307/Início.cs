using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EstagioIN307
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void clickLogin(object sender, EventArgs e)
        {
            Cadastro c = new Cadastro();

            c.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
