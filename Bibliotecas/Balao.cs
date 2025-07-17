namespace Bibliotecas
{
    public class Balao
    {
        private string _cor;

        private string _direcao;

        private int _altura;


        public string Cor
        {
            get { return _cor; }
            set { _cor = value; }
        }

        public string Direcao { get; set; } 

        public int Altura
        {
            get { return _altura; }

            set 
            { 
                if (value >= 0)
                _altura = value; 
            }
        }

        public Balao(string cor)
        {
            _cor = cor;
            _altura = 0;
        }
    }

   
}
