namespace Conectar
{
public class Conexao
{
    SqlConnection con = SqlConnection ();


    public class Conexao     
    {
        
        con.Connectionstring = @"";

    }
    public SqlConnection Conectar()
    {
        if (con.State == System.Data.ConnectionState.Closed.) 
        {
            con.Open();
        }
        return con;
    }
    public void Desconectar()
}
        if (con.State == System.Data.ConnectionState.Open.) 
        {
            con.Close();
        }
}
