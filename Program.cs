namespace Torre_de_Hanoi;
class Program
{

    void Torre(int numero, char a, char b, char c){

        //
        if(numero == 1){
            //mover apenas do início para o fim
            Console.WriteLine($"Mova disco 1 da torre {a} para a torre {c}");
        }
        else{
            //chamando a função
            Torre(numero - 1, a, c, b);

            //movendo o disco
            Console.WriteLine($"Mova disco {numero} da torre {a} para a torre {c}");

            //chamando a função
            Torre(numero - 1, b, a, c);
        }

    }

    static void Main(string[] args)
    {
        Program p = new Program();

        //digitar o número de discos
        Console.Write("Digite o número de discos: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        //fazer uma exceção de número == 0
        if(numero == 0){

            Console.Write("Não aceitamos a não existência de discos");
            Console.Write("Digite um novo número de discos: ");
            //novo número de discos
            numero = Convert.ToInt32(Console.ReadLine());

        }

        //nomes das torres
        char a = 'A', b = 'B', c = 'C';

        //definindo as torres
        p.Torre(numero, a, b, c);
    }
}
