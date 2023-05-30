using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusPark
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WebInteraction.SetCreneditials("shurik120304@yandex.ru", "wswbilsweutkxnaz");

            Application.Run(new EnterForm());
        
        }
    }
}
