using System;
using System.Collections.Generic;
namespace PreParcial2
{
    public class CP
    {
         public interface IS
                {
                    void peticion(int p);
                }
                
                public class Proxy : IS
                {
                    private CBa s;
                    
                    public void peticion(int p)
                    {
                        int pass;
        
                        Console.WriteLine("BIENVENIDO AL SISTEMA BANCARIO");
                        Console.WriteLine("CREDENCIALES ");
                        pass = Convert.ToInt32(Console.ReadLine());
        
                        if (pass == 1234)
                        {
                            if (s == null)
                            {
                                s.WriteLine("INICIANDO");
                                s = new CBa();
                            }
        
                            switch (p)
                            {
                                case 1:
                                    s.AddCuenta();
                                    break;
                                case 2:
                                    s.Check();
                                    break;
                                case 3:
                                    s.Check();
                                    s.TotalC();
                                    break;
                                case 4:
                                    s.Check();
                                    s.TotalC();
                                    s.CV();
                                    break;
                                case 5:
                                    Console.WriteLine("HASTA PRONTO");
                                    break;
                                default:
                                    Console.WriteLine("ERROR");
                                    break;
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("ERROR ERROR ERROR");
                        }
                    }
                    
                    private class CBa
                    {
                        List<CB> C = new List<CB>();
                        long balance= 0;
                        string nom = "";
                        
                        public void AddCuenta()
                        {
                            Console.Write("NOMBRE ");
                            nom = Console.ReadLine();
                            Console.Write("A ABONAR: ");
                            balance = Convert.ToInt32(Console.ReadLine());
                            C.Add(new CB(nom,balance));
                            Console.WriteLine("SE HA ALMACENADO");
                        }
        
                        public void Check()
                        {
                            Console.WriteLine("CUENTAS ACT");
                            foreach (var V in C)
                            {
                                Console.WriteLine("Nom="+V._persona+" Balance:"+V._balance+"\n");
                            }
                        }
        
                        public void TotalC()
                        {
                            Console.WriteLine("TOTAL DE CUENTAS");
                            int numC = 0;
                            foreach (var V in C)
                            {
                                numC += 1;
                            }
        
                            Console.WriteLine(numC.ToString());
                        }
        
                        public void CV()
                        {
                            
                            foreach (var V in C)
                            {
                                if (V._persona.Substring(0, 1) == "a" ||
                                    V._persona.Substring(0, 1) == "A" ||
                                    V._persona.Substring(0, 1) == "e" ||
                                    V._persona.Substring(0, 1) == "E" ||
                                    V._persona.Substring(0, 1) == "i" ||
                                    V._persona.Substring(0, 1) == "I" ||
                                    V._persona.Substring(0, 1) == "o" ||
                                    V._persona.Substring(0, 1) == "O" ||
                                    V._persona.Substring(0, 1) == "u" ||
                                    V._persona.Substring(0, 1) == "U")
                                {
                                    Console.WriteLine("CUENTAS CON INICIAL VOCAL");
                                    Console.WriteLine(
                                        "Nom=" + V._persona + " Balance:" + V._balance + "\n");
                                }
                            }
                        }
                    }
                }
    }
}