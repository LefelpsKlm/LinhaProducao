using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaProducao
{
    internal class Linha_Producao : Conexao
    {

        public int id;

        public string nome;

        public int id_empresa;

        public int id_setor;

        public int id_responsavel;

        public DateTime data_cadastro;

        public List<Linha_Producao> GetListaLinhaProducao()
        {

            List<Linha_Producao> listaLinhaProducao = new List<Linha_Producao>();

            try
            {
                OpenConnection();


                string query = "SELECT * FROM linha_producao";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Linha_Producao linhaP = new Linha_Producao();
                            linhaP.id             = Convert.ToInt32(reader.GetString("id"));
                            linhaP.nome           = reader.GetString("id");
                            linhaP.id_empresa     = Convert.ToInt32(reader.GetString("id_empresa"));
                            linhaP.id_setor       = Convert.ToInt32(reader.GetString("id_setor"));
                            linhaP.id_responsavel = Convert.ToInt32(reader.GetString("id_responsavel"));
                            listaLinhaProducao.Add(linhaP);
                        }
                    }
                }

                CloseConnection();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }

            return listaLinhaProducao;
        }

        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `linha_producao` (`nome`, `id_empresa`, `id_setor`, `id_responsavel`) VALUES (@nome,  @id-empresa, @id_setor, @id_responsavel);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@id_setor", this.id_setor),
                new MySqlParameter("@id_responsavel", this.id_responsavel),
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