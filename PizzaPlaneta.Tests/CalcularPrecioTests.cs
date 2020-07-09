using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaPlaneta.Fabrica;
using PizzaPlaneta.Pizza;
using PizzaPlaneta.CalculoPrecio;
using PizzaPlaneta.Ordenes;

namespace PizzaPlaneta.Tests
{
	[TestClass]
	public class CalcularPrecioTests
	{
		[TestMethod]
		public void ObtenerPrecioTotal_PrecioRegularOrdenPizzaPequenaConJamonYHongos_DevuelveElMontoCorrecto()
		{
			// Arrange
			IPizza pizza = PizzaFabrica.CrearPizza(null, "pequena");
			pizza = PizzaFabrica.CrearPizza(pizza, "jamon");
			pizza = PizzaFabrica.CrearPizza(pizza, "hongos");
			double precioTotalEsperado = pizza.GetPrecioTotal();

			Orden orden = new Orden(pizza, "Avenida Central");

			CalcularPrecio calculoPrecio = new CalcularPrecio();
			calculoPrecio.estrategia = new RegularEstrategiaCalcularPrecio();

			// Act
			double precioTotal = calculoPrecio.ObtenerPrecioTotal(orden);

			// Assert

			Assert.AreEqual(precioTotal, precioTotalEsperado);
		}

		[TestMethod]
		public void ObtenerPrecioTotal_PrecioConIvaOrdenPizzaPequenaConJamonYHongos_DevuelveElMontoCorrecto()
		{
			// Arrange
			IPizza pizza = PizzaFabrica.CrearPizza(null, "pequena");
			pizza = PizzaFabrica.CrearPizza(pizza, "jamon");
			pizza = PizzaFabrica.CrearPizza(pizza, "hongos");
			double precioTotalEsperado = pizza.GetPrecioTotal();
			precioTotalEsperado += (precioTotalEsperado * (IvaEstrategiaCalcularPrecio.IVA / 100));

			Orden orden = new Orden(pizza, "Avenida Central");

			CalcularPrecio calculoPrecio = new CalcularPrecio();
			calculoPrecio.estrategia = new IvaEstrategiaCalcularPrecio();

			// Act
			double precioTotal = calculoPrecio.ObtenerPrecioTotal(orden);

			// Assert

			Assert.AreEqual(precioTotal, precioTotalEsperado);
		}
	}
}
