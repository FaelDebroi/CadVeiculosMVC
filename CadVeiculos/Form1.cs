using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadVeiculos
{
    public partial class frmPrincipal : Form
    {
        const string connectionString = "Server=localhost;Database=senai;User id = senai; Password=Senai1234";
        VeiculoController controlador = new VeiculoController();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //habilitar para edição
            mskPlaca.Enabled = true;
            txtModelo.Enabled = true;
            btnSalvar.Enabled = true;

            //foca na placa
            mskPlaca.Focus();

            //bloquear o botão
            btnNovo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controlador.Salvar(mskPlaca.Text, txtModelo.Text));

            //bloquear/habilitar botoes
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            mskPlaca.Enabled = false;
            txtModelo.Enabled = false;

            //limpar os campos
            mskPlaca.Clear();
            txtModelo.Clear();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            //limpar itens
            listVeiculos.Items.Clear();

            List<Veiculo> lista = controlador.Listar();

            foreach(Veiculo v in lista)
            {
                ListViewItem linha = new ListViewItem();
                linha.Text = v.Placa;
                linha.SubItems.Add(v.Modelo);

                listVeiculos.Items.Add(linha);
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controlador.Excluir(listVeiculos.SelectedItems[0].Text));

            listVeiculos.Items.RemoveAt(listVeiculos.SelectedIndices[0]);
        }
    }
}
