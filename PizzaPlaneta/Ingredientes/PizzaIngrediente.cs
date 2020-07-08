using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public abstract class PizzaIngrediente : IPizza
	{
		private IPizza pizza;
		private string nombre;
		private double precio;

		public PizzaIngrediente(IPizza pizza, string nombre)
		{
			this.pizza = pizza;
			this.nombre = nombre;
		}

		public string GetIngredientes()
		{
			return pizza.GetIngredientes() + ", " + nombre;
		}

		public double GetPrecio()
		{
			return this.precio;
		}
		public double GetPrecioTotal()
		{
			return pizza.GetPrecioTotal() + GetPrecio();
		}
	}
}
