using ExercicioReforco1.Dominio;
using ExercicioReforco1.Dominio.Contratos;
using ExercicioReforco1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioReforco1.WinApp.Features.Produtos
{
    public class ProdutoGerenciadorFormulario : GerenciadorFormulario
    {
        private ProdutoControl _produtoControl;
        private readonly IProdutoRepositorio _produtoRepository;
        private ProdutoService _produtoService;

        public ProdutoGerenciadorFormulario(IProdutoRepositorio produtoRepository)
        {
            _produtoRepository = produtoRepository;
            _produtoService = new ProdutoService(_produtoRepository);
        }

        public override void Adicionar()
        {
            CadastroProduto dialog = new CadastroProduto();
            dialog.NovaProduto = new Produto();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                try
                {
                    _produtoService.Adicionar(dialog.NovaProduto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                IList<Produto> produtos = _produtoService.GetAll();

                _produtoControl.PopularListagemProdutos(produtos);
            }
        }

        public override void Atualizar()
        {
            Produto produtoSelecionado = _produtoControl.GetProduto();

            if (produtoSelecionado != null)
            {
                CadastroProduto dialog = new CadastroProduto();
                dialog.NovaProduto = produtoSelecionado;
                DialogResult resultado = dialog.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    try
                    {
                        _produtoService.Update(dialog.NovaProduto);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    IList<Produto> produtos = _produtoService.GetAll();

                    _produtoControl.PopularListagemProdutos(produtos);
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para realizar a atualização");
            }
        }

        public override void Excluir()
        {
            try
            {
                Produto produtoSelecionado = _produtoControl.GetProduto();

                if (produtoSelecionado != null)
                {
                    var resultado = MessageBox.Show("Deseja realmente excluir?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        _produtoService.Delete(produtoSelecionado.Id);

                        IList<Produto> produtos = _produtoService.GetAll();

                        _produtoControl.PopularListagemProdutos(produtos);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um item para realizar a exclusão");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public override UserControl CarregarListagem()
        {
            if (_produtoControl == null)
                _produtoControl = new ProdutoControl();

            IList<Produto> produtos = _produtoService.GetAll();

            _produtoControl.PopularListagemProdutos(produtos);

            return _produtoControl;
        }
    }
}
