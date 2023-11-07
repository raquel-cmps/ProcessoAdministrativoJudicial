using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DevExpress.Data.Filtering;

namespace FFPPRAJ
{
    public class Banco
    {
        //Retorna a conexão com o meu banco de dados
        private static SqlConnection connection;
        public static SqlConnection ConexaoBanco()
        {
            string connectionString = @"Data Source=RAQUEL\SQLEXPRESS;Initial Catalog=DB_FFPPRAJ;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        
        //Retorna uma dataTable com todos os cadastros feitos
        public static DataTable ObterCadastros()
        {    
            SqlDataAdapter adapter = null;
            DataTable dataTable = new DataTable();
             
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand(); 
                cmd.CommandText = "SELECT * FROM Cadastro";
                adapter = new SqlDataAdapter(cmd.CommandText, vcon);
                adapter.Fill(dataTable);
                vcon.Close();
                return dataTable;
 
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        //Metodo generico para consula
        public static DataTable Consulta(string sql)
        {
            SqlDataAdapter adapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                adapter = new SqlDataAdapter(cmd.CommandText, vcon);
                adapter.Fill(dataTable);
                vcon.Close();  
                return dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void NovoCadastro(Processo p)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO Cadastro 
                        (Processo,Tipo,UF,Municipio,Vara,Autoria,Chapa,Indicativo) 
                    VALUES 
                        (@Processo,@Tipo,@UF,@Municipio,@Vara,@Autoria,@Chapa,@Indicativo)";
                cmd.Parameters.AddWithValue("@Processo", p.id_processo);
                cmd.Parameters.AddWithValue("@Tipo", p.tipo);
                cmd.Parameters.AddWithValue("@UF", p.uf);
                cmd.Parameters.AddWithValue("@Municipio", p.municipio);
                cmd.Parameters.AddWithValue("@Vara", p.vara);
                cmd.Parameters.AddWithValue("@Autoria", p.autoria);
                cmd.Parameters.AddWithValue("@Chapa", p.chapa);
                cmd.Parameters.AddWithValue("@Indicativo", p.indicativo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo processo inserido!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "deu ruim");
            }
        }

        //////////TELA DE DETALHE ---list
        public static DataTable ObterDadosCadastro(string id)
        {
            SqlDataAdapter adapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM Cadastro where Processo = " + id;
                adapter = new SqlDataAdapter(cmd.CommandText, vcon);
                adapter.Fill(dataTable);
                vcon.Close();
                return dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarCadastro(Processo p)
        {
            SqlDataAdapter adapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                    UPDATE Cadastro SET 
                        Processo = @Processo, 
                        Tipo = Tipo, 
                        UF = @UF,
                        Municipio = @Municipio, 
                        Vara = @Vara, 
                        Autoria = @Autoria, 
                        Chapa = @Chapa, 
                        Indicativo = @Indicativo
                    WHERE Processo = @Processo";
                cmd.Parameters.AddWithValue("@Processo", p.id_processo);
                cmd.Parameters.AddWithValue("@Tipo", p.tipo);
                cmd.Parameters.AddWithValue("@UF", p.uf);
                cmd.Parameters.AddWithValue("@Municipio", p.municipio);
                cmd.Parameters.AddWithValue("@Vara", p.vara);
                cmd.Parameters.AddWithValue("@Autoria", p.autoria);
                cmd.Parameters.AddWithValue("@Chapa", p.chapa);
                cmd.Parameters.AddWithValue("@Indicativo", p.indicativo);
                adapter = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Processo atualizado com sucesso!");
                vcon.Close();

                /*
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"UPDATE Cadastro SET Processo = '"+ p.id_processo + "',  Tipo = '" + p.tipo + "', UF = '"+ p.uf + "', Municipio = '"+ p.municipio + "',Vara = '"+ p.vara + "', Autoria = '"+ p.autoria + "', Chapa = '"+ p.chapa + "', Indicativo = '" + p.indicativo + "' WHERE Processo = "+p.id_processo;
                    
                adapter = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Processo atualizado com sucesso!");
                vcon.Close();
                */
 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ExluirCadastro(string id)
        {
            SqlDataAdapter adapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM Cadastro WHERE Processo =" + id;
                adapter = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //////TELA MUNICIPIO
        public static DataTable ObterDadosMunicipio(string ibge)
        {
            SqlDataAdapter adapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM cidade WHERE ibge = " + ibge;
                adapter = new SqlDataAdapter(cmd.CommandText, vcon);
                adapter.Fill(dataTable);
                vcon.Close();
                return dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
