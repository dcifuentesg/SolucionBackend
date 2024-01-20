//Punto 3
static void SaveWords()
{
    Console.Write("Ingrese el nombre del archivo de texto: ");
    string nombreArchivo = Console.ReadLine();

    Console.Write("Ingrese el texto a guardar en el archivo: ");
    string texto = Console.ReadLine();

    string[] palabras = texto.Split(' ');


    using (StreamWriter writer = new StreamWriter(nombreArchivo))
    {
        foreach (string palabra in palabras)
        {
            writer.WriteLine(palabra);
        }
    }


    Console.WriteLine("Archivo resultado:");


    foreach (string palabra in palabras)
    {
        Console.WriteLine(palabra);
    }
}

SaveWords();