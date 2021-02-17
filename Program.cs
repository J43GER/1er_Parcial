using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {   

        /*Cree una aplicación de cajero automático para el banco FDP INVERSMENTS. 
            El cajero tendrá un límite de billetes descrito a continuación: 

            18 billetes de 1,000
            19 billetes de 500
            23 billetes de 200
            50 billetes de 100
            El cajero debe solicitar Banco y monto a retirar. 
            Si el banco es FDP INVERSMENTS el limite de retiro es 20,000 y 10,000 pesos por transacción en caso contrario.

            El cajero debe informar si el monto solicitado no puede ser dispensado o si excede el límite de transacción. 
            Y debe hacer la distribución de los billetes de acuerdo al monto. 

            */

            int banco = 0, monto_retiro = 0, monto_retiro_constante = 0;
            int w = 0, x = 0, y = 0, z = 0;
                

            Console.WriteLine("Favor de introducir el banco para realizar retiro");
            Console.WriteLine("1. FDP INVERSMENTS. (El límite de retiro es 20000$");
            Console.WriteLine("2. Otro Banco. (El límite de retiro es 10000$");
            banco = int.Parse(Console.ReadLine());

            Console.WriteLine("Favor de introducir el monto a retirar.");
            monto_retiro_constante = int.Parse(Console.ReadLine());

            monto_retiro = monto_retiro_constante;

            switch (banco)
            {  
                case 1:

                if (monto_retiro <= 20000)
                {
                    for (int i = 0; i <= 18; i++)
                    { 
                    w = monto_retiro - 1000;
                        
                    }
                   
                   for (int i = 0; i <= 19 ; i++)
                   {
                    x = monto_retiro - 500; 
                   }

                    for (int i = 0; i <= 23 ; i++)
                    {
                        y = monto_retiro - 200;
                    }

                    for (int i = 0; i < 50 ; i++)
                    {
                        z = monto_retiro - 100;
                    }
                    
                    Console.WriteLine(w);
                      


                    
                }



                break;


                case 2:

                



                break;

                
                
            }



           




        }
    }
}
