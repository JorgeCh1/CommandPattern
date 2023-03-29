
namespace Patrones.Command.Core
{
    public class BajaStockCommand : OrdenCommand
    {
        // Constructor para realiazar la agregación
        public BajaStockCommand(ProductoReceiver producto, double cantidad) : base(producto, cantidad)
        {
        }

        public override void Ejecutar()
        {
            _producto.RestarStock(_cantidad);
        }
    }
}