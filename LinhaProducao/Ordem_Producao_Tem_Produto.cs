using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaProducao
{
    internal class Ordem_Producao_Tem_Produto : Conexao
    {

        public int id;

        public int id_ordem;

        public int id_produto;

        public int quantidade;

        public DateTime data_cadastro;

        public List<Ordem_Producao_Tem_Produto> GetListaOrdemProducao()
        {

            List<Ordem_Producao_Tem_Produto> listaOrdemProducaoProduto = new List<Ordem_Producao_Tem_Produto>();

            try
            {
                OpenConnection();


                string query = "SELECT * FROM ordem_producao_tem_produto";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ordem_Producao_Tem_Produto OrdemPP = new Ordem_Producao_Tem_Produto();
                            OrdemPP.id         = Convert.ToInt32(reader.GetString("id"));
                            OrdemPP.id_ordem   = Convert.ToInt32(reader.GetString("id_ordem"));
                            OrdemPP.id_produto = Convert.ToInt32(reader.GetString("id_produto"));
                            OrdemPP.quantidade = Convert.ToInt32(reader.GetString("quantidade"));
                            listaOrdemProducaoProduto.Add(OrdemPP);
                        }
                    }
                }

                CloseConnection();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }

            return listaOrdemProducaoProduto;
        }

        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `ordem_producao_tem_produto` (`id_ordem`, `id_produto`, `quantidade`) VALUES (@id_ordem, @id_produto, @quantidade);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_ordem", this.id_ordem),
                new MySqlParameter("@id_produto", this.id_produto),
                new MySqlParameter("@quantidade", this.quantidade),
                };

                this.ExecuteQueryWithParameters(query, param);

                return true;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }

    }
}