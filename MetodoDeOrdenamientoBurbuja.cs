using System;

namespace metododeordenamientoburbuja
{
	class Program
	{
		static void Main(string[] args)
		{


            int[] Numeros = new int[100];int num;string numCap = "";
            for (int i=0;i<Numeros.Length;i++)
            {
                numCap = Console.ReadLine();
                
                if (numCap=="")
                {
                    OrdenamientoBurbuja(Numeros);
                }
                num = int.Parse(numCap);
                if (numCap != "")
                {
                    Numeros[i] = num;
                }

            }
            
            
			
		}
        static void OrdenamientoBurbuja(int[] args)
        {
            int Temp = 0;
			
            for (int i = 1; i < args.Length; i++)
            {
                for (int j = 0; j < args.Length; j++)
                {
                    try
                    {
                        if (args[j] < args[j + 1])
                        {
                            Temp = args[j];
                            args[j] = args[j + 1];
                            args[j + 1] = Temp;

                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.Clear();
                        Console.WriteLine($"El numero mas grande insertado es : {args[0]}");
                        
                    }
                    

                }
               
            }
            Console.ReadKey();
            Environment.Exit(0);

        }
    }
}
