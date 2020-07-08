using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class MasaArtesanalIngrediente : PizzaIngrediente
	{
		public MasaArtesanalIngrediente(IPizza pizza) : base(pizza, "masaartesanal")
		{
			this.precio = 3.0;
		}
	}
}
