using ExercicioReforco1.Dominio;
using ExercicioReforco1.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Infra.Data
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {

        #region Queries
        //Insert
        const string SQLInsert = @"Insert into TBProduto(Nome,PrecoVenda,PrecoCusto,DataFabricacao,DataValidade,Disponivel)
                                   values(@Nome,@PrecoVenda,@PrecoCusto,@DataFabricacao,@DataValidade,@Disponivel)";
        //Update
        const string SQLUpdate = @"Update TBProduto set Nome = @Nome,PrecoVenda = @PrecoVenda,PrecoCusto = @PrecoCusto,
                                  DataFabricacao = @DataFab,DataValidade = @DataValidade,Disponivel = @Diponivel";
        //Get
        const string SQLGetById = @"Select * from TBProduto where Id = @Id";
        //GetAll
        const string SQLGetAll = @"Select * from TBProduto";
        //GetLastId
        private const string sqlGetLastOne = @"SELECT top(1) * FROM TBProduto ORDER BY Id DESC";
        //DeleteById
        private const string sqlDelete = @"Delete from TBProduto where Id = @Id";
        #endregion

        public Produto Adicionar(Produto entidade)
        {
            DB.Insert(SQLInsert, GetParam(entidade));
            int id = ObterUltimoId();
            entidade.Id = id;
            return entidade;

        }
        //Retorna o ultimo Id
        public int ObterUltimoId()
        {
            int id = 0;
            IList<Produto> Contatos = DB.GetAll(sqlGetLastOne, Converter);

            foreach (var item in Contatos)
            {
                id = item.Id;
            }

            return id;
        }

        public Produto Atualizar(Produto entidade)
        {
            DB.Update(SQLUpdate,GetParam(entidade));
            return entidade;
        }

        public void Excluir(int id)
        {
            var param = new Dictionary<string, object> { { "Id", id } };
            DB.Delete(sqlDelete, param);
        }

        public bool Existe(Produto produto)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> ObterTodosItens()
        {
            IList<Produto> getAll = new List<Produto>();
            getAll = DB.GetAll(SQLGetAll, Converter);
            return getAll;
        }

        //Parametros para SQL
        public Dictionary<string, object> GetParam(Produto produto)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", produto.Id);
            dic.Add("Nome", produto.Nome);
            dic.Add("PrecoVenda", produto.PrecoVenda);
            dic.Add("PrecoCusto", produto.PrecoCusto);
            dic.Add("DataFabricacao", produto.DataFabricacao);
            dic.Add("DataValidade", produto.DataVencimento);
            dic.Add("Disponivel", produto.Disponivel);

            return dic;
        }
        private static Produto Converter(IDataReader _reader)
        {
            Produto produto = new Produto();
            produto.Id = Convert.ToInt32(_reader["Id"]);
            produto.Nome = Convert.ToString(_reader["Nome"]);
            produto.PrecoVenda = Convert.ToDecimal(_reader["PrecoVenda"]);
            produto.PrecoCusto = Convert.ToDecimal(_reader["PrecoCusto"]);
            produto.DataFabricacao = Convert.ToDateTime(_reader["DataFabricacao"]);
            produto.DataVencimento = Convert.ToDateTime(_reader["DataValidade"]);
            produto.Disponivel = Convert.ToBoolean(_reader["Disponivel"]);
            return produto;
        }
    }
}
