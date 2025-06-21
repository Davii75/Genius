menuDificuldade:

Console.Clear();

List<Dificuldade> difficulty = new List<Dificuldade>
{
    new Dificuldade() {Dif = "1", Rodadas = 8, Escolhido = false},
    new Dificuldade() {Dif = "2", Rodadas = 14, Escolhido = false},
    new Dificuldade() {Dif = "3", Rodadas = 20, Escolhido = false},
    new Dificuldade() {Dif = "4", Rodadas = 31, Escolhido = false}
};

List<int> sequencia = new List<int>();
Random randomizar = new Random();

int novoNumero;
int RodadasMax = 0;
int RodadaAtual = 1;
bool acertou = true;
string difEscolhida;
string entrada;

Console.WriteLine("--- Genius ---");

foreach (Dificuldade d in difficulty)
{
    Console.WriteLine($"Dificuldade {d.Dif}: {d.Rodadas} rodadas");
}

Console.Write("\nEscolha a dificuldade que você quer jogar (de 1 à 4): ");
difEscolhida = Console.ReadLine()!;

foreach (Dificuldade d in difficulty)
{
    if (d.Dif == difEscolhida)
    {
        d.Escolhido = true;
        RodadasMax = d.Rodadas;
    }
}

if (RodadasMax == 0)
{
    Vermelho();
    Console.WriteLine("Dificuldade inválida");
    ResetaCor();
    return;
}

Console.Clear();
Console.WriteLine($"Dificuldade {difEscolhida} escolhida\n");
Thread.Sleep(1500);
Console.Clear();

menuRegras:
Console.WriteLine("--- Regras ---\n");
Console.WriteLine("Uma sequência de cores irá aparecer, acerte a ordem e passe para a próxima rodada");
Console.WriteLine("Digite os números abaixo de acordo com a ordem mostrada sem espaço entre cada número\n");


Vermelho(); Console.Write("1 "); ResetaCor(); Console.Write("para "); Vermelho(); Console.WriteLine("Vermelho"); ResetaCor(); Console.Beep(400, 400); Thread.Sleep(2000);
Verde(); Console.Write("2 "); ResetaCor(); Console.Write("para "); Verde(); Console.WriteLine("Verde"); ResetaCor(); Console.Beep(600, 400); Thread.Sleep(2000);
Azul(); Console.Write("3 "); ResetaCor(); Console.Write("para "); Azul(); Console.WriteLine("Azul"); ResetaCor(); Console.Beep(800, 400); Thread.Sleep(2000);
Amarelo(); Console.Write("4 "); ResetaCor(); Console.Write("para "); Amarelo(); Console.WriteLine("Amarelo\n"); ResetaCor(); Console.Beep(1000, 400); Thread.Sleep(2000);

Console.WriteLine("Exemplo: Vermelho Amarelo Verde =>  142\n");
Console.WriteLine("Pressione 'R' para repetir o áudio");
Console.WriteLine("Pressione 'Enter' para começar");

ConsoleKey continuar = Console.ReadKey(true).Key;
while (continuar != ConsoleKey.Enter)
{
    if (continuar == ConsoleKey.R)
    {
        Console.Clear();
        goto menuRegras;
    }
    else
    { 
        continuar = Console.ReadKey(true).Key;
    }
} 

while (RodadaAtual <= RodadasMax)
{
    novoNumero = randomizar.Next(1, 5);
    sequencia.Add(novoNumero);

    Console.Clear();
    Console.WriteLine($"Rodada {RodadaAtual}\n");
    Thread.Sleep(1000);

    foreach (int cor in sequencia)
    {
        MostrarCorESom(cor);
    }

    Console.Clear();
    Console.WriteLine("Digite a sequência (sem espaços):");
    entrada = Console.ReadLine()!;

    if (entrada.Length != sequencia.Count)
    {
        Console.WriteLine("Sequência incorreta! Fim de jogo.");
        SomDerrota();
        Console.WriteLine("A sequência correta era: " + string.Join("", sequencia));
        return;
    }

    acertou = true;
    for (int i = 0; i < sequencia.Count; i++)
    {
        int valorDigitado = entrada[i] - '0';
        MostrarCorESom(valorDigitado);
        if (valorDigitado != sequencia[i])
        {
            acertou = false;
            break;
        }
    }

    if (!acertou)
    {
        Console.WriteLine("Sequência incorreta! Fim de jogo.");
        SomDerrota();
        Console.WriteLine("A sequência correta era: " + string.Join("", sequencia));
        return;
    }

    Console.WriteLine("Correto! Prepare-se para a próxima rodada...");
    Thread.Sleep(1500);
    RodadaAtual++;
}

Console.WriteLine("Parabéns, você venceu!\n");
if (difEscolhida == "4")
{
    SomVitoriaEspecial();
}
else
{
    SomVitoria();
}
Console.WriteLine("Pressione 'D' para voltar para a página de Dificuldade");
Console.WriteLine("Pressione 'Enter' para finalizar o jogo");
continuar = Console.ReadKey().Key;
while (continuar != ConsoleKey.Enter)
{
    if (continuar == ConsoleKey.D)
    {
        Console.Clear();
        goto menuDificuldade;
    }
    else
    {
        continuar = Console.ReadKey(true).Key;
    }
}

void MostrarCorESom(int cor)
{
    switch (cor)
    {
        case 1:
            Vermelho(); Console.WriteLine("Vermelho"); Console.Beep(400, 400); break;
        case 2:
            Verde(); Console.WriteLine("Verde"); Console.Beep(600, 400); break;
        case 3:
            Azul(); Console.WriteLine("Azul"); Console.Beep(800, 400); break;
        case 4:
            Amarelo(); Console.WriteLine("Amarelo"); Console.Beep(1000, 400); break;
    }
    ResetaCor();
    Thread.Sleep(400);
}

void Vermelho() => Console.ForegroundColor = ConsoleColor.Red;
void Verde() => Console.ForegroundColor = ConsoleColor.Green;
void Azul() => Console.ForegroundColor = ConsoleColor.DarkCyan;
void Amarelo() => Console.ForegroundColor = ConsoleColor.Yellow;
void ResetaCor() => Console.ResetColor();

void SomVitoria()
{
    Console.Beep(523, 150);  
    Console.Beep(659, 150);  
    Console.Beep(784, 150);  
    Console.Beep(1047, 300); 
    Console.Beep(880, 150);  
}

void SomDerrota()
{
    Console.Beep(784, 300);
    Console.Beep(698, 300);
    Console.Beep(659, 300);
    Console.Beep(587, 300);
    Console.Beep(523, 600);
}

void SomVitoriaEspecial()
{
    Console.Beep(880, 150);  
    Console.Beep(988, 150);  
    Console.Beep(1175, 300); 
    Console.Beep(1047, 200); 
    Console.Beep(784, 400);  
}
class Dificuldade
{
    public required string Dif;
    public int Rodadas;
    public bool Escolhido;
}

