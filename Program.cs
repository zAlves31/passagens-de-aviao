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

Console.WriteLine(@$"
 ------------------------
| 1 - Cadastrar passagem |
| 2 - Listar Passagens   |
| 0 - Sair               |
 ------------------------                
");