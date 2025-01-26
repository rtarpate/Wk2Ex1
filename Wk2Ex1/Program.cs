

using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

//collects user inputs
Console.WriteLine("Input score");

// converts unput into double
double score = Convert.ToDouble(Console.ReadLine());

//cauluates and outputs user score using an if else 
if(score >= 89.5)
{
    //caluates A grade
    Console.WriteLine("The letter Grade for " + score + " is Grade A.");
}
else if (score  >= 79.5)
{
    //caluates B grade
    Console.WriteLine("The letter Grade for " + score + " is Grade B.");
}
else if (score >= 69.5)
{
    //caluates C grade
    Console.WriteLine("The letter Grade for " + score + " is Grade C.");
}
else if (score >= 59.5)
{
    //caluates D grade
    Console.WriteLine("The letter Grade for " + score + " is Grade D.");
}
else
{
    //caluates F grade
    Console.WriteLine("The letter Grade for " + score + " is Grade F.");
}


