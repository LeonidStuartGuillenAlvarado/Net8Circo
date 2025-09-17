using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracionCircoFinancieroAnimal
{
    public class Elefante : artistaAnimal
    {
        public override void presentarEspectaculo()
        {
            Console.WriteLine($"{nombre} hace malabares con la trompa");
        }
        public override void recibirSueldo()
        {
            Console.WriteLine($"{nombre} recibe una bolsa de mani");
        }
    }
    public class Cocodrilo : artistaAnimal
    {
        public override void presentarEspectaculo()
        {
            Console.WriteLine($"{nombre} hace un increible equilibiro sobre una pelota");
        }
        public override void recibirSueldo()
        {
            Console.WriteLine($"{nombre} recibe un capibara");
        }
    }
    public class Tigre : artistaAnimal
    {
        public override void presentarEspectaculo()
        {
            Console.WriteLine($"{nombre} salta aros de fuego");
        }
        public override void recibirSueldo()
        {
            Console.WriteLine($"{nombre} recibe una gacela");
        }
    }
    public class Leon : artistaAnimal
    {
        public override void presentarEspectaculo()
        {
            Console.WriteLine($"{nombre} hace rugidos impresionantes y saltos magestuosos");
        }
        public override void recibirSueldo()
        {
            Console.WriteLine($"{nombre} recibe una cebra como pago");
        }
    }
    public class Mono : artistaAnimal
    {
        public override void presentarEspectaculo()
        {
            Console.WriteLine($"{nombre} hace acrobacias y malabares");
        }
        public override void recibirSueldo()
        {
            Console.WriteLine($"{nombre} recibe bananas");
        }
    }
}
