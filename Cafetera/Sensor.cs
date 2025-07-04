namespace Cafetera
{
    public class Sensor
    {
        public bool detectaAgua()
        {
            Console.WriteLine("Sensor: Hay suficiente agua");
            if (DateTime.Now.Second % 2 == 0)
            {
                Console.WriteLine("Sensor: Agua insuficiente:");
                return false; // Simula que no hay suficiente agua
            }
            return true;
        }

        public bool detectarTaza()
        {
            Console.WriteLine("Sensor: Taza colocada");
            if (DateTime.Now.Second % 2 == 0)
            {
                Console.WriteLine("Sensor: Taza no detectada");
                return false; // Simula que no hay taza colocada
            }
            return true;

        }
    }
}
