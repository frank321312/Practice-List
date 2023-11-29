namespace BibliotecaClases;

public class Persona
{
    public string Nombre { get; set; }
    public int Dni { get; set; }
    public Persona(string nonbre, int dni)
    {
        Nombre = nonbre;
        Dni = dni;
    }
}

public class Veterinario
{
    public string Nombre { get; set; }
    public int Matricula { get; set; }
    public Veterinario(string nombre, int matricula)
    {
        Nombre = nombre;
        Matricula = matricula;
    }
}

public class Mascota
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public Persona Dueño { get; set; }
    public Mascota(string nombre, int edad, Persona dueño)
    {
        Nombre = nombre;
        Edad = edad;
        Dueño = dueño;
    }
}

public class Turno
{
    public DateTime FechaTurno { get; set; }
    public Persona Dueño { get; set; }
    public Mascota Paciente { get; set; }
    public Turno(Persona dueño, Mascota paciente)
    {
        FechaTurno = DateTime.Now;
        Dueño = dueño;
        Paciente = paciente;
    }
}

public class Clinica
{
    public List<Turno> Turnos { get; set; } = new List<Turno>();
    public List<Veterinario> Veterinarios { get; set; } = new List<Veterinario>();
}