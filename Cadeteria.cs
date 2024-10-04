namespace proyectoCadeteria
{
    public class Cadeteria
    {
        private string nombreCadeteria;
        private string telefonoCadeteria;
        private List<Cadete> listaCadetes;

        private List<Pedido> listaPedido;

        public string NombreCadeteria { get => nombreCadeteria; set => nombreCadeteria = value; }
        public List<Cadete> ListaCadetes { get => listaCadetes; set => listaCadetes = value; }
        public string TelefonoCadeteria { get => telefonoCadeteria; set => telefonoCadeteria = value; }

        public Cadeteria(){}
        public Cadeteria(string nombreCad, string telCade)
        {
            this.NombreCadeteria = nombreCad;
            this.TelefonoCadeteria = telCade;
            listaCadetes = new List<Cadete>();
            listaPedido = new List<Pedido>();

        }

        private float JornalCadete (int CadeteId)
        {
            float totalPago = 0;
            foreach (var cadete in listaCadetes)
            {
                if (cadete.Id == CadeteId)
                {
                    totalPago = cadete.EstadoPedido() * 500;
                }
            }
            return totalPago;
        }


        public void AltaCadete ( int id, string nombreCadete, string direccionCadete, string telefonoCadete)
        {
            var nuevoCadete = new Cadete (id, nombreCadete, direccionCadete, telefonoCadete);
            listaCadetes.Add(nuevoCadete);
        } 

        public void AltaPedido (string nombreCliente, string direccionCliente, string telefonoCliente, string referencia, string obsPedido)
        {
            Cliente nuevoCliente = new Cliente(nombreCliente, direccionCliente, telefonoCliente, referencia );
            Pedido nuevoPedido = new Pedido(nuevoCliente, obsPedido);
        }

        private Cadete BuscarCadeteID (int idCadete)
        {
            var cadete = this.listaCadetes.FirstOrDefault(cadete => cadete.Id == idCadete);
            return cadete;
        }

        private Pedido BuscarPedidoNro (int NroPedido)
        {
            var pedido = this.listaPedido.FirstOrDefault(pedido => pedido.NroPedido == NroPedido);
            return pedido;
        }
        public void AsignarPedidoCadete(int idCadete, int NroPedido)
        {       
            var cadete = BuscarCadeteID(idCadete);
            var pedido = BuscarPedidoNro(NroPedido);
            cadete.AgregarPedido(pedido);
        }

        public void EliminarPedidoCadete (int idCadete, int NroPedio)
        {
            var cadete = BuscarCadeteID(idCadete);
            var pedido = BuscarPedidoNro(NroPedio);
            cadete.EliminarPedido(pedido);
        }
        public void ReasignarPedidoCadete (int idCadete1, int idCadete2, int NroPedido)
        {
            var cadete1 = BuscarCadeteID(idCadete1);
            var pedido = BuscarPedidoNro(NroPedido);
            cadete1.EliminarPedido(pedido);
            var cadete2 = BuscarCadeteID(idCadete2);
            cadete2.AgregarPedido(pedido);
        }

     /*   public Cadete CadeteporId (int IDcadete)
        {
            return 
        }*/
      /*  public void CargarDatosCadeteria (string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    var linea = sr.ReadLine();
                    var valores = linea.Split(',');
                    this.NombreCadeteria = valores[0];
                    this.TelefonoCadeteria = valores[1];
                }
            }
        }*/
        
    }
}