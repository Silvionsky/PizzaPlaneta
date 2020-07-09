using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlaneta.Fabrica;
using PizzaPlaneta.Ordenes;
using PizzaPlaneta.Pizza;
using System.Collections.Generic;
using PizzaPlaneta.CalculoPrecio;

namespace PizzaPlaneta.Pages
{
	public class VerOrdenModel : PageModel
    {
		[BindProperty] public string tamano { set; get; }

		[BindProperty] public string masa { set; get; }

		[BindProperty] public List<string> ingredientes { set; get; }

		[BindProperty] public string direccion { set; get; }

		[BindProperty] public double precioConIva { set; get; }

		[BindProperty] public double precioRegular { set; get; }

		public void OnPost()
		{	
			List<string> pedido = new List<string>();
			pedido.Add(tamano);
			pedido.Add(masa);
			pedido.AddRange(ingredientes);

			IPizza pizza = null;
			foreach (string nombre in pedido)
			{
				pizza = PizzaFabrica.CrearPizza(pizza, nombre);
			}

			Orden nuevaOrden = new Orden(pizza, direccion);

			CalcularPrecio calculadora = new CalcularPrecio();

			calculadora.estrategia = new RegularEstrategiaCalcularPrecio();
			precioRegular = calculadora.ObtenerPrecioTotal(nuevaOrden);

			calculadora.estrategia = new IvaEstrategiaCalcularPrecio();
			precioConIva = calculadora.ObtenerPrecioTotal(nuevaOrden);
		}

		public void OnPostAceptar()
		{
			// TODO: Set mensaje de confirmacion y redireccionar a CrearPizza
		}

		public void OnPostCancelar()
		{
			// TODO: Regresar a CrearPizza para realizar modificaciones
		}
	}
}