namespace Cafetera
{
    public partial class Cafetera
    {
        public class Calentador()
        {
            public void encender()
            {
                Console.WriteLine("Encendiendo cafetera");
                Console.WriteLine("Cafetera encendida");    
            }

            public void apagar()
            {
                Console.WriteLine("Apagando cafetera \n ¡CUIDADO SIGUE CALIENTE!");
                Console.WriteLine("Cafetera apagada");
            }
        }
    }
}
