using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace primeiroprojetoCsharpdotnet
{
    class Program
    {


        //----------------------------Enum------------------------------------


        enum Cor { azul = 33, verde = 78, amarelo = 178, vermelho = 199 };



        //----------------------------Enum------------------------------------ -


        static void Main(string[] args)
        {

            Cor corFavorita = Cor.verde;
            Cor corFavoritaCarla = Cor.vermelho;
            // colocar o int antes do nome da var é cast, converter em numero, no caso, numero do indice
            Console.WriteLine((int)corFavorita);
            Console.WriteLine(corFavoritaCarla);
            Console.WriteLine((Cor) 178);


            /*-----------------------------
            // Int armazena numeros inteiros negativos e positivos
            // float é o ponto flutuante, numero como se fosse inteiro mas com casas decimais, negativo e positivo, e as casa podem mudar pode se usar double e decimal
            // Bool é o booleano, verdadeiro ou falso
            // String sao caracteres entre aspas duplas ""
            // Char - aspas simples é para especificar char ''
            // Quando o tipo da variavel é definido ele não pode ser mais trocado;

            int data_Segunda_Guerra = 1939;
            float velocidade_F1 = 322.48f; //usar f no final da declaração de float.
            bool segunda_Guerra_Aconteceu = true;

            //so se pode usar _ alem das letras em declaração de variavel e não pode começar com numero, pode conter:
            //A-Z
            // 0-9 NÃO SENDO NO INICIO
            // _
            // não pode ser usada palavras reservadas tipo "class", "const", "using" e etc...
            
            Console.WriteLine("A segunda Guerra Mundial começou em:"); // \n para o computador é um caractere que siginifica quebra de linha
            Console.WriteLine(data_Segunda_Guerra);
            Console.WriteLine("e esta informação é:");
            Console.WriteLine(segunda_Guerra_Aconteceu);// WriteLine quebra linha igual \n
            Console.ReadLine(); // detectar o que o usuario escreveu no console/fica esperando o usario digitar ou pressionar enter

            velocidade_F1 = 292.95f;
            segunda_Guerra_Aconteceu = false;
            
            // um unico = é atribuição de valor e == é comparação      


            // forma "preguiçosa" de se declarar variavel
            var corFavorita = "Azul";
            var modeloDoProduto = "2596"; 



            //maneira avançada com tipagem dinamica 
            // dynamic abre a possibilidade de trocar o tipo da variavel, e não é aconselhavel a usar pq o padrão C# é tipado e isso é quebra de tipagem
            // não é muito utilizado, é usado em coisas especificas
            dynamic corFavorita = "vermelho";
            Console.WriteLine(corFavorita);
            corFavorita = 2355;
            Console.WriteLine(corFavorita);
            

            //constante é atribuida só uma vez e não se muda mais, é estatico, é usado para um valor critico para o funcionamento de algo
            // const precisa ser seguido do tipo e nome da constante
            const float PI = 3.145184111515f;


            Console.WriteLine("Escreva teu nome:");
            string nome = "";
             nome = Console.ReadLine();
            Console.WriteLine("seu nome é = ");
            Console.WriteLine(nome);
            ------------------*/



            //int numeroQualquer = 20 + 20 - 80;
            //int numeroMult = 10 * 90;
            //int numeroDiv = 10 / 10;
            //float numeroDivFloat = 10f / 4;
            // para a divisao quebrar o numero e o transformar em decimal na divisao, ha de colocar pelo menos um numero decimal na divisao para retornar 
            // um numero decimal, deve-se dizer o decimal com "f" no fim do numero
            //int teste = 2 + 2 * 10 / (5 * 6);

            //Console.WriteLine(numeroQualquer);
            //Console.WriteLine(numeroMult);
            //Console.WriteLine(numeroDiv);
            //Console.WriteLine(numeroDivFloat);
            //Console.WriteLine(teste);
            /*

            int a = 20;
            int b = 25;
            int c = 200;

            // &&(E/AND) e ||(ou/or)
            // cond1 &&  cond2 as duas condiçoes tem de ser verdadeiras para dar true, se uma for falsa, da false
            // cond1 ||  cond2 uma das condiçoes tem de ser verdadeiras para dar true

            if (a < b &&  a > c)
            {

                Console.WriteLine("é verdade");
              
            }
            //pode usar quantos else if quiser antes do else
            else if(c == a || a < b)
            {
                Console.WriteLine("Liberado por OU");
            }

            else
            {
                Console.WriteLine("é mentira");
            } 



            // CAST é usado para converter tipo, a entrada de informações no console.readline se da em string, para converter em int,
            // usar int.parse antes do console.readline
            // parse significa converter 
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é criança");
            }
            else if (idade >= 12 && idade <= 17)
            {
                Console.WriteLine("você é adolescente");
            }
            else if (idade >= 125)
            {
                Console.WriteLine("voce deve estar morto, ninguem nunca viveu tanto");
            }
            else if (idade >= 78)
            {
                Console.WriteLine("Você é idoso");
            }
            else if (idade >=60 && idade <= 78)
            {
                Console.WriteLine("Você é velho, apenas");
            }
            else
            {
                Console.WriteLine("você é adulto");
            }*/







            /*
            GerarPreco(15);
            GerarPreco(-25);
            GerarPreco(05);
            */

            /*
            Console.WriteLine(Math.Abs(-60));
            int soma1 = Somar(1, 3, 5);
            int soma2 = Somar(10, 30, 50);
            int soma3 = Somar(100, 300, 500);
            
            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);
            */




            /* -------------------ARRAY----------------------------------------------




            string[] produtos = new string[5] {
                "bola", 
                "neymar", 
                "homem", 
                "aranha", 
                "miranha"
            };
            
            //maneira mais simples de criar array
            int[] valores = { 5, 6, 7, 8, 9, 10, 22, 99 };

            produtos[1] = "FIFA 2021";
            Console.WriteLine(produtos[1]);



             -------------------ARRAY----------------------------------------------*/

            /*----------------------------Switch-------------------------------------




            //switch tem a mesma função do if, else e else if, porem é usado para multiplas condiçoes
            // vai passar uma variavel e o switch vai checar se a var tem o parametro 
            // switch só realiza operações de igualdade

            string cor = "amarelo";
            switch (cor)
            {
                case "azul":
                    Console.WriteLine("sua cor favorita é azul");
                    break;
                case "amarelo":
                    Console.WriteLine("sua cor favorita é amarelo");
                    break;
                case "vermelho":
                    Console.WriteLine("sua cor favorita é vermelho");
                    break;
                case "rosa":
                    Console.WriteLine("sua cor favorita é rosa");
                    break;
                default:
                    Console.WriteLine("Não há sua cor favorita");
                    break;
            }

            


            ----------------------------Switch-------------------------------------*/




            // usar readline so para o console n fechar
            Console.ReadLine();

        }
            // void significa o tipo de retorno da função - com void n retorna nada
            // retorno é o q a função retorna no fim dela tipo console.readline que retorna o que o usuario escreveu
            static void ExibirMsg()
        {

            Console.WriteLine("esse sistema é show");
            Console.WriteLine("estou usando funções, isso é uma função");
            Console.WriteLine("Bem Vindo!");

        }

        // parametro é um tipo de variavel, a diferença é q parametro so pod ser usado na função onde ele é criado
        static void GerarPreco(int preco)
        {
            //Abs é o modulo que converte numeros negativos para positivos
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);
           

        }

        static int Somar(int a, int b, int c)
        {

            int resultadoFinal = a + b + c;
            return resultadoFinal;
            // tudo escrito abaixo de return vai ser ignorado
        }




    }
}
