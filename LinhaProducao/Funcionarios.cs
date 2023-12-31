﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaProducao
{
    internal class Funcionarios : Conexao
    {

        public int id;

        public int id_empresa;

        public string nome;

        public string email;

        private string senha;

        private int nivel;

        public bool logado = false;

        public DateTime data_cadastro;

        public void SetSenha(string senha)
        {
            //this.senha = BCrypt.Net.BCrypt.HashPassword(senha, BCrypt.Net.BCrypt.GenerateSalt());
            this.senha = senha;
        }

        public string GetSenha()
        {
            return this.senha;
        }

        public void SetNivel(int nivel)
        {
            this.nivel = nivel;
        }

        public int GetNivel()
        {
            return this.nivel;
        }

        public Funcionarios GetFuncionarioPorEmailESenha()
        {
            Funcionarios funcionarios = new Funcionarios();

            try
            {
                OpenConnection();


                string query = "SELECT * FROM funcionario WHERE email = '"+ this.email +"' AND senha = '"+ this.senha +"';";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            this.id = Convert.ToInt32(reader.GetString("id"));
                            this.nome = reader.GetString("nome");
                            this.email = reader.GetString("email");
                            this.SetNivel(Convert.ToInt32(reader.GetString("nivel")));

                            this.logado = true;

                        }
                    }
                }

                CloseConnection();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }

            return this;
        }

        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `funcionario` (`id_empresa`, `nome`, `email`, `senha`, `nivel`) VALUES (@id_empresa, @nome, @email, @senha, @nivel);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@email", this.email),
                new MySqlParameter("@senha", this.senha),
                new MySqlParameter("@nivel", this.nivel),
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