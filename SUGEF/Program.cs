using SUGEF.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SUGEF
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConnectDB connection = new ConnectDB();
            if (connection.Connect())
            {
                Application.Run(new LoginForm());
            }
            else
            {
            MessageBox.Show("Não foi possível conectar-se ao banco, portanto, o App não será inicializado! Entre em contato com o desenvolvedor!!!",
             "Erro de conexão!",
             MessageBoxButtons.OK,
             MessageBoxIcon.Error);
            }
         

        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
