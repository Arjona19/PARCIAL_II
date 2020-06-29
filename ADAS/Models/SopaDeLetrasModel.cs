using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADAS.Models
{
    public class SopaDeLetrasModel
    {
        public SopaDeLetrasModel()
        {

        }

        public SopaDeLetrasModel(string[] sopas_filas)
        {
            this.sopas_filas = sopas_filas;
        }

        public int filas { get; set; }
        public int columnas { get; set; }
        public int NumeroDePalabrasBuscar { get; set; }
        public string[] sopas_filas { get; set; }
        public string[] palabras { get; set; }
        public ListaBuscarModel[] listaPalabras { get; set; }
    }
}