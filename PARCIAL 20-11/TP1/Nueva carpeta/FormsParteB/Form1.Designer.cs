namespace FormsParteB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            materialButton1 = new MaterialSkin2DotNet.Controls.MaterialButton();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            Calculadora = new Label();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tabPage2 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            materialButton2 = new MaterialSkin2DotNet.Controls.MaterialButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            label1 = new Label();
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(materialButton1);
            tabPage1.Controls.Add(numericUpDown2);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(Calculadora);
            tabPage1.Controls.Add(radioButton4);
            tabPage1.Controls.Add(radioButton3);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Aritmetica";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(327, 328);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(86, 36);
            materialButton1.TabIndex = 10;
            materialButton1.Text = "Aceptar";
            materialButton1.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown2.Location = new Point(529, 148);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(63, 43);
            numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(276, 148);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(66, 43);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(461, 148);
            label3.Name = "label3";
            label3.Size = new Size(62, 37);
            label3.TabIndex = 7;
            label3.Text = "N°2";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(201, 148);
            label2.Name = "label2";
            label2.Size = new Size(62, 37);
            label2.TabIndex = 6;
            label2.Text = "N°1";
            label2.Click += label2_Click;
            // 
            // Calculadora
            // 
            Calculadora.AutoSize = true;
            Calculadora.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Calculadora.Location = new Point(215, 36);
            Calculadora.Name = "Calculadora";
            Calculadora.Size = new Size(377, 37);
            Calculadora.TabIndex = 5;
            Calculadora.Text = "Calculadora Aritmetica";
            Calculadora.Click += Calculadora_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(606, 252);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(113, 41);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Dividir";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(361, 252);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(162, 41);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Multiplicar";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(201, 248);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(107, 41);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Restar";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(30, 248);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(110, 41);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sumar";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(numericUpDown4);
            tabPage2.Controls.Add(numericUpDown3);
            tabPage2.Controls.Add(materialButton2);
            tabPage2.Controls.Add(radioButton7);
            tabPage2.Controls.Add(radioButton6);
            tabPage2.Controls.Add(radioButton5);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(materialLabel1);
            tabPage2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Logico";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 124);
            label5.Name = "label5";
            label5.Size = new Size(62, 37);
            label5.TabIndex = 9;
            label5.Text = "N°2";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 126);
            label4.Name = "label4";
            label4.Size = new Size(62, 37);
            label4.TabIndex = 8;
            label4.Text = "N°1";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(575, 124);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(85, 43);
            numericUpDown4.TabIndex = 7;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(243, 124);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(85, 43);
            numericUpDown3.TabIndex = 6;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(371, 303);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(86, 36);
            materialButton2.TabIndex = 5;
            materialButton2.Text = "Aceptar";
            materialButton2.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(544, 208);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(88, 41);
            radioButton7.TabIndex = 4;
            radioButton7.Text = "NOT";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(371, 208);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(71, 41);
            radioButton6.TabIndex = 3;
            radioButton6.Text = "OR";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Checked = true;
            radioButton5.Location = new Point(207, 208);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(91, 41);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Text = "AND";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 31);
            label1.Name = "label1";
            label1.Size = new Size(320, 37);
            label1.TabIndex = 1;
            label1.Text = "Calculadora Logica";
            label1.Click += label1_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.ForeColor = SystemColors.ButtonHighlight;
            materialLabel1.Location = new Point(423, 194);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(1, 0);
            materialLabel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private Label Calculadora;
        private MaterialSkin2DotNet.Controls.MaterialButton materialButton1;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private RadioButton radioButton5;
        private Label label1;
        private MaterialSkin2DotNet.Controls.MaterialButton materialButton2;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private Label label4;
        private Label label5;
    }
}
