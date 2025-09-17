using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSerializers
{
    public static class CsvSerializer
    {

        public static List<string[]> LeerCsv(string ruta)
        {
            var resultado = new List<string[]>();

            if (!File.Exists(ruta))
                return resultado; // Si no existe, se devuelve la lista vacía

            var lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {
                string[] columnas = linea.Split(','); //esto separa cada columna por coma
                resultado.Add(columnas);
            }

            return resultado;
        }


        public static void GuardarCsv(string ruta, List<string[]> datos) //el List<string[]> datos representa las filas q voy a escribir
        {
            using (StreamWriter writer = new StreamWriter(ruta)) //el using nos asegura q el archivo se guarde 
            {
                foreach (var fila in datos)
                {
                    string linea = string.Join(",", fila); //esto une cada columna separada por comas
                    writer.WriteLine(linea);
                }
            }
        }



        public static string[,] ToMatrix(List<string[]> filas)
        {
            if (filas == null || filas.Count == 0) return new string[0, 0];
            int rows = filas.Count;
            int cols = filas[0].Length;
            var m = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    m[i, j] = filas[i][j];
                }
            }
            return m;
        }
    }
}
