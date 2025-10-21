namespace Listas
{
    internal class Program
    {
        Pila pila = new Pila();
        static void Main(string[] args)
        {
            //Lo que se hace es preguntar al usuario que tipo de elemento quiere usar
            try
            {

                Console.WriteLine("Elige un elemento:");
                Console.WriteLine("1. Pila");
                Console.WriteLine("2. Cola");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    EjecutarPila();
                }
                else if (opcion == "2")
                {
                    EjecutarCola();
                }
                else
                {
                    Console.WriteLine("Opción inválida");
                }

                //Se usó el método de EjecutarPila y Cola para cuando el usuario elija la opcíon que quiere
                static void EjecutarPila()
                {
                    Pila pila = new Pila();
                    pila.Agregar("A");
                    pila.Agregar("B");
                    pila.Agregar("C");
                    pila.Agregar("D");
                    pila.Agregar("E");

                    Console.WriteLine("Contenido de la pila:");
                    pila.Imprimir();

                    pila.Eliminar();
                    Console.WriteLine("Pila después de Eliminar():");
                    pila.Imprimir();
                }

                static void EjecutarCola()
                {
                    Cola cola = new Cola();
                    cola.Agregar("A");
                    cola.Agregar("B");
                    cola.Agregar("C");
                    cola.Agregar("D");
                    cola.Agregar("E");

                    Console.WriteLine("Contenido de la cola");
                    cola.Imprimir();

                    cola.Eliminar();
                    Console.WriteLine("Cola después de Eliminar():");
                    cola.Imprimir();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
