using ExercicioReforco1.Infra.Data;
using ExercicioReforco1.WinApp.Features.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioReforco1.WinApp
{
    public partial class Principal : Form
    {
        private ProdutoRepositorio _produtoRepositorio;

        public GerenciadorFormulario _gerenciador;

        public ProdutoGerenciadorFormulario _produtoGerenciadorFormulario;


        public Principal()
        {
            InitializeComponent();
            toolStripMenu.Enabled = false;
        }
        private void CarregarCadastro(GerenciadorFormulario gerenciador)
        {
            _gerenciador = gerenciador;


            toolStripMenu.Enabled = true;


            UserControl listagem = _gerenciador.CarregarListagem();

            listagem.Dock = DockStyle.Fill;

            panelControl.Controls.Clear();
            panelControl.Controls.Add(listagem);
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (_gerenciador != null)
            {
                _gerenciador.Atualizar();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_gerenciador != null)
            {
                _gerenciador.Excluir();
            }
        }
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_produtoGerenciadorFormulario == null)
                _produtoGerenciadorFormulario = new ProdutoGerenciadorFormulario(_produtoRepositorio);

            CarregarCadastro(_produtoGerenciadorFormulario);

        }
    }
}
