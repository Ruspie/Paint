namespace Paint
{
    partial class PaintForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonSizeUp = new System.Windows.Forms.Button();
            this.labelSizeText = new System.Windows.Forms.Label();
            this.buttonSizeDown = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonRhombus = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.groupBoxSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSettings.Controls.Add(this.groupBox1);
            this.groupBoxSettings.Controls.Add(this.buttonClear);
            this.groupBoxSettings.Controls.Add(this.groupBoxColor);
            this.groupBoxSettings.Controls.Add(this.buttonTriangle);
            this.groupBoxSettings.Controls.Add(this.buttonRhombus);
            this.groupBoxSettings.Controls.Add(this.buttonRectangle);
            this.groupBoxSettings.Controls.Add(this.buttonPoint);
            this.groupBoxSettings.Controls.Add(this.buttonLine);
            this.groupBoxSettings.Controls.Add(this.buttonEllipse);
            this.groupBoxSettings.Location = new System.Drawing.Point(-1, 0);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(129, 582);
            this.groupBoxSettings.TabIndex = 2;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSize);
            this.groupBox1.Controls.Add(this.buttonSizeUp);
            this.groupBox1.Controls.Add(this.labelSizeText);
            this.groupBox1.Controls.Add(this.buttonSizeDown);
            this.groupBox1.Location = new System.Drawing.Point(13, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(53, 16);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(13, 13);
            this.labelSize.TabIndex = 12;
            this.labelSize.Text = "2";
            // 
            // buttonSizeUp
            // 
            this.buttonSizeUp.Location = new System.Drawing.Point(25, 41);
            this.buttonSizeUp.Name = "buttonSizeUp";
            this.buttonSizeUp.Size = new System.Drawing.Size(56, 23);
            this.buttonSizeUp.TabIndex = 11;
            this.buttonSizeUp.Text = "UP";
            this.buttonSizeUp.UseVisualStyleBackColor = true;
            this.buttonSizeUp.Click += new System.EventHandler(this.buttonSizeUp_Click);
            // 
            // labelSizeText
            // 
            this.labelSizeText.AutoSize = true;
            this.labelSizeText.Location = new System.Drawing.Point(10, 16);
            this.labelSizeText.Name = "labelSizeText";
            this.labelSizeText.Size = new System.Drawing.Size(27, 13);
            this.labelSizeText.TabIndex = 6;
            this.labelSizeText.Text = "Size";
            // 
            // buttonSizeDown
            // 
            this.buttonSizeDown.Location = new System.Drawing.Point(25, 70);
            this.buttonSizeDown.Name = "buttonSizeDown";
            this.buttonSizeDown.Size = new System.Drawing.Size(56, 23);
            this.buttonSizeDown.TabIndex = 10;
            this.buttonSizeDown.Text = "DOWN";
            this.buttonSizeDown.UseVisualStyleBackColor = true;
            this.buttonSizeDown.Click += new System.EventHandler(this.buttonSizeDown_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(13, 546);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(105, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelColor);
            this.groupBoxColor.Controls.Add(this.label1);
            this.groupBoxColor.Location = new System.Drawing.Point(13, 193);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(105, 45);
            this.groupBoxColor.TabIndex = 8;
            this.groupBoxColor.TabStop = false;
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor.Location = new System.Drawing.Point(56, 12);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(25, 25);
            this.panelColor.TabIndex = 7;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Color";
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Location = new System.Drawing.Point(13, 164);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(105, 23);
            this.buttonTriangle.TabIndex = 5;
            this.buttonTriangle.Text = "Triangle";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonRhombus
            // 
            this.buttonRhombus.Location = new System.Drawing.Point(13, 135);
            this.buttonRhombus.Name = "buttonRhombus";
            this.buttonRhombus.Size = new System.Drawing.Size(105, 23);
            this.buttonRhombus.TabIndex = 4;
            this.buttonRhombus.Text = "Rhombus";
            this.buttonRhombus.UseVisualStyleBackColor = true;
            this.buttonRhombus.Click += new System.EventHandler(this.buttonRhombus_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(13, 106);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(105, 23);
            this.buttonRectangle.TabIndex = 3;
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(13, 48);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(105, 23);
            this.buttonPoint.TabIndex = 2;
            this.buttonPoint.Text = "Point";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(13, 19);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(105, 23);
            this.buttonLine.TabIndex = 1;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(13, 77);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(105, 23);
            this.buttonEllipse.TabIndex = 0;
            this.buttonEllipse.Text = "Ellipse";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1056, 581);
            this.Controls.Add(this.groupBoxSettings);
            this.Name = "PaintForm";
            this.Text = "Бегун А.С. гр.451001";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintForm_MouseUp);
            this.Move += new System.EventHandler(this.PaintForm_Move);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonRhombus;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonSizeUp;
        private System.Windows.Forms.Label labelSizeText;
        private System.Windows.Forms.Button buttonSizeDown;
    }
}

