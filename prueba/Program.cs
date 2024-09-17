using System;

Console.Clear();

// Crear un array de nombres
string[] alumnos = { "Sophia", "Andrew", "Emma", "Logan" };

// Crear un array de arrays de enteros
//Inicializar directamente
int[][] notas = new int[4][];
notas[0] = new int[] { 90, 86, 87, 98, 100 };
notas[1] = new int[] { 92, 89, 81, 96, 90 };
notas[2] = new int[] { 90, 85, 87, 98, 68 };
notas[3] = new int[] { 90, 95, 87, 88, 96 };

var indiceDeAlumno = 0;
decimal sumaDeValores = 0;
// Mostrar los nombres y sus valores asociados
foreach (var alumno in alumnos)
{
    sumaDeValores = notas[indiceDeAlumno].Sum();

    var media = sumaDeValores / (notas.Length + 1);
    indiceDeAlumno++;
    sumaDeValores = 0;


    var notaEnLetra = "F";
    if (media <= 59) { notaEnLetra = "F"; }
    else if (media <= 62) { notaEnLetra = "D-"; }
    else if (media <= 66) { notaEnLetra = "D"; }
    else if (media <= 69) { notaEnLetra = "D+"; }
    else if (media <= 72) { notaEnLetra = "C-"; }
    else if (media <= 76) { notaEnLetra = "C"; }
    else if (media <= 79) { notaEnLetra = "C+"; }
    else if (media <= 82) { notaEnLetra = "B-"; }
    else if (media <= 86) { notaEnLetra = "B"; }
    else if (media <= 89) { notaEnLetra = "B+"; }
    else if (media <= 92) { notaEnLetra = "A-"; }
    else if (media <= 96) { notaEnLetra = "A"; }
    else if (media <= 100) { notaEnLetra = "A+"; }
    else { notaEnLetra = "Out Range"; }

    Console.WriteLine($"Nombre: {alumno} \t Valores: {media} \t {notaEnLetra}");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();