using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DemoCV.clases
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public decimal Precio { get; set; }
        public int Kilometraje { get; set; }

        public override string ToString()
        {
            return $"{Marca} {Modelo}";
        }
        public string mostrarDatos() 
        {
            return $"{Marca} - {Modelo} - {Año} - {Precio} - {Kilometraje}";
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año},Precio:{Precio},Km:{Kilometraje}");

        }
        public string[] itemView()
        {
            string[] data = { Marca,
                    Modelo, Convert.ToString(Precio) };
            return data;
        }

        

    }
}
