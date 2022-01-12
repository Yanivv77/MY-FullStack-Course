namespace Csharp_And_MySQL
{
    partial class student_Form
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
            this.dataGridView_Cars = new System.Windows.Forms.DataGridView();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.BTN_INSERT = new System.Windows.Forms.Button();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Cars
            // 
            this.dataGridView_Cars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cars.Location = new System.Drawing.Point(325, 12);
            this.dataGridView_Cars.Name = "dataGridView_Cars";
            this.dataGridView_Cars.RowHeadersWidth = 51;
            this.dataGridView_Cars.RowTemplate.Height = 24;
            this.dataGridView_Cars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cars.Size = new System.Drawing.Size(673, 433);
            this.dataGridView_Cars.TabIndex = 0;
            this.dataGridView_Cars.SelectionChanged += new System.EventHandler(this.dataGridView_Cars_SelectionChanged);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(113, 59);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(195, 22);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(113, 111);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(195, 22);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(113, 165);
            this.textBoxAge.MaxLength = 327670;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(195, 22);
            this.textBoxAge.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(10, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(97, 22);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Frist Name";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(8, 111);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(96, 22);
            this.labelModel.TabIndex = 8;
            this.labelModel.Text = "Last Name";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(10, 163);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(42, 22);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Age";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(702, 488);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(92, 22);
            this.textBoxId.TabIndex = 12;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(658, 486);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(27, 22);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID";
            // 
            // BTN_INSERT
            // 
            this.BTN_INSERT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_INSERT.Location = new System.Drawing.Point(160, 234);
            this.BTN_INSERT.Name = "BTN_INSERT";
            this.BTN_INSERT.Size = new System.Drawing.Size(136, 60);
            this.BTN_INSERT.TabIndex = 14;
            this.BTN_INSERT.Text = "Insert";
            this.BTN_INSERT.UseVisualStyleBackColor = false;
            this.BTN_INSERT.Click += new System.EventHandler(this.BTN_INSERT_Click);
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_UPDATE.Location = new System.Drawing.Point(18, 234);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(136, 60);
            this.BTN_UPDATE.TabIndex = 15;
            this.BTN_UPDATE.Text = "Update";
            this.BTN_UPDATE.UseVisualStyleBackColor = false;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_DELETE.ForeColor = System.Drawing.Color.Black;
            this.BTN_DELETE.Location = new System.Drawing.Point(12, 471);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(122, 48);
            this.BTN_DELETE.TabIndex = 16;
            this.BTN_DELETE.Text = "Delete";
            this.BTN_DELETE.UseVisualStyleBackColor = false;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_SEARCH.Location = new System.Drawing.Point(820, 471);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(155, 48);
            this.BTN_SEARCH.TabIndex = 17;
            this.BTN_SEARCH.Text = "Search";
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1013, 531);
            this.Controls.Add(this.BTN_SEARCH);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_UPDATE);
            this.Controls.Add(this.BTN_INSERT);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.dataGridView_Cars);
            this.Name = "student_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cars_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Cars;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button BTN_INSERT;
        private System.Windows.Forms.Button BTN_UPDATE;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_SEARCH;
    }
}

