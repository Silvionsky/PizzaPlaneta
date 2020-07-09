using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public class MasaArtesanalIngrediente : PizzaIngrediente
	{
		public MasaArtesanalIngrediente(IPizza pizza) : base(pizza, "Masa artesanal")
		{
			this.precio = 3000;
		}
	}
}
