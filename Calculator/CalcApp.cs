////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////
///name     date        description
///baint    1-22-19     calculator program created
///baint    1-24-19     layout for calc created
///baint    1-29-19     operators created
///baint    2-1-19      decimal functionality created

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class CalcApp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
