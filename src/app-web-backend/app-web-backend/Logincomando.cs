namespace Logindcomando
 {
    class Logincomando
{
        
    // Essa é a classe que vai se comunicar com o banco de dados

        public bool tem = false;
 
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();   
        Conexao con = new Conexao();
        SqlDataReader dr;  

        public bool verificarLogin (String login, String senha)

            {
        // comandos SQL para confirmar se tem no banco de dados, ou seja, procurar login e senha
            cmd.CommandText= "select * from nomedatabela where email = @login and senha = @senha";
            cmd.Parameters.AddwithValue("@login", login);
            cmd.Parameters.AddwithValue("@senha",senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                //Se o login e a senha forem encontrados, "tem" recebe true
                
                if (dr.HasRows)
                {
                    tem = true;
                }

            }
            catch (SQLException)
            {
                
               this.mensagem = "Erro com banco de dados!";
               //Se der erro, ele preencherá a mensagem. Do contrário, a mensagem continuará vazia.
            }
            return tem;
            }

 }
 }