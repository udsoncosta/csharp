namespace Metodos02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MetodoInternal();
            MetodoPublico();
            MetodoProtegido();
            MetodoPrivado();
        }

        public static void MetodoPublico()
        {
            Console.WriteLine("Método público - Classe program");
        }
        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe program");
        }
        protected static void MetodoProtegido()
        {
            Console.WriteLine("Método protegido - Classe program");
        }
        private static void MetodoPrivado()
        {
            Console.WriteLine("Método privado - Classe program");
        }
    }
}