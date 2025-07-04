namespace Cafetera
{
    public class Deposito 
    {
        public int nivelAgua;

        public Deposito(int nivelAgua_Inicial)
        {
            nivelAgua = nivelAgua_Inicial;
        }

        public void consumirAgua(int cantidad)
        {
            nivelAgua -= cantidad;
            Console.WriteLine($"Se consumieron {cantidad} ml de agua");
            if (nivelAgua < 0)
            {
                nivelAgua = 0;
                Console.WriteLine("El depósito de agua está vacío.");
            }
            else
            {
                Console.WriteLine($"Nivel de agua restante: {nivelAgua} ml");
            }
        }
    }
}
