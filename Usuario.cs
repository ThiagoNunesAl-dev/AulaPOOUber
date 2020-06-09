namespace AulaPOOUber
{
    public class Usuario
    {
        public string Nome { get; set; }
        private int idade;
        public int Idade {
            get { return idade; }
            set {
                if (idade > 0) {
                    idade = value;
                }
            }
        }
        public string Foto { get; set; }
        private string login = "ednaldopereira@ednaldopereira.chance";
        private string senha = "ednaldo123pereira";

        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }
        public string TipoDeAcesso { get; set; }

        public bool Login (string login, string senha) {
            if (this.login == login && this.senha == senha) {
                TokenLogin = "234hags&&6716()*&";
                return true;
            }
            return false;
        }

        public void Logout () {
            TokenLogin = "";
        }

    }
}