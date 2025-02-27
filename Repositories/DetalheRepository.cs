using System.Data;
using System.Data.SqlClient;
using FFPPRAJ.Models;

namespace FFPPRAJ.Repositories;

public class DetalheRepository
{
    private readonly DbContext _dbContext = new DbContext();

    public DataTable ObterDadosCadastro(string id)
    {
        SqlDataAdapter adapter = null;
        DataTable dataTable = new DataTable();

        try
        {
            var vcon = _dbContext.ConexaoBanco();
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

    

    public void ExluirCadastro(string id)
    {
        SqlDataAdapter adapter = null;
        DataTable dataTable = new DataTable();

        try
        {
            var vcon = _dbContext.ConexaoBanco();
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
}