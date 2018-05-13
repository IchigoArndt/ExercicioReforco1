using ExercicioReforco1.Dominio.Contratos;
using ExercicioReforco1.Dominio.funcionalidades.Venda;
using ExercicioReforco1.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Service
{
    public class VendaService
    {
        IRepositorio<Venda> _vendaRepositorio;


        public VendaService(IRepositorio<Venda> Repositorio)
        {
            _vendaRepositorio = Repositorio;
        }

        public void Adicionar(Venda Venda)
        {
            try
            {
                Venda.valida();
                _vendaRepositorio.Adicionar(Venda);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Venda Venda)
        {
            try
            {
                Venda.valida();
                _vendaRepositorio.Atualizar(Venda);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                _vendaRepositorio.Excluir(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IList<Venda> GetAll()
        {
            if (_vendaRepositorio == null)
            {
                _vendaRepositorio = new VendaRepositorio();
            }
            return _vendaRepositorio.ObterTodosItens();
        }
    }
}
