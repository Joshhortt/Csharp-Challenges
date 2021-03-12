//Na classe abstrata Forma temos definidos:
//As propriedades públicas : Cor, Area e Perimetro
//Os métodos abstratos : CalcularArea() e CalcularPermitero()
//O método público Descricao()
//A classe Forma não pode ser instanciada.

namespace CalculaForma
{
	public abstract class Forma
    {
        private double _area;
        private string _cor;
        private double _perimetro;

        public string Cor
        {
            get
            {
                return _cor;
            }
            set
            {
                _cor = value;
            }
        }

        public double Area
        {
            get
            { return _area; }
            set
            { _area = value; }

        }

        public double Perimetro
        {
            get
            { return _perimetro; }
            set
            { _perimetro = value; }
        }

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();
        public string Descricao()
        {
            return "Sou a classe base abstrata chamada Forma.";
        }
    }

}

