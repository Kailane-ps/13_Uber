namespace UBER_13
{
    public class Cartao
    {
        public string Numero { get ;set; }
        public string Titular { get; set; }
        public string Bandeira { get; set; }
        public string CVC { get; set; }

        //.....................................................
        /// <summary>
        ///  Cadatro do cartão
        /// </summary>
        
        public string cadastrar (){
            System.Console.WriteLine("Digite o Titular do cartão");
            Titular = System.Console.ReadLine();

            System.Console.WriteLine("Digite o Numero do cartão");
            Numero = System.Console.ReadLine();

            System.Console.WriteLine("Digite a Bandeira do cartão");
            Bandeira = System.Console.ReadLine();

            System.Console.WriteLine("Digite o codigo de segurança (cvv)");
            CVC = System.Console.ReadLine();

            return "Cartão cadastrado com sucesso";
        }

        //......................................................
         /// <summary>
        /// Limpar os dados do cartão
        /// </summary>
       
        public void Excluir(){
            Numero   = "";
            Titular  = "";
            Bandeira = "";
            CVC      = "";
        }
        //.........................................................
    }
}