using PizzaPlaneta.Pizza;
using PizzaPlaneta.Ingredientes;

namespace PizzaPlaneta.Fabrica
{
	public static class PizzaFabrica
	{
		public static IPizza CrearPizza(IPizza pizza, string nombre)
		{
			switch (nombre)
			{
				case "pequena":

				case "mediana":

				case "grande":
					return new PizzaBasica(nombre);
					break;
				case "masaclasica":
					return new MasaClasicaIngrediente(pizza);
					break;
				case "masaartesanal":
					return new MasaArtesanalIngrediente(pizza);
					break;
				case "queso":
					return new QuesoIngrediente(pizza);
					break;
				default:
					return null;
					break;
			}
		}
	}
}
