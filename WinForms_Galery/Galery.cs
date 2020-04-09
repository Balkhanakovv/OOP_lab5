using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Galery
{
    class Galery : HoverButton
    {
        private Bitmap bitmap = new Bitmap(Properties.Resources.image1); 
        
        private int i = 1;

        private string text = "";

        public Galery()
        {
            
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            switch (i)
            {
                case 1:
                    text = "Картинка 1";
                    break;

                case 2:
                    text = "Картинка 2";
                    break;

                case 3:
                    text = "Картинка 3";
                    break;
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            text = "";
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            switch (i)
            {
                case 1:
                    bitmap = new Bitmap(Properties.Resources.image1);
                    break;

                case 2:
                    bitmap = new Bitmap(Properties.Resources.image2);
                    break;

                case 3:
                    bitmap = new Bitmap(Properties.Resources.image3);
                    break;
            }
                
            pevent.Graphics.DrawImage(bitmap, 0, 0);
            
            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            
            pevent.Graphics.DrawString(text, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            i++;
            
            if (i > 3)
                i = 1;
        }
    }
}
