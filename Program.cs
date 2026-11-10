string parola = "";
string comparazione = "";
Console.WriteLine("Inserisci una parola");
parola = Console.ReadLine();
Console.WriteLine("Inserisci la parola che vuoi confrontare");
comparazione = Console.ReadLine();
if(parola == comparazione)
{
    Console.WriteLine("Vero");
}
else
{
    Console.WriteLine("Falso");
}