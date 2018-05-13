using ExercicioReforco1.Dominio;
using ExercicioReforco1.Dominio.Contratos;
using ExercicioReforco1.Dominio.funcionalidades.Venda;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Infra.Data
{
   public class VendaRepositorio : IVendaRepositorio
    {
        #region Queries
        const string sqlInsert =   @"Insert into TBVenda(Nome, Quantidade, Lucro)
                                     values(@Nome, @Quantidade, @Lucro)";
        const string sqlUpdate =    @"Update TBVenda set Nome = @Nome,Quantidade = @Quantidade,Lucro = @Lucro where Id = @Id";
        const string sqlDelete =    @"Delete From TBVenda where Id = @Id";
        const string sqlgetById =   @"Select * From TBVenda where Id = @Id";
        const string sqlgetAll =    @"Select * From TBVenda";
        //Sql Tabela Intermediaria
        const string sqlInsertVenda_Produto = @"Insert into TBVenda_Produto(IdProduto,IdVenda) values (@idProduto,@IdVenda)";
        const string getAllVenda_Produto = @"select * from TBVenda_Produto";
        const string deleteVenda_Produto = @"Delete from TBVenda_Produto where IdVenda = @Id";

        #endregion
        public Venda Adicionar(Venda entidade)
        {
            DB.Insert(sqlInsert, GetParam(entidade));
            //Table Secundaria
            Produto produto = entidade._produto;
            DB.Insert(sqlInsertVenda_Produto, GetParamVendaProduto(entidade, produto));
            return entidade;
        }

        public Venda Atualizar(Venda entidade)
        {
            DB.Update(sqlUpdate, GetParam(entidade));
            return entidade;
        }

        public void Excluir(int id)
        {
            var param = new Dictionary<string, object> { { "Id", id } };
            DB.Delete(sqlDelete, param);
        }

        public IList<Venda> ObterTodosItens()
        {
            IList<Venda> listaVendas = new List<Venda>();
            listaVendas = DB.GetAll(sqlgetAll, Converter);
            return listaVendas;
        }

        public Dictionary<string, object> GetParam(Venda venda)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", venda.Id);
            dic.Add("Nome", venda.NomeCliente);
            dic.Add("Quantidade", venda.Quantidade);
            dic.Add("Lucro", venda.Lucro);

            return dic;
        }

        public Dictionary<string, object> GetParamVendaProduto(Venda venda, Produto produto)
        {
            var dic = new Dictionary<string, object>();

            dic.Add("IdVenda", venda.Id);
            dic.Add("IdProduto", produto.Id);

            return dic;
        }

        private static Venda Converter(IDataReader _reader)
        {
            Venda venda = new Venda();
            venda.Id = Convert.ToInt32(_reader["Id"]);
            venda.NomeCliente = Convert.ToString(_reader["Nome"]);
            venda.Quantidade = Convert.ToInt32(_reader["Quantidade"]);
            venda.Lucro = Convert.ToDecimal(_reader["Lucro"]);
            return venda;
        }
    }
}