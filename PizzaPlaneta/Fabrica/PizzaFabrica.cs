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
				case "hongos":
					return new HongosIngrediente(pizza);
					break;
				case "tomate":
					return new TomateIngrediente(pizza);
					break;
				case "albahaca":
					return new AlbahacaIngrediente(pizza);
					break;
				case "jamon":
					return new JamonIngrediente(pizza);
					break;
				case "carne":
					return new CarneIngrediente(pizza);
					break;
				case "salchicha":
					return new SalchichaIngrediente(pizza);
					break;
				default:
					return null;
					break;
			}
		}
	}
}
