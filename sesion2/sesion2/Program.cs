using sesion2.clases.Clase;

namespace sesion2
{
    //Leer los datos de una persona y decir si es mayor o menor de edad.
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            DateTime fechanac;
            Persona persona = new Persona();

            Console.Write("Dime tu nombre: ");
            nombre=Console.ReadLine();
            Console.Write("En que fecha naciste: ");
            fechanac=DateTime.Parse(Console.ReadLine());

            persona.Nombre = nombre;
            persona.FechaNac = fechanac;
            Console.Write(persona.EvaluarEdad());


        }
    }
}
