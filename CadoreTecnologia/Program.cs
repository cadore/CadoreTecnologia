using CadoreTecnologia.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadoreTecnologia
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
            LoginForm lf = new LoginForm();
            DialogResult rs = lf.ShowDialog();
            if(rs == DialogResult.OK)
                Application.Run(new DesktopForm());
        }
    }
}
