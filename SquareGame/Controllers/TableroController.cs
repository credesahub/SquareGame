using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SquareGame.Controllers
{
    public class TableroController : Controller
    {
        // GET: Tablero
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mejorado()
        {
            return View();
        }
        // Método de nombre Bienvenida, que no recibe parámetros y retorna una variable de tipo string, en este caso devolverá un string con etiquetas HTML en su contenido
        public string Bienvenida(string id)
        {
            return "<h1> Hola Mundo" + id + "</h1>";
        }
    }
}