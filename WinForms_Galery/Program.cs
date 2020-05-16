using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Galery
{
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
            Application.Run(new Form1());

            Galery galeryForm = new Galery();
            galeryForm.galery.Add(new Node(new Bitmap(Properties.Resources.image1), "картинка 1"));
            galeryForm.galery.Add(new Node(new Bitmap(Properties.Resources.image2), "картинка 2"));
            galeryForm.galery.Add(new Node(new Bitmap(Properties.Resources.image3), "картинка 3"));
        }
    }
}
