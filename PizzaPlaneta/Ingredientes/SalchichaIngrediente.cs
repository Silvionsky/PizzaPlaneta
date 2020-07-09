using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class SalchichaIngrediente : PizzaIngrediente
	{
		public SalchichaIngrediente(IPizza pizza) : base(pizza, "Salchicha")
		{
			this.precio = 700;
		}
	}
}
