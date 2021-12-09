using System;
using System.Text;

namespace AulaString
{
    class Program
    {        
        static void Main(string[] args)
        {
            StringBuilder();
        }

        static void StringBuilder() //Serve para concatenar várias cadeias de caracteres em um loop
        {
            var texto = new StringBuilder();
            texto.Append("Este texto é um teste");
            texto.Append(" e algo a mais");
            texto.Append(" que deve ser testado");
            texto.Append(" e melhorado");

            texto.ToString(); 
            Console.WriteLine(texto);

        }
        static void Trim() //Limpa os espaços do começo ou fim (útil para login etc)
        {
            var texto = " Este texto é um teste ";
            Console.WriteLine(texto.Trim());
        }
        static void Substring()
        {
            var texto = "Este texto é um teste";
            var resultado = texto.Substring(5, 5);            
            Console.WriteLine(resultado);
        }
        static void Split() //Dividir
        {
            var texto = "Este texto é um teste";
            var divisiao = texto.Split(" ");
            Console.WriteLine(divisiao[0]);
            Console.WriteLine(divisiao[1]);
            Console.WriteLine(divisiao[2]);
            Console.WriteLine(divisiao[3]);
            Console.WriteLine(divisiao[4]);
        }
        static void Replace() //Troca o caractere/texto por outro
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Replace("Este", "Isto"));
        }
        static void Length() //Tamanho da string
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Length);
        }
        static void Remove()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Remove(5,5));
        }
        static void Insert() //Inserir texto/caractere
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Insert(11, "AQUI "));
        }
        static void ToLower() //Deixa Minúscula
        {
            var texto = "Este texto É Um Teste";
            Console.WriteLine(texto.ToLower());
        }
        static void ToUpper() //Deixa Maiúscula
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToUpper());
        }
        static void Index() //índice 
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("é")); 
            Console.WriteLine(texto.LastIndexOf("s")); // Última letra 
        }
        static void Equals() //Igual
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
        }
        static void EndsWith() //TerminaCom
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
        }
        static void StartsWith() //ComeçaCom
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase)); //Ignorar maiúscula ou minúscula
            Console.WriteLine(texto.StartsWith("texto"));
        }
        static void Comparacao()
        {
            var texto = "Este texto é um teste";
            //var texto = "textando";
            //Console.WriteLine(texto.CompareTo("testando")); //retorna 0 
            //Console.WriteLine(texto.CompareTo("Testando")); // 1 

            Console.WriteLine(texto.Contains("teste")); //Este texto contém a palavra "teste"? Retorna TRUE
            Console.WriteLine(texto.Contains("Teste")); // False
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // Para ignorar maiúscula ou minúscula
        }
        static void Interpolacao()
        {
            var price = 10.2;
            //var texto = "O preço do produto é " + price;
            //var texto = string.Format("O preço do produto é {0} apenas na promoção", price);
            var texto = $"O preço do produto é {price}";

            Console.WriteLine(texto);
        }
        static void ExemploGuid()  //Guid - Identificador Global Único
        {
            var id = Guid.NewGuid();
            id.ToString(); //transformando em uma string

            id = new Guid("d892c30a-2ec6-4dc5-9090-aa6ae97e882e");

            Console.WriteLine(id.ToString().Substring(0, 8));
        }
    }
}
