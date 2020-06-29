using ADAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADAS.Controllers
{
    public class SopaDeLetrasController : Controller
    {
        // GET: SopaDeLetas
        private static SopaDeLetrasModel Model;
        private static string[] sopa_filas;
        public SopaDeLetrasController()
        {
            Model = new SopaDeLetrasModel();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult setarreglo(SopaDeLetrasModel model)
        {
            sopa_filas = model.sopas_filas;
            Model.palabras = new string[model.NumeroDePalabrasBuscar];
            return View(Model);
        }
        public ActionResult setpalabras(SopaDeLetrasModel model)
        {
            Model.listaPalabras = new ListaBuscarModel[Convert.ToInt32(model.palabras.Length)];
            for (int i = 0; i < model.palabras.Length; i++)
            {
                Model.listaPalabras[i] = new ListaBuscarModel(model.palabras[i]);
            }
            // Proceso de búsqueda.
            foreach (ListaBuscarModel objetivos in Model.listaPalabras)
            {
                // Buscar para cada uno de los 8 posibles sentidos.
                for (int fila_actual = 0; fila_actual < sopa_filas.Length; fila_actual++)
                {
                    for (int col_actual = 0; col_actual < sopa_filas[fila_actual].Length; col_actual++)
                    {
                        for (int incx = -1; incx < 2; incx++)
                        {
                            for (int incy = -1; incy < 2; incy++)
                            {
                                if (!(incx == 0 && incy == 0))
                                {
                                    if (buscar_palabra(objetivos.palabra(), fila_actual, col_actual, incx, incy))
                                    {
                                        objetivos.encontrada();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return View(Model);
        }
        public ActionResult arreglo(SopaDeLetrasModel model)
        {
            Model.columnas = model.columnas;
            Model.filas = model.filas;
            Model.sopas_filas = new string[Model.filas];
            return View(Model);
        }

        public bool buscar_palabra(string palabra, int xinicial, int yinicial, int inc_x, int inc_y)
        {
            bool retorno = false;
            bool seguir = true;
            int iteraciones = 0;

            while (seguir)
            {
                if (xinicial < 0 || yinicial < 0 || xinicial + 1 > sopa_filas.Length || yinicial + 1 > sopa_filas[0].Length)
                {
                    seguir = false;
                }
                else
                {
                    if (palabra.Substring(iteraciones, 1) == sopa_filas[xinicial].Substring(yinicial, 1))
                    {
                        iteraciones++;
                        xinicial += inc_x;
                        yinicial += inc_y;
                        if (iteraciones == palabra.Length) // Hemos encontrado una coincidencia.
                        {
                            retorno = true;
                            seguir = false;
                        }
                    }
                    else
                    {
                        seguir = false;
                    }
                }
            }

            return retorno;

        }
    }
}