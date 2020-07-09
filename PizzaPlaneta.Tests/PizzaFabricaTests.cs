using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaPlaneta.Fabrica;
using PizzaPlaneta.Ingredientes;
using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Tests
{
	[TestClass]
	public class PizzaFabricaTests
	{
		[TestMethod]
		public void CrearPizza_CrearPizzaPequena_SeCreaUnaPizzaPequena()
		{
			// Arrange
			string tamano = "pequena";

			// Act
			IPizza pizza = PizzaFabrica.CrearPizza(null, tamano);

			// Assert

			Assert.AreEqual(tamano, pizza.GetNombre());
		}

		[TestMethod]
		public void CrearPizza_CrearPizzaPequenaConJamon_SeCreaUnaPizzaPequena()
		{
			// Arrange
			string tamano = "pequena";
			string ingrediente = "jamon";
			string ingredientes = "pequena, Jamón";
			// Act
			IPizza pizza = PizzaFabrica.CrearPizza(null, tamano);
			pizza = PizzaFabrica.CrearPizza(pizza, ingrediente);

			// Assert

			Assert.IsTrue(ingredientes.Equals(pizza.GetIngredientes()));
		}
	}
}
