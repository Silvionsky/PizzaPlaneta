using PizzaPlaneta.Ordenes;

namespace PizzaPlaneta.CalculoPrecio
{
	public class RegularEstrategiaCalcularPrecio : IEstrategiaCalcularPrecio
	{
		public double ObtenerPrecioTotal(Orden orden)
		{
			return orden.pizza.GetPrecioTotal();
		}
	}
}
