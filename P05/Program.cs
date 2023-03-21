/*
var peixes = new List <string> {"Bagre Ensaboado2","Tilápia2","Camarão2","Sardinha2"};

peixes.Remove("Tilápia2");
foreach (var peixe in peixes)
{
    Console.Write(peixe +" "); 
}

var numeros = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

for ( var index = numeros.Count - 1; index >=0; index--)
{
    if(numeros[index]% 2 == 1)
    {
        numeros.RemoveAt(index);
    }
}

numeros.ForEach(
    numero=>Console.Write(numero +" "));



var nomes = new List<string> {"Renato", "Erikc", "Grazzielle", "Mota", "Maria Clara"};
foreach (var nome in nomes) 
{
    Console.WriteLine ($"Olá {nome.ToUpper()}");
}
Console.WriteLine();
Console.WriteLine ($"Meu nome é {nomes[0]}");
Console.WriteLine ($"Adicionei {nomes[3]} e {nomes[4]} na lista");
Console.WriteLine ($"A lista tem {nomes.Count} pessoas");

var index = nomes.IndexOf("Erick");
if (index == -1) {
    Console.WriteLine ($"Item não encontrado {index}");
}
else{
Console.WriteLine($"O nome {nomes[index]} está no índice {index}");
}

nomes.Sort();
foreach (var nome in nomes) {
    Console.WriteLine($"Olá {nome.ToUpper()}");
}


var fibonacciNumeros = new List<int> {1, 1};

var previo = fibonacciNumeros[fibonacciNumeros.Count -1];
var previo2 = fibonacciNumeros[fibonacciNumeros.Count -2];

fibonacciNumeros.Add(previo+previo2);
foreach (var item in fibonacciNumeros)
{
    Console.WriteLine(item);
}

*/

var fibonacciNumeros = new List<int> {1, 1};

for (int i=0; i<=19; i++) {

var previo = fibonacciNumeros[fibonacciNumeros.Count -1];
var previo2 = fibonacciNumeros[fibonacciNumeros.Count -2];
fibonacciNumeros.Add(previo + previo2);

Console.WriteLine($" Item "+(i+1) + ": " + fibonacciNumeros[i]);

}