using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Galery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            galery1.galery.Add(new Node(new Bitmap(Properties.Resources.image1), "картинка 1"));
            galery1.galery.Add(new Node(new Bitmap(Properties.Resources.image2), "картинка 2"));
            galery1.galery.Add(new Node(new Bitmap(Properties.Resources.image3), "картинка 3"));

            galeryCircle1.galery.Add(new Node(new Bitmap(Properties.Resources.image1), "круг 1"));
            galeryCircle1.galery.Add(new Node(new Bitmap(Properties.Resources.image2), "круг 2"));
            galeryCircle1.galery.Add(new Node(new Bitmap(Properties.Resources.image3), "круг 3"));
        }
    }
}
