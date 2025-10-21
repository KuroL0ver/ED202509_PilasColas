namespace Listas
{
    internal class Pila
    {
        //En esta clase se implementa pila usando una lista para almacenar los elementos
        private List<string> _lista;
        public Pila()
        {
            _lista = new List<string>();
        }
        //Método para agregar un elemento 

        //Lista.Add agrega el elemento al final de la lista.
        //Lista.count devuelve el número de elementos en la lista.
        //Lista.removeat elimina el elemento en el índice especificado.
        public void Agregar(string dato)
        {
            _lista.Add(dato);
        }
        //Método para eliminar el elemento
        public void Eliminar()
        {
            if (_lista.Count == 0)
            {
                throw new Exception("Pila vacia");
            }
            int ultimoIndice = _lista.Count - 1;
            _lista.RemoveAt(ultimoIndice);
        }
        //Método para imprimir los elementos 
        public void Imprimir()
        {
            for (int i = _lista.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(_lista[i]);
            }
        }
    }
}
