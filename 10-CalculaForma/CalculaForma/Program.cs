// 10. Challenge  
//Para calcular a área podemos definir métodos abstratos na classe abstrata e dessa forma obrigar as classes que herdam da classe abstrata
//a implementar esses métodos. Com isso teremos certeza de que esses métodos foram implementados.
//Defina então os métodos CalcularArea() e CalcularPerimetro() como abstratos forçando as classes que derivam da classe base Forma, 
//que também é abstrata, a definir o comportamento dos métodos implementando-os.

//Criar uma instância da classe Quadrado(), atribuir um valor ao seu lado e 
//calcular a área e o perímetro.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaForma
{
	class Program
    {
        static void Main(string[] args)
        {
            // Instancia
            Quadrado q = new Quadrado();

            Console.WriteLine(q.Descricao());

            Console.WriteLine("Informe o valor do lado do quadrado em metros.");

            q.Lado = Convert.ToInt32(Console.ReadLine());
            q.CalcularArea();
            q.CalcularPerimetro();

            Console.WriteLine("A área do quadrado é : " + q.Area + " m2 ");
            Console.WriteLine("O perímetro do quadrado é : " + q.Perimetro + " m ");


            Console.ReadLine();
        }
    }

}
/* No codigo acim fiz:
- A criação de uma instância da classe Quadrado() : Quadrado q = new Quadrado();
- A utilização do método Descricao() : Console.WriteLine(q.Descricao());
- A atribuição do valor do lado do quadrado à propriedade Lado: q.Lado = Convert.ToInt32(Console.ReadLine());
- O cálculo da área e do perímetro: q.CalcularArea(); e q.CalcularPerimetro();
- A exibição do resultado.

OUTPUT NA TELA:
Sou a classe abstrata Forma.
Informe o valor do lado do quadrado em metros.
35
A área do quadrado é : 1225 m2
O perímetro do quadrado é : 140 m
*/

