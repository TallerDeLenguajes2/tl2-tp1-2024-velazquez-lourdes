namespace proyectoCadeteria
{
    enum Estado 
    {
        pendiente, 
        aceptado, 
        cancelado 
    }
    public class Pedido
    {
        private int nroPedido;
        private string? observaciones;
        private Cliente cliente;
        private Estado estado;

        public Pedido(string nombreCliente, string direccionCliente, string telefonoCliente, string referencia, string obsPedido)
        {
            NroPedido++;
            Estado = Estado.pendiente;
            cliente = new Cliente (nombreCliente, direccionCliente, telefonoCliente, referencia);
            Observaciones = obsPedido;
        }

        public Pedido (Cliente cliente, string obsPedido)
        {
            NroPedido++;
            Estado = Estado.pendiente;
            this.cliente = cliente;
            Observaciones = obsPedido;
        }

        public int NroPedido { get => nroPedido; set => nroPedido = value; }
        public string? Observaciones { get => observaciones; set => observaciones = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        internal Estado Estado { get => estado; set => estado = value; }

        public void VerDireccionCliente ()
        {
            Console.WriteLine($"La direccion del cliente es: {Cliente.Direccion1}");
        }

        public void VerDatosCliente()
        {
            Console.WriteLine("\n Datos del cliente: \n");
            Console.WriteLine($"\n Nombre: {Cliente.Nombre1} \n");
            Console.WriteLine($"\n Direccion: {Cliente.Direccion1} \n");
            Console.WriteLine($"\n Telefono: {Cliente.Telefono1} \n");
            Console.WriteLine($"\n Referencia de la direccion {Cliente.DatosReferenciaDireccion1} \n");
        }

        public void CambiarEstadoCancelar ()
        {
            Estado = Estado.cancelado;
        }

        public void CambiarEstadoEntregado()
        {
            Estado = Estado.aceptado;
        }
    }
}