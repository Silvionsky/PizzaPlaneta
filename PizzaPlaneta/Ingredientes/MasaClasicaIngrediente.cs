using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class MasaClasicaIngrediente : PizzaIngrediente
	{
		public MasaClasicaIngrediente(IPizza pizza): base(pizza, "masaclasica")
		{
			this.precio = 2.0;
		}
	}
}
