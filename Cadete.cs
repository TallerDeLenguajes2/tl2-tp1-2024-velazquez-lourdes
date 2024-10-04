namespace proyectoCadeteria
{
    public class Cadete
    {
        private int id;
        private string nombreCadete;
        private string direccionCadete;
        private string telefonoCadete;
        private List<Pedido> listaPedidos;

        public string NombreCadete { get => nombreCadete; set => nombreCadete = value; }
        public string DireccionCadete { get => direccionCadete; set => direccionCadete = value; }
        public string TelefonoCadete { get => telefonoCadete; set => telefonoCadete = value; }
        public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
        public int Id { get => id; set => id = value; }

        public Cadete(int id, string nombre, string direccion, string telefono)
        {
            // Agregar control control para datos vacios y nulos
            Id = id;
            NombreCadete = nombre;
            DireccionCadete = direccion;
            this.telefonoCadete = telefono;
            ListaPedidos =  new List<Pedido> () ;  
        }

        public int EstadoPedido ()
        {
            int cont = 0;
            foreach (var pedido in listaPedidos )
            {
                if (pedido.Estado == Estado.aceptado)
                {
                    cont+=1;
                }
            }
            return cont;
        }

        public void AgregarPedido(Pedido pedido)
        {
            listaPedidos.Add(pedido);
        }

        public void EliminarPedido (Pedido pedido)
        {
            listaPedidos.Remove(pedido);
        }
                

    }
}