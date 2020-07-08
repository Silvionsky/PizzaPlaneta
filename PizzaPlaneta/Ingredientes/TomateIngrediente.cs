using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class TomateIngrediente : PizzaIngrediente
	{
		public TomateIngrediente(IPizza pizza) : base(pizza, "tomate")
		{
			this.precio = 0.1;
		}
	}
}
