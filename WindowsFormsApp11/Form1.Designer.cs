namespace WindowsFormsApp11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_pen = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.pColor = new System.Windows.Forms.Panel();
            this.bColorPick = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pCanvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_pen);
            this.panel1.Controls.Add(this.btn_square);
            this.panel1.Controls.Add(this.btn_circle);
            this.panel1.Controls.Add(this.pColor);
            this.panel1.Controls.Add(this.bColorPick);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 461);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ulozit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_pen
            // 
            this.btn_pen.Location = new System.Drawing.Point(10, 127);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(62, 23);
            this.btn_pen.TabIndex = 3;
            this.btn_pen.Text = "Pero";
            this.btn_pen.UseVisualStyleBackColor = true;
            this.btn_pen.Click += new System.EventHandler(this.selectObject_Click);
            // 
            // btn_square
            // 
            this.btn_square.Location = new System.Drawing.Point(59, 98);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(62, 23);
            this.btn_square.TabIndex = 2;
            this.btn_square.Text = "Stvorec";
            this.btn_square.UseVisualStyleBackColor = true;
            this.btn_square.Click += new System.EventHandler(this.selectObject_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Location = new System.Drawing.Point(10, 98);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(43, 23);
            this.btn_circle.TabIndex = 1;
            this.btn_circle.Text = "Kruh";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.selectObject_Click);
            // 
            // pColor
            // 
            this.pColor.Location = new System.Drawing.Point(48, 44);
            this.pColor.Margin = new System.Windows.Forms.Padding(2);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(24, 23);
            this.pColor.TabIndex = 0;
            // 
            // bColorPick
            // 
            this.bColorPick.Location = new System.Drawing.Point(10, 10);
            this.bColorPick.Margin = new System.Windows.Forms.Padding(2);
            this.bColorPick.Name = "bColorPick";
            this.bColorPick.Size = new System.Drawing.Size(111, 31);
            this.bColorPick.TabIndex = 0;
            this.bColorPick.Text = "Pick color";
            this.bColorPick.UseVisualStyleBackColor = true;
            this.bColorPick.Click += new System.EventHandler(this.bColorPick_Click);
            // 
            // pCanvas
            // 
            this.pCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCanvas.Location = new System.Drawing.Point(146, 8);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(644, 456);
            this.pCanvas.TabIndex = 1;
            this.pCanvas.TabStop = false;
            this.pCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas_Paint);
            this.pCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pCanvas_MouseDown);
            this.pCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCanvas_MouseMove);
            this.pCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pCanvas_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 476);
            this.Controls.Add(this.pCanvas);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bColorPick;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.Button btn_pen;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pCanvas;
    }
}

