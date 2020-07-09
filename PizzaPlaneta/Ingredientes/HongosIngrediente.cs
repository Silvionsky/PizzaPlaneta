using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class HongosIngrediente : PizzaIngrediente
	{
		public HongosIngrediente(IPizza pizza) : base(pizza, "Hongos")
		{
			this.precio = 950;
		}
	}
}
