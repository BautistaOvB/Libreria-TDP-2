using Gestion_Libreria.Presentacion;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Libreria
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo culturaArgentina = new CultureInfo("es-AR");
            Thread.CurrentThread.CurrentCulture = culturaArgentina;
            Thread.CurrentThread.CurrentUICulture = culturaArgentina;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

    }
}
