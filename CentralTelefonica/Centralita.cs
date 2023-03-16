namespace CentralTelefonica
{
    public class Centralita
    {
        public static void Main(String[] args)
        {
            Llamada llamada1 = new Llamada();
            LlamadaLocal llamadalocal1 = new LlamadaLocal();
            LlamadaProvincial llamadaprovincial1 = new LlamadaProvincial();
            Double acum = 0;

            List<string> opciones1 = new List<string>();    //Listado para Llamada o Factura
            opciones1.Add("1- Llamada Local");
            opciones1.Add("2- Llamada Exterior");
            opciones1.Add("3- Imprimir Factura");

            List<string> opciones2 = new List<string>();    //Listado para elegir que Franja Horaria
            opciones2.Add("Franja Horaria 1");
            opciones2.Add("Franja Horaria 2");
            opciones2.Add("Franja Horaria 3");

            double cont = 0;
            int cant = 0;
            

            for (int i = 0; i < 1;)                         //Para Elegir la opcion de Llamada o Factura
            {
                Console.Clear();
                Console.WriteLine("Elija su opcion:");
                Console.WriteLine("\n");

                foreach (string x in opciones1)            //Muestra Listado para Llamada o Factura
                {
                    Console.WriteLine(x);
                }


                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.Clear();

                if (opcion.KeyChar.ToString() == "1")       //Eleccion de Llamada Local
                {
                    cont = llamadalocal1.Precio() * llamada1.Duracion();
                    Console.WriteLine("Tu numero es: " + llamada1.NumOrigen());
                    Console.WriteLine("\n");
                    Console.WriteLine("Llamando a: " + llamada1.NumDestino());
                    Thread.Sleep(3000);
                    Console.WriteLine("Tu llamada ha durado: " + cont/llamadalocal1.Precio() + " segundos.");
                    Console.WriteLine("Se ha añadido " + (cont) + " centavos a tu factura");
                    acum += cont;
                    cant += 1;
                    Thread.Sleep(3000);
                }

                else if (opcion.KeyChar.ToString() == "2")   //Eleccion de Llamada Exterior-Franja Horaria
                {
                    Console.WriteLine("Tu numero es: " + llamada1.NumOrigen());
                    Console.WriteLine("\n");
                    Console.WriteLine("A que Franja Horararia quieres llamar?");
                    Console.WriteLine('\n');

                    foreach (string x in opciones2)         //Muestra Listado para Eleccion de Franja Horaria
                    {
                        Console.WriteLine(x);
                    }
                    ConsoleKeyInfo opcion1 = Console.ReadKey();
                    Console.Clear();

                    if (opcion1.KeyChar.ToString() == "1")       //Eleccion de para cada Franja Horaria

                    {
                        cont = llamadaprovincial1.Precio1() * llamada1.Duracion();
                        Console.WriteLine("Llamando a: " + llamada1.NumDestino());
                        Thread.Sleep(3000);
                        Console.WriteLine("Tu llamada ha durado: " + cont / llamadalocal1.Precio() + " segundos.");
                        Console.WriteLine("Se ha añadido " + (cont) + " centavos a tu factura");
                        acum += cont;
                        cant += 1;
                        Thread.Sleep(4000);

                    }
                    else if (opcion1.KeyChar.ToString() == "2")
                    {
                        cont = llamadaprovincial1.Precio2() * llamada1.Duracion();
                        Console.WriteLine("Llamando a: " + llamada1.NumDestino());
                        Thread.Sleep(3000);
                        Console.WriteLine("Tu llamada ha durado: " + cont / llamadalocal1.Precio() + " segundos.");
                        Console.WriteLine("Se ha añadido " + (cont) + " centavos a tu factura");
                        acum += cont;
                        cant += 1;
                        Thread.Sleep(4000);
                    }
                    else if (opcion1.KeyChar.ToString() == "3")
                    {
                        cont = llamadaprovincial1.Precio3() * llamada1.Duracion();
                        Console.WriteLine("Llamando a: " + llamada1.NumDestino());
                        Thread.Sleep(3000);
                        Console.WriteLine("Tu llamada ha durado: " + cont / llamadalocal1.Precio() + " segundos.");
                        Console.WriteLine("Se ha añadido " + (cont) + " centavos a tu factura");
                        acum += cont;
                        cant += 1;
                        Thread.Sleep(4000);
                    }
                    else
                    {
                        Console.WriteLine("No elegiste ninguna opcion dada");
                        Thread.Sleep(3000);
                    }

                }
                else if (opcion.KeyChar.ToString() == "3")          //Eleccion para Imprirmir factura
                {
                    for (i = 100; i <= acum;)
                    {
                        acum /= 10;
                    }
                    Console.WriteLine("Tu saldo total a pagar de " + cant + " llamadas es de " + Double.Round(acum,2) + " dolares");
                    Thread.Sleep(3000);
                    Console.WriteLine('\n');
                    Console.WriteLine("Su pago de " + Double.Round(acum,2) + " dolares se ha hecho exitosamente!");
                    break;
                }

                else
                {
                    Console.WriteLine("No elegiste ninguna opcion disponible");
                    Thread.Sleep(2000);
                }
            }  


        }
    }
}