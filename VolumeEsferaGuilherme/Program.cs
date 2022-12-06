namespace VolumeEsferaGuilherme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, volume;
            Console.WriteLine("PROGRAMA PARA CALCULAR O VOLUME DE UMA ESFERA\n");
            Console.Write("informe o raio (r) da esfera: ");
            raio = double.Parse(Console.ReadLine());
            if (raio < 0)
            {
                Console.WriteLine("\nNÃO EXISTE VOLUME NEGATIVO!");
            }
            else
            {
                volume = (4 / 3.0) * Math.PI * Math.Pow(raio, 3);

                Console.WriteLine("\nO VOLUME DA ESFERA É: " + volume.ToString("F3"));
            }
        }
    }
}
