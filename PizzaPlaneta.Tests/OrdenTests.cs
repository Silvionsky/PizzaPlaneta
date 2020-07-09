using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaPlaneta.Fabrica;
using PizzaPlaneta.Pizza;
using PizzaPlaneta.CalculoPrecio;
using PizzaPlaneta.Ordenes;

namespace PizzaPlaneta.Tests
{
	[TestClass]
	public class OrdenTests
	{
		[TestMethod]
		public void GetDireccion_SeCreaUnaNuevaOrden_DevuelveLaDireccionCorrecta()
		{
			// Arrange
			IPizza pizza = PizzaFabrica.CrearPizza(null, "pequena");
			string direccionEsperada = "Avenida Central";
			Orden orden = new Orden(pizza, direccionEsperada);

			// Act
			string direccionOrden = orden.direccion;

			// Assert

			Assert.AreEqual(direccionEsperada, direccionOrden);
		}

		[TestMethod]
		public void GetPizza_SeCreaUnaNuevaOrden_DevuelveLaMismaPizza()
		{
			// Arrange
			IPizza pizzaEsperada = PizzaFabrica.CrearPizza(null, "pequena");
			Orden orden = new Orden(pizzaEsperada, "Avenida Central");

			// Act
			IPizza pizzaDevuelta = orden.pizza;

			// Assert

			Assert.AreEqual(pizzaDevuelta, pizzaEsperada);
		}
	}
}
