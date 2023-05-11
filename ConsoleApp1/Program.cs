using ConsoleApp1;

Impressora impressora = Impressora.Instancia();

void Menu()
{
    bool sair = false;

    while (!sair)
    {
        Console.WriteLine("MENU:");
        Console.WriteLine("1 - Adicionar Documento");
        Console.WriteLine("2 - Imprimir");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Documento doc = new Documento();

                Console.WriteLine("Digita o conteúdo do documento: ");
                doc.texto = Console.ReadLine();

                impressora.AdicionarImpressao(doc);
                break;

            case "2":
                impressora.Imprimir();
                break;

            case "3":
                Console.Clear();
                Console.WriteLine("Saindo...");
                sair = true;
                break;

            default:
                Console.WriteLine("Opção inválida! Digite novamente.");
                Console.ReadLine();
                break;
        }
    }
}

Menu();




