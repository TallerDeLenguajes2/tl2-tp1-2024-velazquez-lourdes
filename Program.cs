using proyectoCadeteria;
internal class Program
{
    private static void Main(string[] args)
    {
       // D:\Users\Lourdes Velazquez\Desktop\LOURDES I\FACULTAD\INGENIERIA  INFORMATICA\TALLER 2\PRACTICO 1\tp1\Cadeteria.csv
        Cadeteria cad = new Cadeteria();
        AccesoDatosCSV datos = new AccesoDatosCSV();
        cad =  datos.GetCadeteria("Cadeteria.csv");
        Console.WriteLine(cad.NombreCadeteria);
        Console.WriteLine(cad.TelefonoCadeteria);
        AccesoDatos datoss = new AccesoDatos();
        List<string[]> datosCadeteria = datoss.ObtenerDatos("Cadeteria.csv");
    }

}