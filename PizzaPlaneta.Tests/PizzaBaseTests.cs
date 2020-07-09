using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaPlaneta.Fabrica;
using PizzaPlaneta.Pizza;
using PizzaPlaneta.CalculoPrecio;
using PizzaPlaneta.Ordenes;

namespace PizzaPlaneta.Tests
{
	[TestClass]
	public class PizzaBasicaTests
	{
		[TestMethod]
		public void GetPrecio_SeCreaUnaPizzaPequena_DevuelveElPrecioEsperado()
		{
			// Arrange
			double precioEsperado = 3500;
			IPizza pizza = PizzaFabrica.CrearPizza(null, "pequena");
		

			// Act
			double precio = pizza.GetPrecio();

			// Assert

			Assert.AreEqual(precioEsperado, precio);
		}

		[TestMethod]
		public void GetPrecio_SeCreaUnaPizzaMediana_DevuelveElPrecioEsperado()
		{
			// Arrange
			double precioEsperado = 5000;
			IPizza pizza = PizzaFabrica.CrearPizza(null, "mediana");


			// Act
			double precio = pizza.GetPrecio();

			// Assert

			Assert.AreEqual(precioEsperado, precio);
		}

		[TestMethod]
		public void GetPrecio_SeCreaUnaPizzaGrande_DevuelveElPrecioEsperado()
		{
			// Arrange
			double precioEsperado = 9000;
			IPizza pizza = PizzaFabrica.CrearPizza(null, "grande");


			// Act
			double precio = pizza.GetPrecio();

			// Assert

			Assert.AreEqual(precioEsperado, precio);
		}
	}
}
