
namespace PaisFormsApp
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
            this.maxNum_btn = new System.Windows.Forms.Button();
            this.numToCheck_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.frequencyGridView = new System.Windows.Forms.DataGridView();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.top6Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lastResultLbl = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.strongNumLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maxNum_btn
            // 
            this.maxNum_btn.BackColor = System.Drawing.Color.Gray;
            this.maxNum_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxNum_btn.Location = new System.Drawing.Point(534, 79);
            this.maxNum_btn.Name = "maxNum_btn";
            this.maxNum_btn.Size = new System.Drawing.Size(126, 35);
            this.maxNum_btn.TabIndex = 1;
            this.maxNum_btn.Text = "מס\' מקסימלי";
            this.maxNum_btn.UseVisualStyleBackColor = false;
            this.maxNum_btn.Click += new System.EventHandler(this.getMaxNumber);
            // 
            // numToCheck_txtBox
            // 
            this.numToCheck_txtBox.Location = new System.Drawing.Point(232, 106);
            this.numToCheck_txtBox.Name = "numToCheck_txtBox";
            this.numToCheck_txtBox.Size = new System.Drawing.Size(81, 27);
            this.numToCheck_txtBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(191, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = ":הכנס מס\' לבדיקת שכיחות";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(232, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "בדיקה";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.checkFrequencyOfNumber);
            // 
            // frequencyGridView
            // 
            this.frequencyGridView.AllowUserToAddRows = false;
            this.frequencyGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.frequencyGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.frequencyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frequencyGridView.Location = new System.Drawing.Point(69, 257);
            this.frequencyGridView.Name = "frequencyGridView";
            this.frequencyGridView.RowHeadersWidth = 51;
            this.frequencyGridView.RowTemplate.Height = 29;
            this.frequencyGridView.Size = new System.Drawing.Size(300, 339);
            this.frequencyGridView.TabIndex = 9;
            this.frequencyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.frequencyGridView_CellContentClick);
            // 
            // resultsGridView
            // 
            this.resultsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Location = new System.Drawing.Point(423, 257);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.RowHeadersWidth = 51;
            this.resultsGridView.RowTemplate.Height = 29;
            this.resultsGridView.Size = new System.Drawing.Size(616, 339);
            this.resultsGridView.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSalmon;
            this.label3.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(928, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = ":תוצאות הגרלות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(264, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "טבלת שכיחויות";
            // 
            // top6Btn
            // 
            this.top6Btn.BackColor = System.Drawing.Color.Gray;
            this.top6Btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.top6Btn.Location = new System.Drawing.Point(534, 138);
            this.top6Btn.Name = "top6Btn";
            this.top6Btn.Size = new System.Drawing.Size(126, 35);
            this.top6Btn.TabIndex = 14;
            this.top6Btn.Text = "Top 6";
            this.top6Btn.UseVisualStyleBackColor = false;
            this.top6Btn.Click += new System.EventHandler(this.top6Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(880, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = ":תוצאות הגרלה אחרונה";
            // 
            // lastResultLbl
            // 
            this.lastResultLbl.AutoSize = true;
            this.lastResultLbl.BackColor = System.Drawing.SystemColors.Control;
            this.lastResultLbl.Location = new System.Drawing.Point(850, 99);
            this.lastResultLbl.Name = "lastResultLbl";
            this.lastResultLbl.Size = new System.Drawing.Size(15, 20);
            this.lastResultLbl.TabIndex = 16;
            this.lastResultLbl.Text = "_";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.DarkSalmon;
            this.lbl.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(941, 145);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(99, 20);
            this.lbl.TabIndex = 17;
            this.lbl.Text = ":המספר החזק";
            // 
            // strongNumLbl
            // 
            this.strongNumLbl.AutoSize = true;
            this.strongNumLbl.Location = new System.Drawing.Point(908, 146);
            this.strongNumLbl.Name = "strongNumLbl";
            this.strongNumLbl.Size = new System.Drawing.Size(15, 20);
            this.strongNumLbl.TabIndex = 18;
            this.strongNumLbl.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PaisFormsApp.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 637);
            this.Controls.Add(this.strongNumLbl);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numToCheck_txtBox);
            this.Controls.Add(this.lastResultLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.top6Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultsGridView);
            this.Controls.Add(this.frequencyGridView);
            this.Controls.Add(this.maxNum_btn);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frequencyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button maxNum_btn;
        private System.Windows.Forms.TextBox numToCheck_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView frequencyGridView;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button top6Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lastResultLbl;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label strongNumLbl;
    }
}

