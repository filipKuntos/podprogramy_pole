/*
Kuntoš P2B
1.Počet prvků
2.Maximum (ne přes vestavěné funkce)
3.Minimum
4.Součet všech hodnot
5.Součin všech hodnot
6.Aritmetický průměr
7.Geometrický průměr - pozor na to, že je definován pouze pro kladná čísla
8.Medián (k seřazení hodnot použijte funkci Array.Sort())
9.Četnost výskytu všech hodnot (vrátí pole, ve kterém bude počet výskytů dané hodnoty - tedy pro {1,2,1,3,5,1} vrátí {0,3,1,1,0,1} ), zde je otázka, jak se postarat o záporná čísla
10.Pole odchylek všech prvků od dané hodnoty - tedy pro pole {4,3,2} a hodnotu 3 vrátí {1,0,-1}
11.Rozptyl
12.Směrodatnou odchylku
*/
int jedna(int[] arr)
{
    int pocet = 0;
    foreach (int i in arr)
    {
        pocet++;
    }
    return pocet;
}

int[] pole = new int[2] { 2, 8 };
double[] pole_double = new double[pole.Length];
int index = 0;
foreach (int i in pole)
{
    pole_double[index] = i;
    index++;
}
Console.WriteLine("počet prvků");
Console.WriteLine(jedna(pole));

int dva(int[] arr)
{
    int max = 0;
    foreach (int i in arr)
    {
        if (i > max)
        {
            max = i;
        }
    }
    return max;
}
Console.WriteLine("maximum");
Console.WriteLine(dva(pole));

int tri(int[] arr)
{
    int min = arr.Length > 0?Int32.MaxValue : 0;
    foreach (int i in arr)
    {
        if (i < min)
        {
            min = i;
        }
    }
    return min;
}

Console.WriteLine("minimum");
Console.WriteLine(tri(pole));


int ctyri(int[] arr)
{
    int soucet = 0;
    foreach (int i in arr)
    {
        soucet += i;
    }
    return soucet;
}

Console.WriteLine("součet všech hodnot");
Console.WriteLine(ctyri(pole));


int pet(int[] arr)
{
    int soucin = arr.Length > 0 ? 1 : 0;
    foreach (int i in arr)
    {
        soucin *= i;
    }
    return soucin;
}

Console.WriteLine("součin všech hodnot");
Console.WriteLine(pet(pole));


int sest(int[] arr)
{
    int art = 0;
    int index = arr.Length > 0 ? arr.Length : 1;
    foreach (int i in arr)
    {
        art += i;
    }
    art = art / index;
    return art;
}

Console.WriteLine("Aritmetický průměr");
Console.WriteLine(sest(pole));


double sedm(int[] arr)
{
    double geo = arr.Length > 0 ? 1 : 0;
    foreach (int i in arr)
    {

        geo *= Math.Abs(i);
    }
    geo =Math.Pow(geo, 1d / arr.Length);
    return geo;
}


Console.WriteLine("Geometrický průměr");
Console.WriteLine(sedm(pole));


double osm(double[] arr)
{
    Array.Sort(arr);
    double median = 0;
    int index = arr.Length % 2 == 0 ? arr.Length / 2 - 1 : arr.Length / 2;
    if (arr.Length > 0) { 

        if (arr.Length % 2 == 0)
        {
            median = (arr[index] + arr[index + 1]) / 2;
        }
        else
        {

            median = arr[index];
        }
    }

    return median;
}

Console.WriteLine("Medián");
Console.WriteLine(osm(pole_double));

string devet(int[] arr)
{
    int index = arr.Length;

    string vyskyt = "";
    if (arr.Length > 0)
    {

    
        for (int i = 0; i < index; i++)
        {
            int pocet = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    pocet += 1;
                }
            }
            vyskyt += pocet + " ";
        }
        return vyskyt;
    }
    return "1";
    
}



Console.WriteLine("Četnost výskytu všech hodnot");
Console.WriteLine(devet(pole));


string deset(int[] arr)
{
    int prumer = sest(arr);
    string odchylka = "";
    if (arr.Length > 0) 
    { 
        for (int i = 0; i < arr.Length; i++)
        {
            odchylka += i - prumer + " ";
        }
        return odchylka;
    }
    return "0";
    
    
}

Console.WriteLine("Pole odchylek všech prvků od dané hodnoty");
Console.WriteLine(deset(pole));


int jedenact(int[] arr)
{
    int rozptyl = 0;
    int index = arr.Length > 0 ? arr.Length : 1;
    int odchylka = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int prumer = sest(arr);
        odchylka += prumer * prumer;
    }
    rozptyl = odchylka / index;
    return rozptyl;
}

Console.WriteLine("rozptyl");
Console.WriteLine(jedenact(pole));


double dvanact(int[] arr)
{
    int rozptyl = jedenact(arr);
    double odchylka = Math.Sqrt(rozptyl);
    return odchylka;
}

Console.WriteLine("Směrodatnou odchylku");
Console.WriteLine(dvanact(pole));


