//By YO
List<string> nombres = new List<string> { "Mª ÁNGELES PEÑA", "LILIANA","NATHALI VILLAPARDO", "YAZMIN MEJIA",
    "MARIEL LOAYZA", "ROMY ANTEZANA", "CLAUDIA", "EDIMAR", "SARAY", "ERIKA", "SANDRA", "ALISON",  "ANDREW",
    "BRIAN",  "CESAR", "DENNIS",  "DIEGO","LUIS", "MARCELO", "PAUL", "RICHARD", "ABRAHAM", "CRISTIAM", "EDSON",  "RICARDO",
    "ALEX",  "ALICIA",  "ANITA VILLCAZANA",  "LILI", "PATRICIA" ,"WALDY"};

// Festivos nacionales de España (2024 y 2025)
HashSet<DateTime> festivos = new HashSet<DateTime>
        {
            // Festivos 2024
            new DateTime(2024, 1, 1),
            new DateTime(2024, 1, 6),
            new DateTime(2024, 3, 29),
            new DateTime(2024, 5, 1),
            new DateTime(2024, 8, 15),
            new DateTime(2024, 10, 12),
            new DateTime(2024, 11, 1),
            new DateTime(2024, 12, 6),
            new DateTime(2024, 12, 8),
            new DateTime(2024, 12, 25),
            
            // Festivos 2025
            new DateTime(2025, 1, 1),
            new DateTime(2025, 1, 6),
            new DateTime(2025, 4, 18),
            new DateTime(2025, 5, 1),
            new DateTime(2025, 8, 15),
            new DateTime(2025, 10, 12),
            new DateTime(2025, 11, 1),
            new DateTime(2025, 12, 6),
            new DateTime(2025, 12, 8),
            new DateTime(2025, 12, 25),
        };

// Mezclar la lista de nombres aleatoriamente
Random rand = new Random();
nombres = nombres.OrderBy(x => rand.Next()).ToList();

// Obtener el primer viernes a partir de hoy
DateTime fecha = DateTime.Today;
while (fecha.DayOfWeek != DayOfWeek.Friday)
{
    fecha = fecha.AddDays(1);
}

// Asignar fechas excluyendo festivos

Dictionary<string, DateTime> resultado = new Dictionary<string, DateTime>();
foreach (string nombre in nombres)
{
    while (festivos.Contains(fecha))
    {
        fecha = fecha.AddDays(7); // Saltar al siguiente viernes
    }

    resultado[nombre] = fecha;
    fecha = fecha.AddDays(7); // Ir al siguiente viernes
}

// Mostrar resultados
Console.WriteLine("Asignación de fechas:");
foreach (var item in resultado)
{
    Console.WriteLine($"{item.Key}: {item.Value:yyyy-MM-dd}");
}
Console.WriteLine("Presiona cualquier tecla para cerrar la aplicación...");
Console.ReadKey();
