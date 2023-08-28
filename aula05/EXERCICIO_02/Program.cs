using System;

class Program
{
    static void Main(string[] args)
    {

        int aluno = 10, bimestres = 4;
        float[,] notas = new float[aluno, bimestres];


        for (int i = 0; i < aluno; i++)
        {
            Console.WriteLine($"Digite as notas do aluno {i + 1}:");
            for (int j = 0; j < bimestres; j++)
        {
                Console.Write($"Nota do bimestre {j + 1}: ");
                notas[i, j] = float.Parse(Console.ReadLine());
        }
        }

        float[] medias = new float[aluno];


        for (int i = 0; i < aluno; i++)
        {
            float soma = 0;
            for (int j = 0; j < bimestres; j++)
        {
                soma += notas[i, j];
        }
            medias[i] = soma / bimestres;
        }

                Console.WriteLine("Médias dos alunos:");
        for (int i = 0; i < aluno; i++)
        {
               
            Console.WriteLine($"Aluno: {i + 1}: {medias[i]:f}" );
         }
    }
}




