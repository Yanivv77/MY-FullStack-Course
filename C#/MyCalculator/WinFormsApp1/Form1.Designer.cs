
namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Output.Location = new System.Drawing.Point(57, 27);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(351, 72);
            this.Output.TabIndex = 60;
            this.Output.Text = "0";
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calculate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculate.Location = new System.Drawing.Point(66, 412);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(158, 60);
            this.Calculate.TabIndex = 59;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Pow
            // 
            this.Pow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Pow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pow.Location = new System.Drawing.Point(66, 267);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(67, 60);
            this.Pow.TabIndex = 58;
            this.Pow.Text = "Pow";
            this.Pow.UseVisualStyleBackColor = false;
            this.Pow.Click += new System.EventHandler(this.Pow_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sqrt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sqrt.Location = new System.Drawing.Point(66, 201);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(67, 60);
            this.Sqrt.TabIndex = 57;
            this.Sqrt.Text = "Sqrt 2";
            this.Sqrt.UseVisualStyleBackColor = false;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(248, 412);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(160, 60);
            this.Clear.TabIndex = 55;
            this.Clear.Text = "AC";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Num7
            // 
            this.Num7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Num7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Num7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num7.Location = new System.Drawing.Point(157, 201);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(67, 60);
            this.Num7.TabIndex = 54;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = false;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // Num4
            // 
            this.Num4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Num4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Num4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num4.Location = new System.Drawing.Point(157, 270);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(67, 60);
            this.Num4.TabIndex = 53;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = false;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Num1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Num1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num1.Location = new System.Drawing.Point(157, 336);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(67, 60);
            this.Num1.TabIndex = 52;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = false;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num0
            // 
            this.Num0.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Num0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Num0.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num0.Location = new System.Drawing.Point(66, 336);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(67, 60);
            this.Num0.TabIndex = 51;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = false;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Num8
            // 
            this.Num8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Num8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Num8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num8.Location = new System.Drawing.Point(248, 201);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(67, 60);
            this.Num8.TabIndex = 50;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = false;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // Num5
            // 
            this.Num5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Num5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Num5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num5.Location = new System.Drawing.Point(248, 270);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(67, 60);
            this.Num5.TabIndex = 49;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = false;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Num2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Num2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num2.Location = new System.Drawing.Point(248, 336);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(67, 60);
            this.Num2.TabIndex = 48;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = false;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num9
            // 
            this.Num9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Num9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Num9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num9.Location = new System.Drawing.Point(341, 201);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(67, 60);
            this.Num9.TabIndex = 47;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = false;
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // Num6
            // 
            this.Num6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Num6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Num6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num6.Location = new System.Drawing.Point(341, 267);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(67, 60);
            this.Num6.TabIndex = 46;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = false;
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // Num3
            // 
            this.Num3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Num3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Num3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num3.Location = new System.Drawing.Point(341, 336);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(67, 60);
            this.Num3.TabIndex = 45;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = false;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Div.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Div.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Div.Location = new System.Drawing.Point(157, 130);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(67, 60);
            this.Div.TabIndex = 44;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Multi
            // 
            this.Multi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Multi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Multi.Location = new System.Drawing.Point(248, 130);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(67, 60);
            this.Multi.TabIndex = 43;
            this.Multi.Text = "*";
            this.Multi.UseVisualStyleBackColor = false;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Minus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Minus.Location = new System.Drawing.Point(341, 130);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(67, 60);
            this.Minus.TabIndex = 42;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Plus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Plus.Location = new System.Drawing.Point(66, 130);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(67, 60);
            this.Plus.TabIndex = 41;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(474, 497);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox Output;
        internal System.Windows.Forms.Button Calculate;
        internal System.Windows.Forms.Button Pow;
        internal System.Windows.Forms.Button Sqrt;
        internal System.Windows.Forms.Button Clear;
        internal System.Windows.Forms.Button Num7;
        internal System.Windows.Forms.Button Num4;
        internal System.Windows.Forms.Button Num1;
        internal System.Windows.Forms.Button Num0;
        internal System.Windows.Forms.Button Num8;
        internal System.Windows.Forms.Button Num5;
        internal System.Windows.Forms.Button Num2;
        internal System.Windows.Forms.Button Num9;
        internal System.Windows.Forms.Button Num6;
        internal System.Windows.Forms.Button Num3;
        internal System.Windows.Forms.Button Div;
        internal System.Windows.Forms.Button Multi;
        internal System.Windows.Forms.Button Minus;
        internal System.Windows.Forms.Button Plus;
    }
}

