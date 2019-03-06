namespace MyDrive
{
    partial class frmEstimate
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEuroDrivesOrPatios = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.rbGravel = new System.Windows.Forms.RadioButton();
            this.rbTarmac = new System.Windows.Forms.RadioButton();
            this.rbConcrete = new System.Windows.Forms.RadioButton();
            this.rbBrick = new System.Windows.Forms.RadioButton();
            this.grpFoundations = new System.Windows.Forms.GroupBox();
            this.rbExtraDeep = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.txtGravel = new System.Windows.Forms.TextBox();
            this.txtTarmac = new System.Windows.Forms.TextBox();
            this.txtConcrete = new System.Windows.Forms.TextBox();
            this.txtBrick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlExchangeRate = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCalculate = new System.Windows.Forms.Panel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtGBR = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpType.SuspendLayout();
            this.grpFoundations.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            this.pnlExchangeRate.SuspendLayout();
            this.pnlCalculate.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 80;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblEuroDrivesOrPatios
            // 
            this.lblEuroDrivesOrPatios.AutoSize = true;
            this.lblEuroDrivesOrPatios.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroDrivesOrPatios.ForeColor = System.Drawing.Color.Red;
            this.lblEuroDrivesOrPatios.Location = new System.Drawing.Point(135, 35);
            this.lblEuroDrivesOrPatios.Name = "lblEuroDrivesOrPatios";
            this.lblEuroDrivesOrPatios.Size = new System.Drawing.Size(234, 26);
            this.lblEuroDrivesOrPatios.TabIndex = 2;
            this.lblEuroDrivesOrPatios.Text = "Euro Drives or Patios";
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rbGravel);
            this.grpType.Controls.Add(this.rbTarmac);
            this.grpType.Controls.Add(this.rbConcrete);
            this.grpType.Controls.Add(this.rbBrick);
            this.grpType.Location = new System.Drawing.Point(23, 105);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(115, 127);
            this.grpType.TabIndex = 15;
            this.grpType.TabStop = false;
            this.grpType.Text = "Materials";
            // 
            // rbGravel
            // 
            this.rbGravel.AutoSize = true;
            this.rbGravel.Location = new System.Drawing.Point(20, 92);
            this.rbGravel.Name = "rbGravel";
            this.rbGravel.Size = new System.Drawing.Size(68, 17);
            this.rbGravel.TabIndex = 13;
            this.rbGravel.TabStop = true;
            this.rbGravel.Tag = "3";
            this.rbGravel.Text = "GRAVEL";
            this.rbGravel.UseVisualStyleBackColor = true;
            this.rbGravel.CheckedChanged += new System.EventHandler(this.rbMaterial_CheckedChanged);
            // 
            // rbTarmac
            // 
            this.rbTarmac.AutoSize = true;
            this.rbTarmac.Location = new System.Drawing.Point(20, 68);
            this.rbTarmac.Name = "rbTarmac";
            this.rbTarmac.Size = new System.Drawing.Size(70, 17);
            this.rbTarmac.TabIndex = 12;
            this.rbTarmac.TabStop = true;
            this.rbTarmac.Tag = "2";
            this.rbTarmac.Text = "TARMAC";
            this.rbTarmac.UseVisualStyleBackColor = true;
            this.rbTarmac.CheckedChanged += new System.EventHandler(this.rbMaterial_CheckedChanged);
            // 
            // rbConcrete
            // 
            this.rbConcrete.AutoSize = true;
            this.rbConcrete.Location = new System.Drawing.Point(20, 44);
            this.rbConcrete.Name = "rbConcrete";
            this.rbConcrete.Size = new System.Drawing.Size(84, 17);
            this.rbConcrete.TabIndex = 11;
            this.rbConcrete.TabStop = true;
            this.rbConcrete.Tag = "1";
            this.rbConcrete.Text = "CONCRETE";
            this.rbConcrete.UseVisualStyleBackColor = true;
            this.rbConcrete.CheckedChanged += new System.EventHandler(this.rbMaterial_CheckedChanged);
            // 
            // rbBrick
            // 
            this.rbBrick.AutoSize = true;
            this.rbBrick.Checked = true;
            this.rbBrick.Location = new System.Drawing.Point(20, 20);
            this.rbBrick.Name = "rbBrick";
            this.rbBrick.Size = new System.Drawing.Size(57, 17);
            this.rbBrick.TabIndex = 10;
            this.rbBrick.TabStop = true;
            this.rbBrick.Tag = "0";
            this.rbBrick.Text = "BRICK";
            this.rbBrick.UseVisualStyleBackColor = true;
            this.rbBrick.CheckedChanged += new System.EventHandler(this.rbMaterial_CheckedChanged);
            // 
            // grpFoundations
            // 
            this.grpFoundations.Controls.Add(this.rbExtraDeep);
            this.grpFoundations.Controls.Add(this.rbStandard);
            this.grpFoundations.Location = new System.Drawing.Point(380, 106);
            this.grpFoundations.Name = "grpFoundations";
            this.grpFoundations.Size = new System.Drawing.Size(130, 84);
            this.grpFoundations.TabIndex = 16;
            this.grpFoundations.TabStop = false;
            this.grpFoundations.Text = "Foundations";
            this.grpFoundations.Visible = false;
            // 
            // rbExtraDeep
            // 
            this.rbExtraDeep.AutoSize = true;
            this.rbExtraDeep.Location = new System.Drawing.Point(20, 43);
            this.rbExtraDeep.Name = "rbExtraDeep";
            this.rbExtraDeep.Size = new System.Drawing.Size(93, 17);
            this.rbExtraDeep.TabIndex = 16;
            this.rbExtraDeep.TabStop = true;
            this.rbExtraDeep.Text = "EXTRA DEEP";
            this.rbExtraDeep.UseVisualStyleBackColor = true;
            this.rbExtraDeep.CheckedChanged += new System.EventHandler(this.rbFoundations_CheckedChanged);
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Checked = true;
            this.rbStandard.Location = new System.Drawing.Point(20, 19);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(85, 17);
            this.rbStandard.TabIndex = 15;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "STANDARD";
            this.rbStandard.UseVisualStyleBackColor = true;
            this.rbStandard.CheckedChanged += new System.EventHandler(this.rbFoundations_CheckedChanged);
            // 
            // pnlPrice
            // 
            this.pnlPrice.Controls.Add(this.txtGravel);
            this.pnlPrice.Controls.Add(this.txtTarmac);
            this.pnlPrice.Controls.Add(this.txtConcrete);
            this.pnlPrice.Controls.Add(this.txtBrick);
            this.pnlPrice.Controls.Add(this.label2);
            this.pnlPrice.Location = new System.Drawing.Point(144, 102);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(158, 130);
            this.pnlPrice.TabIndex = 2;
            // 
            // txtGravel
            // 
            this.txtGravel.Location = new System.Drawing.Point(29, 94);
            this.txtGravel.Name = "txtGravel";
            this.txtGravel.Size = new System.Drawing.Size(100, 20);
            this.txtGravel.TabIndex = 5;
            this.txtGravel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGravel.Leave += new System.EventHandler(this.txtGravel_Leave);
            // 
            // txtTarmac
            // 
            this.txtTarmac.Location = new System.Drawing.Point(29, 70);
            this.txtTarmac.Name = "txtTarmac";
            this.txtTarmac.Size = new System.Drawing.Size(100, 20);
            this.txtTarmac.TabIndex = 4;
            this.txtTarmac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTarmac.Leave += new System.EventHandler(this.txtTarmac_Leave);
            // 
            // txtConcrete
            // 
            this.txtConcrete.Location = new System.Drawing.Point(29, 46);
            this.txtConcrete.Name = "txtConcrete";
            this.txtConcrete.Size = new System.Drawing.Size(100, 20);
            this.txtConcrete.TabIndex = 3;
            this.txtConcrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConcrete.Leave += new System.EventHandler(this.txtConcrete_Leave);
            // 
            // txtBrick
            // 
            this.txtBrick.Location = new System.Drawing.Point(29, 22);
            this.txtBrick.Name = "txtBrick";
            this.txtBrick.Size = new System.Drawing.Size(100, 20);
            this.txtBrick.TabIndex = 2;
            this.txtBrick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBrick.Leave += new System.EventHandler(this.txtBrick_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PRICE PER SQUARE METRE";
            // 
            // pnlExchangeRate
            // 
            this.pnlExchangeRate.Controls.Add(this.label4);
            this.pnlExchangeRate.Controls.Add(this.txtExchangeRate);
            this.pnlExchangeRate.Controls.Add(this.label3);
            this.pnlExchangeRate.Location = new System.Drawing.Point(12, 68);
            this.pnlExchangeRate.Name = "pnlExchangeRate";
            this.pnlExchangeRate.Size = new System.Drawing.Size(396, 31);
            this.pnlExchangeRate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "EUROS";
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(148, 6);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(54, 20);
            this.txtExchangeRate.TabIndex = 1;
            this.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExchangeRate.Leave += new System.EventHandler(this.txtExchangeRate_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "EXCHANGE RATE:  £1 -";
            // 
            // pnlCalculate
            // 
            this.pnlCalculate.Controls.Add(this.lblOutput);
            this.pnlCalculate.Controls.Add(this.label10);
            this.pnlCalculate.Controls.Add(this.label9);
            this.pnlCalculate.Controls.Add(this.label7);
            this.pnlCalculate.Controls.Add(this.label8);
            this.pnlCalculate.Controls.Add(this.label6);
            this.pnlCalculate.Controls.Add(this.label5);
            this.pnlCalculate.Controls.Add(this.txtEuro);
            this.pnlCalculate.Controls.Add(this.txtGBR);
            this.pnlCalculate.Controls.Add(this.txtWidth);
            this.pnlCalculate.Controls.Add(this.txtLength);
            this.pnlCalculate.Location = new System.Drawing.Point(66, 259);
            this.pnlCalculate.Name = "pnlCalculate";
            this.pnlCalculate.Size = new System.Drawing.Size(395, 127);
            this.pnlCalculate.TabIndex = 7;
            this.pnlCalculate.Visible = false;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.Green;
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(29, 98);
            this.lblOutput.MinimumSize = new System.Drawing.Size(340, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(340, 19);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "GBP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "EURO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "METRES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "WIDTH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "METRES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "LENGTH";
            // 
            // txtEuro
            // 
            this.txtEuro.BackColor = System.Drawing.SystemColors.Window;
            this.txtEuro.Location = new System.Drawing.Point(269, 66);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.ReadOnly = true;
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 100;
            this.txtEuro.TabStop = false;
            this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGBR
            // 
            this.txtGBR.BackColor = System.Drawing.SystemColors.Window;
            this.txtGBR.Location = new System.Drawing.Point(61, 66);
            this.txtGBR.Name = "txtGBR";
            this.txtGBR.ReadOnly = true;
            this.txtGBR.Size = new System.Drawing.Size(100, 20);
            this.txtGBR.TabIndex = 100;
            this.txtGBR.TabStop = false;
            this.txtGBR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(149, 29);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 21;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWidth.Leave += new System.EventHandler(this.txtWidth_Leave);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(149, 3);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 20;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLength.Leave += new System.EventHandler(this.txtLength_Leave);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(95, 401);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(83, 23);
            this.btnCalculate.TabIndex = 30;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Visible = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(360, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(233, 401);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 496);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pnlCalculate);
            this.Controls.Add(this.pnlExchangeRate);
            this.Controls.Add(this.pnlPrice);
            this.Controls.Add(this.grpFoundations);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblEuroDrivesOrPatios);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drive Estimates";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpFoundations.ResumeLayout(false);
            this.grpFoundations.PerformLayout();
            this.pnlPrice.ResumeLayout(false);
            this.pnlPrice.PerformLayout();
            this.pnlExchangeRate.ResumeLayout(false);
            this.pnlExchangeRate.PerformLayout();
            this.pnlCalculate.ResumeLayout(false);
            this.pnlCalculate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label lblEuroDrivesOrPatios;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton rbBrick;
        private System.Windows.Forms.GroupBox grpFoundations;
        private System.Windows.Forms.RadioButton rbConcrete;
        private System.Windows.Forms.RadioButton rbGravel;
        private System.Windows.Forms.RadioButton rbTarmac;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGravel;
        private System.Windows.Forms.TextBox txtTarmac;
        private System.Windows.Forms.TextBox txtConcrete;
        private System.Windows.Forms.TextBox txtBrick;
        private System.Windows.Forms.RadioButton rbExtraDeep;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.Panel pnlExchangeRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCalculate;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtGBR;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
    }
}

