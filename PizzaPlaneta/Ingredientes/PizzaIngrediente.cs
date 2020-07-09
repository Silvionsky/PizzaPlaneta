using PizzaPlaneta.Pizza;
using System.Collections.Generic;

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

		public List<IPizza> GetComponentes()
		{
			List<IPizza> componentes = pizza.GetComponentes();
			componentes.Add(this);
			return componentes;
		}

		public double GetPrecio()
		{
			return precio;
		}

		public double GetPrecioTotal()
		{
			return pizza.GetPrecioTotal() + GetPrecio();
		}

		public string GetNombre()
		{
			return nombre;
		}
	}
}
