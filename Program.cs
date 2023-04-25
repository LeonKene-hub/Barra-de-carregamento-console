static void BarraCarregamento(string texto, int Ponto, int Tempo)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Write(texto);

        for (var i = 0; i < Ponto; i++)
        {
            Console.Write($".");
            Thread.Sleep(Tempo);
        }
        Console.ResetColor();
    }

    BarraCarregamento("Mudando Perspectiva", 8, 300);
    Console.WriteLine($"");