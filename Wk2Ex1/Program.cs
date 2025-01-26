

using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Input score");


double score = Convert.ToDouble(Console.ReadLine());

if(score >= 89.5)
{
    Console.WriteLine("The letter Grade for " + score + " is Grade A.");
}
else if (score  >= 79.5)
{
    Console.WriteLine("The letter Grade for " + score + " is Grade B.");
}
else if (score >= 69.5)
{
    Console.WriteLine("The letter Grade for " + score + " is Grade C.");
}
else if (score >= 59.5)
{
    Console.WriteLine("The letter Grade for " + score + " is Grade D.");
}
else
{
    Console.WriteLine("The letter Grade for " + score + " is Grade F.");
}


