using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class QuesoIngrediente : PizzaIngrediente
	{
		public QuesoIngrediente(IPizza pizza) : base(pizza, "Queso")
		{
			this.precio = 300;
		}
	}
}
