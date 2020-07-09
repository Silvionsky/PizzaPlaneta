using PizzaPlaneta.Ordenes;

namespace PizzaPlaneta.CalculoPrecio
{
	public class IvaEstrategiaCalcularPrecio : IEstrategiaCalcularPrecio
	{
		public const double IVA = 13;

		public double ObtenerPrecioTotal(Orden orden)
		{
			double precioTotal = orden.pizza.GetPrecioTotal();
			precioTotal += (precioTotal * (IVA / 100));

			return precioTotal;
		}
	}
}
