void matriz()
{
    string[] nombre = new string[] {
        "Anderson", "Brandon", "Yeimi", "Fatima", "Vivian"
    };

    foreach (string s in nombre)
    {
        Console.WriteLine("nombre= " + s);
    }

    int[] notas = new int[] {
        51, 80, 96, 76, 61
    };

    int promedio = 0;
    foreach (int n in notas)
    {
        promedio = promedio + n;
    }
    promedio = promedio / notas.Length;
    Console.WriteLine("promedio= " + promedio);

    int notaMaxima = notas[0];
    string nombreNotaMaxima = nombre[0];
    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] > notaMaxima)
        {
            notaMaxima = notas[i];
            nombreNotaMaxima = nombre[i];
        }
    }

    Console.WriteLine("La nota más alta es de " + nombreNotaMaxima + " con " + notaMaxima + " puntos");
}
matriz(); 
