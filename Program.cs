string senha;
bool autenticado = false;

do
{
    Console.WriteLine("Por favor, insira a senha de acesso: ");
    senha = Console.ReadLine();

    if (senha == "310704")
    {
        autenticado = true;
    }
    else
    {
        Console.WriteLine("Senha incorreta. Tente novamente.");
    }
} while (!autenticado);


string resposta;
int opcao;
string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

do
{
    Console.WriteLine(@$"
     ------------------------
    | 1 - Cadastrar passagem |
    | 2 - Listar Passagens   |
    | 0 - Sair               |
     ------------------------                
");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {

        case 1:
            Console.WriteLine($"Cadastro de passagens");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Passageiro " + (i + 1) + ":");
                Console.Write("Nome: ");
                nome [i] = Console.ReadLine();
                Console.Write("Origem: ");
                origem [i] = Console.ReadLine();
                Console.Write("Destino: ");
                destino [i] = Console.ReadLine();
                Console.Write("Data do Voo: ");
                data [i] = Console.ReadLine();

                Console.WriteLine($"Passagem cadastrada com sucesso!");

                Console.Write("Deseja cadastrar uma nova passagem? (S/N): ");
                resposta = Console.ReadLine();

                if (resposta.ToUpper() != "S")
                {
                    break;
                }

            }
            break;

        case 2:
            Console.WriteLine($"Listagem de Passagens:");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                if (!string.IsNullOrEmpty(nome[i]))
                {
                    Console.WriteLine($"Nome do passageiro: {nome[i]}");
                    Console.WriteLine($"origem: {origem[i]}");
                    Console.WriteLine($"destino: {destino[i]}");
                    Console.WriteLine($"data do voo: {data[i]}");
                    Console.WriteLine();
                }
            }

            break;

        case 0:
            Console.WriteLine($"Saindo do sistema...");
            break;
        default:
            Console.WriteLine($"Opção inválida. Tente novamente.");
            break;
    }

} while (opcao != 0);
