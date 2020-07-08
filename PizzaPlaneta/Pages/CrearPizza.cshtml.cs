using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlaneta.Pizza;
using PizzaPlaneta.Fabrica;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PizzaPlaneta.Pages
{
	public class CrearPizzaModel : PageModel
	{	
		[BindProperty] public string tamano { set; get; }

		[BindProperty] public string masa { set; get; }

		[BindProperty] public List<string> ingredientes { set; get; }

		[BindProperty] public string direccion { set; get; }

		public ActionResult OnPost()
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

			double costoTotal = pizza.GetPrecioTotal();
			string ingredientesTotal = pizza.GetIngredientes();
		

			return Page();
		}
	}
}
