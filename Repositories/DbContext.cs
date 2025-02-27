using System.Data;
using System.Data.SqlClient;

namespace FFPPRAJ.Repositories;

public class DbContext
{
    //Retorna a conexão com o meu banco de dados
    private static SqlConnection connection;
    public SqlConnection ConexaoBanco()
    {
        string connectionString = @"Data Source=RAQUEL\SQLEXPRESS;Initial Catalog=DB_FFPPRAJ;Integrated Security=True";
        connection = new SqlConnection(connectionString);
        connection.Open();
        return connection;
    }
    public DataTable Consulta(string sql)
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
}