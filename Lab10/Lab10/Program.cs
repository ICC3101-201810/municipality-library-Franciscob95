using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ClassLibrary1.Person> per = new List<Person>();
            List<ClassLibrary1.Address> adr = new List<Address>();
            List<ClassLibrary1.Car> car = new List<Car>();

            ClassLibrary1.Person p;
            ClassLibrary1.Address a;
            ClassLibrary1.Car c;

            bool pat;
            bool piscina;

            while (true)
            {
                Console.WriteLine("Desea inscribir: /n 1 = Persona /n 2 = Propiedad /n 3 = Automovil ");
                string resp = Console.ReadLine();
                if (resp == "1")
                {
                    Console.WriteLine("Ingrese el nombre del cliente");
                    string nom = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido");
                    string ap = Console.ReadLine();
                    Console.WriteLine("Ingrese la fecha de nacimiento");
                    DateTime fNac = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la direccion");
                    ClassLibrary1.Address direc = //ERROR DE CODIGO
                    Console.WriteLine("Ingrese el numero de RUT");
                    string RUT = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre de su Padre");
                    string nomP1 = Console.ReadLine();
                    ClassLibrary1.Person parent1 = new Person(nomP1, ap, 10 / 10 / 10, ERROR, "1111", null, null);
                    Console.WriteLine("Ingrese el nombre de su madre");
                    string nomP2 = Console.ReadLine();
                    ClassLibrary1.Person parent2 = new Person(nomP2, ap, 10 / 10 / 10, ERROR, "1111", null, null); 

                    p = new ClassLibrary1.Person(nom,ap,fNac,ERROR,RUT,parent1, parent2);

                    per.Add(p);

                }
                else if (resp == "2")
                {
                    Console.WriteLine("Ingrese el nombre de la calle");
                    string str = Console.ReadLine();
                    Console.WriteLine("Ingrese el numero");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la Comuna");
                    string com = Console.ReadLine();
                    Console.WriteLine("Ingrese la ciudad");
                    string ci = Console.ReadLine();
                    Console.WriteLine("Ingrese la direccion");
                    ClassLibrary1.Person per = //ERROR DE CODIGO
                    Console.WriteLine("Ingrese el anio de construccion");
                    int anio = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el numero de piezas");
                    int numpie = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el numero de banios");
                    int numban = int.Parse(Console.ReadLine());
                    Console.WriteLine("Tiene piscina? /n 1 = si /n 2 = no");
                    string resp2 = Console.ReadLine();
                    if (resp2 == "1")
                    {
                        bool piscina = true;
                    }
                    else if (resp2 == "2")
                    {
                        bool piscina = false;
                    }
                    Console.WriteLine("Tiene patio? / n 1 = si / n 2 = no");
                    string resp3 = Console.ReadLine();

                    if (resp3 == "1")
                    {
                        bool pat = true;
                    }
                    else if (resp == "2")
                    {
                        bool pat = false;
                    }


                    a = new ClassLibrary1.Address(str, num, com, ci, per, anio, numpie, numban, pat, piscina);

                    adr.Add(a);
                }
                else if (resp == "3")
                {
                    Console.WriteLine("Ingrese el nombre del cliente");
                    string nom = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido");
                    string ap = Console.ReadLine();
                    Console.WriteLine("Ingrese la fecha de nacimiento");
                    DateTime fNac = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la direccion");
                    ClassLibrary1.Address direc = //ERROR DE CODIGO
                    Console.WriteLine("Ingrese el numero de RUT");
                    string RUT = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre de su Padre");
                    string nomP1 = Console.ReadLine();
                    ClassLibrary1.Person parent1 = new Person(nomP1, ap, 10 / 10 / 10, ERROR, "1111", null, null);
                    Console.WriteLine("Ingrese el nombre de su madre");
                    string nomP2 = Console.ReadLine();
                    ClassLibrary1.Person parent2 = new Person(nomP2, ap, 10 / 10 / 10, ERROR, "1111", null, null);

                    p = new ClassLibrary1.Person(nom, ap, fNac, ERROR, RUT, parent1, parent2);

                    per.Add(p);
                }
            }
        }
    }
}
