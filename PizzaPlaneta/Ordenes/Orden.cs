using PizzaPlaneta.Pizza;

namespace PizzaPlaneta.Ordenes
{
	public class Orden
	{
		public IPizza pizza { get; set; }
		public string direccion { get; set; }

		public Orden(IPizza pizza, string direccion)
		{
			this.pizza = pizza;
			this.direccion = direccion;
		}
	}
}
