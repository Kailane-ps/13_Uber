namespace UBER_13
{
    public class Motorista : Usuario
    {
        public string Carro { get; set; }
        public string Placa { get; set; }

        //.................................................................
        /// <summary>
        /// Mostrar ao usuario que a corrida foi aceita
        /// </summary>

        public string AceitarPassageiro(string nome){
            return $"Passageiro {nome} aceito pelo motorist {this.Nome}";
        }
        //....................................................................
         /// <summary>
        /// Mostrar para fazer o pagamento caso a corrida estiver finalizada
        /// </summary>

        public bool ReceberPagamento (string StatusCorrida){
            if (StatusCorrida == "Finalizada")
            {
                return true;
            }
                return false;
        }
        //......................................................................
    
    }
}