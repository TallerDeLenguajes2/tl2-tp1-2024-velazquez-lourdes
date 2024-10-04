using System;
namespace proyectoCadeteria
{
    public class AccesoDatosCSV
    {
        public string ReadFile (string filePath)
        {
            string text = File.ReadAllText(filePath); 
            return text;
        }
        public Cadeteria GetCadeteria (string cadeteriaFilePaht)
        {
            var text = File.ReadAllText(cadeteriaFilePaht);
            string[] linea = text.Split('\n');
            if (linea.Length >= 1)
            {
                string[] splits = linea[0].Split(',');
                if (splits.Length == 2)
                {
                    return new Cadeteria(splits[0],splits[1]);
                }
            }
            return null; 
        }

        public void AddCadetes (Cadeteria cadeteria, string cadetesFilePath)
        {
            var text = File.ReadAllText(cadetesFilePath);
            string[] cadetes = text.Split('\n');
            if (cadetes.Length >= 1)
            {
                foreach (string linea in cadetes)
                {
                    string[] splits = linea.Split(',');
                    if (splits.Length >= 4)
                    {
                        cadeteria.AltaCadete(Convert.ToInt32(splits[0]), splits[1], splits[2], splits[3]);
                    }
                }
            }
        }
    }

    public class AccesoDatos
    {
        public List<string[]> ObtenerDatos (string rutaArchivo)
        {
            var datos = new List<string[]>();
            string[] lineas = File.ReadAllLines(rutaArchivo);
            foreach (var linea in lineas)
            {
                var lineaDatos = linea.Split(',');
                datos.Add(lineaDatos);
            }
            return datos;
        }
    }

}