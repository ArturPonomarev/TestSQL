using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQL
{
    interface ISort
    {
        void Sort();
    }

    class AutomobileSort
        :ISort
    {
        public void Sort()
        {

        }
    }

    class OrderSort
        :ISort
    {
        public void Sort()
        {

        }
    }

    class ClientSort
        : ISort
    {
        public void Sort()
        {

        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


    }
}
