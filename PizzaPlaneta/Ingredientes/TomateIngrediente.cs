using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class TomateIngrediente : PizzaIngrediente
	{
		public TomateIngrediente(IPizza pizza) : base(pizza, "Tomate")
		{
			this.precio = 500;
		}
	}
}
