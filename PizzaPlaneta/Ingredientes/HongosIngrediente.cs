using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class HongosIngrediente : PizzaIngrediente
	{
		public HongosIngrediente(IPizza pizza) : base(pizza, "hongos")
		{
			this.precio = 0.6;
		}
	}
}
