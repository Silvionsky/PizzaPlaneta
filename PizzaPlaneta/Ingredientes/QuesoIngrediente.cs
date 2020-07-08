using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class QuesoIngrediente : PizzaIngrediente
	{
		public QuesoIngrediente(IPizza pizza) : base(pizza, "queso")
		{
			this.precio = 0.3;
		}
	}
}
