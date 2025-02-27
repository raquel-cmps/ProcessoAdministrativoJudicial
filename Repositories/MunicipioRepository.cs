using System.Data;
using System.Data.SqlClient;

namespace FFPPRAJ.Repositories;

public class MunicipioRepository
{
    private readonly DbContext _dbContext = new DbContext();

    public DataTable ObterDadosMunicipio(string ibge)
    {
        SqlDataAdapter adapter = null;
        DataTable dataTable = new DataTable();

        try
        {
            var vcon = _dbContext.ConexaoBanco();
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