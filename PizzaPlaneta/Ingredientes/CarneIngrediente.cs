using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class CarneIngrediente : PizzaIngrediente
	{
		public CarneIngrediente(IPizza pizza) : base(pizza, "Carne")
		{
			this.precio = 1500;
		}
	}
}
