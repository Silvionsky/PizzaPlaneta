using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class SalchichaIngrediente : PizzaIngrediente
	{
		public SalchichaIngrediente(IPizza pizza) : base(pizza, "Carne")
		{
			this.precio = 0.3;
		}
	}
}
