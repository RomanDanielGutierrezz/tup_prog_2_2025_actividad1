using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Actividad_1
{
    public class Ortoedro
    {
        public Rectangulo[] Laterales = new Rectangulo[4];
        public Rectangulo[] Base = new Rectangulo[2];
        public Ortoedro(double anchoBase,double ladoComun,double largoLateral)
        {
            Base[0] = new Rectangulo(anchoBase, ladoComun);
            Base[1] = new Rectangulo(anchoBase, ladoComun);
            Laterales[0] = new Rectangulo(largoLateral, ladoComun);
            Laterales[1] = new Rectangulo(largoLateral, ladoComun);
            Laterales[2] = new Rectangulo(largoLateral, ladoComun);
            Laterales[3] = new Rectangulo(largoLateral, ladoComun);
        }
        public double CalcularArea()
        {
            double areaBase = Base[0].CalcularArea();
            double areaLateral = Laterales[0].CalcularArea();
            return (2 * areaBase) + (4 * areaLateral);
        }
        public double CalcularVolumen()
        {
            return Base[0].CalcularArea() * Laterales[0].Largo;
        }
        public string Describir()
        {
            var culture = CultureInfo.InvariantCulture;

            string lateralesDescripcion = "";
            for (int n = 0; n < 3; n++)
            {
                lateralesDescripcion += Laterales[n].Describir() + ", \n";
            }
            lateralesDescripcion += Laterales[3].Describir();

            string descripcion = @$"{{  
            ""Tipo"": ""Ortoedro"", 
            ""Tapas"": 
                [
                    {Base[0].Describir()}, 
                    {Base[1].Describir()}
                ],
            ""Laterales"": 
                [
                    {lateralesDescripcion},
                ],
            ""Area"": {CalcularArea().ToString("f2", culture)},
            ""Volumen"": {CalcularVolumen().ToString("f2", culture)}
            }}";
            return descripcion;
        }   
    }
}
