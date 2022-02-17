using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Navigation
    {
        public bool? abrirNuevaVentana()
        {
            Nueva ventana = new Nueva();
            return ventana.ShowDialog();
        }
    }
}
