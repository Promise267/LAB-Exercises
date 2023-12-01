namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ShapeSize = new System.Windows.Forms.TextBox();
            this.cmb_PenSize = new System.Windows.Forms.ComboBox();
            this.btn_PenColor = new System.Windows.Forms.Button();
            this.btn_CanvasColor = new System.Windows.Forms.Button();
            this.btn_Square = new System.Windows.Forms.Button();
            this.btn_Rectnagle = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.pnl_Draw = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Pen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ShapeSize
            // 
            this.txt_ShapeSize.Location = new System.Drawing.Point(525, 101);
            this.txt_ShapeSize.Name = "txt_ShapeSize";
            this.txt_ShapeSize.Size = new System.Drawing.Size(121, 20);
            this.txt_ShapeSize.TabIndex = 6;
            // 
            // cmb_PenSize
            // 
            this.cmb_PenSize.FormattingEnabled = true;
            this.cmb_PenSize.Location = new System.Drawing.Point(525, 46);
            this.cmb_PenSize.Name = "cmb_PenSize";
            this.cmb_PenSize.Size = new System.Drawing.Size(121, 21);
            this.cmb_PenSize.TabIndex = 7;
            // 
            // btn_PenColor
            // 
            this.btn_PenColor.Location = new System.Drawing.Point(222, 45);
            this.btn_PenColor.Name = "btn_PenColor";
            this.btn_PenColor.Size = new System.Drawing.Size(84, 33);
            this.btn_PenColor.TabIndex = 8;
            this.btn_PenColor.Text = "Pen Color";
            this.btn_PenColor.UseVisualStyleBackColor = true;
            // 
            // btn_CanvasColor
            // 
            this.btn_CanvasColor.Location = new System.Drawing.Point(323, 45);
            this.btn_CanvasColor.Name = "btn_CanvasColor";
            this.btn_CanvasColor.Size = new System.Drawing.Size(84, 33);
            this.btn_CanvasColor.TabIndex = 9;
            this.btn_CanvasColor.Text = "Canvas";
            this.btn_CanvasColor.UseVisualStyleBackColor = true;
            this.btn_CanvasColor.Click += new System.EventHandler(this.btn_CanvasColor_Click);
            // 
            // btn_Square
            // 
            this.btn_Square.Location = new System.Drawing.Point(121, 94);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(84, 33);
            this.btn_Square.TabIndex = 10;
            this.btn_Square.Text = "Square";
            this.btn_Square.UseVisualStyleBackColor = true;
            this.btn_Square.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // btn_Rectnagle
            // 
            this.btn_Rectnagle.Location = new System.Drawing.Point(222, 94);
            this.btn_Rectnagle.Name = "btn_Rectnagle";
            this.btn_Rectnagle.Size = new System.Drawing.Size(84, 33);
            this.btn_Rectnagle.TabIndex = 11;
            this.btn_Rectnagle.Text = "Rectangle";
            this.btn_Rectnagle.UseVisualStyleBackColor = true;
            this.btn_Rectnagle.Click += new System.EventHandler(this.btn_Rectnagle_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.Location = new System.Drawing.Point(323, 94);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(84, 33);
            this.btn_Circle.TabIndex = 12;
            this.btn_Circle.Text = "Circle";
            this.btn_Circle.UseVisualStyleBackColor = true;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // pnl_Draw
            // 
            this.pnl_Draw.Location = new System.Drawing.Point(121, 157);
            this.pnl_Draw.Name = "pnl_Draw";
            this.pnl_Draw.Size = new System.Drawing.Size(526, 249);
            this.pnl_Draw.TabIndex = 13;
            this.pnl_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseDown);
            this.pnl_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseMove);
            this.pnl_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Draw);
            this.Controls.Add(this.btn_Circle);
            this.Controls.Add(this.btn_Rectnagle);
            this.Controls.Add(this.btn_Square);
            this.Controls.Add(this.btn_CanvasColor);
            this.Controls.Add(this.btn_PenColor);
            this.Controls.Add(this.cmb_PenSize);
            this.Controls.Add(this.txt_ShapeSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_ShapeSize;
        private System.Windows.Forms.ComboBox cmb_PenSize;
        private System.Windows.Forms.Button btn_PenColor;
        private System.Windows.Forms.Button btn_CanvasColor;
        private System.Windows.Forms.Button btn_Square;
        private System.Windows.Forms.Button btn_Rectnagle;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Panel pnl_Draw;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}