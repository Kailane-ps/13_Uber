namespace UBER_13
{
    public class Conta
    {
        public string agencia { get; set; }
        public string ContaCorrente { get; set; }

        //.................................................................
         /// <summary>
        /// Cadastro do usuario
        /// </summary>
        public string Cadastrar (){
            System.Console.WriteLine("Digite a sua Agencia");
            agencia = System.Console.ReadLine();

            System.Console.WriteLine("Digete sua Conta Corrente");
            ContaCorrente = System.Console.ReadLine();

            return "Cadatro finalizado com sucesso!";
        }
        //................................................................
         /// <summary>
        /// Limpar dados do usuario
        /// </summary>
       
        public void Excluir () {
            agencia = "";
            ContaCorrente = "";
        }
        //.................................................................
    }
}