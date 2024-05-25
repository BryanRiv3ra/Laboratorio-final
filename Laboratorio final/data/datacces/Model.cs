using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_final.data.datacces
{
        public class model
        {
            public int id_Consola { get; set; }
            public string nombre_consola { get; set; }
            public string compania { get; set; }
            public DateTime fecha_lanzamiento { get; set; }
            public int generacion { get; set; }
            public  model() { }

      
            public model(int id_consola, string nombre_Consola, string Compania, DateTime Fecha_lanzamiento, int Generacion)
            {
                id_Consola = id_consola;
                nombre_consola = nombre_Consola;
                compania = Compania;
                fecha_lanzamiento = Fecha_lanzamiento;
                generacion = Generacion;
            }
            public override string ToString()
            {
                return $"id_Consola: {id_Consola}, nombre_consola: {nombre_consola}, compania: {compania}, fecha_lanzamiento: {fecha_lanzamiento.ToShortDateString()}, generacion: {generacion}";
            }
        }
 }

