using System;
using System.IO;

namespace av_cs;

class App
{
    static void Main(string[] args)
    {
        Console.WriteLine("><><><><><><><><><><><><><><><><><><><><><");
        Console.WriteLine("Atividade avaliativa em C#");
        Console.WriteLine("><><><><><><><><><><><><><><><><><><><><><");

        //ler arquivo
        string[] lines = File.ReadAllLines("C:/Users/joao_/Documents/csproj/av_cs/src/listaNumeros.txt");
        int [] values = Array.ConvertAll(lines, int.Parse);

        Console.WriteLine("Valores lidos da lista: ");
        Console.WriteLine(string.Join(", ", values)); //alocando valores no array

        //realizar ordenação de valores por bubble sort
        Console.WriteLine("Ordenando valores com Bubble Sort: "); //valores no output.txt
        BubbleSort(values);
        Console.WriteLine("Valores ordenados: ");
        Console.WriteLine(string.Join(", ", values));//imprime ordenação

        //add os valores na collection
        System.Collections.ArrayList sortedValues = new System.Collections.ArrayList(values);
        Console.WriteLine("Varrendo collection com os mesmos valores que o array");
        Console.WriteLine("Valores na collection: "+ string.Join(", ", sortedValues.ToArray()));
        Console.WriteLine("Arrays idênticos: " + sortedValues.ToArray().Equals(values)); //verificando se tem os mesmos valores

        using(StreamWriter sw = new StreamWriter("output.txt"))
        { 
            foreach (int value in values) //exportando para o arquivo
            {
                sw.WriteLine(value);
            }
        } //output.txt

        //metodo de sort
        static void BubbleSort(int[] values){
            int n = values.Length;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (values[j] > values[j+1])
                    {
                        int temp = values[j];
                        values[j] = values[j+1];
                        values[j+1] = temp;
                    }
                }
            }
        }



    }
   
}
