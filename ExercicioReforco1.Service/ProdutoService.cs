using ExercicioReforco1.Dominio;
using ExercicioReforco1.Dominio.Contratos;
using ExercicioReforco1.Infra.Data;
using System;
using System.Collections.Generic;

namespace ExercicioReforco1.Service
{
    public class ProdutoService 
    {
        IRepositorio<Produto> _produtoRepositorio;


        public ProdutoService(IRepositorio<Produto> Repositorio)
        {
            _produtoRepositorio = Repositorio;

        }

        public void Adicionar(Produto produto)
        {
            try
            {
                produto.valida();
               _produtoRepositorio.Adicionar(produto);

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Produto produto)
        {
            try
            {
                produto.valida();
                _produtoRepositorio.Atualizar(produto);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                _produtoRepositorio.Excluir(id);
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IList<Produto> GetAll()
        {
            if(_produtoRepositorio == null)
            {
                _produtoRepositorio = new ProdutoRepositorio();
            }
            return _produtoRepositorio.ObterTodosItens();
        }
    }
}
