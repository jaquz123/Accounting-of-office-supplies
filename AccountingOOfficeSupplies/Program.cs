using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALBD
{
    internal static class Program
    {
        public const string ConnectionString =
            "server=MySql-8.2;username=root;password=;database=AccounitgProduct";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autorization());


        }
        
    }
}
