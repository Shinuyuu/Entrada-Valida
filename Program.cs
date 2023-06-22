void Shin(string frase, int fun)
{
    if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }
    else if (fun == 03)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    else if (fun == 04)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
    }
     else if (fun == 05)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
     else if (fun == 06)
    {
        Console.ForegroundColor = ConsoleColor.Black;
    }
for (int i = 00; i < frase.Length; i++)
{
Console.Write(frase[i]);
Thread.Sleep(45);
}
}
Shin("--- Entrada Válida ---\n",01);

int numeroDigitado = -1;

if (numeroDigitado < 0 || numeroDigitado > 9)
{
    Shin("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ",05);
    numeroDigitado = Convert.ToInt32(Console.ReadLine());
}

if (numeroDigitado == 0)
{
   Shin("\nOperação cancelada.",03);
}
else
{
    Shin($"\nNúmero selecionado = {numeroDigitado}",01);
}

Shin("\n\nVolte sempre!",02);
