using System.Collections;

class Kalkulator
{
    static void Main(string[] args)
    {
       
        int liczba1p, liczba2p;
        char operatora;
        int operatorb;
        
            Console.WriteLine("podaj pierwsza liczbe");
            bool liczba1 = int.TryParse(Console.ReadLine(), out liczba1p);
            Console.WriteLine("podaj operator(+,-,*,/)");
            bool op = char.TryParse(Console.ReadLine(), out operatora);

            Console.WriteLine("podaj druga liczbe");
            bool liczba2 = int.TryParse(Console.ReadLine(), out liczba2p);
        switch (operatora)
        {
            case '+':
            {
                    Console.WriteLine(liczba1p + liczba2p);
                    break;
            }
            case '-':
                {
                    Console.WriteLine(liczba1p - liczba2p);
                    break;
                }
            case '*':
                {
                    Console.WriteLine(liczba1p * liczba2p);
                    break;
                }
            case '/':
                {
                    Console.WriteLine(liczba1p / liczba2p);
                    break;
                }
            default:
                {
                    break;
                }
        }
       
        
    }
    
}