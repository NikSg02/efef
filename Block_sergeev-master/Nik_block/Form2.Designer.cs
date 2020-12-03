
namespace Tinker_quest
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.dgvIdProdukts = new System.Windows.Forms.DataGridView();
            this.IdGoods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.кудашкинDataSet = new Tinker_quest.КудашкинDataSet();
            this.idProduktsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProduktsTableAdapter = new Tinker_quest.КудашкинDataSetTableAdapters.IdProduktsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdProdukts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кудашкинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idProduktsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Артикул";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(39, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(148, 105);
            this.txtArt.Multiline = true;
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(182, 24);
            this.txtArt.TabIndex = 2;
            // 
            // dgvIdProdukts
            // 
            this.dgvIdProdukts.AllowUserToDeleteRows = false;
            this.dgvIdProdukts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvIdProdukts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdProdukts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGoods,
            this.Article,
            this.Name,
            this.Remove});
            this.dgvIdProdukts.Location = new System.Drawing.Point(463, 59);
            this.dgvIdProdukts.Name = "dgvIdProdukts";
            this.dgvIdProdukts.ReadOnly = true;
            this.dgvIdProdukts.Size = new System.Drawing.Size(443, 356);
            this.dgvIdProdukts.TabIndex = 3;
            this.dgvIdProdukts.DoubleClick += new System.EventHandler(this.dgvIdProdukts_DoubleClick);
            // 
            // IdGoods
            // 
            this.IdGoods.DataPropertyName = "IdGoods";
            this.IdGoods.HeaderText = "Id товара";
            this.IdGoods.Name = "IdGoods";
            this.IdGoods.ReadOnly = true;
            // 
            // Article
            // 
            this.Article.DataPropertyName = "Article";
            this.Article.HeaderText = "Артикул";
            this.Article.Name = "Article";
            this.Article.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Наименование";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.DataPropertyName = "Remove";
            this.Remove.HeaderText = "Признак удаления";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Признак удаления";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 140);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 24);
            this.txtName.TabIndex = 6;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(148, 178);
            this.txtRemove.Multiline = true;
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(182, 24);
            this.txtRemove.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // кудашкинDataSet
            // 
            this.кудашкинDataSet.DataSetName = "КудашкинDataSet";
            this.кудашкинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idProduktsBindingSource
            // 
            this.idProduktsBindingSource.DataMember = "IdProdukts";
            this.idProduktsBindingSource.DataSource = this.кудашкинDataSet;
            // 
            // idProduktsTableAdapter
            // 
            this.idProduktsTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(918, 427);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvIdProdukts);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            //this.Name = "Form2";
            this.Text = "Закупка сырья";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdProdukts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кудашкинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idProduktsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.DataGridView dgvIdProdukts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remove;
        private КудашкинDataSet кудашкинDataSet;
        private System.Windows.Forms.BindingSource idProduktsBindingSource;
        private КудашкинDataSetTableAdapters.IdProduktsTableAdapter idProduktsTableAdapter;
    }
}