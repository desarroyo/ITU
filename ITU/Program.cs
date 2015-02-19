using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VentanaPrincipal vp = new VentanaPrincipal();

           

            // Request that oThread be stopped
            //oThread.Abort();

            // Wait until oThread finishes. Join also has overloads
            // that take a millisecond interval or a TimeSpan object.
            //oThread.Join();

            //Console.WriteLine();
            //Console.WriteLine("Alpha.Beta has finished");

            Application.Run(vp);

        }
    }
}
