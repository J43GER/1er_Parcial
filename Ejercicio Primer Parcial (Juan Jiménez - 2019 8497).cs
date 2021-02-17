using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {   

        /*  Cree una aplicación de cajero automático para el banco FDP INVERSMENTS. 
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
            int cantde1000 = 18, cantde500 = 19, cantde200 = 23, cantde100 = 53; 

            Console.Clear();    

            Console.WriteLine("Favor de introducir el banco para realizar retiro");
            Console.WriteLine("1. FDP INVERSMENTS. (El límite de retiro es 20000$)");
            Console.WriteLine("2. Otro Banco. (El límite de retiro es 10000$)");
            banco = int.Parse(Console.ReadLine());

            Console.WriteLine("Favor de introducir el monto a retirar.");
            monto_retiro_constante = int.Parse(Console.ReadLine());

            monto_retiro = monto_retiro_constante;

            switch (banco)
            {  
                case 1:

                    if (monto_retiro_constante <= 20000 && monto_retiro_constante % 100 == 0)
                    {
                      if (monto_retiro >= 1000)
                      {
                         w = monto_retiro / 1000;
                         
                         if (w > cantde1000)
                         {
                            monto_retiro -= (cantde1000 * 1000);
                            w = cantde1000;
                           }

                           else
                                {
                                    monto_retiro -= (w * 1000); 
                                }  
                         
                      }  
                    
                        if (monto_retiro >= 500)
                        {
                         x = monto_retiro / 500;
                         
                         if (x > cantde500 )
                         {
                            monto_retiro -= (cantde500 * 500);
                            x = cantde500; 
                         }

                         else
                         {
                             monto_retiro -= (x * 500);
                         }

                        }

                        if (monto_retiro >= 200)
                        {
                         y = monto_retiro / 200;

                         if (y > cantde200)
                         {
                             monto_retiro -= (cantde200 * 200);
                             y = cantde200;
                         }

                         else
                                {
                                    monto_retiro -= (y * 200); 
                                }  
                        }
                        
                        if (monto_retiro >= 100)
                        {
                            z = monto_retiro / 100;

                            if (z > cantde100)
                            {
                                monto_retiro -= (cantde100 * 100);
                                z = cantde100;
                                
                            }

                            else
                                {
                                    monto_retiro -= (z * 100); 
                                }  
                        }

                        Console.WriteLine("Se dispensaran {0} billetes de mil.", w);
                        Console.WriteLine("Se dispensaran {0} billetes de quinientos.", x);
                        Console.WriteLine("Se dispensaran {0} billetes de doscientos.", y);
                        Console.WriteLine("Se dispensaran {0} billetes de cien.", z);
                    }

                    else if (monto_retiro_constante % 100 != 0)
                    {
                    Console.WriteLine("Este monto no se puede retirar, puesto que no es un multiplo de 100.");
                    } 
                    
                    else if (monto_retiro_constante > 20000)
                    {
                    Console.WriteLine("El retiro supera el límite de 20000$");
                    }
                    
                  
                    break;

                    case 2:

                    if (monto_retiro_constante <= 10000 && monto_retiro_constante % 100 == 0)
                    {
                    
                    if (monto_retiro >= 1000)
                      {
                         w = monto_retiro / 1000;
                         
                         if (w > cantde1000)
                         {
                            monto_retiro -= (cantde1000 * 1000);
                            w = cantde1000;
                           }

                           else
                                {
                                    monto_retiro -= (w * 1000); 
                                }  
                         
                      }  
                    
                        if (monto_retiro >= 500)
                        {
                         x = monto_retiro / 500;
                         
                         if (x > cantde500 )
                         {
                            monto_retiro -= (cantde500 * 500);
                            x = cantde500; 
                         }

                         else
                         {
                             monto_retiro -= (x * 500);
                         }

                        }

                        if (monto_retiro >= 200)
                        {
                         y = monto_retiro / 200;

                         if (y > cantde200)
                         {
                             monto_retiro -= (cantde200 * 200);
                             y = cantde200;
                         }

                         else
                                {
                                    monto_retiro -= (y * 200); 
                                }  
                        }
                        
                        if (monto_retiro >= 100)
                        {
                            z = monto_retiro / 100;

                            if (z > cantde100)
                            {
                                monto_retiro -= (cantde100 * 100);
                                z = cantde100;
                                
                            }

                            else
                                {
                                    monto_retiro -= (z * 100); 
                                }  
                        }



                        Console.WriteLine("Se dispensaran {0} billetes de mil.", w);
                        Console.WriteLine("Se dispensaran {0} billetes de quinientos.", x);
                        Console.WriteLine("Se dispensaran {0} billetes de doscientos.", y);
                        Console.WriteLine("Se dispensaran {0} billetes de cien.", z); 
                    }

                    else if (monto_retiro_constante % 100 != 0)

                    {
                        Console.WriteLine("Este monto no se puede retirar, puesto que no es un multiplo de 100.");
                    } 
                    
                    else if (monto_retiro_constante > 10000)
                    {
                       Console.WriteLine("El retiro supera el límite de 10000");
                    }
                    


                    break;
            }

        }
    }
}
