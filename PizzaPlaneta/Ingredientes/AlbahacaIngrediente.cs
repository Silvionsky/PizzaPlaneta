using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class AlbahacaIngrediente : PizzaIngrediente
	{
		public AlbahacaIngrediente(IPizza pizza) : base(pizza, "Albahaca")
		{
			this.precio = 400;
		}
	}
}
