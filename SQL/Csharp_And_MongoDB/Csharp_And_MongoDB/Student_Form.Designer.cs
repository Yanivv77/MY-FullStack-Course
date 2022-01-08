namespace Csharp_And_MongoDB
{
    partial class Student_Form
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxSubDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelSubDescription = new System.Windows.Forms.Label();
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
            this.dataGridView_Cars.Location = new System.Drawing.Point(415, 12);
            this.dataGridView_Cars.Name = "dataGridView_Cars";
            this.dataGridView_Cars.RowHeadersWidth = 51;
            this.dataGridView_Cars.RowTemplate.Height = 24;
            this.dataGridView_Cars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cars.Size = new System.Drawing.Size(673, 433);
            this.dataGridView_Cars.TabIndex = 0;

            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(188, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(195, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(188, 111);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(195, 22);
            this.textBoxModel.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(188, 160);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(195, 22);
            this.textBoxDescription.TabIndex = 3;
            // 
            // textBoxSubDescription
            // 
            this.textBoxSubDescription.Location = new System.Drawing.Point(188, 219);
            this.textBoxSubDescription.Name = "textBoxSubDescription";
            this.textBoxSubDescription.Size = new System.Drawing.Size(195, 22);
            this.textBoxSubDescription.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(188, 277);
            this.textBoxPrice.MaxLength = 327670;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(195, 22);
            this.textBoxPrice.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(43, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 22);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(42, 109);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(58, 22);
            this.labelModel.TabIndex = 8;
            this.labelModel.Text = "Model";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(36, 158);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 22);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description";
            // 
            // labelSubDescription
            // 
            this.labelSubDescription.AutoSize = true;
            this.labelSubDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubDescription.Location = new System.Drawing.Point(36, 217);
            this.labelSubDescription.Name = "labelSubDescription";
            this.labelSubDescription.Size = new System.Drawing.Size(132, 22);
            this.labelSubDescription.TabIndex = 10;
            this.labelSubDescription.Text = "SubDescription";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(42, 275);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(51, 22);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Price";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(792, 488);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(92, 22);
            this.textBoxId.TabIndex = 12;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(748, 486);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(27, 22);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID";
            // 
            // BTN_INSERT
            // 
            this.BTN_INSERT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_INSERT.Location = new System.Drawing.Point(223, 362);
            this.BTN_INSERT.Name = "BTN_INSERT";
            this.BTN_INSERT.Size = new System.Drawing.Size(170, 60);
            this.BTN_INSERT.TabIndex = 14;
            this.BTN_INSERT.Text = "Insert";
            this.BTN_INSERT.UseVisualStyleBackColor = false;

            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_UPDATE.Location = new System.Drawing.Point(12, 362);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(168, 60);
            this.BTN_UPDATE.TabIndex = 15;
            this.BTN_UPDATE.Text = "Update";
            this.BTN_UPDATE.UseVisualStyleBackColor = false;

            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_DELETE.ForeColor = System.Drawing.Color.Black;
            this.BTN_DELETE.Location = new System.Drawing.Point(111, 447);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(186, 61);
            this.BTN_DELETE.TabIndex = 16;
            this.BTN_DELETE.Text = "Delete";
            this.BTN_DELETE.UseVisualStyleBackColor = false;

            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_SEARCH.Location = new System.Drawing.Point(910, 471);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(155, 48);
            this.BTN_SEARCH.TabIndex = 17;
            this.BTN_SEARCH.Text = "Search";
            this.BTN_SEARCH.UseVisualStyleBackColor = false;

            // 
            // Cars_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1100, 531);
            this.Controls.Add(this.BTN_SEARCH);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_UPDATE);
            this.Controls.Add(this.BTN_INSERT);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelSubDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxSubDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView_Cars);
            this.Name = "Cars_Form";
            this.Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Cars;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxSubDescription;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelSubDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button BTN_INSERT;
        private System.Windows.Forms.Button BTN_UPDATE;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_SEARCH;
    }
}

