using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ingredientes
{
	public abstract class PizzaIngrediente : IPizza
	{
		protected IPizza pizza;
		protected string nombre;
		protected double precio;

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
