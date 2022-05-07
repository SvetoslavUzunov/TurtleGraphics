
namespace TurtleGraphics
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonShowHideTurtle = new System.Windows.Forms.Button();
            this.DrawHexagon = new System.Windows.Forms.Button();
            this.DrawStar = new System.Windows.Forms.Button();
            this.DrawSpiral = new System.Windows.Forms.Button();
            this.DrawTriangles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 31);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(89, 57);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 94);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(89, 44);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonShowHideTurtle
            // 
            this.buttonShowHideTurtle.Location = new System.Drawing.Point(12, 144);
            this.buttonShowHideTurtle.Name = "buttonShowHideTurtle";
            this.buttonShowHideTurtle.Size = new System.Drawing.Size(89, 55);
            this.buttonShowHideTurtle.TabIndex = 2;
            this.buttonShowHideTurtle.Text = "Hide Turtle";
            this.buttonShowHideTurtle.UseVisualStyleBackColor = true;
            this.buttonShowHideTurtle.Click += new System.EventHandler(this.buttonShowHideTurtle_Click);
            // 
            // DrawHexagon
            // 
            this.DrawHexagon.Location = new System.Drawing.Point(12, 220);
            this.DrawHexagon.Name = "DrawHexagon";
            this.DrawHexagon.Size = new System.Drawing.Size(88, 43);
            this.DrawHexagon.TabIndex = 3;
            this.DrawHexagon.Text = "Hexagon";
            this.DrawHexagon.UseVisualStyleBackColor = true;
            this.DrawHexagon.Click += new System.EventHandler(this.DrawHexagon_Click);
            // 
            // DrawStar
            // 
            this.DrawStar.Location = new System.Drawing.Point(12, 278);
            this.DrawStar.Name = "DrawStar";
            this.DrawStar.Size = new System.Drawing.Size(89, 41);
            this.DrawStar.TabIndex = 4;
            this.DrawStar.Text = "Star";
            this.DrawStar.UseVisualStyleBackColor = true;
            this.DrawStar.Click += new System.EventHandler(this.DrawStar_Click);
            // 
            // DrawSpiral
            // 
            this.DrawSpiral.Location = new System.Drawing.Point(12, 336);
            this.DrawSpiral.Name = "DrawSpiral";
            this.DrawSpiral.Size = new System.Drawing.Size(88, 37);
            this.DrawSpiral.TabIndex = 5;
            this.DrawSpiral.Text = "Spiral";
            this.DrawSpiral.UseVisualStyleBackColor = true;
            this.DrawSpiral.Click += new System.EventHandler(this.DrawSpiral_Click);
            // 
            // DrawTriangles
            // 
            this.DrawTriangles.Location = new System.Drawing.Point(12, 388);
            this.DrawTriangles.Name = "DrawTriangles";
            this.DrawTriangles.Size = new System.Drawing.Size(88, 40);
            this.DrawTriangles.TabIndex = 6;
            this.DrawTriangles.Text = "Triangles";
            this.DrawTriangles.UseVisualStyleBackColor = true;
            this.DrawTriangles.Click += new System.EventHandler(this.DrawTriangles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 746);
            this.Controls.Add(this.DrawTriangles);
            this.Controls.Add(this.DrawSpiral);
            this.Controls.Add(this.DrawStar);
            this.Controls.Add(this.DrawHexagon);
            this.Controls.Add(this.buttonShowHideTurtle);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDraw);
            this.Name = "Form1";
            this.Text = "Turtle Graphics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonShowHideTurtle;
        private System.Windows.Forms.Button DrawHexagon;
        private System.Windows.Forms.Button DrawStar;
        private System.Windows.Forms.Button DrawSpiral;
        private System.Windows.Forms.Button DrawTriangles;
    }
}

