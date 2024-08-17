    
    bool sair = false;
do
{
    Console.WriteLine("#####################################################");
    Console.WriteLine("#### Este é nosso programa de 'fazer' árvores #####");
    Console.WriteLine("#####################################################");
    Console.WriteLine("Você pode escolher um caractere para construir a árvore ou não: ");

    string caracter = Console.ReadLine();

    Console.WriteLine("Digite a altura da árvore: ");
    int altura = int.Parse(Console.ReadLine());

    for (int i = 1; i <= altura; i++)
    {
        Console.Write(new string(' ', altura - i));

        if (!string.IsNullOrEmpty(caracter))
        {
            Console.WriteLine(new string(caracter[0], i * 2 - 1));
        }
        else
        {
            Console.WriteLine(new string('*', i * 2 - 1));
        }
    }

    Console.Write(new string(' ', altura - 1));
    Console.WriteLine('*');

    Console.WriteLine("Para sair do programa digite 1 ou 0 para fazer outra árvore");
    string escolha = Console.ReadLine();
    
    if (escolha == "1")
        sair = true;
    else
        sair = false;

} while (!sair);