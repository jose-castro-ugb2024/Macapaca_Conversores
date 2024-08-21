using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macapaca_Conversores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 1;
            while (m == 1)
            {
                Console.WriteLine("___BIENVENIDO A CONVERSOR MACAPACA___");
                Console.WriteLine("UN CONVERSOR EN SERIE, DONDE DEBES ATRAVESAR NUESTROS CONVERSORES ");
                Console.WriteLine(". . . ");
                Console.WriteLine("(PERDON NO SE PONER MENUS DENTRO DE OTROS MENUS COF COF)");
                Console.WriteLine("CONVERSOR de Monedas"); //CONVERSOR DE MONEDAS
                Console.WriteLine("-----------------------------");

                Console.WriteLine("1-) Dolares a Pesos Chilenos");
                Console.WriteLine("2-) Pesos Chilenos a Dolares");
                Console.WriteLine("3-) Dolares a Euros");
                Console.WriteLine("4-) Euros a Dolares");
                Console.WriteLine("5-) Pesos Mexicanos a Dolares");
                Console.WriteLine("6-) Dolares a Pesos Mexicanos");
                Console.WriteLine("7-) Dolares a Yenes");
                Console.WriteLine("8-) Yenes a Dolares");
                Console.WriteLine("9-) Dolares a Yuanes");
                Console.WriteLine("10-) Yuanes a Dolares");
                Console.WriteLine("0-) Para pasar al siguiente Conversor de MASA ");
                Console.WriteLine("");

                int hl = Convert.ToInt32(Console.ReadLine());
                if (hl == 1)
                {
                    Console.WriteLine("Cantidad en Dolares: ");
                    var mon1 = Convert.ToInt32(Console.ReadLine());
                    double v1 = mon1 * 937.55;
                    Console.WriteLine("Pesos Chilenos = " + v1);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 2)
                {
                    Console.Write("Cantidad de Pesos Chilenos: ");
                    double mon2 = Convert.ToDouble(Console.ReadLine());
                    double v2 = mon2 / 937.55;
                    Console.WriteLine("Dolares = " + v2);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 3)
                {
                    Console.Write("Cantidad de Dolares: ");
                    int mon3 = Convert.ToInt32(Console.ReadLine());
                    double v3 = mon3 * 0.9121;
                    Console.WriteLine("Euros = " + v3);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 4)
                {
                    Console.Write("Cantidad de Euros: ");
                    int mon4 = Convert.ToInt32(Console.ReadLine());
                    double v4 = mon4 / 0.9121;
                    Console.WriteLine("Dolares = " + v4);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 5)
                {
                    Console.Write("Cantidad de Pesos Mexicanos: ");
                    int mon5 = Convert.ToInt32(Console.ReadLine());
                    double v5 = mon5 / 18.64;
                    Console.WriteLine("Dolares = " + v5);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 6)
                {
                    Console.Write("Cantidad de Dolares: ");
                    int mon6 = Convert.ToInt32(Console.ReadLine());
                    double v6 = mon6 * 18.64;
                    Console.WriteLine("Pesos Mexicanos = " + v6);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 7)
                {
                    Console.Write("Cantidad de Dolares: ");
                    int mon7 = Convert.ToInt32(Console.ReadLine());
                    double v7 = mon7 * 148.92;
                    Console.WriteLine("Yenes = " + v7);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 8)
                {
                    Console.Write("Cantidad de Yenes: ");
                    int mon8 = Convert.ToInt32(Console.ReadLine());
                    double v8 = mon8 / 148.92;
                    Console.WriteLine("Dolares = " + v8);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 9)
                {
                    Console.Write("Cantidad de Dolares: ");
                    int mon9 = Convert.ToInt32(Console.ReadLine());
                    double v9 = mon9 * 7.1767;
                    Console.WriteLine("Yuanes = " + v9);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 10)
                {
                    Console.Write("Cantidad de Yuanes: ");
                    int mon10 = Convert.ToInt32(Console.ReadLine());
                    double v10 = mon10 / 7.1767;
                    Console.WriteLine("Dolares = " + v10);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 0)
                {
                    m = 1;
                }
                else
                {
                    Console.WriteLine("Opcion invalida!");
                    Console.WriteLine("Presiona enter para continuar con el conversor de MASA ");

                }



                int a = 1;
                while (a == 1)








                { // CONVERSOR DE MASA
                    Console.WriteLine(" Conversor de Masas ");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine(" 1).KILOGRAMOS A TONELADAS ");
                    Console.WriteLine(" 2).KILOGRAMOS A TONELADAS LARGAS ");
                    Console.WriteLine(" 3).KILOGRAMOS A GRAMOS ");
                    Console.WriteLine(" 4).KILOGRAMOS A LIBRAS ");
                    Console.WriteLine(" 5).KILOGRAMOS A ONZAS ");
                    Console.WriteLine(" 6).KILOGRAMOS A STONE ");
                    Console.WriteLine(" 7).KILOGRAMS A MILIGRAMOS ");
                    Console.WriteLine(" 8).KILOGRAMOS A MICROGRAMOS ");
                    Console.WriteLine(" 9).KILOGRAMOS A HECTOGRAMOS ");
                    Console.WriteLine(" 10).KILOGRAMOS A DECAGRAMOS ");
                    Console.WriteLine("0). Para pasar al siguiente Conversor de VOLUMEN ");
                    Console.WriteLine(" ");

                    int kl = Convert.ToInt32(Console.ReadLine());
                    if (kl == 1)
                    {
                        Console.WriteLine("Cantidad en kilogramos: ");
                        var mas1 = Convert.ToInt32(Console.ReadLine());
                        double mas2 = mas1 / 1000;
                        Console.WriteLine("Toneladas = " + mas2);
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                    }
                    else if (kl == 2)
                    {
                        Console.Write("Cantidad de kilogramos: ");
                        double mas3 = Convert.ToDouble(Console.ReadLine());
                        double mas4 = mas3 / 1016;
                        Console.WriteLine("Tonelada larga = " + mas4);
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                    }
                    else if (kl == 3)
                    {
                        Console.Write("Cantidad de kilogramos: ");
                        int mas5 = Convert.ToInt32(Console.ReadLine());
                        double mas6 = mas5 * 1000;
                        Console.WriteLine("Gramos = " + mas6);
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                    }
                    else if (kl == 4)
                    {
                        Console.Write("Cantidad de kilogramos: ");
                        int mas7 = Convert.ToInt32(Console.ReadLine());
                        double mas8 = mas7 * 2.205;
                        Console.WriteLine("Libras = " + mas8);
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                    }
                    else if (kl == 5)
                    {
                        Console.Write("Cantidad de kilogramos: ");
                        int mas9 = Convert.ToInt32(Console.ReadLine());
                        double ma10 = mas9 / 35.274;
                        Console.WriteLine("Onzas = " + ma10);
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                    }
                    else if (kl == 6)
                    {
                        Console.Write("Cantidad de kilogramos: ");
                        int ma11 = Convert.ToInt32(Console.ReadLine());
                        double ma12 = ma11 / 6.35;
                        Console.WriteLine("Stones = " + ma12);
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                    }
                    else if (kl == 7)
                    {
                        Console.Write("Cantidad de kilogramos: ");
                        int ma13 = Convert.ToInt32(Console.ReadLine());
                        double ma14 = ma13 * 1000000;
                        Console.WriteLine("miligramos = " + ma14);
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                    }
                    else if (kl == 8)
                    {
                        Console.Write("Cantidad de kilogramos: ");
                        int ma15 = Convert.ToInt32(Console.ReadLine());
                        double ma16 = ma15 / 1000000000;
                        Console.WriteLine("microgramos = " + ma16);
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                    }
                    else if (kl == 9)
                    {
                        Console.Write("Cantidad de kilogramos: ");
                        int ma17 = Convert.ToInt32(Console.ReadLine());
                        double ma18 = ma17 * 10;
                        Console.WriteLine("Hectogramos = " + ma18);
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                    }
                    else if (kl == 10)
                    {
                        Console.Write("Cantidad de kilogramos: ");
                        int ma19 = Convert.ToInt32(Console.ReadLine());
                        double ma20 = ma19 * 100;
                        Console.WriteLine("Decagramos = " + ma20);
                        Console.WriteLine("Presiona enter para continuar");
                        Console.ReadLine();
                    }
                    else if (kl == 0)
                    {
                        m = 1;
                    }
                    else
                    {
                        Console.WriteLine("Opcion invalida!");
                        Console.WriteLine("Presiona enter para continuar con el conversor de MASA ");

                    }




                    /* Console.WriteLine("-----------------------------");
                     Console.WriteLine(" 1).TONELADAS " + toneladas.ToString("0.00"));
                     Console.WriteLine(" 2).TONELADAS LARGAS " + toneladasl.ToString("0.00"));
                     Console.WriteLine(" 3).GRAMOS " + gramos.ToString("0.00"));
                     Console.WriteLine(" 4).LIBRAS " + libras.ToString("0.00"));
                     Console.WriteLine(" 5).ONZAS " + onzas.ToString("0.00"));
                     Console.WriteLine(" 6).STONE " + stones.ToString("0.00"));
                     Console.WriteLine(" 7).MILIGRAMOS " + miligramos.ToString("0.00"));
                     Console.WriteLine(" 8).MICROGRAMOS " + microgramos.ToString("0.00"));
                     Console.WriteLine(" 9).HECTOGRAMOS " + hectogramos.ToString("0.00"));
                     Console.WriteLine(" 10).DECAGRAMOS " + decagramos.ToString("0.00"));
                     Console.WriteLine("0-) pasar al siguiente Conversor de VOLUMEN n/");


                     Console.ReadLine();  */

                    //CONVERSOR DE VOLUMEN
                    int b = 1;
                    while (b == 1)
                    {

                        Console.WriteLine("CONVERSOR DE VOLUMEN");
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("1-) litros a mililitros ");
                        Console.WriteLine("2-) mililitros a litros ");
                        Console.WriteLine("3-) litros a metros cubicos ");
                        Console.WriteLine("4-) metros cubicos a litros ");
                        Console.WriteLine("5-) litros a pies cubicos ");
                        Console.WriteLine("6-) pies cubicos a litros ");
                        Console.WriteLine("7-) litros a pulgadas cubicas ");
                        Console.WriteLine("8-) pulgadas cubicas a litros ");
                        Console.WriteLine("9-) litros a galones ");
                        Console.WriteLine("10-) galones a litros ");
                        Console.WriteLine("0-) Para pasar al siguiente conversor de LONGITUD...");
                        Console.WriteLine("");



                        double vl = Convert.ToDouble(Console.ReadLine());
                        if (vl == 1)

                        {
                            Console.WriteLine("cantidad de litros: ");
                            double litros = Convert.ToDouble(Console.ReadLine());
                            double mililitros = litros * 1000;
                            Console.WriteLine("ml = " + mililitros);
                            Console.WriteLine("Presiona enter para continuar");
                            Console.ReadLine();
                        }
                        else if (vl == 2)
                        {
                            Console.WriteLine("cantidad de mililitros: ");
                            double mililitros1 = Convert.ToDouble(Console.ReadLine());
                            double litros1 = mililitros1 / 1000;
                            Console.WriteLine("lt = " + litros1);
                            Console.WriteLine("Presiona enter para continuar");
                            Console.ReadLine();
                        }
                        else if (vl == 3)
                        {
                            Console.WriteLine("cantidad de litros: ");
                            double litros2 = Convert.ToDouble(Console.ReadLine());
                            double mtr3 = litros2 / 1000;
                            Console.WriteLine("mtrs cubicos = " + mtr3);
                            Console.WriteLine("Presiona enter para continuar");
                            Console.ReadLine();
                        }
                        else if (vl == 4)
                        {

                            Console.WriteLine("cantidad de metros cubicos: ");
                            double mtcub = Convert.ToDouble(Console.ReadLine());
                            double litros3 = mtcub * 1000;
                            Console.WriteLine("lt = " + litros3);
                            Console.WriteLine("Presiona enter para continuar");
                            Console.ReadLine();

                        }
                        else if (vl == 5)
                        {
                            Console.WriteLine("cantidad de litros: ");
                            double litros4 = Convert.ToDouble(Console.ReadLine());
                            double pies = litros4 * 28.317;
                            Console.WriteLine("Pies cubicos = " + pies);
                            Console.WriteLine("Presiona enter para continuar");
                            Console.ReadLine();

                        }
                        else if (vl == 6)
                        {
                            Console.WriteLine("cantidad de pies cubicos: ");
                            double pies2 = Convert.ToDouble(Console.ReadLine());
                            double litros5 = pies2 / 28.317;
                            Console.WriteLine("lt = " + litros5);
                            Console.WriteLine("Presiona enter para continuar");
                            Console.ReadLine();
                        }
                        else if (vl == 7)
                        {
                            Console.WriteLine("cantidad de litros: ");
                            double litros6 = Convert.ToDouble(Console.ReadLine());
                            double pulgcub = litros6 * 61.024;
                            Console.WriteLine("pulgadas cubicas = " + pulgcub);
                            Console.WriteLine("Presiona enter para continuar");
                            Console.ReadLine();

                        }
                        else if (vl == 8)
                        {
                            Console.WriteLine("cantidad de pulgadas cubicas: ");
                            double pulg3 = Convert.ToDouble(Console.ReadLine());
                            double litros7 = pulg3 / 61.024;
                            Console.WriteLine("lt = " + litros7);
                            Console.WriteLine("Presiona enter para continuar");
                            Console.ReadLine();

                        }
                        else if (vl == 9)
                        {
                            Console.WriteLine("cantidad de litros: ");
                            double litros8 = Convert.ToDouble(Console.ReadLine());
                            double gals = litros8 / 3.785;
                            Console.WriteLine("Galon Estadounidense = " + gals);
                            Console.WriteLine("Presiona enter para continuar");
                            Console.ReadLine();

                        }
                        else if (vl == 10)
                        {
                            Console.WriteLine("cantidad de Galones: ");
                            double gals1 = Convert.ToDouble(Console.ReadLine());
                            double litros9 = gals1 * 3.785;
                            Console.WriteLine("lt = " + litros9);
                            Console.WriteLine("Presiona enter para continuar");

                            Console.ReadLine();
                        }
                        //CONVERSOR DE LONGITUDES
                        else if (b == 0)
                        {
                            b = 0;
                        }
                        else
                        {

                            Console.WriteLine("Opcion invalida!");
                            Console.WriteLine("Presiona enter para pasar al conversor de LONGITUDES ");
                            Console.ReadLine();
                        }


                        {
                            Console.WriteLine("CONVERSOR DE LONGITUD");
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine("1-) metros a pies");
                            Console.WriteLine("2-) pies a metros");
                            Console.WriteLine("3-) pulgadas a centimetros");
                            Console.WriteLine("4-) centimetros a pulgadas");
                            Console.WriteLine("5-) kilometros a metros");
                            Console.WriteLine("6-) metros a kilometros");
                            Console.WriteLine("7-) yardas a millas");
                            Console.WriteLine("8-) millas a yardas");
                            Console.WriteLine("9-) metros a milimetros");
                            Console.WriteLine("10-) milimetros a metros");
                            Console.WriteLine("0-) para pasar al conversor de ALMACENAMIENTO ");
                            Console.WriteLine("");



                            double ll = Convert.ToDouble(Console.ReadLine());
                            if (ll == 1)

                            {
                                Console.WriteLine("cantidad de metros: ");
                                double metros = Convert.ToDouble(Console.ReadLine());
                                double pies = metros * 3.28084;
                                Console.WriteLine("pies = " + pies);
                                Console.WriteLine("Presiona enter para continuar");
                                Console.ReadLine();
                            }
                            else if (ll == 2)
                            {
                                Console.WriteLine("cantidad de pies: ");
                                double pies = Convert.ToDouble(Console.ReadLine());
                                double metros1 = pies / 0.3048;
                                Console.WriteLine("metros = " + metros1);
                                Console.WriteLine("Presiona enter para continuar");
                                Console.ReadLine();
                            }
                            else if (ll == 3)
                            {
                                Console.WriteLine("cantidad de pulgadas: ");
                                double pulgadas = Convert.ToDouble(Console.ReadLine());
                                double centimetros = pulgadas * 2.54;
                                Console.WriteLine("centimetros = " + centimetros);
                                Console.WriteLine("Presiona enter para continuar");
                                Console.ReadLine();
                            }
                            else if (ll == 4)
                            {

                                Console.WriteLine("cantidad centimetros: ");
                                double centimetros = Convert.ToDouble(Console.ReadLine());
                                double pulgadas2 = centimetros / 0.393701;
                                Console.WriteLine("pulgadas = " + pulgadas2);
                                Console.WriteLine("Presiona enter para continuar");
                                Console.ReadLine();

                            }
                            else if (ll == 5)
                            {
                                Console.WriteLine("cantidad de kilometros: ");
                                double kilometros = Convert.ToDouble(Console.ReadLine());
                                double metros2 = kilometros * 100;
                                Console.WriteLine("metros = " + metros2);
                                Console.WriteLine("Presiona enter para continuar");
                                Console.ReadLine();

                            }
                            else if (ll == 6)
                            {
                                Console.WriteLine("cantidad de metros: ");
                                double metros2 = Convert.ToDouble(Console.ReadLine());
                                double kilometros1 = metros2 / 0.001;
                                Console.WriteLine("kilometros = " + kilometros1);
                                Console.WriteLine("Presiona enter para continuar");
                                Console.ReadLine();
                            }
                            else if (ll == 7)
                            {
                                Console.WriteLine("cantidad de yardas: ");
                                double yardas = Convert.ToDouble(Console.ReadLine());
                                double millas = yardas / 0.000568182;
                                Console.WriteLine("millas = " + millas);
                                Console.WriteLine("Presiona enter para continuar");
                                Console.ReadLine();

                            }
                            else if (ll == 8)
                            {
                                Console.WriteLine("cantidad de millas: ");
                                double millas = Convert.ToDouble(Console.ReadLine());
                                double yardas = millas * 1760;
                                Console.WriteLine("yardas = " + yardas);
                                Console.WriteLine("Presiona enter para continuar");
                                Console.ReadLine();

                            }
                            else if (ll == 9)
                            {
                                Console.WriteLine("cantidad de metros: ");
                                double metros3 = Convert.ToDouble(Console.ReadLine());
                                double milimetros = metros3 * 1000;
                                Console.WriteLine("milimetros = " + milimetros);
                                Console.WriteLine("Presiona enter para continuar");
                                Console.ReadLine();

                            }
                            else if (ll == 10)
                            {
                                Console.WriteLine("cantidad de milimetros: ");
                                double milimetros2 = Convert.ToDouble(Console.ReadLine());
                                double metros4 = milimetros2 / 0.001;
                                Console.WriteLine("metros = " + metros4);
                                Console.WriteLine("Presiona enter para continuar");

                                Console.WriteLine("Opcion invalida!");
                                Console.WriteLine("Presiona enter para pasar al conversor de ALMACENAMIENTO");
                                Console.ReadLine();
                            }
                            // CONVERSOR DE UNIDADES DE ALMACENAMIENTO

                            int c = 1;
                            while (c == 1)
                            {
                                Console.WriteLine("CONVERSOR de ALMACENAMIENTO");
                                Console.WriteLine("-----------------------------");

                                Console.WriteLine("1-) bytes a kilobytes. ");
                                Console.WriteLine("2-) kilobytes a Megabytes. ");
                                Console.WriteLine("3-) Megabytes a Gigabytes. ");
                                Console.WriteLine("4-) Gigabytes a Terabytes. ");
                                Console.WriteLine("5-) Terabytes a Petabytes. ");
                                Console.WriteLine("6-) bytes a bits. ");
                                Console.WriteLine("7-) bits a megabits. ");
                                Console.WriteLine("8-) megabits a gigabits. ");
                                Console.WriteLine("9-) gigabits a terabits. ");
                                Console.WriteLine("10-) terabits a bytes");
                                Console.WriteLine("0-) Para pasar al conversor de TIEMPO ");
                                Console.WriteLine("");

                                int al = Convert.ToInt32(Console.ReadLine());
                                if (al == 1)
                                {
                                    Console.WriteLine("Cantidad en bytes: ");
                                    var bytes = Convert.ToInt32(Console.ReadLine());
                                    double kilobytes = bytes / 1000;
                                    Console.WriteLine("kilobytes = " + kilobytes);
                                    Console.WriteLine("Presiona enter para continuar");
                                    Console.ReadLine();
                                }
                                else if (al == 2)
                                {
                                    Console.Write("Cantidad de kilobytes: ");
                                    double kilobytes1 = Convert.ToDouble(Console.ReadLine());
                                    double Megabytes = kilobytes1 / 1000;
                                    Console.WriteLine("Megabytes = " + Megabytes);
                                    Console.WriteLine("Presiona enter para continuar");
                                    Console.ReadLine();
                                }
                                else if (al == 3)
                                {
                                    Console.Write("Cantidad de Megabytes: ");
                                    int Megabytes1 = Convert.ToInt32(Console.ReadLine());
                                    double Gigabytes = Megabytes1 / 1000;
                                    Console.WriteLine("Gigabytes = " + Gigabytes);
                                    Console.WriteLine("Presiona enter para continuar");
                                    Console.ReadLine();
                                }
                                else if (al == 4)
                                {
                                    Console.Write("Cantidad de Giabytes: ");
                                    int Gigabytes = Convert.ToInt32(Console.ReadLine());
                                    double Terabytes = Gigabytes / 1000;
                                    Console.WriteLine("Terabytes = " + Terabytes);
                                    Console.WriteLine("Presiona enter para continuar");
                                    Console.ReadLine();
                                }
                                else if (al == 5)
                                {
                                    Console.Write("Cantidad de Terabytes: ");
                                    int Terabytes1 = Convert.ToInt32(Console.ReadLine());
                                    double Petabytes = Terabytes1 / 1000;
                                    Console.WriteLine("Petabytes = " + Petabytes);
                                    Console.WriteLine("Presiona enter para continuar");
                                    Console.ReadLine();
                                }
                                else if (al == 6)
                                {
                                    Console.Write("Cantidad de bytes: ");
                                    int bytes1 = Convert.ToInt32(Console.ReadLine());
                                    double bits = bytes1 * 8;
                                    Console.WriteLine("bits = " + bits);
                                    Console.WriteLine("Presiona enter para continuar");
                                    Console.ReadLine();
                                }
                                else if (al == 7)
                                {
                                    Console.Write("Cantidad de bits: ");
                                    int bits1 = Convert.ToInt32(Console.ReadLine());
                                    double megabits = bits1 / 1000;
                                    Console.WriteLine("megabits = " + megabits);
                                    Console.WriteLine("Presiona enter para continuar");
                                    Console.ReadLine();
                                }
                                else if (al == 8)
                                {
                                    Console.Write("Cantidad de megabits: ");
                                    int megabits1 = Convert.ToInt32(Console.ReadLine());
                                    double gigabits = megabits1 / 1000;
                                    Console.WriteLine("gigabits = " + gigabits);
                                    Console.WriteLine("Presiona enter para continuar");
                                    Console.ReadLine();
                                }
                                else if (al == 9)
                                {
                                    Console.Write("Cantidad de gigabits: ");
                                    int gigabits1 = Convert.ToInt32(Console.ReadLine());
                                    double terabits = gigabits1 / 1000;
                                    Console.WriteLine("terabits = " + terabits);
                                    Console.WriteLine("Presiona enter para continuar");
                                    Console.ReadLine();
                                }
                                else if (al == 10)
                                {
                                    Console.Write("Cantidad de terabits: ");
                                    int terabits1 = Convert.ToInt32(Console.ReadLine());
                                    double bytes1 = terabits1 / 8;
                                    Console.WriteLine("Bytes = " + bytes1);
                                    Console.WriteLine("Presiona enter para continuar");
                                    Console.ReadLine();
                                }
                                else if (al == 0)
                                {
                                    c = 0;
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida!");
                                    Console.WriteLine("Presiona enter para pasar al conversor de TIEMPO");
                                    Console.ReadLine();


                                }



                                int d = 1;
                                while (d == 1)
                                {

                                    Console.WriteLine("CONVERSOR DE TIEMPO");
                                    Console.WriteLine("-----------------------------");
                                    Console.WriteLine("1-) dias a semanas ");
                                    Console.WriteLine("2-) semanas a dias ");
                                    Console.WriteLine("3-) dias a años");
                                    Console.WriteLine("4-) años a dias");
                                    Console.WriteLine("5-) minutos a horas");
                                    Console.WriteLine("6-) horas a minutos");
                                    Console.WriteLine("7-) minutos a segundos ");
                                    Console.WriteLine("8-) segundos a minutos");
                                    Console.WriteLine("9-) semanas a años");
                                    Console.WriteLine("10-) años a semanas ");
                                    Console.WriteLine("0-) para salir ");
                                    Console.WriteLine("");



                                    double tl = Convert.ToDouble(Console.ReadLine());
                                    if (tl == 1)

                                    {
                                        Console.WriteLine("cantidad de dias: ");
                                        double dias = Convert.ToDouble(Console.ReadLine());
                                        double semanas = dias / 7;
                                        Console.WriteLine("semanas = " + semanas);
                                        Console.WriteLine("Presiona enter para continuar");
                                        Console.ReadLine();
                                    }
                                    else if (tl == 2)
                                    {
                                        Console.WriteLine("cantidad de semanas: ");
                                        double semanas1 = Convert.ToDouble(Console.ReadLine());
                                        double dias1 = semanas1 * 7;
                                        Console.WriteLine("dias = " + dias1);
                                        Console.WriteLine("Presiona enter para continuar");
                                        Console.ReadLine();
                                    }
                                    else if (tl == 3)
                                    {
                                        Console.WriteLine("cantidad de dias: ");
                                        double dias3 = Convert.ToDouble(Console.ReadLine());
                                        double años = dias3 / 365;
                                        Console.WriteLine("años = " + años);
                                        Console.WriteLine("Presiona enter para continuar");
                                        Console.ReadLine();
                                    }
                                    else if (tl == 4)
                                    {

                                        Console.WriteLine("cantidad años: ");
                                        double años2 = Convert.ToDouble(Console.ReadLine());
                                        double dias4 = años2 * 365;
                                        Console.WriteLine("dias = " + dias4);
                                        Console.WriteLine("Presiona enter para continuar");
                                        Console.ReadLine();

                                    }
                                    else if (tl == 5)
                                    {
                                        Console.WriteLine("cantidad de minutos: ");
                                        double minutos = Convert.ToDouble(Console.ReadLine());
                                        double horas = minutos / 60;
                                        Console.WriteLine("horas = " + horas);
                                        Console.WriteLine("Presiona enter para continuar");
                                        Console.ReadLine();

                                    }
                                    else if (tl == 6)
                                    {
                                        Console.WriteLine("cantidad de horas: ");
                                        double horas1 = Convert.ToDouble(Console.ReadLine());
                                        double minutos1 = horas1 * 60;
                                        Console.WriteLine("minutos = " + minutos1);
                                        Console.WriteLine("Presiona enter para continuar");
                                        Console.ReadLine();
                                    }
                                    else if (tl == 7)
                                    {
                                        Console.WriteLine("cantidad de minutos: ");
                                        double minutos2 = Convert.ToDouble(Console.ReadLine());
                                        double segundos = minutos2 * 60;
                                        Console.WriteLine("segundos = " + segundos);
                                        Console.WriteLine("Presiona enter para continuar");
                                        Console.ReadLine();

                                    }
                                    else if (tl == 8)
                                    {
                                        Console.WriteLine("cantidad de segundos: ");
                                        double segundos1 = Convert.ToDouble(Console.ReadLine());
                                        double minutos3 = segundos1 / 60;
                                        Console.WriteLine("minutos = " + minutos3);
                                        Console.WriteLine("Presiona enter para continuar");
                                        Console.ReadLine();

                                    }
                                    else if (tl == 9)
                                    {
                                        Console.WriteLine("cantidad de semanas: ");
                                        double semanas2 = Convert.ToDouble(Console.ReadLine());
                                        double años3 = semanas2 / 52.143;
                                        Console.WriteLine("años = " + años3);
                                        Console.WriteLine("Presiona enter para continuar");
                                        Console.ReadLine();

                                    }
                                    else if (tl == 10)
                                    {
                                        Console.WriteLine("cantidad de años: ");
                                        double años4 = Convert.ToDouble(Console.ReadLine());
                                        double semanas3 = años4 * 52.143;
                                        Console.WriteLine("semanas = " + semanas3);
                                        Console.WriteLine("Presiona enter para continuar");

                                        Console.ReadLine();
                                    }
                                    else if (tl == 0)
                                    {
                                        d = 0;
                                    }
                                    else
                                    {

                                        Console.WriteLine("Opcion invalida!");
                                        Console.WriteLine("Presiona enter para pasar Salir");
                                        Console.ReadLine();
                                    }
                                } 
                            } 
                        }
                    }
                }
            }
        }
    }
}


    
    

