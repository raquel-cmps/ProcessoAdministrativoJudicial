using System.Data;
using System.Data.SqlClient;
using FFPPRAJ.Models;

namespace FFPPRAJ.Repositories;

public class CadastroRepository
{
    private readonly DbContext _dbContext = new DbContext();

    //Retorna uma dataTable com todos os cadastros feitos
    public DataTable ObterCadastros()
    {
        SqlDataAdapter adapter = null;
        DataTable dataTable = new DataTable();

        try
        {
            var vcon = _dbContext.ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT * FROM Cadastro";
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

    public void NovoCadastro(Processo p)
    {
        try
        {
            var vcon = _dbContext.ConexaoBanco();
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

    public void AtualizarCadastro(Processo p)
    {
        SqlDataAdapter adapter = null;
        DataTable dataTable = new DataTable();

        try
        {
            var vcon = _dbContext.ConexaoBanco();
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
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}