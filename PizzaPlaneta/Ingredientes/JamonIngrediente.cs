using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class JamonIngrediente : PizzaIngrediente
	{
		public JamonIngrediente(IPizza pizza) : base(pizza, "Jamón")
		{
			this.precio = 0.5;
		}
	}
}
