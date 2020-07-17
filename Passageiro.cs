namespace UBER_13
{
    public class Passageiro : Usuario
    {
        public string SolicitarMotorista (){
            return "Procurando Motorista";
        }
        public bool Pagar (string statusCorrida) {
            if (statusCorrida == "finalizada")
            {
                return true;
            }
        
            return false;
        }
    
    }
}