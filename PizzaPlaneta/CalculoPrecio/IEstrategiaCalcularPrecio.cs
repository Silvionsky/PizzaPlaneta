using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlaneta.CalculoPrecio
{
	interface IEstrategiaCalcularPrecio
	{
		double ObtenerPrecioTotal();
	}
}
