int valor = int.Parse(Console.ReadLine());
// Comprovar que el valor és positiu
List<int> multiples = Metodes.ComptadorMultiples(valor);

Console.WriteLine("Multiples de 7 menors que " + valor + ":");
foreach (int m in multiples)
{
    Console.WriteLine(m);
}
bool boleana = true;
internal static class Metodes
{
    public static List<int> ComptadorMultiples(int v)
    {
        List<int> multiples = new List<int>();
        for (int i = 1; i < v; i++)
        {
            if (i % 7 == 0)
            {
                multiples.Add(i);
            }
        }
        return multiples;
    }
}
