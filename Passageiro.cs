namespace AulaPOOUber
{
    public class Passageiro : Usuario
    {
        public string ChamarMotorista () {
            return "Chamando motorista...";
        }
        public bool Pagar (string statusCorrida) {
            if (statusCorrida == "Finalizada.") {
                return true;
            }
            return false;
        }
    }
}