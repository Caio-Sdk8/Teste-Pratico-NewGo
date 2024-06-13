int escolha;
bool menu;
menu = true;


do
{
    Console.WriteLine("Selecione uma opção /n 1 - Criar senha /n 2 - Alterar senha /n 3 - sair");
    escolha  = int.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1 :
            senha senhaUsuario = new senha();

            Console.WriteLine("Digite sua nova senha:");
            senhaUsuario.conteudo = Console.ReadLine();

            if(senhaUsuario.conteudo.Length <10 || senhaUsuario.conteudo.Length > 30){
                Console.WriteLine("Senha inválida, tamanho fora do especificado.");
            }
            if (senhaUsuario.conteudo.Any(char.IsUpper) && senhaUsuario.conteudo.Any(char.IsLower) && senhaUsuario.conteudo.Any(char.IsDigit)){
                foreach (char item in senhaUsuario.conteudo)
                {
                    if (!char.IsLetterOrDigit(item))
                    {
                        Console.WriteLine("Caracteres validados");
                        break;
                    }
                }

            }else{
                Console.WriteLine("Caracteres invalidos, tente novamente");
            }

            break;
        case 2 :
            break;
        case 3:
            menu = false;
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente");
            break;
    }

} while (menu);
