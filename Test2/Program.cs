// See https://aka.ms/new-console-template for more information



string frase = "O dia está lindo!!!!!";
//retorna parte da frase

Console.WriteLine (frase.Substring(0,5));
//subtitui uma palavra

frase.Replace("lindo", "chuvoso");
Console.WriteLine (frase.Replace("lindo", "chuvoso"));

//remove espaços vazios no ínicio e final da String

//remove espaços vazios final da String
frase.TrimEnd();

//remove espaços vazios no ínicio String
frase.TrimStart();

//tira caracter especificos
frase.Trim();
frase.Trim('!');
Console.WriteLine(frase.Trim('!'));


const string APROVADO = "Aprovado!";
const string REPROVADO = "Reprovado!";
const string EM_RECUPERACAO = "Em Recuperação!";

Console.WriteLine("Digite a nota  ");
decimal nota = Convert.ToDecimal(Console.ReadLine());

if (nota >= 5)
{
    Console.WriteLine(APROVADO);
}
else if(nota >= 4 && nota < 5)
{
    Console.WriteLine(EM_RECUPERACAO);
}
else
{
    Console.WriteLine(REPROVADO);
}
