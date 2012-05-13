namespace Doodle
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
      this.components = new System.ComponentModel.Container();
      this.picCanvas = new System.Windows.Forms.PictureBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.rbtnPen = new System.Windows.Forms.RadioButton();
      this.rbtnFillNone = new System.Windows.Forms.RadioButton();
      this.rbtnFillRectangle = new System.Windows.Forms.RadioButton();
      this.rbtnFillEllipse = new System.Windows.Forms.RadioButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnDrawSize = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtDrawSize = new System.Windows.Forms.TextBox();
      this.rbtnDrawNone = new System.Windows.Forms.RadioButton();
      this.rbtnDrawRectangle = new System.Windows.Forms.RadioButton();
      this.rbthDrawEllipse = new System.Windows.Forms.RadioButton();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.btnFillColor = new System.Windows.Forms.Button();
      this.btnDrawColor = new System.Windows.Forms.Button();
      this.picFill = new System.Windows.Forms.PictureBox();
      this.picDraw = new System.Windows.Forms.PictureBox();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnreset = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.btnSizeSmall = new System.Windows.Forms.Button();
      this.btnSizeMedium = new System.Windows.Forms.Button();
      this.btnSizeLarge = new System.Windows.Forms.Button();
      this.btnSizeRandom = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picFill)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
      this.SuspendLayout();
      // 
      // picCanvas
      // 
      this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.picCanvas.BackColor = System.Drawing.Color.White;
      this.picCanvas.Location = new System.Drawing.Point(12, 12);
      this.picCanvas.Name = "picCanvas";
      this.picCanvas.Size = new System.Drawing.Size(661, 539);
      this.picCanvas.TabIndex = 0;
      this.picCanvas.TabStop = false;
      this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
      this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
      this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.rbtnPen);
      this.groupBox1.Controls.Add(this.rbtnFillNone);
      this.groupBox1.Controls.Add(this.rbtnFillRectangle);
      this.groupBox1.Controls.Add(this.rbtnFillEllipse);
      this.groupBox1.Location = new System.Drawing.Point(692, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(105, 115);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Filled";
      // 
      // rbtnPen
      // 
      this.rbtnPen.AutoSize = true;
      this.rbtnPen.Checked = true;
      this.rbtnPen.Location = new System.Drawing.Point(6, 19);
      this.rbtnPen.Name = "rbtnPen";
      this.rbtnPen.Size = new System.Drawing.Size(44, 17);
      this.rbtnPen.TabIndex = 3;
      this.rbtnPen.TabStop = true;
      this.rbtnPen.Text = "Pen";
      this.rbtnPen.UseVisualStyleBackColor = true;
      // 
      // rbtnFillNone
      // 
      this.rbtnFillNone.AutoSize = true;
      this.rbtnFillNone.Location = new System.Drawing.Point(6, 88);
      this.rbtnFillNone.Name = "rbtnFillNone";
      this.rbtnFillNone.Size = new System.Drawing.Size(51, 17);
      this.rbtnFillNone.TabIndex = 2;
      this.rbtnFillNone.Text = "None";
      this.rbtnFillNone.UseVisualStyleBackColor = true;
      // 
      // rbtnFillRectangle
      // 
      this.rbtnFillRectangle.AutoSize = true;
      this.rbtnFillRectangle.Location = new System.Drawing.Point(6, 65);
      this.rbtnFillRectangle.Name = "rbtnFillRectangle";
      this.rbtnFillRectangle.Size = new System.Drawing.Size(74, 17);
      this.rbtnFillRectangle.TabIndex = 1;
      this.rbtnFillRectangle.Text = "Rectangle";
      this.rbtnFillRectangle.UseVisualStyleBackColor = true;
      // 
      // rbtnFillEllipse
      // 
      this.rbtnFillEllipse.AutoSize = true;
      this.rbtnFillEllipse.Location = new System.Drawing.Point(6, 42);
      this.rbtnFillEllipse.Name = "rbtnFillEllipse";
      this.rbtnFillEllipse.Size = new System.Drawing.Size(55, 17);
      this.rbtnFillEllipse.TabIndex = 0;
      this.rbtnFillEllipse.Text = "Ellipse";
      this.rbtnFillEllipse.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.btnDrawSize);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.txtDrawSize);
      this.groupBox2.Controls.Add(this.rbtnDrawNone);
      this.groupBox2.Controls.Add(this.rbtnDrawRectangle);
      this.groupBox2.Controls.Add(this.rbthDrawEllipse);
      this.groupBox2.Location = new System.Drawing.Point(692, 133);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(105, 115);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Border";
      // 
      // btnDrawSize
      // 
      this.btnDrawSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDrawSize.Location = new System.Drawing.Point(72, 87);
      this.btnDrawSize.Name = "btnDrawSize";
      this.btnDrawSize.Size = new System.Drawing.Size(29, 20);
      this.btnDrawSize.TabIndex = 13;
      this.btnDrawSize.Text = "Set";
      this.btnDrawSize.UseVisualStyleBackColor = true;
      this.btnDrawSize.Click += new System.EventHandler(this.btnDrawSize_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 90);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(30, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Size:";
      // 
      // txtDrawSize
      // 
      this.txtDrawSize.Location = new System.Drawing.Point(40, 87);
      this.txtDrawSize.MaxLength = 2;
      this.txtDrawSize.Name = "txtDrawSize";
      this.txtDrawSize.Size = new System.Drawing.Size(26, 20);
      this.txtDrawSize.TabIndex = 4;
      this.txtDrawSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDrawSize_KeyPress);
      this.txtDrawSize.Enter += new System.EventHandler(this.txtDrawSize_Enter);
      // 
      // rbtnDrawNone
      // 
      this.rbtnDrawNone.AutoSize = true;
      this.rbtnDrawNone.Checked = true;
      this.rbtnDrawNone.Location = new System.Drawing.Point(7, 67);
      this.rbtnDrawNone.Name = "rbtnDrawNone";
      this.rbtnDrawNone.Size = new System.Drawing.Size(51, 17);
      this.rbtnDrawNone.TabIndex = 3;
      this.rbtnDrawNone.TabStop = true;
      this.rbtnDrawNone.Text = "None";
      this.rbtnDrawNone.UseVisualStyleBackColor = true;
      // 
      // rbtnDrawRectangle
      // 
      this.rbtnDrawRectangle.AutoSize = true;
      this.rbtnDrawRectangle.Location = new System.Drawing.Point(7, 44);
      this.rbtnDrawRectangle.Name = "rbtnDrawRectangle";
      this.rbtnDrawRectangle.Size = new System.Drawing.Size(74, 17);
      this.rbtnDrawRectangle.TabIndex = 1;
      this.rbtnDrawRectangle.Text = "Rectangle";
      this.rbtnDrawRectangle.UseVisualStyleBackColor = true;
      // 
      // rbthDrawEllipse
      // 
      this.rbthDrawEllipse.AutoSize = true;
      this.rbthDrawEllipse.Location = new System.Drawing.Point(7, 20);
      this.rbthDrawEllipse.Name = "rbthDrawEllipse";
      this.rbthDrawEllipse.Size = new System.Drawing.Size(55, 17);
      this.rbthDrawEllipse.TabIndex = 0;
      this.rbthDrawEllipse.Text = "Ellipse";
      this.rbthDrawEllipse.UseVisualStyleBackColor = true;
      // 
      // btnFillColor
      // 
      this.btnFillColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFillColor.Location = new System.Drawing.Point(716, 254);
      this.btnFillColor.Name = "btnFillColor";
      this.btnFillColor.Size = new System.Drawing.Size(88, 23);
      this.btnFillColor.TabIndex = 3;
      this.btnFillColor.Text = "Fill Color";
      this.btnFillColor.UseVisualStyleBackColor = true;
      this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
      // 
      // btnDrawColor
      // 
      this.btnDrawColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDrawColor.Location = new System.Drawing.Point(716, 283);
      this.btnDrawColor.Name = "btnDrawColor";
      this.btnDrawColor.Size = new System.Drawing.Size(88, 23);
      this.btnDrawColor.TabIndex = 4;
      this.btnDrawColor.Text = "Border Color";
      this.btnDrawColor.UseVisualStyleBackColor = true;
      this.btnDrawColor.Click += new System.EventHandler(this.btnDrawColor_Click);
      // 
      // picFill
      // 
      this.picFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.picFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picFill.Location = new System.Drawing.Point(686, 254);
      this.picFill.Name = "picFill";
      this.picFill.Size = new System.Drawing.Size(24, 23);
      this.picFill.TabIndex = 5;
      this.picFill.TabStop = false;
      // 
      // picDraw
      // 
      this.picDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.picDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picDraw.Location = new System.Drawing.Point(686, 283);
      this.picDraw.Name = "picDraw";
      this.picDraw.Size = new System.Drawing.Size(24, 23);
      this.picDraw.TabIndex = 6;
      this.picDraw.TabStop = false;
      // 
      // btnClear
      // 
      this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClear.Location = new System.Drawing.Point(686, 527);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(118, 23);
      this.btnClear.TabIndex = 7;
      this.btnClear.Text = "Clear Canvas";
      this.toolTip1.SetToolTip(this.btnClear, "Can also use ESC clear canvas");
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnreset
      // 
      this.btnreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnreset.Location = new System.Drawing.Point(686, 312);
      this.btnreset.Name = "btnreset";
      this.btnreset.Size = new System.Drawing.Size(118, 23);
      this.btnreset.TabIndex = 8;
      this.btnreset.Text = "Random Colors";
      this.btnreset.UseVisualStyleBackColor = true;
      this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
      // 
      // btnSizeSmall
      // 
      this.btnSizeSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSizeSmall.Location = new System.Drawing.Point(686, 368);
      this.btnSizeSmall.Name = "btnSizeSmall";
      this.btnSizeSmall.Size = new System.Drawing.Size(28, 23);
      this.btnSizeSmall.TabIndex = 9;
      this.btnSizeSmall.Text = "S";
      this.btnSizeSmall.UseVisualStyleBackColor = true;
      this.btnSizeSmall.Click += new System.EventHandler(this.HandleBtnClick);
      // 
      // btnSizeMedium
      // 
      this.btnSizeMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSizeMedium.Location = new System.Drawing.Point(730, 368);
      this.btnSizeMedium.Name = "btnSizeMedium";
      this.btnSizeMedium.Size = new System.Drawing.Size(28, 23);
      this.btnSizeMedium.TabIndex = 10;
      this.btnSizeMedium.Text = "M";
      this.btnSizeMedium.UseVisualStyleBackColor = true;
      this.btnSizeMedium.Click += new System.EventHandler(this.HandleBtnClick);
      // 
      // btnSizeLarge
      // 
      this.btnSizeLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSizeLarge.Location = new System.Drawing.Point(776, 368);
      this.btnSizeLarge.Name = "btnSizeLarge";
      this.btnSizeLarge.Size = new System.Drawing.Size(28, 23);
      this.btnSizeLarge.TabIndex = 11;
      this.btnSizeLarge.Text = "L";
      this.btnSizeLarge.UseVisualStyleBackColor = true;
      this.btnSizeLarge.Click += new System.EventHandler(this.HandleBtnClick);
      // 
      // btnSizeRandom
      // 
      this.btnSizeRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSizeRandom.Location = new System.Drawing.Point(686, 397);
      this.btnSizeRandom.Name = "btnSizeRandom";
      this.btnSizeRandom.Size = new System.Drawing.Size(118, 23);
      this.btnSizeRandom.TabIndex = 12;
      this.btnSizeRandom.Text = "Random Size";
      this.btnSizeRandom.UseVisualStyleBackColor = true;
      this.btnSizeRandom.Click += new System.EventHandler(this.HandleBtnClick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(816, 563);
      this.Controls.Add(this.btnSizeRandom);
      this.Controls.Add(this.btnSizeLarge);
      this.Controls.Add(this.btnSizeMedium);
      this.Controls.Add(this.btnSizeSmall);
      this.Controls.Add(this.btnreset);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.picDraw);
      this.Controls.Add(this.picFill);
      this.Controls.Add(this.btnDrawColor);
      this.Controls.Add(this.btnFillColor);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.picCanvas);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Doodle";
      this.Resize += new System.EventHandler(this.Form1_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picFill)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbtnFillRectangle;
    private System.Windows.Forms.RadioButton rbtnFillEllipse;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton rbtnDrawRectangle;
    private System.Windows.Forms.RadioButton rbthDrawEllipse;
    private System.Windows.Forms.RadioButton rbtnFillNone;
    private System.Windows.Forms.RadioButton rbtnDrawNone;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Button btnFillColor;
    private System.Windows.Forms.Button btnDrawColor;
    private System.Windows.Forms.PictureBox picFill;
    private System.Windows.Forms.PictureBox picDraw;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnreset;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Button btnSizeSmall;
    private System.Windows.Forms.Button btnSizeMedium;
    private System.Windows.Forms.Button btnSizeLarge;
    private System.Windows.Forms.Button btnSizeRandom;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtDrawSize;
    private System.Windows.Forms.Button btnDrawSize;
    private System.Windows.Forms.RadioButton rbtnPen;
    private System.Windows.Forms.PictureBox picCanvas;
  }
}

