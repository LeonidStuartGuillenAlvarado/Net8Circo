using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracionCircoFinancieroAnimal
{
    // abstract significa que no puede instarciarse directamente
    // solo puede ser heredada por otras clases
    public abstract class artistaAnimal
    {
        // Propiedades
        public string nombre { get; set; }
        public string tipoAlimentacion { get; set; }
        public bool trucoEspecial { get; set; }

        // metodo no abstracto
        public void saludarPublico()
        {
            Console.WriteLine($"Hola, soy {nombre} y estoy listo para el show");
        }

        // metodos abstractos, obligatorios de implementar en las clases hijas
        public abstract void presentarEspectaculo();
        public abstract void recibirSueldo();
    }

}
