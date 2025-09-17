// See https://aka.ms/new-console-template for more information
using AbstracionCircoFinancieroAnimal;

//asignamos valores a la lista de artistas
List<artistaAnimal> artistas = new List<artistaAnimal> {
    new Elefante { nombre = "Dumbo", tipoAlimentacion = "Herviboro", trucoEspecial = true},
    new Cocodrilo { nombre = "Krocodali", tipoAlimentacion = "Carnivoro", trucoEspecial = true},
    new Tigre { nombre = "Trigeson", tipoAlimentacion = "Carnivoro", trucoEspecial = true},
    new Leon { nombre = "Alecai", tipoAlimentacion = "Carnivoro", trucoEspecial = true},
    new Mono { nombre = "Jaime", tipoAlimentacion = "Omnivoro", trucoEspecial = true}
};

int carnivoros = 0, herviboros = 0, omnivoros = 0;
int conTruco = 0;

// recorremos la lista de artistas y mostramos su espectaculo y sueldo

foreach (var artista in artistas)
{
    // cada artista saluda, presenta su espectaculo y recibe su sueldo
    artista.saludarPublico();
    artista.presentarEspectaculo();
    artista.recibirSueldo();
    Console.WriteLine("........................................................");

    switch (artista.tipoAlimentacion)
    {
        // según su alimentacion contamos
        case "Carnivoro":carnivoros++;break;
        case "Herviboro": herviboros++; break;
        case "Omnivoro": omnivoros++; break;
    }

    // contamos los artistas/animales con truco especial
    // si es asi el contador suma 1
    if (artista.trucoEspecial)
        conTruco++;
}

//imprimir
Console.WriteLine("\nEstadisticas del circo");
Console.WriteLine($"Carnivoros: {carnivoros}");
Console.WriteLine($"Herviboros: {herviboros}");
Console.WriteLine($"Omnivoros: {omnivoros}");
Console.WriteLine($"Animales con truco: {conTruco}");

Console.WriteLine("\nEl espectaculo finalizo");