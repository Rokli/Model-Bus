using BusCurs.Model;
using BusCurs.Presenter;
using BusCurs.View.CLass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusCurs
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
            SaveLoad saveload = new SaveLoad();
            MyVIew view = new MyVIew(saveload);
            MyPresenter presenter = new MyPresenter(view);
            Application.Run(view);
        }
    }
}
