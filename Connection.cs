using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Diagnostics;
using NpgsqlTypes;



namespace SPA
{
    public class Connection
    {


        public static readonly NpgsqlConnection connection = new NpgsqlConnection(@"Server=ec2-3-234-131-8.compute-1.amazonaws.com;Port=5432;User Id=pqxdghzjuuaahh;Password=e87b7533a59857bc6311180d5cb0daf64b4904f78deb37be4577b4c939798410;Database=d49v08ivhupqfp");

		public static void RunQuery(string query)
		{
			connection.Open();

			// Define a query
			NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

			// Execute a query
			NpgsqlDataReader dr = cmd.ExecuteReader();

			connection.Close();
		}

		public static string LoginTest(string query, string CPF)
		{
			connection.Open();
			using (var cmd = new NpgsqlCommand(query, connection))
			{
				cmd.Parameters.AddWithValue("CPF", CPF);
				cmd.Prepare();

				NpgsqlDataReader r = cmd.ExecuteReader();

				string cpf = string.Empty, senha = string.Empty;
				while (r.Read())
				{
					cpf = r.GetString(0);
					senha = r.GetString(2);
				}
				connection.Close();
				if (cpf == string.Empty) return "";
				else return cpf + ";"+ senha;

				
			}
			
		}

		public static string[] NotasAln(string CPF)
		{
			connection.Open();
			using (var cmd = new NpgsqlCommand("select * from alunos where CPF = @CPF", connection))
			{
				cmd.Parameters.AddWithValue("CPF", CPF);
				cmd.Prepare();

				NpgsqlDataReader r = cmd.ExecuteReader();

				string[] n = new string[7];

				while (r.Read())
				{
					n[0] = r.GetString(1);
                    n[1] = r.GetDouble(5).ToString();
					n[2] = r.GetDouble(6).ToString();
					n[3] = r.GetDouble(7).ToString();
					n[4] = r.GetDouble(8).ToString();
					n[5] = r.GetDouble(9).ToString();
					n[6] = r.GetDouble(10).ToString();
				}
				connection.Close();
				return n;

				}

			}

        public static string[] DadosAln(string CPF)
        {
            connection.Open();
            using (var cmd = new NpgsqlCommand("select * from alunos where CPF = @CPF", connection))
            {
                cmd.Parameters.AddWithValue("CPF", CPF);
                cmd.Prepare();

                NpgsqlDataReader r = cmd.ExecuteReader();

                string[] dados = new string[11];
                dados[0] = "NullCPF";
                while (r.Read())
                {
                    dados[0] = r.GetString(0);
                    dados[1] = r.GetString(1);
                    dados[2] = r.GetString(2);
                    dados[3] = r.GetString(3);
                    dados[4] = r.GetString(4);
                    dados[5] = r.GetDouble(5).ToString();
                    dados[6] = r.GetDouble(6).ToString();
                    dados[7] = r.GetDouble(7).ToString();
                    dados[8] = r.GetDouble(8).ToString();
                    dados[9] = r.GetDouble(9).ToString();
                    dados[10] = r.GetDouble(10).ToString();

                }
                connection.Close();
                return dados;

            }
        }

        public static bool AlterarSenha(string CPF,String senha)
        {
            connection.Open();
            using (var cmd = new NpgsqlCommand("UPDATE alunos SET senha = @senha WHERE CPF = @CPF", connection))
            {
                cmd.Parameters.AddWithValue("CPF", CPF);
                cmd.Parameters.AddWithValue("senha", senha);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
        }



        public static List<string> Atividades(string turma)
        {
            connection.Open();
            using (var cmd = new NpgsqlCommand("select * from atividades where turma = @turma", connection))
            {
                cmd.Parameters.AddWithValue("turma", turma);
                cmd.Prepare();

                NpgsqlDataReader r = cmd.ExecuteReader();

                var atvs = new List<string>();
				String atv = String.Empty;
                while (r.Read())
                {
					atv += r.GetString(0) + ";";
					atv += r.GetString(1) + ";";
					atv += r.GetString(3) + ";";
					atvs.Add(atv);
					atv = String.Empty;
				}
                connection.Close();
                return atvs;

            }
        }


    }
}
