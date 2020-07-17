namespace UBER_13
{
    public class Corrida
    {
        public string LocalizacaoInicial { get; set; }
        public string LocalFinal { get; set; }
        public string StatusCorrida { get; set; }
        public string Motorista { get; set; }
        public string Passageiro { get; set; }

        //......................................................
        /// <summary>
        /// Cancelar a corrida
        /// </summary>

        public string Cancelar (){
            StatusCorrida = "Cancelada";
            return "A Corrida foi Cancelada";
        }
        //.......................................................
    }
}