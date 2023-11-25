using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LinhaProducao
{
    internal class Processos : Conexao
    {

        public int id;

        public string nome;

        public int setor;

        public DateTime data_cadastro;

        public List<Processos> GetListaProcessos()
        {

            List<Processos> listaProcessos = new List<Processos>();

            try
            {
                OpenConnection();


                string query = "SELECT * FROM processos";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Processos processos = new Processos();
                            processos.id        = Convert.ToInt32(reader.GetString("id"));
                            processos.nome      = (reader.GetString("nome"));
                            processos.setor     = Convert.ToInt32(reader.GetString("setor"));
                            listaProcessos.Add(processos);
                        }
                    }
                }

                CloseConnection();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }

            return listaProcessos;
        }

        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `processos` (`nome`, `setor`) VALUES (@nome, @setor);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@setor", this.setor),
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