using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsApp11
{

    public struct formSize
    {
        public float x;
        public float y;
        public float width;
        public float height;
    }

    public enum DrawType { pen=0, circle=1,square=2};

    public partial class Form1 : Form
    {
        private bool        isMousePressed = false;
        private Graphics    graphics = null;
        private int         tempX = 0;
        private int         tempY = 0;

        private int startX = 0;
        private int startY = 0;

        private int _x, _y;

        private Color       color = Color.Black;
        private SolidBrush  brush = new SolidBrush(Color.Black);

        private Pen         pen;

        private Pen         eraser;

        private Graphics    gCache = null;

        private formSize    frmSize;

        private DrawType    drawType = new DrawType();

        private Rectangle   drawingRectangle;

        private Image image;
        

        public Form1()
        {
            InitializeComponent();

            this.pCanvas.Image = new Bitmap(this.pCanvas.ClientSize.Width,this.pCanvas.ClientSize.Height);
            this.graphics = Graphics.FromImage(this.pCanvas.Image);
            this.gCache = this.pCanvas.CreateGraphics();
           // this.gCache = Graphics.FromImage(this.pCanvas.Image);


            //this.graphics.CopyFromScreen()

            this.pen = new Pen(this.brush);
            this.eraser = new Pen(new SolidBrush(Color.White));
            this.drawType = DrawType.pen;
            /*Color color = new Color();
            color.
            SolidBrush brush = new SolidBrush();*/
        }

        private void pCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            //nastavime stav kde bola stlacena mys
            if (!isMousePressed)
            {

                this.startX = e.X;
                this.startY = e.Y;
            }

            tempX = e.X;
            tempY = e.Y;
            isMousePressed = true;

           // this.graphics.FillRectangle(brush, new Rectangle(e.X, e.Y, 1, 1));
        }

        private void pCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePressed = false;

           // this.graphics.FillRectangle(brush, new Rectangle(e.X, e.Y, 1, 1));
        }

        private void pCanvas_MouseMove(object sender, MouseEventArgs e)
        {
           /* this._x = e.X;
            this._y = e.Y;
            return;*/
            if (!isMousePressed) return;

            int x = e.X;
            int y = e.Y;

            switch (drawType)
            {
                case DrawType.pen:
                    //this.pCanvas.Image.dr
                    this.graphics.DrawLine(pen, tempX, tempY, x, y);
                    this.gCache.DrawLine(pen, tempX, tempY, x, y);
                    break;
                case DrawType.circle:
                    //vymazeme predchadzajuce
                   
                    this.graphics.DrawEllipse(this.eraser, this.startX, this.startY, tempX, tempY);
                    this.graphics.DrawEllipse(pen, this.startX,this.startY, x,y);
                    break;
                case DrawType.square:
                    //vymazeme predchadzjuci
                    this.graphics.DrawRectangle(this.eraser, this.startX, this.startY, tempX, tempY);
                    this.graphics.DrawRectangle(this.pen, this.startX, this.startY, x, y);
                    break;
            }
           // this.pCanvas.BackgroundImage = this.graphics.

            //this.gCache.Flush();
            //this.gCache.Save();
            //this.pCanvas.Invalidate();
            

           // this.graphics.FillRectangle(brush, x, y, 1, 1);

            tempX = e.X;
            tempY = e.Y;
        }

        private void pCanvas_SizeChanged(object sender, EventArgs e)
        {
            if (graphics == null) return;

            //this.graphics = this.pCanvas.CreateGraphics();
            this.graphics = Graphics.FromImage(this.pCanvas.Image);


            if (this.Width > this.frmSize.width || this.Height > this.frmSize.height)
            {
                this.graphics = this.gCache;
                this.graphics = this.pCanvas.CreateGraphics();
            }
            

           // graphics.Clip = new Region(r);
        }

        private void bColorPick_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = Color.Black;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                color = MyDialog.Color;
                brush.Color = color;
                this.pColor.BackColor = color;

                this.pen = new Pen(new SolidBrush(color));
            }
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            this.gCache = (Graphics)this.graphics;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.frmSize.height = this.Height;
            this.frmSize.width = this.Width;
           // this.graphics = this.gCache;
        }

        private void selectObject_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string[] type = btn.Name.Split('_');

            switch (type[1])
            {
                case "pen":
                    this.drawType = DrawType.pen;
                    break;
                case "circle":
                    this.drawType = DrawType.circle;
                    break;
                case "square":
                    this.drawType = DrawType.square;
                    break;
            }
        }

        private void pCanvas_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //this.pCanvas.DrawToBitmap(this.gr, this.pCanvas.ClientRectangle);

                //this.pCanvas.Image
                this.pCanvas.Image.Save(this.saveFileDialog1.FileName, ImageFormat.Jpeg);
                /*byte[] ar = new byte[ms.Length];
                ms.Write(ar, 0, ar.Length);
                ms.Dispose();*/
               
                //this.pCanvas.Image.Save(this.saveFileDialog1.FileName, ImageFormat.Jpeg);

            }
           
        }

        private void pCanvas_Paint(object sender, PaintEventArgs e)
        {
            return;

            if (!isMousePressed) return;

           

            switch (drawType)
            {
                case DrawType.pen:
                    //this.pCanvas.Image.dr
                    e.Graphics.DrawLine(pen, tempX, tempY, this._x, this._y);
                    break;
                case DrawType.circle:
                    //vymazeme predchadzajuce

                    e.Graphics.DrawEllipse(this.eraser, this.startX, this.startY, tempX, tempY);
                    e.Graphics.DrawEllipse(pen, this.startX, this.startY, this._x, this._y);
                    break;
                case DrawType.square:
                    //vymazeme predchadzjuci
                    e.Graphics.DrawRectangle(this.eraser, this.startX, this.startY, tempX, tempY);
                    e.Graphics.DrawRectangle(this.pen, this.startX, this.startY, this._x, this._y);
                    break;
            }
            e.Graphics.Flush();
            e.Graphics.Save();
            //this.pCanvas.Invalidate();


            // this.graphics.FillRectangle(brush, x, y, 1, 1);

            tempX = this._x;
            tempY = this._y;

           
        }
    }
}
