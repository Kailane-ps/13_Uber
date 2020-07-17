namespace UBER_13
{
    public class Usuario
    {

        public string Nome { get; set; }
        public string login = "Kilane@hotmail.com";
        public string senha = "0987654321";
        public string localizacaoAtual{ get; set; }
        public string TokenLogin { get;set;}

        //......................................
        private int idade = 0;
        public int Idade
        {
            get{ return idade; }
            set{
                if (idade > 0 ){
                    idade = value;
                }
            }       
        }
        //.......................................
        /// <summary>
        /// login
        /// </summary>

        public bool Login (string login, string senha){
            if (this.login == login && this.senha == senha)
            {
                TokenLogin = "asdfghjklasdfgh23456jk";
                return true;
            }

            return false;
        }
        //........................................
        /// <summary>
        /// Apaga o token
        /// </summary>

        public void ApagarToken (){
            TokenLogin = "";
        }
        //........................................
    }
}