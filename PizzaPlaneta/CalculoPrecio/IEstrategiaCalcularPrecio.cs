using PizzaPlaneta.Ordenes;

namespace PizzaPlaneta.CalculoPrecio
{
	public interface IEstrategiaCalcularPrecio
	{
		double ObtenerPrecioTotal(Orden orden);
	}
}
