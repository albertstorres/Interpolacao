using System;

namespace Interpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var preco = 10.2;
            var preco1 = 20.2;
            var texto = "O preço do produto é R$ " + preco + " Lulas"; //PRIMEIRA FORMA DE INTERPOLAÇÃO
            var texto1 = string.Format("O preço do produto é R$ {0} na promoção. Preço normal R$ {0}", preco, preco1);
            //SEGUNDA FORMA DE INTERPOLAÇÃO. SUBSTITUINDO O {} POR VARIÁVEIS LISTADAS EM ORDEM APÓS A VÍRGULA. INICIA NO 0
            var texto2 = $"O preço do produto é R$ {preco}";
            //TERCEIRA FORMA DE INTERPOLAÇÃO. A QUE FOI USADA ATÉ AGORA NO CURSO.
            var texto3 = @"O texto a seguir permite
quebra de linha no código.";
            //DICA. O @ PERMITE QUEBRA DE LINHA PARA ORGANIZAR O CÓDIGO. PORÉM SE SEGUE AS QUEBRAS DE LINHA E ESPAÇOS NA EXIBIÇÃO.

            Console.WriteLine(texto);
            Console.WriteLine(texto1);
            Console.WriteLine(texto2);
            Console.WriteLine(texto3);
        }
    }
}
