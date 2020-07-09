using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlaneta.Pizza;
using PizzaPlaneta.Fabrica;
using Microsoft.AspNetCore.Mvc;
using PizzaPlanenta.Utilidades;
using PizzaPlaneta.Ordenes;

namespace PizzaPlaneta.Pages
{
	public class CrearPizzaModel : PageModel
	{	
		[BindProperty] public string tamano { set; get; }

		[BindProperty] public string masa { set; get; }

		[BindProperty] public List<string> ingredientes { set; get; }

		[BindProperty] public string direccion { set; get; }

		public void OnPost()
		{

		}
	}
}
