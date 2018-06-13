using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movies
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form welcome = new Welcome();
            Form1 views = new Form1();
            Controller controlador = new Controller(views);
            Application.Run(welcome);

            Application.Run(views);
        }
    }
}
