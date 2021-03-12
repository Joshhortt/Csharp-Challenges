
//Criar a classe Quadrado que vai herdar da classe Forma
//e implementar os métodos CalcularArea() e CalcularPerimetro()
//Os métodos CalcularArea() e CalcularPerimetro() tiveram
//apenas a declaração de sua assinatura e não foram implementados na
//classe abstrata Forma.

namespace CalculaForma
{
	public class Quadrado : Forma
    {
        private double lado;

        public double Lado
        {
            get
            { 
                return lado; 
            }
            set
            { 
                lado = value; 
            }
        }

        public override void CalcularArea()
        {
            this.Area = lado * lado;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 4 * lado;
        }
    }

}

