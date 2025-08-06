namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero;
        private string _modelo;
        private string _imei;
        private uint _memoria;

        protected Smartphone(string numero, string modelo, string imei, uint memoria)
        {
            this._numero = numero;
            this._modelo = modelo;
            this._imei = imei;
            this._memoria = memoria;
        }

        public string Numero
        {
            get => _numero;
            set => _numero = value;
        }

        public string Modelo
        {
            get => _modelo;
            set => _modelo = value;
        }

        public string Imei
        {
            get => _imei;
            set => _imei = value;
        }

        public uint Memoria
        {
            get => _memoria;
            set => _memoria = value;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}