﻿string tamanho, valet, lavagem;
int tempo, horas, horasExtras;
double valorEstacionamento, precoValet, valorLavagem, total;

Console.Clear();
Console.WriteLine("--- Estacionamento ---");

Console.Write("Tamanho do veículo (P/G).....: ");
tamanho = Console.ReadLine().ToUpper();

if (tamanho != "P" && tamanho != "G")
{
    Console.WriteLine("Tamanho inválido.");
    return;
}

 Console.Write("Tempo de permanência (min)...: ");
 tempo = Convert.ToInt32(Console.ReadLine());
 
 if (tempo <= 0 && tempo > 720)
{
 Console.WriteLine("Tempo inválido. Deve ser entre 1 e 720 minutos.");
 return;
}

Console.Write("Serviço de valet (S/N).......: ");
         valet = Console.ReadLine().ToUpper();

Console.Write("Serviço de lavagem (S/N).....: ");
        lavagem = Console.ReadLine().ToUpper();

valorEstacionamento = 0;
precoValet = 0;
valorLavagem = 0;

if (tempo <= 65 )
{
    valorEstacionamento = 20;
}
else 
{
    horas = (int)Math.Ceiling((tempo - 5) / 60.0);
if (horas >= 5)
            {
                if (tamanho == "G")
                {
                  valorEstacionamento = 80;
                }
                else
                {
                  valorEstacionamento = 50;
                }
            }
            else
            {
                valorEstacionamento = 20; 
                horasExtras = horas - 1;
                if (tamanho == "G")
                {
                  valorEstacionamento += horasExtras * 20;
                }
                else
                {
                  valorEstacionamento += horasExtras * 10;
                }
            }
        }

 if (valet == "S")
        {
            precoValet = valorEstacionamento * 0.20;
        }

        if (lavagem == "S")
        {
           if (tamanho == "G")
            {
              valorLavagem = 100;
            }
           else
           {
             valorLavagem = 50;
           }
        }

         total = valorEstacionamento + precoValet + valorLavagem;

        Console.WriteLine();
        Console.WriteLine($"Estacionamento..: {valorEstacionamento,10:C2}");
        Console.WriteLine($"Valet...........: {precoValet,10:C2}");
        Console.WriteLine($"Lavagem.........: {valorLavagem,10:C2}");
        Console.WriteLine($"--------------------------------"); 
        Console.WriteLine($"Total...........: {total,10:C2}");