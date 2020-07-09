using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlaneta.Pizza
{
	public class PizzaBasica : IPizza
	{
		private string tamano;
		
		public PizzaBasica(string tamano)
		{
			this.tamano = tamano;
		}

		public string GetIngredientes()
		{
			return this.tamano;
		}

		public List<IPizza> GetComponentes()
		{
			List<IPizza> componentes = new List<IPizza>();
			componentes.Add(this);
			return componentes;
		}

		public double GetPrecio()
		{
			double precio = 0.0;
			switch (this.tamano)
			{
				case "pequena":
					precio = 1.0;			
					break;
				case "mediana":
					precio = 2.5;
					break;
				case "grande":
					precio = 5.0;
					break;
			}

			return precio;
		}

		public double GetPrecioTotal()
		{
			return GetPrecio();
		}

		public string GetNombre()
		{
			return tamano;
		}

	}
}
