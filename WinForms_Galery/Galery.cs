using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Galery
{
    public class Node
    {
        public Bitmap bitmap { get; }

        public string visibleText { get; }

        public string  text = "";

        public Node() { }

        public Node(Bitmap bitmap, string visibleText)
        {
            this.bitmap = bitmap;
            this.visibleText = visibleText;
        }
    }

    class Galery : HoverButton
    {
        private int i = 0;

        List<Node> galery = new List<Node>();

        public Galery() : base()
        {
            galery.Add(new Node(new Bitmap(Properties.Resources.image1), "картинка 1"));
            galery.Add(new Node(new Bitmap(Properties.Resources.image2), "картинка 2"));
            galery.Add(new Node(new Bitmap(Properties.Resources.image3), "картинка 3"));
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            galery[i].text = galery[i].visibleText;

        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            galery[i].text = "";
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.DrawImage(galery[i].bitmap, 0, 0);
            
            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            
            pevent.Graphics.DrawString(galery[i].text, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            i++;
            
            if (i > galery.Count - 1)
                i = 0;
        }
    }
}
