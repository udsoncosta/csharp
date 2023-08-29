namespace atividade03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float salarioBruto, adicionalNoturno, horasExtras, descontos, salarioLiquido;

            Console.WriteLine("Digite o salário bruto: ");
            salarioBruto = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do adicional noturno: ");
            adicionalNoturno = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor das horas extras: ");
            horasExtras = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite quais os descontos");
            descontos = float.Parse(Console.ReadLine());

            salarioLiquido = salarioBruto + adicionalNoturno + (horasExtras * 5) - descontos;

            Console.WriteLine("O salário líquido é:" + salarioLiquido);
        }
    }
}