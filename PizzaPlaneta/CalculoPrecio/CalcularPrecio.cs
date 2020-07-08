using PizzaPlaneta.Ordenes;

namespace PizzaPlaneta.CalculoPrecio
{
	public class CalcularPrecio
	{
		public IEstrategiaCalcularPrecio estrategia { set; get; }

		public double ObtenerPrecioTotal(Orden orden)
		{
			return estrategia.ObtenerPrecioTotal(orden);
		}

	}
}
