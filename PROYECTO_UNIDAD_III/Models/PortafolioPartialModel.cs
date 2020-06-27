using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using PROYECTO_UNIDAD_III;

namespace PROYECTO_UNIDAD_III.Models
{
    public class PortafolioPartialModel : Portafolio
    {
        public byte[] GetByte64File
        {
            get {
                byte[] fileInBytes = new byte[this.Fotos64.ContentLength];
                using (BinaryReader theReader = new BinaryReader(this.Fotos64.InputStream))
                {
                    fileInBytes = theReader.ReadBytes(this.Fotos64.ContentLength);
                }
                return fileInBytes;
            }
            set { }
        }
        public HttpPostedFileBase Fotos64 { get; set; }
    }
}