//Arrays -foreach
//Ejercicio 1 - inventario
Console.WriteLine("Ejercicio 1");

int[] inventory = [200, 450, 700, 175, 250];
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total : {sum})");
}

Console.WriteLine($"We have {sum} items in inventory");

//Ejercicio 2 - Buscar valores 
Console.WriteLine("\nEjercicio 2");

string[] valores = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (var item in valores)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine("Los valores son: " + item);
    }
}

//Ejercicio 3 - NOTAS
Console.WriteLine("\nEjercicio 3");

Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

//Ejercicio 4 -  invertir una cadena y contar el número de veces que aparece un carácter determinado.
Console.WriteLine("\nEjercicio 4");

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");