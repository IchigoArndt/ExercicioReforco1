using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExercicioReforco1.Dominio;

namespace ExercicioReforco1.WinApp.Features.Produtos
{
    public partial class ProdutoControl : UserControl
    {
        public ProdutoControl()
        {
            InitializeComponent();
        }
        public void PopularListagemProdutos(IList<Produto> produto)
        {
            listProdutos.Items.Clear();

            foreach (Produto c in produto)
            {
                listProdutos.Items.Add(c);
            }
        }
        public Produto GetProduto()
        {
            return listProdutos.SelectedItem as Produto;
        }
    }
}
