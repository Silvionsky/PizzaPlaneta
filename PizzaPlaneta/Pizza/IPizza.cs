using System.Collections.Generic;

namespace PizzaPlaneta.Pizza
{
	public interface IPizza
	{
		string GetIngredientes();

		List<IPizza> GetComponentes();

		string GetNombre();

		double GetPrecioTotal();

		double GetPrecio();
	}
}
