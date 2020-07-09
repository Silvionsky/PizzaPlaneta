using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class MasaClasicaIngrediente : PizzaIngrediente
	{
		public MasaClasicaIngrediente(IPizza pizza): base(pizza, "Masa clasica")
		{
			this.precio = 2000;
		}
	}
}
