using PizzaPlaneta.Ordenes;

namespace PizzaPlaneta.CalculoPrecio
{
	interface IEstrategiaCalcularPrecio
	{
		double ObtenerPrecioTotal(Orden orden);
	}
}
