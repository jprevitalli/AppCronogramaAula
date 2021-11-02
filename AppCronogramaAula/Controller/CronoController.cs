using System.Data;
using AppCronogramaAula.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppCronogramaAula.Controller
{
    class CronoController
    {
  
            public void cadastroCrono()
            {

                SqlConnection conexao = new SqlConnection(Conexao.conectar());
                SqlCommand comando = new SqlCommand("pCadastrarCrono", conexao);
                comando.CommandType = CommandType.StoredProcedure;

                try
                {
                    MessageBox.Show(Cronograma.DataAula);
                    comando.Parameters.AddWithValue("@dataAula", Cronograma.DataAula);


                    SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                    codigo.Direction = ParameterDirection.Output;

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    var resposta = MessageBox.Show("Cronograma cadastrado com sucesso! \n" +
                        "Deseja cadastrar outro cronograma?",
                        "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resposta == DialogResult.Yes)
                    {
                        Cronograma.Retorno = "False";
                        return;
                    }
                    else
                    {
                        Cronograma.Retorno = "True";
                        return;
                    }

                }
                catch
                {
                    MessageBox.Show("Cronograma não cadastrado", "Atenção");
                }
                finally
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }


            }

            public void visuCodigoCrono()
            {

                SqlConnection conexao = new SqlConnection(Conexao.conectar());
                SqlCommand comandos = new SqlCommand("pBuscaCodigoCrono", conexao);
                comandos.CommandType = CommandType.StoredProcedure;

                try
                {

                    comandos.Parameters.AddWithValue("@codigo", Cronograma.Codigo);
                    conexao.Open();

                    var tabelaDados = comandos.ExecuteReader();

                    if (tabelaDados.Read())
                    {
                        Cronograma.DataAula = tabelaDados["dataAula"].ToString();
                        Cronograma.Retorno = "True";

                    }
                    else
                    {
                        MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        Cronograma.Retorno = "False";
                    }

                }
                catch
                {
                    MessageBox.Show("Não foi possível localizar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                finally
                {
                    if (conexao.State != ConnectionState.Closed)
                    {
                        conexao.Close();
                    }
                }
            }

            public void alterarCrono()
            {
                SqlConnection conexao = new SqlConnection(Conexao.conectar());
                SqlCommand comandos = new SqlCommand("pAlterarCrono", conexao);
                comandos.CommandType = CommandType.StoredProcedure;

                try
                {
                    comandos.Parameters.AddWithValue("@dataAula", Cronograma.DataAula);



                    conexao.Open();
                    comandos.ExecuteNonQuery();
                    MessageBox.Show("Cronograma alterado com sucesso!");
                    Cronograma.Retorno = "True";
                }
                catch
                {
                    MessageBox.Show("Cronograma não alterado.");
                    Cronograma.Retorno = "False";
                }
                finally
                {
                    if (conexao.State != ConnectionState.Closed)
                    {
                        conexao.Close();
                    }
                }
            }

            public void deletarCrono()
            {
                SqlConnection conexao = new SqlConnection(Conexao.conectar());
                SqlCommand comandos = new SqlCommand("pDeletarCrono", conexao);
                comandos.CommandType = CommandType.StoredProcedure;

                try
                {
                    comandos.Parameters.AddWithValue("@codigo", Cronograma.Codigo);
                    conexao.Open();
                    comandos.ExecuteNonQuery();
                    Cronograma.Retorno = "True";
                    MessageBox.Show("Cronograma excluído com sucesso!");

                }
                catch
                {
                    MessageBox.Show("Cronograma não deletado.");
                    Cronograma.Retorno = "False";
                }
                finally
                {
                    if (conexao.State != ConnectionState.Closed)
                    {
                        conexao.Close();
                    }
                }

            }
        }
    }
