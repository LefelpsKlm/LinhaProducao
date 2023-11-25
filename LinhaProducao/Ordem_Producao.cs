using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaProducao
{
    internal class Ordem_Producao : Conexao
    {

        public int id;

        public int id_empresa;

        public int setor;

        public int cliente;

        public DateTime data_cadastro;

        public List<Ordem_Producao> GetListaOrdemProducao()
        {

            List<Ordem_Producao> listaOrdemProducao = new List<Ordem_Producao>();

            try
            {
                OpenConnection();


                string query = "SELECT * FROM ordem_producao";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ordem_Producao OrdemP = new Ordem_Producao();
                            OrdemP.id             = Convert.ToInt32(reader.GetString("id"));
                            OrdemP.id_empresa     = Convert.ToInt32(reader.GetString("id_empresa"));
                            OrdemP.setor          = Convert.ToInt32(reader.GetString("setor"));
                            OrdemP.cliente        = Convert.ToInt32(reader.GetString("cliente"));
                            listaOrdemProducao.Add(OrdemP);
                        }
                    }
                }

                CloseConnection();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }

            return listaOrdemProducao;
        }

        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `ordem_producao` (`id_empresa`, `setor`, `cliente`) VALUES (@id_empresa, @setor, @cliente);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@setor", this.setor),
                new MySqlParameter("@cliente", this.cliente),
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