namespace POOCelular
{
    public class Celular
    {
        public string cor;

        public string modelo;

        public string tamanho;

        public bool ligado;


        public string ligar(){

            return "Solicitar número de telefone";
        }

        public string desligar(){

            return "encerrar chamada";
        }

        public string enviarMensagem(){

            return "Mensagem enviada com sucesso";
        }
    }
}