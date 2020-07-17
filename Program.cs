using System;

namespace  UBER_13
{
    class Program
    {
        static void Main(string[] args)

        {
            //............insasiando passageiro.....................

            Passageiro passageiro = new Passageiro();

            Console.WriteLine("Digite seu login");
            string login = Console.ReadLine();
            
            Console.WriteLine("Digite sua senha");
            string senha = Console.ReadLine();

            passageiro.Login (login,senha);

            //.........................................................

            if (passageiro.TokenLogin != "" && passageiro.TokenLogin != null)
            {
                Console.WriteLine("Login autorizado");

                //.............instanciando Motorista.................
                Motorista motorista = new Motorista ();
                motorista.Nome  = "Antônio Rodrigues";
                motorista.Carro = "Honda Civic";
                motorista.Placa = "OKAI-2607";

                //..............Criando conta Motorista...............
                Conta contM = new Conta();
                contM.Cadastrar();
                
                //...............Dados do Pasageiro...................
                passageiro.Nome  = "Kailane Pereira";
                passageiro.Idade = 17;
                passageiro.localizacaoAtual = "Rua porto principe, 200";
                
                //..............instanciando Usuario..................
                Cartao cartao = new Cartao();
                cartao.cadastrar();
                
                passageiro.SolicitarMotorista();
                motorista.AceitarPassageiro(passageiro.Nome);

                //..............Corrida inicada.......................
                Corrida corrida   = new Corrida();
                corrida.Motorista = motorista.Nome;
                corrida.Passageiro= passageiro.Nome;
                corrida.LocalizacaoInicial = passageiro.localizacaoAtual;
                corrida.LocalFinal= "Rua da nobrega, 321"; 
                
                string resposta = "No Caminho";

                while (resposta != "Sim")
                {
                    Console.WriteLine("Você chegou ao seu destino? Digite Sim ou Nao");
                    resposta = Console.ReadLine();

                }

                //...............Finalizando Corrida....................
                corrida.StatusCorrida = "Finalizada";
                passageiro.Pagar(corrida.StatusCorrida);
                motorista.ReceberPagamento(corrida.StatusCorrida);

                //...............Pagamento.............................
                Pagamento pg = new Pagamento();

                pg.data = DateTime.Now;
                pg.StatusPagamento = "Pago";

                Console.WriteLine("Corrida Finalizada");
                Console.WriteLine("Status Corrida: "+corrida.StatusCorrida);
                Console.WriteLine("Data e Hora: "+pg.data);
                Console.WriteLine("Status de Pagamento "+pg.StatusPagamento);
                Console.WriteLine("Motorista "+motorista.Nome);

                //.......................................................

            }else{
                Console.WriteLine("Não é possivel usar o APP");
            }

        }
    }
}
