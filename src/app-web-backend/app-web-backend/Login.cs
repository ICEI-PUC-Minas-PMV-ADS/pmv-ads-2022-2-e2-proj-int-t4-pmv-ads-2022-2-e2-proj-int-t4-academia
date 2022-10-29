namespace Logincontrole
{
    public class controle
    {
        // Essa classe controla a comunicação entre as classes
        // Ela manipula as informações só do formulário


        public bool tem;
        public string mensagem;
        
        public bool acessar(String login, String senha) 
        
        {
            Logincomando Logincomando = new Logincomando();
            tem = Logincomando.verificarLogin(login, senha);
            // Esse método "verificalogin" confere se as duas informações estão no banco
            // Se estiverem, ele lança o resultado nessa variável "tem"

            if(!Logincomando.mensagem.equals(""))
            // Equals é um comando de comparação
            // Exclamação é negação, ou seja, se for diferente de ("")
            // Raciocínio: se essa mensagem contiver uma informação, houve erro
            {
                this.mensagem=Logincomando.mensagem;
                // A string mensagem fica vazia, vou usá-la para saber se há erros.
                // Se ela for preenchida, será por uma string de erro, aí saberei que há erro
            }
            return tem;
            // Return encerra a condição. A variável "tem" é retornada para o formulário
        }

    }

}

